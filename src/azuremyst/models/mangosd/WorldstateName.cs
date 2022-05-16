using System;
using System.Collections.Generic;

namespace azuremyst.models.mangosd
{
    public partial class WorldstateName
    {
        /// <summary>
        /// Worldstate variable Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Name and use of variable
        /// </summary>
        public string Name { get; set; } = null!;
    }
}
