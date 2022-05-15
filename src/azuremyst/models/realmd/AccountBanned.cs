using System;
using System.Collections.Generic;

namespace azuremyst.models.realmd
{
    /// <summary>
    /// Ban List
    /// </summary>
    public partial class AccountBanned
    {
        public int Id { get; set; }
        /// <summary>
        /// Account id
        /// </summary>
        public int AccountId { get; set; }
        public long BannedAt { get; set; }
        public long ExpiresAt { get; set; }
        public string BannedBy { get; set; } = null!;
        public long UnbannedAt { get; set; }
        public string? UnbannedBy { get; set; }
        public string Reason { get; set; } = null!;
        public sbyte Active { get; set; }
    }
}
