using System;
using System.Collections.Generic;

namespace azuremyst.models.mangosd
{
    /// <summary>
    /// DBScript system
    /// </summary>
    public partial class DbscriptRandomTemplate
    {
        /// <summary>
        /// Id of template
        /// </summary>
        public uint Id { get; set; }
        /// <summary>
        /// Type of template
        /// </summary>
        public uint Type { get; set; }
        /// <summary>
        /// Id of chanced element
        /// </summary>
        public int TargetId { get; set; }
        /// <summary>
        /// Chance for element to occur in %
        /// </summary>
        public int Chance { get; set; }
        public string? Comments { get; set; }
    }
}
