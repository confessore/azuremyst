using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace azuremyst.models.logs
{
    /// <summary>
    /// Last applied sql update to DB
    /// </summary>
    public partial class LogsDbVersion
    {
        public ulong? RequiredS243301LogsAnticheat { get; set; }
    }
}
