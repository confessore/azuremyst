namespace azuremyst.models.mangosd
{
    public partial class SpellBonusDatum
    {
        public ushort Entry { get; set; }
        public float DirectBonus { get; set; }
        public float DotBonus { get; set; }
        public float ApBonus { get; set; }
        public float ApDotBonus { get; set; }
        public string? Comments { get; set; }
    }
}
