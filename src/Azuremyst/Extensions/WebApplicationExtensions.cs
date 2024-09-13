using Azuremyst.Contexts;
using Azuremyst.Services;
using Discord;
using Discord.WebSocket;
using Microsoft.EntityFrameworkCore;

namespace Azuremyst.Extensions;

internal static class WebApplicationExtensions
{
    public static async Task<WebApplication> MigrateApplicationDbContextAsync(
        this WebApplication webApplication
    )
    {
        using var scope = webApplication
            .Services.GetRequiredService<IServiceScopeFactory>()
            .CreateScope();
        using var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
        await context.Database.MigrateAsync();
        return webApplication;
    }

    public static async Task StartDiscordBotAsync(
        this WebApplication webApplication,
        string discordToken
    )
    {
        var client = webApplication.Services.GetRequiredService<DiscordShardedClient>();

        // The Sharded Client does not have a Ready event.
        // The ShardReady event is used instead, allowing for individual
        // control per shard.
        client.ShardReady += ReadyAsync;
        client.Log += LogAsync;

        await webApplication
            .Services.GetRequiredService<InteractionHandlingService>()
            .InitializeAsync();

        await webApplication
            .Services.GetRequiredService<CommandHandlingService>()
            .InitializeAsync();

        // Tokens should be considered secret data, and never hard-coded.
        await client.LoginAsync(TokenType.Bot, discordToken);
        await client.StartAsync();
#if !DEBUG
        await client.SetCustomStatusAsync("Azuremyst");
#elif DEBUG
        await client.SetCustomStatusAsync("Azuremyst");
#endif
    }

    private static Task ReadyAsync(DiscordSocketClient shard)
    {
        Console.WriteLine($"Shard Number {shard.ShardId} is connected and ready!");
        return Task.CompletedTask;
    }

    private static Task LogAsync(LogMessage log)
    {
        Console.WriteLine(log.ToString());
        return Task.CompletedTask;
    }
}
