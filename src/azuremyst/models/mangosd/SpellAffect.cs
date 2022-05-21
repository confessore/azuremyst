namespace azuremyst.models.mangosd
{
    public partial class SpellAffect
    {
        public ushort Entry { get; set; }
        public byte EffectId { get; set; }
        public ulong SpellFamilyMask { get; set; }
    }
}
