namespace azuremyst.models.mangosd
{
    /// <summary>
    /// Creature System (Spawn Data)
    /// </summary>
    public partial class CreatureSpawnDatum
    {
        /// <summary>
        /// guid of creature
        /// </summary>
        public uint Guid { get; set; }
        /// <summary>
        /// ID of template
        /// </summary>
        public uint Id { get; set; }
    }
}
