using System;
using System.Collections.Generic;

namespace azuremyst.models.characters
{
    /// <summary>
    /// Item System
    /// </summary>
    public partial class ItemLoot
    {
        public uint Guid { get; set; }
        public uint OwnerGuid { get; set; }
        public uint Itemid { get; set; }
        public uint Amount { get; set; }
        public uint Suffix { get; set; }
        public int Property { get; set; }
    }
}
