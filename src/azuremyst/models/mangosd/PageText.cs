namespace azuremyst.models.mangosd
{
    /// <summary>
    /// Item System
    /// </summary>
    public partial class PageText
    {
        public uint Entry { get; set; }
        public string Text { get; set; } = null!;
        public uint NextPage { get; set; }
    }
}
