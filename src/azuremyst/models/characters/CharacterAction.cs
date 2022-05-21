namespace azuremyst.models.characters
{
    /// <summary>
    /// Player System
    /// </summary>
    public partial class CharacterAction
    {
        /// <summary>
        /// Global Unique Identifier
        /// </summary>
        public uint Guid { get; set; }
        public byte Button { get; set; }
        public uint Action { get; set; }
        public byte Type { get; set; }
    }
}
