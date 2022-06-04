using azuremyst.models.enums;
using azuremyst.services.interfaces;
using Discord.WebSocket;

namespace azuremyst.services
{
    public class RoleService : IRoleService
    {
        public async Task UpdateClassRoleAsync(SocketGuild guild, SocketGuildUser user, string name)
        {
            foreach (var userRole in user.Roles.ToArray())
            {
                if (classes.Any(x => x == userRole.Name))
                    await user.RemoveRoleAsync(userRole);
            }
            var guildRole = FindGuildRole(guild, name);
            if (guildRole != null)
                await user.AddRoleAsync(guildRole);
        }

        public async Task UpdateFactionRoleAsync(SocketGuild guild, SocketGuildUser user, string name)
        {
            foreach (var userRole in user.Roles.ToArray())
            {
                if (factions.Any(x => x == userRole.Name))
                    await user.RemoveRoleAsync(userRole);
            }
            var guildRole = FindGuildRole(guild, name);
            if (guildRole != null)
                await user.AddRoleAsync(guildRole);
        }

        static SocketRole? FindGuildRole(SocketGuild guild, string name) =>
            guild.Roles.Where(x => x.Name == name.ToLower()).FirstOrDefault();

        public readonly static string[] classes = new string[9]
        {
            "druid",
            "hunter",
            "mage",
            "paladin",
            "priest",
            "rogue",
            "shaman",
            "warlock",
            "warrior"
        };

        public readonly static string[] factions = new string[2]
        {
            "horde",
            "alliance"
        };

        public readonly static WoWRace[] horde = new WoWRace[5]
        {
            WoWRace.Undead,
            WoWRace.Tauren,
            WoWRace.BloodElf,
            WoWRace.Troll,
            WoWRace.Orc,
        };

        public readonly static WoWRace[] alliance = new WoWRace[5]
{
            WoWRace.Gnome,
            WoWRace.Dwarf,
            WoWRace.Draenei,
            WoWRace.Human,
            WoWRace.NightElf,
};
    }
}
