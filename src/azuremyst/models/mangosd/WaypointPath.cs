namespace azuremyst.models.mangosd
{
    public partial class WaypointPath
    {
        /// <summary>
        /// Unique path id
        /// </summary>
        public uint PathId { get; set; }
        public uint Point { get; set; }
        public float PositionX { get; set; }
        public float PositionY { get; set; }
        public float PositionZ { get; set; }
        public float Orientation { get; set; }
        public uint WaitTime { get; set; }
        public uint ScriptId { get; set; }
        public string? Comment { get; set; }
    }
}
