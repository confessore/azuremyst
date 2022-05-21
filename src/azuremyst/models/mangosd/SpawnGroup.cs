namespace azuremyst.models.mangosd
{
    public partial class SpawnGroup
    {
        /// <summary>
        /// Spawn Group ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Description of usage
        /// </summary>
        public string Name { get; set; } = null!;
        /// <summary>
        /// Creature or GO spawn group
        /// </summary>
        public int Type { get; set; }
        /// <summary>
        /// Maximum total count of all spawns in a group
        /// </summary>
        public int MaxCount { get; set; }
        /// <summary>
        /// Worldstate which enables spawning of given group
        /// </summary>
        public int WorldState { get; set; }
        /// <summary>
        /// Flags for various behaviour
        /// </summary>
        public uint Flags { get; set; }
    }
}
