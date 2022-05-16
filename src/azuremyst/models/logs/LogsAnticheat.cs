using System;
using System.Collections.Generic;

namespace azuremyst.models.logs
{
    public partial class LogsAnticheat
    {
        public uint Id { get; set; }
        public DateTime? Time { get; set; }
        public uint Realm { get; set; }
        public uint Account { get; set; }
        public string Ip { get; set; } = null!;
        public uint Fingerprint { get; set; }
        public uint? ActionMask { get; set; }
        public string Player { get; set; } = null!;
        public string Info { get; set; } = null!;
    }
}
