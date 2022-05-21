namespace azuremyst.models.characters
{
    /// <summary>
    /// AuctionHouseBot overridden item settings
    /// </summary>
    public partial class AhbotItem
    {
        /// <summary>
        /// Item Identifier
        /// </summary>
        public uint Item { get; set; }
        /// <summary>
        /// Item value, a value of 0 bans item from being sold/bought by AHBot
        /// </summary>
        public uint Value { get; set; }
        /// <summary>
        /// Chance item is added to AH upon bot visit, 0 for normal loot sources
        /// </summary>
        public uint AddChance { get; set; }
        /// <summary>
        /// Min amount added, not used when add_chance is 0
        /// </summary>
        public uint MinAmount { get; set; }
        /// <summary>
        /// Max amount added, not used when add_chance is 0
        /// </summary>
        public uint MaxAmount { get; set; }
    }
}
