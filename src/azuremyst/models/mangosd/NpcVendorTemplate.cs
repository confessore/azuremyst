namespace azuremyst.models.mangosd
{
    /// <summary>
    /// Npc System
    /// </summary>
    public partial class NpcVendorTemplate
    {
        public uint Entry { get; set; }
        public uint Item { get; set; }
        public byte Maxcount { get; set; }
        public uint Incrtime { get; set; }
        public byte Slot { get; set; }
        public uint ExtendedCost { get; set; }
        public uint ConditionId { get; set; }
    }
}
