namespace Azuremyst.Models.Acore.World;

/// <summary>
/// Add (multiple) requirements before being able to enter a dungeon/raid
/// </summary>
public partial class DungeonAccessRequirement
{
    /// <summary>
    /// ID from dungeon_access_template
    /// </summary>
    public byte DungeonAccessId { get; set; }

    /// <summary>
    /// 0 = achiev, 1 = quest, 2 = item
    /// </summary>
    public byte RequirementType { get; set; }

    /// <summary>
    /// Achiev/quest/item ID
    /// </summary>
    public uint RequirementId { get; set; }

    /// <summary>
    /// Optional msg shown ingame to player if he cannot enter. You can add extra info
    /// </summary>
    public string? RequirementNote { get; set; }

    /// <summary>
    /// 0 = Alliance, 1 = Horde, 2 = Both factions
    /// </summary>
    public byte Faction { get; set; }

    /// <summary>
    /// Priority order for the requirement, sorted by type. 0 is the highest priority
    /// </summary>
    public byte? Priority { get; set; }

    /// <summary>
    /// 0 = check the requirement for the player trying to enter, 1 = check the requirement for the party leader
    /// </summary>
    public sbyte LeaderOnly { get; set; }

    public string? Comment { get; set; }
}
