namespace azuremyst.models.characters
{
    public partial class Instance
    {
        public uint Id { get; set; }
        public uint Map { get; set; }
        public ulong Resettime { get; set; }
        public uint EncountersMask { get; set; }
        public byte Difficulty { get; set; }
        public string? Data { get; set; }
    }
}
