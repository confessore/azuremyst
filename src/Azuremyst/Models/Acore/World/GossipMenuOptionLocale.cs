namespace Azuremyst.Models.Acore.World;

public partial class GossipMenuOptionLocale
{
    public uint MenuId { get; set; }

    public ushort OptionId { get; set; }

    public string Locale { get; set; } = null!;

    public string? OptionText { get; set; }

    public string? BoxText { get; set; }
}
