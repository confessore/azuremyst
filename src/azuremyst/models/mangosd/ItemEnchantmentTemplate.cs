using System;
using System.Collections.Generic;

namespace azuremyst.models.mangosd
{
    /// <summary>
    /// Item Random Enchantment System
    /// </summary>
    public partial class ItemEnchantmentTemplate
    {
        public uint Entry { get; set; }
        public uint Ench { get; set; }
        public float Chance { get; set; }
    }
}
