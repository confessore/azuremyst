using System;
using System.Collections.Generic;

namespace azuremyst.models.mangosd
{
    /// <summary>
    /// GameObject battleground indexing system
    /// </summary>
    public partial class GameobjectBattleground
    {
        /// <summary>
        /// GameObject&apos;s GUID
        /// </summary>
        public uint Guid { get; set; }
        /// <summary>
        /// main event
        /// </summary>
        public byte Event1 { get; set; }
        /// <summary>
        /// sub event
        /// </summary>
        public byte Event2 { get; set; }
    }
}
