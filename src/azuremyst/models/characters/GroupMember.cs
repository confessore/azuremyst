using System;
using System.Collections.Generic;

namespace azuremyst.models.characters
{
    /// <summary>
    /// Groups
    /// </summary>
    public partial class GroupMember
    {
        public uint GroupId { get; set; }
        public uint MemberGuid { get; set; }
        public byte Assistant { get; set; }
        public ushort Subgroup { get; set; }
    }
}
