namespace azuremyst.models.mangosd
{
    public partial class WorldSafeLoc
    {
        public uint Id { get; set; }
        public uint Map { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public float O { get; set; }
        public string Name { get; set; } = null!;
    }
}
