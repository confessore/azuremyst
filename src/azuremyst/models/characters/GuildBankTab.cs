namespace azuremyst.models.characters
{
    public partial class GuildBankTab
    {
        public uint Guildid { get; set; }
        public byte TabId { get; set; }
        public string TabName { get; set; } = null!;
        public string TabIcon { get; set; } = null!;
        public string? TabText { get; set; }
    }
}
