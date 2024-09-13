namespace Azuremyst.Models.Acore.World;

public partial class GameEventPrerequisite
{
    /// <summary>
    /// Entry of the game event
    /// </summary>
    public byte EventEntry { get; set; }

    public uint PrerequisiteEvent { get; set; }
}
