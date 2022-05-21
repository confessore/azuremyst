namespace azuremyst.models.mangosd
{
    /// <summary>
    /// Creature System (Spawn Data Template)
    /// </summary>
    public partial class CreatureSpawnDataTemplate
    {
        /// <summary>
        /// ID of template
        /// </summary>
        public uint Entry { get; set; }
        public int NpcFlags { get; set; }
        public long UnitFlags { get; set; }
        public uint Faction { get; set; }
        public uint ModelId { get; set; }
        public int EquipmentId { get; set; }
        public uint CurHealth { get; set; }
        public uint CurMana { get; set; }
        public uint SpawnFlags { get; set; }
        public uint RelayId { get; set; }
    }
}
