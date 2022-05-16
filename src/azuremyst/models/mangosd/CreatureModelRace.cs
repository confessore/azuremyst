using System;
using System.Collections.Generic;

namespace azuremyst.models.mangosd
{
    /// <summary>
    /// Model system
    /// </summary>
    public partial class CreatureModelRace
    {
        public uint Modelid { get; set; }
        public uint Racemask { get; set; }
        /// <summary>
        /// option 1, modelid_N from creature_template
        /// </summary>
        public uint CreatureEntry { get; set; }
        /// <summary>
        /// option 2, explicit modelid
        /// </summary>
        public uint ModelidRacial { get; set; }
    }
}
