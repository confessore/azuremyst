using System;
using System.Collections.Generic;

namespace azuremyst.models.mangosd
{
    /// <summary>
    /// Gameobject System
    /// </summary>
    public partial class Gameobject
    {
        /// <summary>
        /// Global Unique Identifier
        /// </summary>
        public uint Guid { get; set; }
        /// <summary>
        /// Gameobject Identifier
        /// </summary>
        public uint Id { get; set; }
        /// <summary>
        /// Map Identifier
        /// </summary>
        public ushort Map { get; set; }
        public byte SpawnMask { get; set; }
        public float PositionX { get; set; }
        public float PositionY { get; set; }
        public float PositionZ { get; set; }
        public float Orientation { get; set; }
        public float Rotation0 { get; set; }
        public float Rotation1 { get; set; }
        public float Rotation2 { get; set; }
        public float Rotation3 { get; set; }
        /// <summary>
        /// GameObject respawn time minimum
        /// </summary>
        public int Spawntimesecsmin { get; set; }
        /// <summary>
        /// Gameobject respawn time maximum
        /// </summary>
        public int Spawntimesecsmax { get; set; }
        public byte Animprogress { get; set; }
        public byte State { get; set; }
    }
}
