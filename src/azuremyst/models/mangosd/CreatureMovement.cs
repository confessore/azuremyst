using System;
using System.Collections.Generic;

namespace azuremyst.models.mangosd
{
    /// <summary>
    /// Creature System
    /// </summary>
    public partial class CreatureMovement
    {
        /// <summary>
        /// Creature GUID
        /// </summary>
        public uint Id { get; set; }
        public uint Point { get; set; }
        public float PositionX { get; set; }
        public float PositionY { get; set; }
        public float PositionZ { get; set; }
        public float Orientation { get; set; }
        public uint WaitTime { get; set; }
        public uint ScriptId { get; set; }
        public string? Comment { get; set; }
    }
}
