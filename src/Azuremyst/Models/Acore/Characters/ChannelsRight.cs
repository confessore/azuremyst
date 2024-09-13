namespace Azuremyst.Models.Acore.Characters;

public partial class ChannelsRight
{
    public string Name { get; set; } = null!;

    public uint Flags { get; set; }

    public uint Speakdelay { get; set; }

    public string Joinmessage { get; set; } = null!;

    public string Delaymessage { get; set; } = null!;

    public string? Moderators { get; set; }
}
