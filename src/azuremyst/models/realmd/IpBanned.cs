using System;
using System.Collections.Generic;

namespace azuremyst.models.realmd
{
    /// <summary>
    /// Banned IPs
    /// </summary>
    public partial class IpBanned
    {
        public string Ip { get; set; } = null!;
        public long BannedAt { get; set; }
        public long ExpiresAt { get; set; }
        public string BannedBy { get; set; } = null!;
        public string Reason { get; set; } = null!;
    }
}
