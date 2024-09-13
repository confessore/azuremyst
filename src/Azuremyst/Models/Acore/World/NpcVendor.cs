namespace Azuremyst.Models.Acore.World;

/// <summary>
/// Npc System
/// </summary>
public partial class NpcVendor
{
    public uint Entry { get; set; }

    public short Slot { get; set; }

    public int Item { get; set; }

    public byte Maxcount { get; set; }

    public uint Incrtime { get; set; }

    public uint ExtendedCost { get; set; }

    public int? VerifiedBuild { get; set; }
}
