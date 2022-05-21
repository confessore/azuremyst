namespace azuremyst.models.mangosd
{
    public partial class SpellThreat
    {
        public uint Entry { get; set; }
        public short Threat { get; set; }
        /// <summary>
        /// threat multiplier for damage/healing
        /// </summary>
        public float Multiplier { get; set; }
        /// <summary>
        /// additional threat bonus from attack power
        /// </summary>
        public float ApBonus { get; set; }
    }
}
