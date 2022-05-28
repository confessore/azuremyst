
using azuremyst.auth.services;
using azuremyst.contexts;
using azuremyst.extensions;
using azuremyst.handlers;
using azuremyst.models.abstractions;
using azuremyst.providers;
using azuremyst.services;
using azuremyst.services.interfaces;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server;
using Microsoft.AspNetCore.Components.Server.Circuits;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Serilog;
using Serilog.Events;
using System.Collections;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;

var executingAssemblyName = Assembly.GetExecutingAssembly().GetName().Name;
var loggerConfig = new LoggerConfiguration()
    .MinimumLevel.Verbose()
    .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
    .Enrich.FromLogContext()
    .WriteTo.Logger(config =>
    {
        config
            .MinimumLevel.Information()
            .WriteTo.Console()
            .WriteTo.File(string.Concat(executingAssemblyName, ".log"));
    });
Log.Logger = loggerConfig.CreateLogger();
Log.Information("updating environment variables...");
foreach (DictionaryEntry environmentVariable in Environment.GetEnvironmentVariables())
{
    if (environmentVariable.Key.ToString()!.Contains("APPLICATION") && environmentVariable.Value!.ToString()!.StartsWith('/'))
        Environment.SetEnvironmentVariable(environmentVariable.Key.ToString()!, await File.ReadAllTextAsync(environmentVariable.Value.ToString()!));
}
Log.Information("environment variables updated!");
Log.Information("building configuration...");
var configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: false)
    .AddEnvironmentVariables()
    .Build();
Log.Information("configuration built!");

var defaultConnection = await configuration.BuildDefaultConnectionStringAsync();
var keyConnection = await configuration.BuildKeyConnectionStringAsync();
var logsConnection = await configuration.BuildLogsConnectionStringAsync();
var authConnection = await configuration.BuildAuthConnectionStringAsync();
var characterConnection = await configuration.BuildCharacterConnectionStringAsync();
var worldConnection = await configuration.BuildWorldConnectionStringAsync();
var discordOptions = await configuration.BuildDiscordOptionsAsync();
var mangosOptions = await configuration.BuildMangosOptionsAsync();
var smtpOptions = await configuration.BuildSmtpOptionsAsync();
var options = new WebApplicationOptions()
{
    ApplicationName = executingAssemblyName,
    Args = args,
    WebRootPath = "wwwroot"
};
var builder = WebApplication.CreateBuilder(options);
builder.Host
    .UseSerilog();
