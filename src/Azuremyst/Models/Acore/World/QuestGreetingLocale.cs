namespace Azuremyst.Models.Acore.World;

public partial class QuestGreetingLocale
{
    public uint Id { get; set; }

    public byte Type { get; set; }

    public string Locale { get; set; } = null!;

    public string? Greeting { get; set; }

    public int? VerifiedBuild { get; set; }
}
