using System;
using System.Collections.Generic;

namespace azuremyst.models.mangosd
{
    public partial class ReputationRewardRate
    {
        public uint Faction { get; set; }
        public float QuestRate { get; set; }
        public float CreatureRate { get; set; }
        public float SpellRate { get; set; }
    }
}
