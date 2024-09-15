using Azuremyst.Contexts;
using Azuremyst.Models.Acore.Characters;
using Microsoft.EntityFrameworkCore;

namespace Azuremyst.Services;

public class AcoreCharactersService(
    IDbContextFactory<AcoreCharactersContext> _acoreCharactersContextFactory
)
{
    public async Task<IEnumerable<Character>> GetAllCharactersByAccountIdAsync(
        AcoreCharactersContext context,
        uint id
    ) => await context.Characters.Where(x => x.Account == id).ToArrayAsync();

    public async Task<IEnumerable<Character>> GetAllCharactersByAccountIdAsync(uint id)
    {
        using var context = await _acoreCharactersContextFactory.CreateDbContextAsync();
        return await GetAllCharactersByAccountIdAsync(context, id);
    }

    public async Task<Character?> GetCharacterByGuid(AcoreCharactersContext context, uint guid) =>
        await context.Characters.FirstOrDefaultAsync(x => x.Guid == guid);

    public async Task<Character?> GetCharacterByGuid(uint guid)
    {
        using var context = await _acoreCharactersContextFactory.CreateDbContextAsync();
        return await GetCharacterByGuid(context, guid);
    }

    public async Task<IEnumerable<Auctionhouse>> GetAllAuctionsAsync(
        AcoreCharactersContext context
    ) => await context.Auctionhouses.ToArrayAsync();

    public async Task<IEnumerable<Auctionhouse>> GetAllAuctionsAsync()
    {
        using var context = await _acoreCharactersContextFactory.CreateDbContextAsync();
        return await GetAllAuctionsAsync(context);
    }

    public async Task<int> CountHordeCharactersAboveLevel20Async(AcoreCharactersContext context) =>
        await context.Characters.CountAsync(x => horde.Contains(x.Race) && x.Level >= 20);

    public async Task<int> CountHordeCharactersAboveLevel20Async()
    {
        using var context = await _acoreCharactersContextFactory.CreateDbContextAsync();
        return await CountHordeCharactersAboveLevel20Async(context);
    }

    public async Task<int> CountAllianceCharactersAboveLevel20Async(AcoreCharactersContext context) =>
        await context.Characters.CountAsync(x => alliance.Contains(x.Race) && x.Level >= 20);

    public async Task<int> CountAllianceCharactersAboveLevel20Async()
    {
        using var context = await _acoreCharactersContextFactory.CreateDbContextAsync();
        return await CountAllianceCharactersAboveLevel20Async(context);
    }

    private byte[] alliance =
    [
        1, // Human
            3, // Dwarf
            4, // NightElf
            7, // Gnome
            11 // Draenei
    ];

    private byte[] horde = 
        [
            2, // Orc
            5, // Scourge
            6, // Tauren
            8, // Troll
            10 // BloodElf
        ];
}
