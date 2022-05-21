namespace azuremyst.models.mangosd
{
    /// <summary>
    /// Quest and Gossip system
    /// </summary>
    public partial class QuestgiverGreeting
    {
        /// <summary>
        /// Entry of Questgiver
        /// </summary>
        public uint Entry { get; set; }
        /// <summary>
        /// Type of entry
        /// </summary>
        public uint Type { get; set; }
        /// <summary>
        /// Text of the greeting
        /// </summary>
        public string? Text { get; set; }
        /// <summary>
        /// Emote ID of greeting
        /// </summary>
        public uint EmoteId { get; set; }
        /// <summary>
        /// Emote delay of the greeting
        /// </summary>
        public uint EmoteDelay { get; set; }
    }
}
