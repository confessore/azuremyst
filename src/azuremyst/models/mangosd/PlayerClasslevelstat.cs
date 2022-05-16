using System;
using System.Collections.Generic;

namespace azuremyst.models.mangosd
{
    /// <summary>
    /// Stores levels stats.
    /// </summary>
    public partial class PlayerClasslevelstat
    {
        public byte Class { get; set; }
        public byte Level { get; set; }
        public ushort Basehp { get; set; }
        public ushort Basemana { get; set; }
    }
}
