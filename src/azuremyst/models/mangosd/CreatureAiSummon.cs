namespace azuremyst.models.mangosd
{
    /// <summary>
    /// EventAI Summoning Locations
    /// </summary>
    public partial class CreatureAiSummon
    {
        /// <summary>
        /// Location Identifier
        /// </summary>
        public uint Id { get; set; }
        public float PositionX { get; set; }
        public float PositionY { get; set; }
        public float PositionZ { get; set; }
        public float Orientation { get; set; }
        public uint Spawntimesecs { get; set; }
        /// <summary>
        /// Summon Comment
        /// </summary>
        public string Comment { get; set; } = null!;
    }
}
