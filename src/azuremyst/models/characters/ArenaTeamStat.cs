using System;
using System.Collections.Generic;

namespace azuremyst.models.characters
{
    public partial class ArenaTeamStat
    {
        public uint Arenateamid { get; set; }
        public uint Rating { get; set; }
        public uint GamesWeek { get; set; }
        public uint WinsWeek { get; set; }
        public uint GamesSeason { get; set; }
        public uint WinsSeason { get; set; }
        public uint Rank { get; set; }
    }
}
