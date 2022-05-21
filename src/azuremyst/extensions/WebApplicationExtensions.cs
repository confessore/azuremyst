using azuremyst.contexts;
using azuremyst.models.options;
using azuremyst.services;
using Discord;
using Discord.Commands;
using Discord.WebSocket;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace azuremyst.extensions
{
    static class WebApplicationExtensions
    {
        public static async Task InitializeDiscordSocketClientAsync(this IApplicationBuilder app, DiscordOptions options)
        {
            // need a better place for this. we're calling disposed objects with this nonsense.
            // a scoped provider will not continue to live
            // getting the required service from the scoped provider feels hacky
            using var scope = app.ApplicationServices.CreateScope();
            var scopedServices = scope.ServiceProvider;
            var logging = scopedServices.GetRequiredService<LoggingService>();
            var messaging = scopedServices.GetRequiredService<MessageService>();
            var commands = scopedServices.GetRequiredService<CommandService>();
            var services = scopedServices.GetRequiredService<IServiceProvider>();
            await commands.AddModulesAsync(
                Assembly.GetEntryAssembly(),
                services);
            var client = scopedServices.GetRequiredService<DiscordSocketClient>();
            await client.LoginAsync(
                TokenType.Bot,
                options.BotToken);
            await client.StartAsync();
            await client.SetGameAsync("'>help' for commands");
        }

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

        //public static async Task<WebApplication> MigrateLogsDbContextAsync(this WebApplication webApplication)
        //{
        //    using var scope = webApplication.Services.GetRequiredService<IServiceScopeFactory>().CreateScope();
        //    using var context = scope.ServiceProvider.GetRequiredService<LogsDbContext>();
        //    await context.Database.MigrateAsync();
        //    return webApplication;
        //}

        //public static async Task<WebApplication> MigrateAuthDbContextAsync(this WebApplication webApplication)
        //{
        //    using var scope = webApplication.Services.GetRequiredService<IServiceScopeFactory>().CreateScope();
        //    using var context = scope.ServiceProvider.GetRequiredService<AuthDbContext>();
        //    await context.Database.MigrateAsync();
        //    return webApplication;
        //}

        //public static async Task<WebApplication> MigrateCharacterDbContextAsync(this WebApplication webApplication)
        //{
        //    using var scope = webApplication.Services.GetRequiredService<IServiceScopeFactory>().CreateScope();
        //    using var context = scope.ServiceProvider.GetRequiredService<CharacterDbContext>();
        //    await context.Database.MigrateAsync();
        //    return webApplication;
        //}

        //public static async Task<WebApplication> MigrateWorldDbContextAsync(this WebApplication webApplication)
        //{
        //    using var scope = webApplication.Services.GetRequiredService<IServiceScopeFactory>().CreateScope();
        //    using var context = scope.ServiceProvider.GetRequiredService<WorldDbContext>();
        //    await context.Database.MigrateAsync();
        //    return webApplication;
        //}

        //public static async Task<WebApplication> InitializeLogsDbAsync(this WebApplication webApplication)
        //{
        //    using var scope = webApplication.Services.GetRequiredService<IServiceScopeFactory>().CreateScope();
        //    var contextFactory = scope.ServiceProvider.GetRequiredService<IDbContextFactory<LogsDbContext>>();
        //    using var context = await contextFactory.CreateDbContextAsync();
        //    if (context.LogsDbVersions != null && !await context.LogsDbVersions.AnyAsync())
        //    {
        //        var sql = "INSERT INTO logs_db_version VALUES (@bit);";
        //        var name = new MySqlParameter("@bit", null);
        //        await context.Database.ExecuteSqlRawAsync(sql, name);
        //        await context.SaveChangesAsync();
        //    }
        //    return webApplication;
        //}

        //public static async Task<WebApplication> InitializeAuthDbAsync(this WebApplication webApplication)
        //{
        //    using var scope = webApplication.Services.GetRequiredService<IServiceScopeFactory>().CreateScope();
        //    var contextFactory = scope.ServiceProvider.GetRequiredService<IDbContextFactory<AuthDbContext>>();
        //    using var context = await contextFactory.CreateDbContextAsync();
        //    if (context.Realmlists != null && !await context.Realmlists.AnyAsync())
        //    {
        //        await context.Realmlists.AddAsync(new Realmlist()
        //        {
        //            Address = "0.0.0.0",
        //            AllowedSecurityLevel = 0,
        //            Icon = 1,
        //            Name = "azuremyst",
        //            Population = 0f,
        //            Port = 8085,
        //            Realmflags = 0x40,
        //            Timezone = 0x00
        //        });
        //        await context.SaveChangesAsync();
        //    }
        //    if (context.RealmdDbVersions != null && !await context.RealmdDbVersions.AnyAsync())
        //    {
        //        var sql = "INSERT INTO realmd_db_version VALUES (@bit);";
        //        var name = new MySqlParameter("@bit", null);
        //        await context.Database.ExecuteSqlRawAsync(sql, name);
        //        await context.SaveChangesAsync();
        //    }
        //    return webApplication;
        //}

        //public static async Task<WebApplication> InitializeCharacterDbAsync(this WebApplication webApplication)
        //{
        //    using var scope = webApplication.Services.GetRequiredService<IServiceScopeFactory>().CreateScope();
        //    var contextFactory = scope.ServiceProvider.GetRequiredService<IDbContextFactory<CharacterDbContext>>();
        //    using var context = await contextFactory.CreateDbContextAsync();
        //    if (context.CharacterDbVersions != null && !await context.CharacterDbVersions.AnyAsync())
        //    {
        //        var sql = "INSERT INTO character_db_version VALUES (@bit);";
        //        var name = new MySqlParameter("@bit", null);
        //        await context.Database.ExecuteSqlRawAsync(sql, name);
        //        await context.SaveChangesAsync();
        //    }
        //    return webApplication;
        //}

        //public static async Task<WebApplication> InitializeWorldDbAsync(this WebApplication webApplication)
        //{
        //    using var scope = webApplication.Services.GetRequiredService<IServiceScopeFactory>().CreateScope();
        //    var contextFactory = scope.ServiceProvider.GetRequiredService<IDbContextFactory<WorldDbContext>>();
        //    using var context = await contextFactory.CreateDbContextAsync();
        //    if (context.DbVersions != null && !await context.DbVersions.AnyAsync())
        //    {
        //        var sql = "INSERT INTO db_version VALUES (@str1, @str2, @bit);";
        //        var version = new MySqlParameter("@str1", "azuremyst");
        //        var ai = new MySqlParameter("@str2", "no ai");
        //        var required = new MySqlParameter("@bit", null);
        //        await context.Database.ExecuteSqlRawAsync(sql, version, ai, required);
        //        await context.SaveChangesAsync();
        //    }
        //    return webApplication;
        //}
    }
}
