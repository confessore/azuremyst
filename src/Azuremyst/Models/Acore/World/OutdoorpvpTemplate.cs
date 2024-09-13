namespace Azuremyst.Models.Acore.World;

/// <summary>
/// OutdoorPvP Templates
/// </summary>
public partial class OutdoorpvpTemplate
{
    public byte TypeId { get; set; }

    public string ScriptName { get; set; } = null!;

    public string? Comment { get; set; }
}
