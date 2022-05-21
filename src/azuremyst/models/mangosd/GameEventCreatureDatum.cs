namespace azuremyst.models.mangosd
{
    public partial class GameEventCreatureDatum
    {
        public uint Guid { get; set; }
        public uint EntryId { get; set; }
        public uint Modelid { get; set; }
        public uint EquipmentId { get; set; }
        public uint VendorId { get; set; }
        public uint SpellStart { get; set; }
        public uint SpellEnd { get; set; }
        public ushort Event { get; set; }
    }
}
