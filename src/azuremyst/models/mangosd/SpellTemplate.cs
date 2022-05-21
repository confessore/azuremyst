namespace azuremyst.models.mangosd
{
    /// <summary>
    /// MaNGOS server side spells
    /// </summary>
    public partial class SpellTemplate
    {
        public uint Id { get; set; }
        public uint ProcFlags { get; set; }
        public uint ProcChance { get; set; }
        public uint DurationIndex { get; set; }
        public uint Effect0 { get; set; }
        public uint Effect0ImplicitTargetA { get; set; }
        public uint Effect0RadiusIdx { get; set; }
        public uint Effect0ApplyAuraName { get; set; }
        public uint Effect0MiscValue { get; set; }
        public uint Effect0MiscValueB { get; set; }
        public uint Effect0TriggerSpell { get; set; }
        public string Comments { get; set; } = null!;
    }
}
