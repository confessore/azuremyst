using System.ComponentModel;

namespace azuremyst.models.enums
{
    public enum WoWClass : uint
    {
        [Description("None")]
        None = 0,
        [Description("Warrior")]
        Warrior = 1,
        [Description("Paladin")]
        Paladin = 2,
        [Description("Hunter")]
        Hunter = 3,
        [Description("Rogue")]
        Rogue = 4,
        [Description("Priest")]
        Priest = 5,
        [Description("DeathKnight")]
        DeathKnight = 6,
        [Description("Shaman")]
        Shaman = 7,
        [Description("Mage")]
        Mage = 8,
        [Description("Warlock")]
        Warlock = 9,
        [Description("Druid")]
        Druid = 11,
    }
}
