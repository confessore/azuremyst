namespace azuremyst.models.characters
{
    public partial class ArenaTeamMember
    {
        public uint Arenateamid { get; set; }
        public uint Guid { get; set; }
        public uint PlayedWeek { get; set; }
        public uint WonsWeek { get; set; }
        public uint PlayedSeason { get; set; }
        public uint WonsSeason { get; set; }
        public uint PersonalRating { get; set; }
    }
}
