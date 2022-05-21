namespace azuremyst.models.mangosd
{
    /// <summary>
    /// Item System
    /// </summary>
    public partial class SpellLearnSpell
    {
        public ushort Entry { get; set; }
        public ushort SpellId { get; set; }
        public byte Active { get; set; }
    }
}
