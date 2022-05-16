using System;
using System.Collections.Generic;

namespace azuremyst.models.characters
{
    /// <summary>
    /// Persistent Playerbot settings per alt
    /// </summary>
    public partial class PlayerbotSavedDatum
    {
        public uint Guid { get; set; }
        public byte CombatOrder { get; set; }
        public uint PrimaryTarget { get; set; }
        public uint SecondaryTarget { get; set; }
        public string Pname { get; set; } = null!;
        public string Sname { get; set; } = null!;
        public uint CombatDelay { get; set; }
        public uint AutoFollow { get; set; }
        public bool Autoequip { get; set; }
    }
}
