using Azuremyst.Contexts;
using Azuremyst.Models.Acore.Auth;
using Azuremyst.Models.Acore.World;
using Microsoft.EntityFrameworkCore;

namespace Azuremyst.Services;

public class AcoreWorldService(
    IDbContextFactory<AcoreAuthContext> _acoreAuthContextFactory,
    IDbContextFactory<AcoreCharactersContext> _acoreCharactersContextFactory,
    IDbContextFactory<AcoreWorldContext> _acoreWorldContextFactory)
{
    public async Task<GameGraveyard?> GetGameGraveyardByCharacterZoneAsync(AcoreWorldContext context, ushort characterZone)
    {
        var ghostZone = await context.GraveyardZones.FirstOrDefaultAsync(x => x.GhostZone == characterZone);
        var gameGraveyard = await context.GameGraveyards.FirstOrDefaultAsync(x => x.Id == ghostZone.Id);
        return gameGraveyard;
    }

    public async Task<GameGraveyard?> GetGameGraveyardByCharacterZone(ushort characterZone)
    {
        using var context = await _acoreWorldContextFactory.CreateDbContextAsync();
        return await GetGameGraveyardByCharacterZoneAsync(context, characterZone);
    }
}
