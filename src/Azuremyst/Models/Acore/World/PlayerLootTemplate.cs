namespace Azuremyst.Models.Acore.World;

/// <summary>
/// Loot System
/// </summary>
public partial class PlayerLootTemplate
{
    public uint Entry { get; set; }

    public uint Item { get; set; }

    public int Reference { get; set; }

    public float Chance { get; set; }

    public sbyte QuestRequired { get; set; }

    public ushort LootMode { get; set; }

    public byte GroupId { get; set; }

    public byte MinCount { get; set; }

    public byte MaxCount { get; set; }

    public string? Comment { get; set; }
}
