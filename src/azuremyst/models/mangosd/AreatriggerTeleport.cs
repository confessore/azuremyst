namespace azuremyst.models.mangosd
{
    /// <summary>
    /// Trigger System
    /// </summary>
    public partial class AreatriggerTeleport
    {
        /// <summary>
        /// Identifier
        /// </summary>
        public uint Id { get; set; }
        public string? Name { get; set; }
        public byte RequiredLevel { get; set; }
        public uint RequiredItem { get; set; }
        public uint RequiredItem2 { get; set; }
        public uint HeroicKey { get; set; }
        public uint HeroicKey2 { get; set; }
        public uint RequiredQuestDone { get; set; }
        public uint RequiredQuestDoneHeroic { get; set; }
        public ushort TargetMap { get; set; }
        public float TargetPositionX { get; set; }
        public float TargetPositionY { get; set; }
        public float TargetPositionZ { get; set; }
        public float TargetOrientation { get; set; }
        public uint ConditionId { get; set; }
        public string? StatusFailedText { get; set; }
    }
}
