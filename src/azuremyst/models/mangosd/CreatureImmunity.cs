namespace azuremyst.models.mangosd
{
    public partial class CreatureImmunity
    {
        /// <summary>
        /// creature_template entry
        /// </summary>
        public uint Entry { get; set; }
        /// <summary>
        /// immunity set ID
        /// </summary>
        public uint SetId { get; set; }
        /// <summary>
        /// enum SpellImmunity
        /// </summary>
        public byte Type { get; set; }
        /// <summary>
        /// value depending on type
        /// </summary>
        public uint Value { get; set; }
    }
}
