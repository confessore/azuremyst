namespace Azuremyst.Models.Acore.World;

public partial class GameEventPool
{
    /// <summary>
    /// Entry of the game event. Put negative entry to remove during event.
    /// </summary>
    public sbyte EventEntry { get; set; }

    /// <summary>
    /// Id of the pool
    /// </summary>
    public uint PoolEntry { get; set; }
}
