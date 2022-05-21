namespace azuremyst.models.characters
{
    /// <summary>
    /// Guild System
    /// </summary>
    public partial class GuildRank
    {
        public uint Guildid { get; set; }
        public uint Rid { get; set; }
        public string Rname { get; set; } = null!;
        public uint Rights { get; set; }
        public uint BankMoneyPerDay { get; set; }
    }
}
