using System;
using System.Collections.Generic;

namespace azuremyst.models.mangosd
{
    /// <summary>
    /// Creature Linking System
    /// </summary>
    public partial class CreatureLinking
    {
        /// <summary>
        /// creature.guid of the slave mob that is linked
        /// </summary>
        public uint Guid { get; set; }
        /// <summary>
        /// master to trigger events
        /// </summary>
        public uint MasterGuid { get; set; }
        /// <summary>
        /// flag - describing what should happen when
        /// </summary>
        public uint Flag { get; set; }
    }
}
