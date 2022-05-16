using System;
using System.Collections.Generic;

namespace azuremyst.models.mangosd
{
    public partial class CreatureSpellListEntry
    {
        /// <summary>
        /// List ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Description of usage
        /// </summary>
        public string Name { get; set; } = null!;
        /// <summary>
        /// Chance of support action per tick
        /// </summary>
        public int ChanceSupportAction { get; set; }
        /// <summary>
        /// Chance of ranged attack per tick
        /// </summary>
        public int ChanceRangedAttack { get; set; }
    }
}
