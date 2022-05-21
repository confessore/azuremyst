namespace azuremyst.models.mangosd
{
    public partial class CreatureSpellList
    {
        /// <summary>
        /// List ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Position on list
        /// </summary>
        public int Position { get; set; }
        /// <summary>
        /// Spell ID
        /// </summary>
        public int SpellId { get; set; }
        /// <summary>
        /// Spell Flags
        /// </summary>
        public int Flags { get; set; }
        /// <summary>
        /// Targeting ID
        /// </summary>
        public int TargetId { get; set; }
        /// <summary>
        /// Dbscript to be launched on success
        /// </summary>
        public int ScriptId { get; set; }
        /// <summary>
        /// Chance on spawn for spell to be included
        /// </summary>
        public int Availability { get; set; }
        /// <summary>
        /// Weight of spell when multiple are available
        /// </summary>
        public int Probability { get; set; }
        /// <summary>
        /// Initial delay minimum
        /// </summary>
        public int InitialMin { get; set; }
        /// <summary>
        /// Initial delay maximum
        /// </summary>
        public int InitialMax { get; set; }
        /// <summary>
        /// Repeated delay minimum
        /// </summary>
        public int RepeatMin { get; set; }
        /// <summary>
        /// Repeated delay maximum
        /// </summary>
        public int RepeatMax { get; set; }
        /// <summary>
        /// Description of spell use
        /// </summary>
        public string Comments { get; set; } = null!;
    }
}
