using Discord.Commands;
using Discord.WebSocket;
using Serilog;

namespace azuremyst.services
{
    public class MessageService
    {
        readonly IServiceProvider _services;
        readonly DiscordSocketClient _client;
        readonly CommandService _commands;

        public MessageService(
            IServiceProvider services,
            DiscordSocketClient client,
            CommandService commands)
        {
            _services = services;
            _client = client;
            _commands = commands;
            _client.MessageReceived += MessageReceived;
            _client.UserJoined += UserJoined;
        }

        async Task MessageReceived(SocketMessage msg)
        {
            var tmp = (SocketUserMessage)msg;
            if (tmp == null) return;
            var pos = 0;
            if (!(tmp.HasCharPrefix('>', ref pos) ||
                tmp.HasMentionPrefix(_client.CurrentUser, ref pos)) ||
                tmp.Author.IsBot)
                return;
            var context = new SocketCommandContext(_client, tmp);
            var result = await _commands.ExecuteAsync(context, pos, _services);
            if (!result.IsSuccess)
                Log.Error(result.ErrorReason);
        }

        async Task UserJoined(SocketGuildUser user)
        {
            var dmc = await user.CreateDMChannelAsync();
            await dmc.SendMessageAsync("welcome to azuremyst!\n" +
                "please change your discord name to reflect your main in-game character name.\n" +
                "when you have done this, type the command '>sync' in a server channel for your roles to be applied.");
        }
    }
}
