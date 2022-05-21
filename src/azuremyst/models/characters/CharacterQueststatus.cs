namespace azuremyst.models.characters
{
    /// <summary>
    /// Player System
    /// </summary>
    public partial class CharacterQueststatus
    {
        /// <summary>
        /// Global Unique Identifier
        /// </summary>
        public uint Guid { get; set; }
        /// <summary>
        /// Quest Identifier
        /// </summary>
        public uint Quest { get; set; }
        public uint Status { get; set; }
        public byte Rewarded { get; set; }
        public byte Explored { get; set; }
        public ulong Timer { get; set; }
        public uint Mobcount1 { get; set; }
        public uint Mobcount2 { get; set; }
        public uint Mobcount3 { get; set; }
        public uint Mobcount4 { get; set; }
        public uint Itemcount1 { get; set; }
        public uint Itemcount2 { get; set; }
        public uint Itemcount3 { get; set; }
        public uint Itemcount4 { get; set; }
    }
}
