namespace Azuremyst.Models.Acore.World;

public partial class AchievementRewardLocale
{
    public uint Id { get; set; }

    public string Locale { get; set; } = null!;

    public string? Subject { get; set; }

    public string? Text { get; set; }
}