builder.WebHost
    .ConfigureAppConfiguration(x =>
    {
        x.AddConfiguration(configuration);
    })
    .ConfigureServices(x =>
    {
        x.AddDbContextPool<DefaultDbContext>(x =>
        {
            x.UseMySql(defaultConnection, ServerVersion.AutoDetect(defaultConnection), x =>
            {
                x.MigrationsAssembly(executingAssemblyName);
            });
            x.EnableSensitiveDataLogging();
            x.EnableDetailedErrors();
        });
        x.AddDbContextFactory<DefaultDbContext>(x =>
        {
            x.UseMySql(defaultConnection, ServerVersion.AutoDetect(defaultConnection), x =>
            {
                x.MigrationsAssembly(executingAssemblyName);
            });
            x.EnableSensitiveDataLogging();
            x.EnableDetailedErrors();
        });
        x.AddDbContextPool<KeyDbContext>(x =>
        {
            x.UseMySql(keyConnection, ServerVersion.AutoDetect(keyConnection), x =>
            {
                x.MigrationsAssembly(executingAssemblyName);
            });
            x.EnableSensitiveDataLogging();
            x.EnableDetailedErrors();
        });
        x.AddDbContextFactory<KeyDbContext>(x =>
        {
            x.UseMySql(keyConnection, ServerVersion.AutoDetect(keyConnection), x =>
            {
                x.MigrationsAssembly(executingAssemblyName);
            });
            x.EnableSensitiveDataLogging();
            x.EnableDetailedErrors();
        });
        x.AddDbContextPool<LogsDbContext>(x =>
        {
            x.UseMySql(logsConnection, ServerVersion.AutoDetect(logsConnection), x =>
            {
                x.MigrationsAssembly(executingAssemblyName);
            });
            x.EnableSensitiveDataLogging();
            x.EnableDetailedErrors();
        });
        x.AddDbContextFactory<LogsDbContext>(x =>
        {
            x.UseMySql(logsConnection, ServerVersion.AutoDetect(logsConnection), x =>
            {
                x.MigrationsAssembly(executingAssemblyName);
            });
            x.EnableSensitiveDataLogging();
            x.EnableDetailedErrors();
        });
        x.AddDbContextPool<AuthDbContext>(x =>
        {
            x.UseMySql(authConnection, ServerVersion.AutoDetect(authConnection), x =>
            {
                x.MigrationsAssembly(executingAssemblyName);
            });
            x.EnableSensitiveDataLogging();
            x.EnableDetailedErrors();
        });
        x.AddDbContextFactory<AuthDbContext>(x =>
        {
            x.UseMySql(authConnection, ServerVersion.AutoDetect(authConnection), x =>
            {
                x.MigrationsAssembly(executingAssemblyName);
            });
            x.EnableSensitiveDataLogging();
            x.EnableDetailedErrors();
        });
        x.AddDbContextPool<CharacterDbContext>(x =>
        {
            x.UseMySql(characterConnection, ServerVersion.AutoDetect(characterConnection), x =>
            {
                x.MigrationsAssembly(executingAssemblyName);
            });
            x.EnableSensitiveDataLogging();
            x.EnableDetailedErrors();
        });
        x.AddDbContextFactory<CharacterDbContext>(x =>
        {
            x.UseMySql(characterConnection, ServerVersion.AutoDetect(characterConnection), x =>
            {
                x.MigrationsAssembly(executingAssemblyName);
            });
            x.EnableSensitiveDataLogging();
            x.EnableDetailedErrors();
        });
        x.AddDbContextPool<WorldDbContext>(x =>
        {
            x.UseMySql(worldConnection, ServerVersion.AutoDetect(worldConnection), x =>
            {
                x.MigrationsAssembly(executingAssemblyName);
            });
            x.EnableSensitiveDataLogging();
            x.EnableDetailedErrors();
        });
        x.AddDbContextFactory<WorldDbContext>(x =>
        {
            x.UseMySql(worldConnection, ServerVersion.AutoDetect(worldConnection), x =>
            {
                x.MigrationsAssembly(executingAssemblyName);
            });
            x.EnableSensitiveDataLogging();
            x.EnableDetailedErrors();
        });
        x.AddIdentity<User, Role>(x =>
        {
            x.User.RequireUniqueEmail = true;
            x.Password.RequireDigit = false;
            x.Password.RequireNonAlphanumeric = false;
            x.Password.RequireUppercase = false;
        })
        .AddEntityFrameworkStores<DefaultDbContext>()
        .AddDefaultTokenProviders();
        x.ConfigureSameSiteNone();
        x.AddAuthentication()
            .AddCookie();
        x.AddRazorPages(x =>
        {
            x.Conventions.ConfigureFilter(new IgnoreAntiforgeryTokenAttribute());
        });
        x.AddServerSideBlazor();
        x.AddControllers();
        x.AddHttpContextAccessor();
        x.AddSingleton(mangosOptions);
        x.AddHttpClient<ISoapService, SoapService>(
            Assembly.GetExecutingAssembly().GetName().Name,
            x =>
            {
                x.BaseAddress = new Uri($"http://{mangosOptions.Host.Trim()}:{mangosOptions.Port.Trim()}");
                x.DefaultRequestHeaders.Add("User-Agent", "azuremyst");
                x.DefaultRequestHeaders.Add("Authorization",
                    "Basic " + 
                    Convert.ToBase64String(
                        Encoding.UTF8.GetBytes(
                            string.Concat(mangosOptions.Username.Trim(), ":", mangosOptions.Password.Trim()))));
                x.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/xml"));
                x.DefaultRequestHeaders.Add("Accept", "text/xml");
                x.DefaultRequestHeaders.Add("Method", "POST");
            });
        //x.AddScoped<RoleService>();
        //x.AddScoped<ArmoryService>();
        //x.AddHttpClient(Strings.CallingAssemblyName, client => client.BaseAddress = new Uri("http://localhost:5000"));
        //x.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient(Strings.CallingAssemblyName));
        x.AddScoped<IAuthService, AuthService>();
        x.AddScoped<ILocalStorageService, LocalStorageService>();
        x.AddScoped<ISoapService, SoapService>();
        x.AddSingleton(smtpOptions);
        x.AddScoped<IEmailService, EmailService>();
        //x.AddScoped<IMarketService, MarketService>();
        //x.AddScoped<IAtomService, AtomService>();
        //x.AddScoped<IUserService, UserService>();
        x.AddScoped<AuthenticationStateProvider, DefaultRevalidatingServerAuthenticationStateProvider>();
        x.AddScoped<IHostEnvironmentAuthenticationStateProvider>(x =>
        {
            // this is safe because
            //     the `RevalidatingServerAuthenticationStateProvider` extends the `ServerAuthenticationStateProvider`
            var provider = (ServerAuthenticationStateProvider)x.GetRequiredService<AuthenticationStateProvider>();
            return provider;
        });
        x.AddScoped<CircuitHandler, DefaultCircuitHandler>();
        x.AddDiscordSocketClient();
        //await x.AddQuartzAsync();
    });
try
{
    var webApplication = builder.Build();

    await webApplication.MigrateDefaultDbContextAsync();
    await webApplication.MigrateKeyDbContextAsync();

    await webApplication.InitializeDiscordSocketClientAsync(discordOptions);
    await webApplication.InitializeRealmdAsync();

    // Configure the HTTP request pipeline.
    if (!webApplication.Environment.IsDevelopment())
    {
        webApplication.UseExceptionHandler("/Error");
    }
    webApplication.UseForwardedHeaders(new ForwardedHeadersOptions
    {
        ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
    });
    webApplication.UseCookiePolicy(new CookiePolicyOptions
    {
        MinimumSameSitePolicy = Microsoft.AspNetCore.Http.SameSiteMode.Lax
    });
    webApplication.UseStaticFiles();
    webApplication.UseRouting();
    webApplication.UseAuthentication();
    webApplication.UseAuthorization();
    webApplication.UseEndpoints(x =>
    {
        x.MapControllers();
        x.MapBlazorHub();
        x.MapFallbackToPage("/_Host");
    });
    await webApplication.RunAsync("http://*:5000");
}
catch (Exception e)
{
    if (e.GetType().Name.Equals("StopTheHostException", StringComparison.Ordinal))
        throw;

    Log.Fatal(e, "host terminated unexpectedly...");
    if (Debugger.IsAttached && Environment.UserInteractive)
    {
        Console.WriteLine(string.Concat(Environment.NewLine, "press the 'any' key to exit..."));
        Console.Read();
    }
}
finally
{
    Log.CloseAndFlush();
}
