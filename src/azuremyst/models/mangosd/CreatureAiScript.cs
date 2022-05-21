namespace azuremyst.models.mangosd
{
    /// <summary>
    /// EventAI Scripts
    /// </summary>
    public partial class CreatureAiScript
    {
        /// <summary>
        /// Identifier
        /// </summary>
        public uint Id { get; set; }
        /// <summary>
        /// Creature Template Identifier
        /// </summary>
        public uint CreatureId { get; set; }
        /// <summary>
        /// Event Type
        /// </summary>
        public byte EventType { get; set; }
        /// <summary>
        /// Mask which phases this event will not trigger in
        /// </summary>
        public int EventInversePhaseMask { get; set; }
        public uint EventChance { get; set; }
        public uint EventFlags { get; set; }
        public int EventParam1 { get; set; }
        public int EventParam2 { get; set; }
        public int EventParam3 { get; set; }
        public int EventParam4 { get; set; }
        public int EventParam5 { get; set; }
        public int EventParam6 { get; set; }
        /// <summary>
        /// Action Type
        /// </summary>
        public byte Action1Type { get; set; }
        public int Action1Param1 { get; set; }
        public int Action1Param2 { get; set; }
        public int Action1Param3 { get; set; }
        /// <summary>
        /// Action Type
        /// </summary>
        public byte Action2Type { get; set; }
        public int Action2Param1 { get; set; }
        public int Action2Param2 { get; set; }
        public int Action2Param3 { get; set; }
        /// <summary>
        /// Action Type
        /// </summary>
        public byte Action3Type { get; set; }
        public int Action3Param1 { get; set; }
        public int Action3Param2 { get; set; }
        public int Action3Param3 { get; set; }
        /// <summary>
        /// Event Comment
        /// </summary>
        public string Comment { get; set; } = null!;
    }
}
