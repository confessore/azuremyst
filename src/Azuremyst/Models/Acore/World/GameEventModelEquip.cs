namespace Azuremyst.Models.Acore.World;

public partial class GameEventModelEquip
{
    /// <summary>
    /// Entry of the game event.
    /// </summary>
    public sbyte EventEntry { get; set; }

    public uint Guid { get; set; }

    public uint Modelid { get; set; }

    public byte EquipmentId { get; set; }
}
