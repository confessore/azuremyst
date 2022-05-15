using System;
using System.Collections.Generic;

namespace azuremyst.models.realmd
{
    /// <summary>
    /// Realm System
    /// </summary>
    public partial class Realmlist
    {
        public uint Id { get; set; }
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public int Port { get; set; }
        public byte Icon { get; set; }
        /// <summary>
        /// Supported masks: 0x1 (invalid, not show in realm list), 0x2 (offline, set by mangosd), 0x4 (show version and build), 0x20 (new players), 0x40 (recommended)
        /// </summary>
        public byte Realmflags { get; set; }
        public byte Timezone { get; set; }
        public byte AllowedSecurityLevel { get; set; }
        public float Population { get; set; }
        public string Realmbuilds { get; set; } = null!;
    }
}
