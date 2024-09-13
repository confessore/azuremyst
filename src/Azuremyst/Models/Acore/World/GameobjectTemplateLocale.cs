namespace Azuremyst.Models.Acore.World;

public partial class GameobjectTemplateLocale
{
    public uint Entry { get; set; }

    public string Locale { get; set; } = null!;

    public string? Name { get; set; }

    public string? CastBarCaption { get; set; }

    public int? VerifiedBuild { get; set; }
}
