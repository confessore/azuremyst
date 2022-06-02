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

        public async Task<bool> Boost60Async(string name)
        {
            using var context = await _characterDbContextFactory.CreateDbContextAsync();
            if (context.Characters != null)
            {
                var character = await context.Characters.FirstOrDefaultAsync(x => x.Name.ToLower() == name.ToLower());
                if (character != null)
                {
                    if (character.Level < 60)
                    {
                        await _soapService.CharacterLevel(name, 60);
                        // modify money for spells (only like 150g)
                        // teach 150/150 mount
                    }
                    switch ((WoWClass)character.Class)
                    {
                        case WoWClass.Druid:
                            {
                                await _soapService.SendItemsAsync(name, druid);
                                await _soapService.SendItemsAsync(name, druidMisc);
                                await _soapService.SendItemsAsync(name, sharedCaster);
                                await _soapService.SendItemsAsync(name, sharedHealer);
                                await _soapService.SendItemsAsync(name, sharedPhysical);
                                return true;
                            }
                        case WoWClass.Hunter:
                            {
                                await _soapService.SendItemsAsync(name, hunter);
                                await _soapService.SendItemsAsync(name, hunterMisc);
                                await _soapService.SendItemsAsync(name, sharedPhysical);
                                return true;
                            }
                        case WoWClass.Mage:
                            {
                                await _soapService.SendItemsAsync(name, mage);
                                await _soapService.SendItemsAsync(name, mageMisc);
                                await _soapService.SendItemsAsync(name, sharedCaster);
                                return true;
                            }
                        case WoWClass.Paladin:
                            {
                                await _soapService.SendItemsAsync(name, paladin);
                                await _soapService.SendItemsAsync(name, paladinMisc);
                                await _soapService.SendItemsAsync(name, sharedCaster);
                                await _soapService.SendItemsAsync(name, sharedHealer);
                                await _soapService.SendItemsAsync(name, sharedPhysical);
                                return true;
                            }
                        case WoWClass.Priest:
                            {
                                await _soapService.SendItemsAsync(name, priest);
                                await _soapService.SendItemsAsync(name, priestMisc);
                                await _soapService.SendItemsAsync(name, sharedCaster);
                                await _soapService.SendItemsAsync(name, sharedHealer);
                                return true;
                            }
                        case WoWClass.Rogue:
                            {
                                await _soapService.SendItemsAsync(name, rogue);
                                await _soapService.SendItemsAsync(name, rogueMisc);
                                await _soapService.SendItemsAsync(name, sharedPhysical);
                                return true;
                            }
                        case WoWClass.Shaman:
                            {
                                await _soapService.SendItemsAsync(name, shaman);
                                await _soapService.SendItemsAsync(name, shamanMisc);
                                await _soapService.SendItemsAsync(name, sharedCaster);
                                await _soapService.SendItemsAsync(name, sharedHealer);
                                await _soapService.SendItemsAsync(name, sharedPhysical);
                                return true;
                            }
                        case WoWClass.Warlock:
                            {
                                await _soapService.SendItemsAsync(name, warlock);
                                await _soapService.SendItemsAsync(name, warlockMisc);
                                await _soapService.SendItemsAsync(name, sharedCaster);
                                return true;
                            }
                        case WoWClass.Warrior:
                            {
                                await _soapService.SendItemsAsync(name, warrior);
                                await _soapService.SendItemsAsync(name, warriorMisc);
                                await _soapService.SendItemsAsync(name, sharedPhysical);
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

        public static readonly int[] druid =
        {

        };

        public static readonly int[] druidMisc =
        {

        };

        // limit 12 per mail
        public static readonly int[] hunter =
        {
            22010, // girdle
            22011, // bindings
            22013, // cap
            22015, // gloves
            22016, // mantle
            22017, // pants
            22060, // tunic
            22061, // boots
        };

        public static readonly int[] hunterMisc =
        {
            18473, // hunter seal
            12651, // blackcrow
            18520, // barbarous blade
        };

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

        public static readonly int[] mageMisc =
        {
            22335, // lord valthalak's staff of command
            22408, // ritssyn's wand of bad mojo
        };

        public static readonly int[] paladin =
        {

        };

        public static readonly int[] paladinMisc =
        {

        };

        public static readonly int[] priest =
        {

        };

        public static readonly int[] priestMisc =
        {

        };

        public static readonly int[] rogue =
        {

        };

        public static readonly int[] rogueMisc =
        {

        };

        public static readonly int[] shaman =
        {

        };

        public static readonly int[] shamanMisc =
        {

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

        public static readonly int[] warlockMisc =
        {
            22335, // lord valthalak's staff of command
            22408, // ritssyn's wand of bad mojo
        };

        public static readonly int[] warrior =
        {

        };

        public static readonly int[] warriorMisc =
        {

        };

        public static readonly int[] sharedCaster =
        {
            12103, // star of mystaria
            12968, // frostweaver cape
            22433, // don mauricio's band of domination
            22339, // rune band of wizardry
            12930, // briarwood reed
            22268, // draconic infused emblem
        };

        public static readonly int[] sharedHealer =
        {

        };

        public static readonly int[] sharedPhysical =
        {
            13965, // blackhand's breadth
            18500, // tarnished elven ring
            18500, // tarnished elven ring
            22340, // pendant of celerity
            13340, // cape of the black baron
        };
    }
}
