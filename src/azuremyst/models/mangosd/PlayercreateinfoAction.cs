﻿using System;
using System.Collections.Generic;

namespace azuremyst.models.mangosd
{
    public partial class PlayercreateinfoAction
    {
        public byte Race { get; set; }
        public byte Class { get; set; }
        public ushort Button { get; set; }
        public uint Action { get; set; }
        public ushort Type { get; set; }
    }
}