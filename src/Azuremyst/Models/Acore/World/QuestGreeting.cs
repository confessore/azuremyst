namespace Azuremyst.Models.Acore.World;

public partial class QuestGreeting
{
    public uint Id { get; set; }

    public byte Type { get; set; }

    public ushort GreetEmoteType { get; set; }

    public uint GreetEmoteDelay { get; set; }

    public string? Greeting { get; set; }

    public int? VerifiedBuild { get; set; }
}
