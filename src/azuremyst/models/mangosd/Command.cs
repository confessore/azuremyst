namespace azuremyst.models.mangosd
{
    /// <summary>
    /// Chat System
    /// </summary>
    public partial class Command
    {
        public string Name { get; set; } = null!;
        public byte Security { get; set; }
        public string? Help { get; set; }
    }
}
