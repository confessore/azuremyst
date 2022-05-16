using System;
using System.Collections.Generic;

namespace azuremyst.models.characters
{
    /// <summary>
    /// WorldState save system
    /// </summary>
    public partial class WorldState
    {
        /// <summary>
        /// Internal save ID
        /// </summary>
        public uint Id { get; set; }
        public string? Data { get; set; }
    }
}
