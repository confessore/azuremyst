namespace Azuremyst.Models.Acore.World;

public partial class GameEventCreature
{
    /// <summary>
    /// Entry of the game event. Put negative entry to remove during event.
    /// </summary>
    public sbyte EventEntry { get; set; }

    public uint Guid { get; set; }
}
