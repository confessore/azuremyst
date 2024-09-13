namespace Azuremyst.Models.Acore.World;

public partial class QuestOfferRewardLocale
{
    public uint Id { get; set; }

    public string Locale { get; set; } = null!;

    public string? RewardText { get; set; }

    public int? VerifiedBuild { get; set; }
}
