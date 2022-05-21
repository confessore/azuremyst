namespace azuremyst.models.characters
{
    /// <summary>
    /// Guild System
    /// </summary>
    public partial class Guild
    {
        public uint Guildid { get; set; }
        public string Name { get; set; } = null!;
        public uint Leaderguid { get; set; }
        public int EmblemStyle { get; set; }
        public int EmblemColor { get; set; }
        public int BorderStyle { get; set; }
        public int BorderColor { get; set; }
        public int BackgroundColor { get; set; }
        public string Info { get; set; } = null!;
        public string Motd { get; set; } = null!;
        public ulong Createdate { get; set; }
        public ulong BankMoney { get; set; }
    }
}
