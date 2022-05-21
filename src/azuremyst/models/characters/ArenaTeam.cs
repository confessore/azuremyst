namespace azuremyst.models.characters
{
    public partial class ArenaTeam
    {
        public uint Arenateamid { get; set; }
        public string Name { get; set; } = null!;
        public uint Captainguid { get; set; }
        public byte Type { get; set; }
        public uint BackgroundColor { get; set; }
        public uint EmblemStyle { get; set; }
        public uint EmblemColor { get; set; }
        public uint BorderStyle { get; set; }
        public uint BorderColor { get; set; }
    }
}
