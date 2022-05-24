using azuremyst.contexts;
using azuremyst.extensions;
using azuremyst.models.enums;
using azuremyst.services.interfaces;
using Discord;
using Discord.Commands;
using Discord.WebSocket;
using Microsoft.EntityFrameworkCore;

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
            using var context = await _character.CreateDbContextAsync();
            if (context.Characters != null)
            {
                var character = await context.Characters.FirstOrDefaultAsync(x => x.Name.ToLower() == (user.Nickname ?? user.Username).ToLower());
                if (character != null)
                    await ReplyAsync($"{character.Name} is a level {character.Level} {((WoWRace)character.Race).GetDescription()} {((WoWClass)character.Class).GetDescription()} with guid: {character.Guid}");
            }
        }

        [Command("senditem", RunMode = RunMode.Async)]
        [Summary("bot: adds a specified item to a specified character" +
            "\n >senditem")]
        async Task SendItemAsync(string name, [Remainder] int id)
        {
            await RemoveCommandMessageAsync();
            var result = await _soap.SendItemAsync(name, id);
            if (result)
                await ReplyAsync($"{id} sent to {name}");
            else
                await WarningAsync();
        }

        [Command("shutdown", RunMode = RunMode.Async)]
        [Summary("bot: shuts down mangosd" +
            "\n >sync")]
        async Task ShutdownAsync()
        {
            await RemoveCommandMessageAsync();
            var result = await _soap.ShutdownAsync();
            if (result)
                await ReplyAsync($"shutdown initiated");
            else
                await WarningAsync();
        }

        [Command("setgm", RunMode = RunMode.Async)]
        [Summary("bot: sets gm level 0:player 1:mod 2:gm 3:admin" +
            "\n >setgmlevel")]
        async Task SetGmAsync(string name, [Remainder] int level)
        {
            await RemoveCommandMessageAsync();
            if (await _soap.SetGmLevelAsync(name, level))
                await ReplyAsync($"gm level on {name} set to {level}");
            else
                await WarningAsync();
        }

        [Command("createaccount", RunMode = RunMode.Async)]
        [Summary("bot: creates an account with specified password" +
            "\n >setgmlevel")]
        async Task CreateAccountAsync(string name, string password)
        {
            await RemoveCommandMessageAsync();
            if (await _soap.CreateAccountAsync(name, password))
                await ReplyAsync($"account {name} created");
            else
                await WarningAsync();
        }

        [Command("setaddon", RunMode = RunMode.Async)]
        [Summary("bot: sets addon expansion (1 for tbc)" +
            "\n >setaddon")]
        async Task SetAddonAsync(string name, [Remainder] int expansion)
        {
            await RemoveCommandMessageAsync();
            if (await _soap.SetAddonAsync(name, expansion))
                await ReplyAsync($"{name} addon set to {expansion}");
            else
                await WarningAsync();
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

        async Task WarningAsync()
        {
            await ReplyAsync($"something went wrong. blame booga 😂");
        }
    }
}
