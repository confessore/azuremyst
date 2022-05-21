namespace azuremyst.models.characters
{
    public partial class CharacterAccountDatum
    {
        public uint Guid { get; set; }
        public uint Type { get; set; }
        public ulong Time { get; set; }
        public byte[] Data { get; set; } = null!;
    }
}
