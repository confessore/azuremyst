using System;
using System.Collections.Generic;

namespace azuremyst.models.mangosd
{
    public partial class SpawnGroupEntry
    {
        /// <summary>
        /// Spawn Group ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Entry of creature or GO
        /// </summary>
        public int Entry { get; set; }
        /// <summary>
        /// Minimum count of entry in a group before random
        /// </summary>
        public int MinCount { get; set; }
        /// <summary>
        /// Maximum total count of entry in a group
        /// </summary>
        public int MaxCount { get; set; }
        /// <summary>
        /// Chance for entry to be selected
        /// </summary>
        public int Chance { get; set; }
    }
}
