namespace azuremyst.models.mangosd
{
    public partial class WardenScan
    {
        public ushort Id { get; set; }
        public int? Type { get; set; }
        public string? Str { get; set; }
        public string? Data { get; set; }
        public int? Address { get; set; }
        public int? Length { get; set; }
        public string Result { get; set; } = null!;
        public ushort Flags { get; set; }
        public string Comment { get; set; } = null!;
    }
}
