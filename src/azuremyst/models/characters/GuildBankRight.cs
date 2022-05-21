namespace azuremyst.models.characters
{
    public partial class GuildBankRight
    {
        public uint Guildid { get; set; }
        public byte TabId { get; set; }
        public uint Rid { get; set; }
        public byte Gbright { get; set; }
        public uint SlotPerDay { get; set; }
    }
}
