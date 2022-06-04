using Discord.WebSocket;

namespace azuremyst.services.interfaces
{
    public interface IRoleService
    {
        Task UpdateClassRoleAsync(SocketGuild guild, SocketGuildUser user, string name);

        Task UpdateFactionRoleAsync(SocketGuild guild, SocketGuildUser user, string name);
    }
}
