using System;
using System.Collections.Generic;

namespace azuremyst.models.mangosd
{
    /// <summary>
    /// Creature System
    /// </summary>
    public partial class CreatureInvolvedrelation
    {
        /// <summary>
        /// Identifier
        /// </summary>
        public uint Id { get; set; }
        /// <summary>
        /// Quest Identifier
        /// </summary>
        public uint Quest { get; set; }
    }
}
