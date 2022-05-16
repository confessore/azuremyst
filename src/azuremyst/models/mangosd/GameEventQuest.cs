using System;
using System.Collections.Generic;

namespace azuremyst.models.mangosd
{
    /// <summary>
    /// Game event system
    /// </summary>
    public partial class GameEventQuest
    {
        /// <summary>
        /// entry from quest_template
        /// </summary>
        public uint Quest { get; set; }
        /// <summary>
        /// entry from game_event
        /// </summary>
        public ushort Event { get; set; }
    }
}
