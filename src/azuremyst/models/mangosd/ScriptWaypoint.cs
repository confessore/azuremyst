namespace azuremyst.models.mangosd
{
    /// <summary>
    /// Script Creature waypoints
    /// </summary>
    public partial class ScriptWaypoint
    {
        /// <summary>
        /// creature_template entry
        /// </summary>
        public uint Entry { get; set; }
        public uint PathId { get; set; }
        public uint Point { get; set; }
        public float PositionX { get; set; }
        public float PositionY { get; set; }
        public float PositionZ { get; set; }
        public float Orientation { get; set; }
        /// <summary>
        /// waittime in millisecs
        /// </summary>
        public uint WaitTime { get; set; }
        public uint ScriptId { get; set; }
        public string? Comment { get; set; }
    }
}
