namespace Azuremyst.Models.Acore.World;

/// <summary>
/// Item System
/// </summary>
public partial class PageText
{
    public uint Id { get; set; }

    public string Text { get; set; } = null!;

    public uint NextPageId { get; set; }

    public int? VerifiedBuild { get; set; }
}
