namespace azuremyst.models.mangosd
{
    /// <summary>
    /// Creature System (Conditional Spawn)
    /// </summary>
    public partial class CreatureConditionalSpawn
    {
        /// <summary>
        /// Global Unique Identifier
        /// </summary>
        public uint Guid { get; set; }
        /// <summary>
        /// Alliance Creature Identifier
        /// </summary>
        public uint EntryAlliance { get; set; }
        /// <summary>
        /// Horde Creature Identifier
        /// </summary>
        public uint EntryHorde { get; set; }
        public string Comments { get; set; } = null!;
    }
}
