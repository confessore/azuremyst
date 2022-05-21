namespace azuremyst.models.characters
{
    /// <summary>
    /// Player System
    /// </summary>
    public partial class CharacterQueststatusMonthly
    {
        /// <summary>
        /// Global Unique Identifier
        /// </summary>
        public uint Guid { get; set; }
        /// <summary>
        /// Quest Identifier
        /// </summary>
        public uint Quest { get; set; }
    }
}
