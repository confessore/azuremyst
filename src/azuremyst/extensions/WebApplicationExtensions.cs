using azuremyst.contexts;
using Microsoft.EntityFrameworkCore;

namespace azuremyst.extensions
{
    static class WebApplicationExtensions
    {
        //public static async Task InitializeDiscordSocketClientAsync(this IApplicationBuilder app, DiscordOptions options)
        //{
        //    using var scope = app.ApplicationServices.CreateScope();
        //    var services = scope.ServiceProvider;
        //    var logging = services.GetRequiredService<LoggingService>();
        //    var messaging = services.GetRequiredService<MessageService>();
        //    var commands = services.GetRequiredService<CommandService>();
        //    await commands.AddModulesAsync(
        //        Assembly.GetEntryAssembly(),
        //        services);
        //    var client = services.GetRequiredService<DiscordSocketClient>();
        //    await client.LoginAsync(
        //        TokenType.Bot,
        //        options.BotToken);
        //    await client.StartAsync();
        //    await client.SetGameAsync("'>help' for commands");
        //}

        public static async Task<WebApplication> MigrateDefaultDbContextAsync(this WebApplication webApplication)
        {
            using var scope = webApplication.Services.GetRequiredService<IServiceScopeFactory>().CreateScope();
            using var context = scope.ServiceProvider.GetRequiredService<DefaultDbContext>();
            await context.Database.MigrateAsync();
            return webApplication;
        }

        public static async Task<WebApplication> MigrateKeyDbContextAsync(this WebApplication webApplication)
        {
            using var scope = webApplication.Services.GetRequiredService<IServiceScopeFactory>().CreateScope();
            using var context = scope.ServiceProvider.GetRequiredService<KeyDbContext>();
            await context.Database.MigrateAsync();
            return webApplication;
        }

        public static async Task<WebApplication> MigrateAuthDbContextAsync(this WebApplication webApplication)
        {
            using var scope = webApplication.Services.GetRequiredService<IServiceScopeFactory>().CreateScope();
            using var context = scope.ServiceProvider.GetRequiredService<AuthDbContext>();
            await context.Database.MigrateAsync();
            return webApplication;
        }
    }
}
