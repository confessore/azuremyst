using System;
using System.Collections.Generic;

namespace azuremyst.models.mangosd
{
    public partial class GameEventGameobject
    {
        public uint Guid { get; set; }
        /// <summary>
        /// Negatives value to remove during event and ignore pool grouping, positive value for spawn during event and if guid is part of pool then al pool memebers must be listed as part of event spawn.
        /// </summary>
        public short Event { get; set; }
    }
}
