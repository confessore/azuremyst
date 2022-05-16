using System;
using System.Collections.Generic;

namespace azuremyst.models.mangosd
{
    public partial class GossipMenu
    {
        public ushort Entry { get; set; }
        public uint TextId { get; set; }
        /// <summary>
        /// script in `dbscripts_on_gossip` - will be executed on GossipHello
        /// </summary>
        public uint ScriptId { get; set; }
        public uint ConditionId { get; set; }
    }
}
