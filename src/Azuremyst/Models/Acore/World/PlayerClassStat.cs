namespace Azuremyst.Models.Acore.World;

/// <summary>
/// Stores levels stats.
/// </summary>
public partial class PlayerClassStat
{
    public byte Class { get; set; }

    public byte Level { get; set; }

    public uint BaseHp { get; set; }

    public uint BaseMana { get; set; }

    public uint Strength { get; set; }

    public uint Agility { get; set; }

    public uint Stamina { get; set; }

    public uint Intellect { get; set; }

    public uint Spirit { get; set; }
}
