namespace Azuremyst.Models.Acore.Characters;

public partial class ItemLootStorage
{
    public uint ContainerGuid { get; set; }

    public uint Itemid { get; set; }

    public uint Count { get; set; }

    public uint ItemIndex { get; set; }

    public int RandomPropertyId { get; set; }

    public uint RandomSuffix { get; set; }

    public byte FollowLootRules { get; set; }

    public byte Freeforall { get; set; }

    public byte IsBlocked { get; set; }

    public byte IsCounted { get; set; }

    public byte IsUnderthreshold { get; set; }

    public byte NeedsQuest { get; set; }

    public int ConditionLootId { get; set; }
}
