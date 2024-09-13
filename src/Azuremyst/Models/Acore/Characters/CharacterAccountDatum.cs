namespace Azuremyst.Models.Acore.Characters;

public partial class CharacterAccountDatum
{
    public uint Guid { get; set; }

    public byte Type { get; set; }

    public uint Time { get; set; }

    public byte[] Data { get; set; } = null!;
}
