using azuremyst.contexts;
using azuremyst.extensions;
using azuremyst.models.enums;
using azuremyst.models.users;
using azuremyst.services.interfaces;
using Discord;
using Discord.Commands;
using Discord.WebSocket;
using Microsoft.EntityFrameworkCore;
using SoapHttpClient;
using SoapHttpClient.Enums;
using System.Net;
using System.Xml.Linq;

namespace azuremyst.modules
{
    public class CommandModule : ModuleBase<SocketCommandContext>
    {
        readonly IServiceProvider _services;
        readonly DiscordSocketClient _client;
        readonly CommandService _commands;
        readonly IDbContextFactory<DefaultDbContext> _defaultDbContextFactory;
        readonly IDbContextFactory<CharacterDbContext> _character;
        readonly ISoapService _soap;

        public CommandModule(
            IServiceProvider services,
            DiscordSocketClient client,
            CommandService commands,
            IDbContextFactory<DefaultDbContext> defaultDbContextFactory,
            IDbContextFactory<CharacterDbContext> character,
            ISoapService soap)
        {
            _services = services;
            _client = client;
            _commands = commands;
            _defaultDbContextFactory = defaultDbContextFactory;
            _character = character;
            _soap = soap;
        }

        readonly Random random = new Random();

        [Command("help", RunMode = RunMode.Async)]
        [Summary("all: displays available commands" +
            "\n >help")]
        async Task HelpAsync()
        {
            await RemoveCommandMessageAsync();
            var embedBuilder = new EmbedBuilder();
            foreach (var command in await _commands.GetExecutableCommandsAsync(Context, _services))
                embedBuilder.AddField(command.Name, command.Summary ?? "no summary available");
            await ReplyAsync("here's a list of commands and their summaries: ", false, embedBuilder.Build());
        }

        [Command("insult", RunMode = RunMode.Async)]
        [Summary("all: got 'em" +
            "\n >insult")]
        async Task InsultAsync()
        {
            await RemoveCommandMessageAsync();
            await ReplyAsync("your mother");
        }

        [Command("nick", RunMode = RunMode.Async)]
        [Summary("all: change your nick" +
            "\n >nick 'your nick here'")]
        async Task NickAsync([Remainder] string name)
        {
            await RemoveCommandMessageAsync();
            await _client.GetGuild(Context.Guild.Id).GetUser(Context.User.Id).ModifyAsync(x => x.Nickname = name);
        }

        [Command("sync", RunMode = RunMode.Async)]
        [Summary("all: sync a single guild user's membership role according to their nickname (character name)" +
            "\n >sync")]
        async Task SyncAsync()
        {
            await RemoveCommandMessageAsync();
            var user = _client.GetGuild(Context.Guild.Id).GetUser(Context.User.Id);
            //var character = await _armory.LookupCharacterAsync(user.Nickname ?? user.Username);
            //character.Id = user.Id;
            //await _role.UpdateFactionRoleAsync(Context.Guild, (SocketGuildUser)Context.User, character.FactionId is 1 ? "horde" : "alliance");
            //await _role.UpdateClassRoleAsync(Context.Guild, (SocketGuildUser)Context.User, character.Class ?? string.Empty);
            //using var context = await _character.CreateDbContextAsync();
            //if (context.Characters != null)
            //{
            //    var character = await context.Characters.FirstOrDefaultAsync(x => x.Name.ToLower() == (user.Nickname ?? user.Username).ToLower());
            //    if (character != null)
            //        await ReplyAsync($"{character.Name} is a level {character.Level} {((WoWRace)character.Race).GetDescription()} {((WoWClass)character.Class).GetDescription()} with guid: {character.Guid}");
            //}
            await ReplyAsync(await _soap.TestAsync());
        }

        [Command("tip", RunMode = RunMode.Async)]
        [Summary("all: tips a user" +
            "\n >tip" +
            "\n >tip feeram")]
        async Task TipAsync([Remainder] string name)
        {
            await RemoveCommandMessageAsync();
        }

        [Command("grant", RunMode = RunMode.Async)]
        [Summary("bot: grants a user for exceptional distinguishment" +
            "\n >grant" + 
            "\n >grant feeram")]
        async Task GrantAsync([Remainder] string name)
        {
            await RemoveCommandMessageAsync();
        }

        [Command("droll", RunMode = RunMode.Async)]
        [Summary("all: begins a death roll with the specified name at the specified wager" +
            "\n >droll" +
            "\n >droll feeram 69")]
        async Task DeathRollAsync([Remainder] string name)
        {
            await RemoveCommandMessageAsync();
        }

        async Task RemoveCommandMessageAsync() =>
            await _client.GetGuild(Context.Guild.Id).GetTextChannel(Context.Message.Channel.Id).DeleteMessageAsync(Context.Message);
    }
}
