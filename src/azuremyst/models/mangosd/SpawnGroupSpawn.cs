using System;
using System.Collections.Generic;

namespace azuremyst.models.mangosd
{
    public partial class SpawnGroupSpawn
    {
        /// <summary>
        /// Spawn Group ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Guid of creature or GO
        /// </summary>
        public int Guid { get; set; }
        /// <summary>
        /// 0 is the leader, -1 not part of the formation
        /// </summary>
        public sbyte SlotId { get; set; }
        /// <summary>
        /// Chance for a spawn to occur
        /// </summary>
        public uint Chance { get; set; }
    }
}
