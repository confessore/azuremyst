using System;
using System.Collections.Generic;

namespace azuremyst.models.mangosd
{
    /// <summary>
    /// Spell System
    /// </summary>
    public partial class SpellScriptTarget
    {
        public uint Entry { get; set; }
        public byte Type { get; set; }
        public uint TargetEntry { get; set; }
        public uint InverseEffectMask { get; set; }
    }
}
