namespace Azuremyst.Models.Acore.World;

public partial class BroadcastTextLocale
{
    public uint Id { get; set; }

    public string Locale { get; set; } = null!;

    public string? MaleText { get; set; }

    public string? FemaleText { get; set; }

    public short? VerifiedBuild { get; set; }
}
