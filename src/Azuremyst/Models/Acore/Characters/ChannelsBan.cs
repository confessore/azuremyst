namespace Azuremyst.Models.Acore.Characters;

public partial class ChannelsBan
{
    public uint ChannelId { get; set; }

    public uint PlayerGuid { get; set; }

    public uint BanTime { get; set; }
}
