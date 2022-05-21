namespace azuremyst.models.mangosd
{
    public partial class CreatureCooldown
    {
        public uint Entry { get; set; }
        public uint SpellId { get; set; }
        public uint CooldownMin { get; set; }
        public uint CooldownMax { get; set; }
    }
}
