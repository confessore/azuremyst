using System;
using System.Collections.Generic;

namespace azuremyst.models.mangosd
{
    /// <summary>
    /// Creature System (Spells used by creature)
    /// </summary>
    public partial class CreatureTemplateSpell
    {
        public uint Entry { get; set; }
        /// <summary>
        /// Id of set of spells
        /// </summary>
        public uint SetId { get; set; }
        public uint Spell1 { get; set; }
        public uint Spell2 { get; set; }
        public uint Spell3 { get; set; }
        public uint Spell4 { get; set; }
        public uint Spell5 { get; set; }
        public uint Spell6 { get; set; }
        public uint Spell7 { get; set; }
        public uint Spell8 { get; set; }
        public uint Spell9 { get; set; }
        public uint Spell10 { get; set; }
    }
}
