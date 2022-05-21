namespace azuremyst.models.mangosd
{
    /// <summary>
    /// Creature Linking System
    /// </summary>
    public partial class CreatureLinkingTemplate
    {
        /// <summary>
        /// creature_template.entry of the slave mob that is linked
        /// </summary>
        public uint Entry { get; set; }
        /// <summary>
        /// Id of map of the mobs
        /// </summary>
        public ushort Map { get; set; }
        /// <summary>
        /// master to trigger events
        /// </summary>
        public uint MasterEntry { get; set; }
        /// <summary>
        /// flag - describing what should happen when
        /// </summary>
        public uint Flag { get; set; }
        /// <summary>
        /// search_range - describing in which range (spawn-coords) master and slave are linked together
        /// </summary>
        public uint SearchRange { get; set; }
    }
}
