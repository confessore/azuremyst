namespace Azuremyst.Models.Acore.World;

public partial class GameEventGameobjectQuest
{
    /// <summary>
    /// Entry of the game event
    /// </summary>
    public byte EventEntry { get; set; }

    public uint Id { get; set; }

    public uint Quest { get; set; }
}
