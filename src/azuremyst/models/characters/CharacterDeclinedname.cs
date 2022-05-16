using System;
using System.Collections.Generic;

namespace azuremyst.models.characters
{
    public partial class CharacterDeclinedname
    {
        /// <summary>
        /// Global Unique Identifier
        /// </summary>
        public uint Guid { get; set; }
        public string Genitive { get; set; } = null!;
        public string Dative { get; set; } = null!;
        public string Accusative { get; set; } = null!;
        public string Instrumental { get; set; } = null!;
        public string Prepositional { get; set; } = null!;
    }
}
