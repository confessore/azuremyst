using System;
using System.Collections.Generic;

namespace azuremyst.models.mangosd
{
    public partial class NpcTrainer
    {
        public uint Entry { get; set; }
        public uint Spell { get; set; }
        public uint Spellcost { get; set; }
        public ushort Reqskill { get; set; }
        public ushort Reqskillvalue { get; set; }
        public byte Reqlevel { get; set; }
        public uint ConditionId { get; set; }
    }
}
