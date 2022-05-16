using System;
using System.Collections.Generic;

namespace azuremyst.models.characters
{
    public partial class PvpstatsBattleground
    {
        public ulong Id { get; set; }
        public sbyte WinnerTeam { get; set; }
        public byte BracketId { get; set; }
        public byte Type { get; set; }
        public DateTime Date { get; set; }
    }
}
