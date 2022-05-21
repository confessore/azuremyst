namespace azuremyst.models.mangosd
{
    /// <summary>
    /// Custom Texts
    /// </summary>
    public partial class CustomText
    {
        public int Entry { get; set; }
        public string ContentDefault { get; set; } = null!;
        public string? ContentLoc1 { get; set; }
        public string? ContentLoc2 { get; set; }
        public string? ContentLoc3 { get; set; }
        public string? ContentLoc4 { get; set; }
        public string? ContentLoc5 { get; set; }
        public string? ContentLoc6 { get; set; }
        public string? ContentLoc7 { get; set; }
        public string? ContentLoc8 { get; set; }
        public uint Sound { get; set; }
        public byte Type { get; set; }
        public byte Language { get; set; }
        public ushort Emote { get; set; }
        public string? Comment { get; set; }
    }
}
