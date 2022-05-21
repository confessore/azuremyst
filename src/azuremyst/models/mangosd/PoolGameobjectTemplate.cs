namespace azuremyst.models.mangosd
{
    public partial class PoolGameobjectTemplate
    {
        public uint Id { get; set; }
        public uint PoolEntry { get; set; }
        public float Chance { get; set; }
        public string Description { get; set; } = null!;
    }
}
