namespace Azuremyst.Models.Acore.World;

/// <summary>
/// Mail System
/// </summary>
public partial class MailLevelReward
{
    public byte Level { get; set; }

    public uint RaceMask { get; set; }

    public uint MailTemplateId { get; set; }

    public uint SenderEntry { get; set; }
}
