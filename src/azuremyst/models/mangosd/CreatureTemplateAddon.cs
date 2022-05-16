using System;
using System.Collections.Generic;

namespace azuremyst.models.mangosd
{
    public partial class CreatureTemplateAddon
    {
        public uint Entry { get; set; }
        public uint Mount { get; set; }
        public uint Bytes1 { get; set; }
        public byte B20Sheath { get; set; }
        public byte B21Flags { get; set; }
        public uint Emote { get; set; }
        public uint Moveflags { get; set; }
        public string? Auras { get; set; }
    }
}
