namespace azuremyst.models.characters
{
    /// <summary>
    /// Grid Loading System
    /// </summary>
    public partial class GameobjectRespawn
    {
        /// <summary>
        /// Global Unique Identifier
        /// </summary>
        public uint Guid { get; set; }
        public ulong Respawntime { get; set; }
        public uint Instance { get; set; }
    }
}
