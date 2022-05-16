using System;
using System.Collections.Generic;

namespace azuremyst.models.characters
{
    public partial class CharacterInstance
    {
        public uint Guid { get; set; }
        public uint Instance { get; set; }
        public byte Permanent { get; set; }
    }
}
