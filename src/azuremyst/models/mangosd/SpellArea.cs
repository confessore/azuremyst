using System;
using System.Collections.Generic;

namespace azuremyst.models.mangosd
{
    public partial class SpellArea
    {
        public uint Spell { get; set; }
        public uint Area { get; set; }
        public uint QuestStart { get; set; }
        public byte QuestStartActive { get; set; }
        public uint QuestEnd { get; set; }
        public uint ConditionId { get; set; }
        public int AuraSpell { get; set; }
        public uint Racemask { get; set; }
        public byte Gender { get; set; }
        public byte Autocast { get; set; }
    }
}
