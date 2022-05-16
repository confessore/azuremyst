using System;
using System.Collections.Generic;

namespace azuremyst.models.mangosd
{
    /// <summary>
    /// Quest System
    /// </summary>
    public partial class QuestTemplate
    {
        public uint Entry { get; set; }
        public byte Method { get; set; }
        public short ZoneOrSort { get; set; }
        public byte MinLevel { get; set; }
        public byte MaxLevel { get; set; }
        public short QuestLevel { get; set; }
        public ushort Type { get; set; }
        public ushort RequiredClasses { get; set; }
        public ushort RequiredRaces { get; set; }
        public ushort RequiredSkill { get; set; }
        public ushort RequiredSkillValue { get; set; }
        public uint RequiredCondition { get; set; }
        public ushort RepObjectiveFaction { get; set; }
        public int RepObjectiveValue { get; set; }
        public ushort RequiredMinRepFaction { get; set; }
        public int RequiredMinRepValue { get; set; }
        public ushort RequiredMaxRepFaction { get; set; }
        public int RequiredMaxRepValue { get; set; }
        public byte SuggestedPlayers { get; set; }
        public uint LimitTime { get; set; }
        public ushort QuestFlags { get; set; }
        public byte SpecialFlags { get; set; }
        public byte CharTitleId { get; set; }
        public int PrevQuestId { get; set; }
        public int NextQuestId { get; set; }
        public int ExclusiveGroup { get; set; }
        public uint BreadcrumbForQuestId { get; set; }
        public uint NextQuestInChain { get; set; }
        public uint SrcItemId { get; set; }
        public byte SrcItemCount { get; set; }
        public uint SrcSpell { get; set; }
        public string? Title { get; set; }
        public string? Details { get; set; }
        public string? Objectives { get; set; }
        public string? OfferRewardText { get; set; }
        public string? RequestItemsText { get; set; }
        public string? EndText { get; set; }
        public string? ObjectiveText1 { get; set; }
        public string? ObjectiveText2 { get; set; }
        public string? ObjectiveText3 { get; set; }
        public string? ObjectiveText4 { get; set; }
        public uint ReqItemId1 { get; set; }
        public uint ReqItemId2 { get; set; }
        public uint ReqItemId3 { get; set; }
        public uint ReqItemId4 { get; set; }
        public ushort ReqItemCount1 { get; set; }
        public ushort ReqItemCount2 { get; set; }
        public ushort ReqItemCount3 { get; set; }
        public ushort ReqItemCount4 { get; set; }
        public uint ReqSourceId1 { get; set; }
        public uint ReqSourceId2 { get; set; }
        public uint ReqSourceId3 { get; set; }
        public uint ReqSourceId4 { get; set; }
        public ushort ReqSourceCount1 { get; set; }
        public ushort ReqSourceCount2 { get; set; }
        public ushort ReqSourceCount3 { get; set; }
        public ushort ReqSourceCount4 { get; set; }
        public int ReqCreatureOrGoid1 { get; set; }
        public int ReqCreatureOrGoid2 { get; set; }
        public int ReqCreatureOrGoid3 { get; set; }
        public int ReqCreatureOrGoid4 { get; set; }
        public ushort ReqCreatureOrGocount1 { get; set; }
        public ushort ReqCreatureOrGocount2 { get; set; }
        public ushort ReqCreatureOrGocount3 { get; set; }
        public ushort ReqCreatureOrGocount4 { get; set; }
        public uint ReqSpellCast1 { get; set; }
        public uint ReqSpellCast2 { get; set; }
        public uint ReqSpellCast3 { get; set; }
        public uint ReqSpellCast4 { get; set; }
        public uint RewChoiceItemId1 { get; set; }
        public uint RewChoiceItemId2 { get; set; }
        public uint RewChoiceItemId3 { get; set; }
        public uint RewChoiceItemId4 { get; set; }
        public uint RewChoiceItemId5 { get; set; }
        public uint RewChoiceItemId6 { get; set; }
        public ushort RewChoiceItemCount1 { get; set; }
        public ushort RewChoiceItemCount2 { get; set; }
        public ushort RewChoiceItemCount3 { get; set; }
        public ushort RewChoiceItemCount4 { get; set; }
        public ushort RewChoiceItemCount5 { get; set; }
        public ushort RewChoiceItemCount6 { get; set; }
        public uint RewItemId1 { get; set; }
        public uint RewItemId2 { get; set; }
        public uint RewItemId3 { get; set; }
        public uint RewItemId4 { get; set; }
        public ushort RewItemCount1 { get; set; }
        public ushort RewItemCount2 { get; set; }
        public ushort RewItemCount3 { get; set; }
        public ushort RewItemCount4 { get; set; }
        /// <summary>
        /// faction id from Faction.dbc in this case
        /// </summary>
        public ushort RewRepFaction1 { get; set; }
        /// <summary>
        /// faction id from Faction.dbc in this case
        /// </summary>
        public ushort RewRepFaction2 { get; set; }
        /// <summary>
        /// faction id from Faction.dbc in this case
        /// </summary>
        public ushort RewRepFaction3 { get; set; }
        /// <summary>
        /// faction id from Faction.dbc in this case
        /// </summary>
        public ushort RewRepFaction4 { get; set; }
        /// <summary>
        /// faction id from Faction.dbc in this case
        /// </summary>
        public ushort RewRepFaction5 { get; set; }
        public int RewRepValue1 { get; set; }
        public int RewRepValue2 { get; set; }
        public int RewRepValue3 { get; set; }
        public int RewRepValue4 { get; set; }
        public int RewRepValue5 { get; set; }
        public int RewMaxRepValue1 { get; set; }
        public int RewMaxRepValue2 { get; set; }
        public int RewMaxRepValue3 { get; set; }
        public int RewMaxRepValue4 { get; set; }
        public int RewMaxRepValue5 { get; set; }
        public uint RewHonorableKills { get; set; }
        public int RewOrReqMoney { get; set; }
        public uint RewMoneyMaxLevel { get; set; }
        public uint RewSpell { get; set; }
        public uint RewSpellCast { get; set; }
        public uint RewMailTemplateId { get; set; }
        public uint RewMailDelaySecs { get; set; }
        public ushort PointMapId { get; set; }
        public float PointX { get; set; }
        public float PointY { get; set; }
        public uint PointOpt { get; set; }
        public ushort DetailsEmote1 { get; set; }
        public ushort DetailsEmote2 { get; set; }
        public ushort DetailsEmote3 { get; set; }
        public ushort DetailsEmote4 { get; set; }
        public uint DetailsEmoteDelay1 { get; set; }
        public uint DetailsEmoteDelay2 { get; set; }
        public uint DetailsEmoteDelay3 { get; set; }
        public uint DetailsEmoteDelay4 { get; set; }
        public ushort IncompleteEmote { get; set; }
        public ushort CompleteEmote { get; set; }
        public ushort OfferRewardEmote1 { get; set; }
        public ushort OfferRewardEmote2 { get; set; }
        public ushort OfferRewardEmote3 { get; set; }
        public ushort OfferRewardEmote4 { get; set; }
        public uint OfferRewardEmoteDelay1 { get; set; }
        public uint OfferRewardEmoteDelay2 { get; set; }
        public uint OfferRewardEmoteDelay3 { get; set; }
        public uint OfferRewardEmoteDelay4 { get; set; }
        public uint StartScript { get; set; }
        public uint CompleteScript { get; set; }
    }
}
