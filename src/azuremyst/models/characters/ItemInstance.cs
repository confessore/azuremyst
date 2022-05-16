using System;
using System.Collections.Generic;

namespace azuremyst.models.characters
{
    /// <summary>
    /// Item System
    /// </summary>
    public partial class ItemInstance
    {
        public uint Guid { get; set; }
        public uint OwnerGuid { get; set; }
        public uint ItemEntry { get; set; }
        public uint CreatorGuid { get; set; }
        public uint GiftCreatorGuid { get; set; }
        public uint Count { get; set; }
        public uint Duration { get; set; }
        public string Charges { get; set; } = null!;
        public uint Flags { get; set; }
        public string Enchantments { get; set; } = null!;
        public short RandomPropertyId { get; set; }
        public uint Durability { get; set; }
        public uint ItemTextId { get; set; }
    }
}
