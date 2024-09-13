namespace Azuremyst.Models.Acore.Characters;

public partial class GameEventSave
{
    public byte EventEntry { get; set; }

    public byte State { get; set; }

    public uint NextStart { get; set; }
}
