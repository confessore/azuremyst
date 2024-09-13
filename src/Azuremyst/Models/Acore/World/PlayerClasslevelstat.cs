namespace Azuremyst.Models.Acore.World;

/// <summary>
/// Stores levels stats.
/// </summary>
public partial class PlayerClasslevelstat
{
    public byte Class { get; set; }

    public byte Level { get; set; }

    public uint Basehp { get; set; }

    public uint Basemana { get; set; }
}
