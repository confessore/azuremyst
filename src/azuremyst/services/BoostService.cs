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
                        await _soapService.SendMoneyAsync(name, 5000000);
                        await _soapService.SendItemsAsync(name, bags);
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
                }
            }
            return false;
        }

        public static readonly int[] druid =
        {
            
        };

        public static readonly int[] druidMisc =
        {
            22335, // lord valthalak's staff of command
            11815, // hand of justice
        };

        // limit 12 per mail
        public static readonly int[] hunter =
        {
            22010, // beastmaster's girdle
            22011, // beastmaster's bindings
            22013, // beastmaster's cap
            22015, // beastmaster's gloves
            22016, // beastmaster's mantle
            22017, // beastmaster's pants
            22060, // beastmaster's tunic
            22061, // beastmaster's boots
        };

        public static readonly int[] hunterMisc =
        {
            18473, // hunter seal
            12651, // blackcrow
            18520, // barbarous blade
            18737, // bone slicing hatchet
            18737, // bone slicing hatchet
        };

        public static readonly int[] mage =
        {
            22062, // sorcerer's belt
            22063, // sorcerer's bindings
            22064, // sorcerer's boots
            22065, // sorcerer's crown
            22066, // sorcerer's gloves
            22067, // sorcerer's leggings
            22068, // sorcerer's mantle
            22069, // sorcerer's robes
        };

        public static readonly int[] mageMisc =
        {
            22335, // lord valthalak's staff of command
            22408, // ritssyn's wand of bad mojo
        };

        public static readonly int[] paladin =
        {
            22086, // soulforge belt
            22087, // soulforge boots
            22088, // soulforge bracers
            22089, // soulforge breastplate
            22090, // soulforge guantlets
            22091, // soulforge helm
            22092, // soulforge legplates
            22093, // soulforge spaulders
        };

        public static readonly int[] paladinMisc =
        {
            18520, // barbarous blade
            11815, // hand of justice
            12602, // draconian deflector
            18396, // mind carver
        };

        public static readonly int[] priest =
        {
            22078, // virtuous belt
            22079, // virtuous bracers
            22080, // virtuous crown
            22081, // virtuous gloves
            22082, // virtuous mantle
            22083, // virtuous robe
            22084, // virtuous sandals
            22085, // virtuous skirt
        };

        public static readonly int[] priestMisc =
        {
            22335, // lord valthalak's staff of command
            22408, // ritssyn's wand of bad mojo
        };

        public static readonly int[] rogue =
        {
            22002, // darkmantle belt
            22003, // darkmantle boots
            22004, // darkmantle bracers
            22005, // darkmantle cap
            22006, // darkmantle gloves
            22007, // darkmantle pants
            22008, // darkmantle spaulders
            22009, // darkmantle tunic
        };

        public static readonly int[] rogueMisc =
        {
            18323, // satyr's bow
            12939, // dal'rend's tribal guardian
            12940, // dal'rend's sacred charge
            11815, // hand of justice
            19100, // electrified dagger
            18392, // distracting dagger
        };

        public static readonly int[] shaman =
        {

        };

        public static readonly int[] shamanMisc =
        {
            11815, // hand of justice
        };

        public static readonly int[] warlock =
        {
            22070, // deathmist belt
            22071, // deathmist braces
            22072, // deathmist leggings
            22073, // deathmist mantle
            22074, // deathmist mask
            22075, // deathmist robe
            22076, // deathmist sandals
            22077, // deathmist wraps
        };

        public static readonly int[] warlockMisc =
        {
            22335, // lord valthalak's staff of command
            22408, // ritssyn's wand of bad mojo
        };

        public static readonly int[] warrior =
        {
            21994, // belt of heroism
            21995, // boots of heroism
            21996, // bracers of heroism
            21997, // breastplate of heroism
            21998, // guantlets of heroism
            21999, // helm of heroism
            22000, // legplates of heroism
            22001, // spaulders of heroism
        };

        public static readonly int[] warriorMisc =
        {
            18520, // barbarous blade
            18323, // satyr's bow
            12939, // dal'rend's tribal guardian
            12940, // dal'rend's sacred charge
            11815, // hand of justice
            12602, // draconian deflector
            18737, // bone slicing hatchet
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
            11923, // the hammer of grace
            22319, // tome of divine right
            18723, // animated chain necklace
            18371, // mindtap talisman,
            13178, // rosewine circle
            16058, // fordring's seal
        };

        public static readonly int[] sharedPhysical =
        {
            13965, // blackhand's breadth
            17713, // blackstone ring
            18500, // tarnished elven ring
            22340, // pendant of celerity
            13340, // cape of the black baron
        };

        public static readonly int[] bags =
        {
            21841, // netherweave bag
            21841, // netherweave bag
            21841, // netherweave bag
            21841, // netherweave bag
        };
    }
}
