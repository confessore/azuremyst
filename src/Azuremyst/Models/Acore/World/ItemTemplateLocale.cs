namespace Azuremyst.Models.Acore.World;

public partial class ItemTemplateLocale
{
    public uint Id { get; set; }

    public string Locale { get; set; } = null!;

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int? VerifiedBuild { get; set; }
}
