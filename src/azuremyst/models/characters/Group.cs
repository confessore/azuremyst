using System;
using System.Collections.Generic;

namespace azuremyst.models.characters
{
    /// <summary>
    /// Groups
    /// </summary>
    public partial class Group
    {
        public uint GroupId { get; set; }
        public uint LeaderGuid { get; set; }
        public uint MainTank { get; set; }
        public uint MainAssistant { get; set; }
        public byte LootMethod { get; set; }
        public uint LooterGuid { get; set; }
        public byte LootThreshold { get; set; }
        public uint Icon1 { get; set; }
        public uint Icon2 { get; set; }
        public uint Icon3 { get; set; }
        public uint Icon4 { get; set; }
        public uint Icon5 { get; set; }
        public uint Icon6 { get; set; }
        public uint Icon7 { get; set; }
        public uint Icon8 { get; set; }
        public byte IsRaid { get; set; }
        public byte Difficulty { get; set; }
    }
}
