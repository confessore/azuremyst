using System;
using System.Collections.Generic;

namespace azuremyst.models.mangosd
{
    public partial class PointsOfInterest
    {
        public uint Entry { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public uint Icon { get; set; }
        public uint Flags { get; set; }
        public uint Data { get; set; }
        public string IconName { get; set; } = null!;
    }
}
