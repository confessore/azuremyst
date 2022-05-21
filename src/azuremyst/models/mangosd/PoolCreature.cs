namespace azuremyst.models.mangosd
{
    public partial class PoolCreature
    {
        public uint Guid { get; set; }
        public uint PoolEntry { get; set; }
        public float Chance { get; set; }
        public string Description { get; set; } = null!;
    }
}
