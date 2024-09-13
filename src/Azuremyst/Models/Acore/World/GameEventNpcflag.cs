namespace Azuremyst.Models.Acore.World;

public partial class GameEventNpcflag
{
    /// <summary>
    /// Entry of the game event
    /// </summary>
    public byte EventEntry { get; set; }

    public uint Guid { get; set; }

    public uint Npcflag { get; set; }
}
