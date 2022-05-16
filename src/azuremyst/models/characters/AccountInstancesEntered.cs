using System;
using System.Collections.Generic;

namespace azuremyst.models.characters
{
    /// <summary>
    /// Instance reset limit system
    /// </summary>
    public partial class AccountInstancesEntered
    {
        /// <summary>
        /// Player account
        /// </summary>
        public uint AccountId { get; set; }
        /// <summary>
        /// Time when instance was entered
        /// </summary>
        public long ExpireTime { get; set; }
        /// <summary>
        /// ID of instance entered
        /// </summary>
        public uint InstanceId { get; set; }
    }
}
