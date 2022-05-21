namespace azuremyst.models.mangosd
{
    public partial class CreatureSpellTargeting
    {
        /// <summary>
        /// Targeting ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Type of targeting ID
        /// </summary>
        public int Type { get; set; }
        /// <summary>
        /// First parameter
        /// </summary>
        public int Param1 { get; set; }
        /// <summary>
        /// Second parameter
        /// </summary>
        public int Param2 { get; set; }
        /// <summary>
        /// Third parameter
        /// </summary>
        public int Param3 { get; set; }
        /// <summary>
        /// Description of target
        /// </summary>
        public string Comments { get; set; } = null!;
    }
}
