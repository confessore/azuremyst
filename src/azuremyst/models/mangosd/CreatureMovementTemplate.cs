using System;
using System.Collections.Generic;

namespace azuremyst.models.mangosd
{
    /// <summary>
    /// Creature waypoint system
    /// </summary>
    public partial class CreatureMovementTemplate
    {
        /// <summary>
        /// Creature entry
        /// </summary>
        public uint Entry { get; set; }
        /// <summary>
        /// Path ID for entry
        /// </summary>
        public uint PathId { get; set; }
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
