using System;
using System.Collections.Generic;

namespace azuremyst.models.mangosd
{
    public partial class GameobjectSpawnEntry
    {
        /// <summary>
        /// Gameobject table guid
        /// </summary>
        public uint Guid { get; set; }
        /// <summary>
        /// Gameobject Template entry
        /// </summary>
        public uint Entry { get; set; }
    }
}
