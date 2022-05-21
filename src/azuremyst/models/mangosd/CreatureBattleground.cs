namespace azuremyst.models.mangosd
{
    /// <summary>
    /// Creature battleground indexing system
    /// </summary>
    public partial class CreatureBattleground
    {
        /// <summary>
        /// Creature&apos;s GUID
        /// </summary>
        public uint Guid { get; set; }
        /// <summary>
        /// main event
        /// </summary>
        public byte Event1 { get; set; }
        /// <summary>
        /// sub event
        /// </summary>
        public byte Event2 { get; set; }
    }
}
