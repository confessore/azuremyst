namespace azuremyst.models.mangosd
{
    /// <summary>
    /// Creature System (Equipment)
    /// </summary>
    public partial class CreatureEquipTemplateRaw
    {
        /// <summary>
        /// Unique entry
        /// </summary>
        public uint Entry { get; set; }
        public uint Equipmodel1 { get; set; }
        public uint Equipmodel2 { get; set; }
        public uint Equipmodel3 { get; set; }
        public uint Equipinfo1 { get; set; }
        public uint Equipinfo2 { get; set; }
        public uint Equipinfo3 { get; set; }
        public int Equipslot1 { get; set; }
        public int Equipslot2 { get; set; }
        public int Equipslot3 { get; set; }
    }
}
