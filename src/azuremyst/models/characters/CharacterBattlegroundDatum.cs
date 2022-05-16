using System;
using System.Collections.Generic;

namespace azuremyst.models.characters
{
    /// <summary>
    /// Player System
    /// </summary>
    public partial class CharacterBattlegroundDatum
    {
        /// <summary>
        /// Global Unique Identifier
        /// </summary>
        public uint Guid { get; set; }
        public uint InstanceId { get; set; }
        public uint Team { get; set; }
        public float JoinX { get; set; }
        public float JoinY { get; set; }
        public float JoinZ { get; set; }
        public float JoinO { get; set; }
        public int JoinMap { get; set; }
    }
}
