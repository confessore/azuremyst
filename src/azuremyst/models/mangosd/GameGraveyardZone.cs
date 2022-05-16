using System;
using System.Collections.Generic;

namespace azuremyst.models.mangosd
{
    /// <summary>
    /// Graveyard link definitions
    /// </summary>
    public partial class GameGraveyardZone
    {
        public uint Id { get; set; }
        public uint GhostLoc { get; set; }
        public byte LinkKind { get; set; }
        public ushort Faction { get; set; }
    }
}
