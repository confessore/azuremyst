using System;
using System.Collections.Generic;

namespace azuremyst.models.characters
{
    /// <summary>
    /// Player System
    /// </summary>
    public partial class CharacterInventory
    {
        /// <summary>
        /// Global Unique Identifier
        /// </summary>
        public uint Guid { get; set; }
        public uint Bag { get; set; }
        public byte Slot { get; set; }
        /// <summary>
        /// Item Global Unique Identifier
        /// </summary>
        public uint Item { get; set; }
        /// <summary>
        /// Item Identifier
        /// </summary>
        public uint ItemTemplate { get; set; }
    }
}
