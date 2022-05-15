using System;
using System.Collections.Generic;

namespace azuremyst.models.realmd
{
    public partial class SystemFingerprintUsage
    {
        public uint Id { get; set; }
        public uint Fingerprint { get; set; }
        public uint Account { get; set; }
        public string Ip { get; set; } = null!;
        public uint Realm { get; set; }
        public DateTime? Time { get; set; }
        public string? Architecture { get; set; }
        public string? Cputype { get; set; }
        public uint? Activecpus { get; set; }
        public uint? Totalcpus { get; set; }
        public uint? Pagesize { get; set; }
    }
}
