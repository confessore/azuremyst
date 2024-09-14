using System.Net.Http.Headers;
using System.Text;
using AspNet.Security.OAuth.Discord;
using Azuremyst;
using Azuremyst.Behaviors;
using Azuremyst.Contexts;
using Azuremyst.Extensions;
using Azuremyst.Services;
using MediatR;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Components.Server.Circuits;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection.Extensions;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents().AddInteractiveServerComponents();
builder.Services.AddMudServices();

builder.Services.AddControllers();
builder.Services.AddHttpContextAccessor();

builder
    .Services.AddCascadingAuthenticationState()
    .AddAuthentication(options =>
    {
        options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
        options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
        options.DefaultChallengeScheme = DiscordAuthenticationDefaults.AuthenticationScheme;
    })
    .AddCookie()
    .AddDiscord(options =>
    {
        options.ClientId =
            Environment.GetEnvironmentVariable("DISCORD_CLIENTID")
            ?? builder.Configuration.GetValue<string>("DISCORD_CLIENTID")
            ?? throw new InvalidOperationException("DISCORD_CLIENTID");
        options.ClientSecret =
            Environment.GetEnvironmentVariable("DISCORD_CLIENTSECRET")
            ?? builder.Configuration.GetValue<string>("DISCORD_CLIENTSECRET")
            ?? throw new InvalidOperationException("DISCORD_CLIENTSECRET");
        options.Scope.Add("email");
        options.SaveTokens = true;
    });

builder.Services.ConfigureSignalR();

var discordToken =
    Environment.GetEnvironmentVariable("DISCORD_TOKEN")
    ?? builder.Configuration.GetValue<string>("DISCORD_TOKEN")
    ?? throw new Exception("DISCORD_TOKEN");
var uid =
    Environment.GetEnvironmentVariable("MYSQL_UID")
    ?? builder.Configuration.GetValue<string>("MYSQL_UID")
    ?? throw new InvalidOperationException("MYSQL_UID");
var pwd =
    Environment.GetEnvironmentVariable("MYSQL_PWD")
    ?? builder.Configuration.GetValue<string>("MYSQL_PWD")
    ?? throw new InvalidOperationException("MYSQL_PWD");
var ac_soap_host =
    Environment.GetEnvironmentVariable("AC_SOAP_HOST")
    ?? builder.Configuration.GetValue<string>("AC_SOAP_HOST")
    ?? throw new Exception("AC_SOAP_HOST");
var ac_soap_port =
    Environment.GetEnvironmentVariable("AC_SOAP_PORT")
    ?? builder.Configuration.GetValue<string>("AC_SOAP_PORT")
    ?? throw new Exception("AC_SOAP_PORT");
var ac_soap_username =
    Environment.GetEnvironmentVariable("AC_SOAP_USERNAME")
    ?? builder.Configuration.GetValue<string>("AC_SOAP_USERNAME")
    ?? throw new Exception("AC_SOAP_USERNAME");
var ac_soap_password =
    Environment.GetEnvironmentVariable("AC_SOAP_PASSWORD")
    ?? builder.Configuration.GetValue<string>("AC_SOAP_PASSWORD")
    ?? throw new Exception("AC_SOAP_PASSWORD");
var azuremystConnectionString = $"Server=ac-database;Database=azuremyst;Uid={uid};Pwd={pwd};";
var authConnectionString = $"Server=ac-database;Database=acore_auth;Uid={uid};Pwd={pwd};";
var charactersConnectionString =
    $"Server=ac-database;Database=acore_characters;Uid={uid};Pwd={pwd};";
var worldConnectionString = $"Server=ac-database;Database=acore_world;Uid={uid};Pwd={pwd};";

builder.Services.AddDbContextPool<ApplicationDbContext>(options =>
{
    options.UseMySQL(azuremystConnectionString);
    //options.EnableSensitiveDataLogging();
    options.EnableDetailedErrors();
});
builder.Services.AddDbContextFactory<ApplicationDbContext>(options =>
{
    options.UseMySQL(azuremystConnectionString);
    //options.EnableSensitiveDataLogging();
    options.EnableDetailedErrors();
});

builder.Services.AddDbContextPool<AcoreAuthContext>(options =>
{
    options.UseMySQL(authConnectionString);
    //options.EnableSensitiveDataLogging();
    options.EnableDetailedErrors();
});
builder.Services.AddDbContextFactory<AcoreAuthContext>(options =>
{
    options.UseMySQL(authConnectionString);
    //options.EnableSensitiveDataLogging();
    options.EnableDetailedErrors();
});

builder.Services.AddDbContextPool<AcoreCharactersContext>(options =>
{
    options.UseMySQL(charactersConnectionString);
    //options.EnableSensitiveDataLogging();
    options.EnableDetailedErrors();
});
builder.Services.AddDbContextFactory<AcoreCharactersContext>(options =>
{
    options.UseMySQL(charactersConnectionString);
    //options.EnableSensitiveDataLogging();
    options.EnableDetailedErrors();
});

builder.Services.AddDbContextPool<AcoreWorldContext>(options =>
{
    options.UseMySQL(worldConnectionString);
    //options.EnableSensitiveDataLogging();
    options.EnableDetailedErrors();
});
builder.Services.AddDbContextFactory<AcoreWorldContext>(options =>
{
    options.UseMySQL(worldConnectionString);
    //options.EnableSensitiveDataLogging();
    options.EnableDetailedErrors();
});

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.Configure<ForwardedHeadersOptions>(options =>
{
    options.ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto;
});

builder.Services.AddMediatR(configuration =>
    configuration.RegisterServicesFromAssemblyContaining<Program>()
);
builder.Services.AddTransient(typeof(IPipelineBehavior<,>), typeof(LoggingPipelineBehavior<,>));
builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<AccountAssociationService>();
builder.Services.AddScoped<AcoreAuthService>();
builder.Services.AddScoped<AcoreCharactersService>();
builder.Services.AddScoped<AcoreWorldService>();
builder.Services.TryAddEnumerable(ServiceDescriptor.Scoped<CircuitHandler, UserCircuitHandler>());
builder.Services.ConfigureDiscordBot();

builder.Services.AddHttpClient<SoapService>(
    nameof(SoapService),
    x =>
    {
        x.BaseAddress = new Uri($"http://{ac_soap_host}:{ac_soap_port}");
        x.DefaultRequestHeaders.Add("User-Agent", "Azuremyst");
        x.DefaultRequestHeaders.Add(
            "Authorization",
            "Basic "
                + Convert.ToBase64String(
                    Encoding.UTF8.GetBytes(string.Concat(ac_soap_username, ":", ac_soap_password))
                )
        );
        x.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/xml"));
        x.DefaultRequestHeaders.Add("Accept", "text/xml");
        x.DefaultRequestHeaders.Add("Method", "POST");
    }
);
builder.Services.AddSingleton<SoapService>();

var app = builder.Build();
await app.MigrateApplicationDbContextAsync();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.Use(
    async (context, next) =>
    {
        context.Request.Scheme = "https";
        await next.Invoke();
    }
);

app.UseForwardedHeaders();
app.UseCookiePolicy(new CookiePolicyOptions() { Secure = CookieSecurePolicy.Always });

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.MapRazorComponents<Azuremyst.Components.App>().AddInteractiveServerRenderMode();

await app.StartDiscordBotAsync(discordToken);

app.Run();
