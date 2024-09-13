namespace Azuremyst.Models.Acore.World;

public partial class QuestRequestItem
{
    public uint Id { get; set; }

    public ushort EmoteOnComplete { get; set; }

    public ushort EmoteOnIncomplete { get; set; }

    public string? CompletionText { get; set; }

    public int? VerifiedBuild { get; set; }
}
