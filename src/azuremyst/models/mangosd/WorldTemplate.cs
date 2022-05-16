using System;
using System.Collections.Generic;

namespace azuremyst.models.mangosd
{
    public partial class WorldTemplate
    {
        public ushort Map { get; set; }
        public string ScriptName { get; set; } = null!;
    }
}
