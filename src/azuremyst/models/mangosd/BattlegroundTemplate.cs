namespace azuremyst.models.mangosd
{
    public partial class BattlegroundTemplate
    {
        public uint Id { get; set; }
        public ushort MinPlayersPerTeam { get; set; }
        public ushort MaxPlayersPerTeam { get; set; }
        public byte MinLvl { get; set; }
        public byte MaxLvl { get; set; }
        public uint AllianceStartLoc { get; set; }
        public uint HordeStartLoc { get; set; }
        public float StartMaxDist { get; set; }
    }
}
