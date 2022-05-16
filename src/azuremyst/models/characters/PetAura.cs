using System;
using System.Collections.Generic;

namespace azuremyst.models.characters
{
    /// <summary>
    /// Pet System
    /// </summary>
    public partial class PetAura
    {
        /// <summary>
        /// Global Unique Identifier
        /// </summary>
        public uint Guid { get; set; }
        /// <summary>
        /// Full Global Unique Identifier
        /// </summary>
        public ulong CasterGuid { get; set; }
        public uint ItemGuid { get; set; }
        public uint Spell { get; set; }
        public uint Stackcount { get; set; }
        public uint Remaincharges { get; set; }
        public int Basepoints0 { get; set; }
        public int Basepoints1 { get; set; }
        public int Basepoints2 { get; set; }
        public uint Periodictime0 { get; set; }
        public uint Periodictime1 { get; set; }
        public uint Periodictime2 { get; set; }
        public int Maxduration { get; set; }
        public int Remaintime { get; set; }
        public uint EffIndexMask { get; set; }
    }
}
