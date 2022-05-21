namespace azuremyst.models.mangosd
{
    public partial class BattlegroundEvent
    {
        public short Map { get; set; }
        public byte Event1 { get; set; }
        public byte Event2 { get; set; }
        public string Description { get; set; } = null!;
    }
}
