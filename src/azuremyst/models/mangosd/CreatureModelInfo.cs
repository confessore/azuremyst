namespace azuremyst.models.mangosd
{
    /// <summary>
    /// Creature System (Model related info)
    /// </summary>
    public partial class CreatureModelInfo
    {
        public uint Modelid { get; set; }
        public float BoundingRadius { get; set; }
        public float CombatReach { get; set; }
        /// <summary>
        /// Default walking speed for any creature with model
        /// </summary>
        public float SpeedWalk { get; set; }
        /// <summary>
        /// Default running speed for any creature with model
        /// </summary>
        public float SpeedRun { get; set; }
        public byte Gender { get; set; }
        public uint ModelidOtherGender { get; set; }
        public uint ModelidAlternative { get; set; }
    }
}
