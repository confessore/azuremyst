using azuremyst.contexts;
using azuremyst.models.enums;
using azuremyst.services.interfaces;
using Microsoft.EntityFrameworkCore;

namespace azuremyst.services
{
    public class BoostService : IBoostService
    {
        readonly IDbContextFactory<CharacterDbContext> _characterDbContextFactory;
        readonly ISoapService _soapService;

        public BoostService(
            IDbContextFactory<CharacterDbContext> characterDbContextFactory,
            ISoapService soapService)
        {
            _characterDbContextFactory = characterDbContextFactory;
            _soapService = soapService;
        }

        public static readonly int[] mage =
        {
            22062,
            22063, 
            22064,
            22065,
            22066,
            22067,
            22068,
            22069
        };

        public static readonly int[] warlock =
{
            22070,
            22071,
            22072,
            22073,
            22074,
            22075,
            22076,
            22077
        };

        public static readonly int[] sharedCaster =
        {
            12103,
            12968,
            22335,
            22408,
            22433,
            22339,
            12930,
            22268
        };

        public async Task<bool> Boost60Async(string name)
        {
            using var context = await _characterDbContextFactory.CreateDbContextAsync();
            if (context.Characters != null)
            {
                var character = await context.Characters.FirstOrDefaultAsync(x => x.Name.ToLower() == name.ToLower());
                if (character != null)
                {
                    if (character.Level < 60)
                        await _soapService.CharacterLevel(name, 60);
                    switch ((WoWClass)character.Class)
                    {
                        // add support for the other classes
                        case WoWClass.Mage:
                        {
                            await _soapService.SendItemsAsync(name, mage);
                            await _soapService.SendItemsAsync(name, sharedCaster);
                            return true;
                        }
                        case WoWClass.Warlock:
                            {
                                await _soapService.SendItemsAsync(name, warlock);
                                await _soapService.SendItemsAsync(name, sharedCaster);
                                return true;
                            }
                        default:
                            return false;
                    }
                }
                return false;
            }
            return false;
        }
    }
}
