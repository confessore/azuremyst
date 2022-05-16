using System;
using System.Collections.Generic;

namespace azuremyst.models.logs
{
    public partial class LogsSpamdetect
    {
        public uint Id { get; set; }
        public DateTime Time { get; set; }
        public uint Realm { get; set; }
        public int? AccountId { get; set; }
        public ulong? FromGuid { get; set; }
        public string FromIp { get; set; } = null!;
        public uint FromFingerprint { get; set; }
        public string Comment { get; set; } = null!;
    }
}
