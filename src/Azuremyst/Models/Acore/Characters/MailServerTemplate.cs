namespace Azuremyst.Models.Acore.Characters;

public partial class MailServerTemplate
{
    public uint Id { get; set; }

    public byte ReqLevel { get; set; }

    public uint ReqPlayTime { get; set; }

    public uint MoneyA { get; set; }

    public uint MoneyH { get; set; }

    public uint ItemA { get; set; }

    public uint ItemCountA { get; set; }

    public uint ItemH { get; set; }

    public uint ItemCountH { get; set; }

    public string Subject { get; set; } = null!;

    public string Body { get; set; } = null!;

    public byte Active { get; set; }
}
