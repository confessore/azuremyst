namespace Azuremyst.Models.Acore.Characters;

public partial class CharacterInstance
{
    public uint Guid { get; set; }

    public uint Instance { get; set; }

    public byte Permanent { get; set; }

    public byte Extended { get; set; }
}
