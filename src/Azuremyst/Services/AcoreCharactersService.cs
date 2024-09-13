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
}
