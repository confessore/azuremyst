using System;
using System.Collections.Generic;

namespace azuremyst.models.mangosd
{
    /// <summary>
    /// Spell Additinal Data
    /// </summary>
    public partial class SpellChain
    {
        public int SpellId { get; set; }
        public int PrevSpell { get; set; }
        public int FirstSpell { get; set; }
        public sbyte Rank { get; set; }
        public int ReqSpell { get; set; }
    }
}
