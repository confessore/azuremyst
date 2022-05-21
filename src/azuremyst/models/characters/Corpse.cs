namespace azuremyst.models.characters
{
    /// <summary>
    /// Death System
    /// </summary>
    public partial class Corpse
    {
        /// <summary>
        /// Global Unique Identifier
        /// </summary>
        public uint Guid { get; set; }
        /// <summary>
        /// Character Global Unique Identifier
        /// </summary>
        public uint Player { get; set; }
        public float PositionX { get; set; }
        public float PositionY { get; set; }
        public float PositionZ { get; set; }
        public float Orientation { get; set; }
        /// <summary>
        /// Map Identifier
        /// </summary>
        public uint Map { get; set; }
        public ulong Time { get; set; }
        public byte CorpseType { get; set; }
        public uint Instance { get; set; }
    }
}
