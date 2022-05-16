using System;
using System.Collections.Generic;

namespace azuremyst.models.characters
{
    /// <summary>
    /// Guild System
    /// </summary>
    public partial class PetitionSign
    {
        public uint Ownerguid { get; set; }
        public uint Petitionguid { get; set; }
        public uint Playerguid { get; set; }
        public uint PlayerAccount { get; set; }
        public uint Type { get; set; }
    }
}
