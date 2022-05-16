using System;
using System.Collections.Generic;

namespace azuremyst.models.characters
{
    /// <summary>
    /// Quest Group picked
    /// </summary>
    public partial class EventGroupChosen
    {
        public uint EventGroup { get; set; }
        public uint Entry { get; set; }
    }
}
