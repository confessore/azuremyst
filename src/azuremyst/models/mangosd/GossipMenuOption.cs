using System;
using System.Collections.Generic;

namespace azuremyst.models.mangosd
{
    public partial class GossipMenuOption
    {
        public ushort MenuId { get; set; }
        public ushort Id { get; set; }
        public uint OptionIcon { get; set; }
        public string? OptionText { get; set; }
        public int OptionBroadcastText { get; set; }
        public byte OptionId { get; set; }
        public uint NpcOptionNpcflag { get; set; }
        public int ActionMenuId { get; set; }
        public uint ActionPoiId { get; set; }
        public uint ActionScriptId { get; set; }
        public byte BoxCoded { get; set; }
        public uint BoxMoney { get; set; }
        public string? BoxText { get; set; }
        public int BoxBroadcastText { get; set; }
        public uint ConditionId { get; set; }
    }
}
