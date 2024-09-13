namespace Azuremyst.Models.Acore.World;

/// <summary>
/// Dungeon/raid access template and single requirements
/// </summary>
public partial class DungeonAccessTemplate
{
    /// <summary>
    /// The dungeon template ID
    /// </summary>
    public byte Id { get; set; }

    /// <summary>
    /// Map ID from instance_template
    /// </summary>
    public uint? MapId { get; set; }

    /// <summary>
    /// 5 man: 0 = normal, 1 = heroic, 2 = epic (not implemented) | 10 man: 0 = normal, 2 = heroic | 25 man: 1 = normal, 3 = heroic
    /// </summary>
    public byte Difficulty { get; set; }

    public byte? MinLevel { get; set; }

    public byte? MaxLevel { get; set; }

    /// <summary>
    /// Min average ilvl required to enter
    /// </summary>
    public ushort? MinAvgItemLevel { get; set; }

    /// <summary>
    /// Dungeon Name 5/10/25/40 man - Normal/Heroic
    /// </summary>
    public string? Comment { get; set; }
}
