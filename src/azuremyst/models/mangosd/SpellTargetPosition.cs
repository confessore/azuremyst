namespace azuremyst.models.mangosd
{
    /// <summary>
    /// Spell System
    /// </summary>
    public partial class SpellTargetPosition
    {
        /// <summary>
        /// Identifier
        /// </summary>
        public uint Id { get; set; }
        public ushort TargetMap { get; set; }
        public float TargetPositionX { get; set; }
        public float TargetPositionY { get; set; }
        public float TargetPositionZ { get; set; }
        public float TargetOrientation { get; set; }
    }
}
