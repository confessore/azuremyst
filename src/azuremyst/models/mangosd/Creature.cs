using System;
using System.Collections.Generic;

namespace azuremyst.models.mangosd
{
    /// <summary>
    /// Creature System
    /// </summary>
    public partial class Creature
    {
        /// <summary>
        /// Global Unique Identifier
        /// </summary>
        public uint Guid { get; set; }
        /// <summary>
        /// Creature Identifier
        /// </summary>
        public uint Id { get; set; }
        /// <summary>
        /// Map Identifier
        /// </summary>
        public ushort Map { get; set; }
        public byte SpawnMask { get; set; }
        public uint Modelid { get; set; }
        public int EquipmentId { get; set; }
        public float PositionX { get; set; }
        public float PositionY { get; set; }
        public float PositionZ { get; set; }
        public float Orientation { get; set; }
        /// <summary>
        /// Creature respawn time minimum
        /// </summary>
        public uint Spawntimesecsmin { get; set; }
        /// <summary>
        /// Creature respawn time maximum
        /// </summary>
        public uint Spawntimesecsmax { get; set; }
        public float Spawndist { get; set; }
        public uint Currentwaypoint { get; set; }
        public uint Curhealth { get; set; }
        public uint Curmana { get; set; }
        public byte DeathState { get; set; }
        public byte MovementType { get; set; }
    }
}
