using System;
using System.Collections.Generic;

namespace azuremyst.models.mangosd
{
    public partial class SpellProcEvent
    {
        public uint Entry { get; set; }
        public byte SchoolMask { get; set; }
        public ushort SpellFamilyName { get; set; }
        public ulong SpellFamilyMask0 { get; set; }
        public ulong SpellFamilyMask1 { get; set; }
        public ulong SpellFamilyMask2 { get; set; }
        public uint ProcFlags { get; set; }
        public uint ProcEx { get; set; }
        public float PpmRate { get; set; }
        public float CustomChance { get; set; }
        public uint Cooldown { get; set; }
    }
}
