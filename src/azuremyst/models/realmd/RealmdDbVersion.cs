using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace azuremyst.models.realmd
{
    /// <summary>
    /// Last applied sql update to DB
    /// </summary>
    public partial class RealmdDbVersion
    {
        public ulong? RequiredS243301RealmdAnticheat { get; set; }
    }
}
