using System;
using System.Collections.Generic;

namespace azuremyst.models.mangosd
{
    /// <summary>
    /// Fishing system
    /// </summary>
    public partial class SkillFishingBaseLevel
    {
        /// <summary>
        /// Area identifier
        /// </summary>
        public uint Entry { get; set; }
        /// <summary>
        /// Base skill level requirement
        /// </summary>
        public short Skill { get; set; }
    }
}
