namespace azuremyst.models.realmd
{
    /// <summary>
    /// Account System
    /// </summary>
    public partial class Account
    {
        /// <summary>
        /// Identifier
        /// </summary>
        public uint Id { get; set; }
        public string Username { get; set; } = null!;
        public byte Gmlevel { get; set; }
        public string? Sessionkey { get; set; }
        public string? V { get; set; }
        public string? S { get; set; }
        public string? Email { get; set; }
        public DateTime Joindate { get; set; }
        public string LockedIp { get; set; } = null!;
        public uint FailedLogins { get; set; }
        public byte Locked { get; set; }
        public string? LastModule { get; set; }
        public uint ModuleDay { get; set; }
        public uint ActiveRealmId { get; set; }
        public byte Expansion { get; set; }
        public ulong Mutetime { get; set; }
        public string Locale { get; set; } = null!;
        public string Os { get; set; } = null!;
        public string? Token { get; set; }
        public uint Flags { get; set; }
    }
}
