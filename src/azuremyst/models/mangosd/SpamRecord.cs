using System;
using System.Collections.Generic;

namespace azuremyst.models.mangosd
{
    /// <summary>
    /// REGEX Spam records
    /// </summary>
    public partial class SpamRecord
    {
        public int Id { get; set; }
        public string Record { get; set; } = null!;
    }
}
