namespace Azuremyst.Models.Acore.World;

public partial class CreatureTextLocale
{
    public uint CreatureId { get; set; }

    public byte GroupId { get; set; }

    public byte Id { get; set; }

    public string Locale { get; set; } = null!;

    public string? Text { get; set; }
}
