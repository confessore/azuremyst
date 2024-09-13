namespace Azuremyst.Models.Acore.World;

public partial class GameEventNpcVendor
{
    /// <summary>
    /// Entry of the game event.
    /// </summary>
    public sbyte EventEntry { get; set; }

    public uint Guid { get; set; }

    public short Slot { get; set; }

    public uint Item { get; set; }

    public uint Maxcount { get; set; }

    public uint Incrtime { get; set; }

    public uint ExtendedCost { get; set; }
}
