namespace Azuremyst.Models.Acore.World;

public partial class QuestRequestItemsLocale
{
    public uint Id { get; set; }

    public string Locale { get; set; } = null!;

    public string? CompletionText { get; set; }

    public int? VerifiedBuild { get; set; }
}
