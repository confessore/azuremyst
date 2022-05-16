using System;
using System.Collections.Generic;

namespace azuremyst.models.characters
{
    public partial class CharacterPetDeclinedname
    {
        public uint Id { get; set; }
        public uint Owner { get; set; }
        public string Genitive { get; set; } = null!;
        public string Dative { get; set; } = null!;
        public string Accusative { get; set; } = null!;
        public string Instrumental { get; set; } = null!;
        public string Prepositional { get; set; } = null!;
    }
}
