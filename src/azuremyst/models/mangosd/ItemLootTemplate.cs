namespace azuremyst.models.mangosd
{
    /// <summary>
    /// Loot System
    /// </summary>
    public partial class ItemLootTemplate
    {
        public uint Entry { get; set; }
        public uint Item { get; set; }
        public float ChanceOrQuestChance { get; set; }
        public byte Groupid { get; set; }
        public int MincountOrRef { get; set; }
        public byte Maxcount { get; set; }
        public uint ConditionId { get; set; }
        public string? Comments { get; set; }
    }
}
