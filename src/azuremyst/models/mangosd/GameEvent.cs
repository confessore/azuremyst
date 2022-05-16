using System;
using System.Collections.Generic;

namespace azuremyst.models.mangosd
{
    public partial class GameEvent
    {
        /// <summary>
        /// Entry of the game event
        /// </summary>
        public uint Entry { get; set; }
        /// <summary>
        /// Delay in minutes between occurences of the event
        /// </summary>
        public ulong Occurence { get; set; }
        /// <summary>
        /// Length in minutes of the event
        /// </summary>
        public ulong Length { get; set; }
        /// <summary>
        /// Client side holiday id
        /// </summary>
        public uint Holiday { get; set; }
        /// <summary>
        /// This event starts only if defined LinkedTo event is started
        /// </summary>
        public uint LinkedTo { get; set; }
        /// <summary>
        /// Used for events that are randomized daily/weekly
        /// </summary>
        public uint EventGroup { get; set; }
        /// <summary>
        /// Description of the event displayed in console
        /// </summary>
        public string? Description { get; set; }
    }
}
