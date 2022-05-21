﻿namespace azuremyst.models.mangosd
{
    /// <summary>
    /// Skill Discovery System
    /// </summary>
    public partial class SkillDiscoveryTemplate
    {
        /// <summary>
        /// SpellId of the discoverable spell
        /// </summary>
        public uint SpellId { get; set; }
        /// <summary>
        /// spell requirement
        /// </summary>
        public uint ReqSpell { get; set; }
        /// <summary>
        /// chance to discover
        /// </summary>
        public float Chance { get; set; }
    }
}
