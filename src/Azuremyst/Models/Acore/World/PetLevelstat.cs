namespace Azuremyst.Models.Acore.World;

/// <summary>
/// Stores pet levels stats.
/// </summary>
public partial class PetLevelstat
{
    public uint CreatureEntry { get; set; }

    public byte Level { get; set; }

    public uint Hp { get; set; }

    public uint Mana { get; set; }

    public uint Armor { get; set; }

    public uint Str { get; set; }

    public uint Agi { get; set; }

    public uint Sta { get; set; }

    public uint Inte { get; set; }

    public uint Spi { get; set; }

    public uint MinDmg { get; set; }

    public uint MaxDmg { get; set; }
}
