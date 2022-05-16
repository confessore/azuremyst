using System;
using System.Collections.Generic;

namespace azuremyst.models.characters
{
    /// <summary>
    /// Variable Saves
    /// </summary>
    public partial class SavedVariable
    {
        public ulong NextArenaPointDistributionTime { get; set; }
        public ulong NextDailyQuestResetTime { get; set; }
        public ulong NextWeeklyQuestResetTime { get; set; }
        public ulong NextMonthlyQuestResetTime { get; set; }
        public uint CleaningFlags { get; set; }
    }
}
