using System;
using System.Collections.Generic;

namespace azuremyst.models.mangosd
{
    public partial class DbscriptsOnCreatureMovement
    {
        public uint Id { get; set; }
        public uint Delay { get; set; }
        public uint Priority { get; set; }
        public uint Command { get; set; }
        public uint Datalong { get; set; }
        public uint Datalong2 { get; set; }
        public uint Datalong3 { get; set; }
        public uint BuddyEntry { get; set; }
        public uint SearchRadius { get; set; }
        public uint DataFlags { get; set; }
        public int Dataint { get; set; }
        public int Dataint2 { get; set; }
        public int Dataint3 { get; set; }
        public int Dataint4 { get; set; }
        public float Datafloat { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
        public float O { get; set; }
        public float Speed { get; set; }
        public uint ConditionId { get; set; }
        public string Comments { get; set; } = null!;
    }
}
