namespace azuremyst.models.mangosd
{
    /// <summary>
    /// Spell System
    /// </summary>
    public partial class SpellElixir
    {
        /// <summary>
        /// SpellId of potion
        /// </summary>
        public uint Entry { get; set; }
        /// <summary>
        /// Mask 0x1 battle 0x2 guardian 0x3 flask 0x7 unstable flasks 0xB shattrath flasks
        /// </summary>
        public byte Mask { get; set; }
    }
}
