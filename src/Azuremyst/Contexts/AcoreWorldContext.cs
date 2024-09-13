using Azuremyst.Models.Acore.World;
using Microsoft.EntityFrameworkCore;

namespace Azuremyst.Contexts;

public partial class AcoreWorldContext : DbContext
{
    public AcoreWorldContext() { }

    public AcoreWorldContext(DbContextOptions<AcoreWorldContext> options)
        : base(options) { }

    public virtual DbSet<AchievementCategoryDbc> AchievementCategoryDbcs { get; set; }

    public virtual DbSet<AchievementCriteriaDatum> AchievementCriteriaData { get; set; }

    public virtual DbSet<AchievementCriteriaDbc> AchievementCriteriaDbcs { get; set; }

    public virtual DbSet<AchievementDbc> AchievementDbcs { get; set; }

    public virtual DbSet<AchievementReward> AchievementRewards { get; set; }

    public virtual DbSet<AchievementRewardLocale> AchievementRewardLocales { get; set; }

    public virtual DbSet<AcoreString> AcoreStrings { get; set; }

    public virtual DbSet<AreagroupDbc> AreagroupDbcs { get; set; }

    public virtual DbSet<AreapoiDbc> AreapoiDbcs { get; set; }

    public virtual DbSet<AreatableDbc> AreatableDbcs { get; set; }

    public virtual DbSet<Areatrigger> Areatriggers { get; set; }

    public virtual DbSet<AreatriggerInvolvedrelation> AreatriggerInvolvedrelations { get; set; }

    public virtual DbSet<AreatriggerScript> AreatriggerScripts { get; set; }

    public virtual DbSet<AreatriggerTavern> AreatriggerTaverns { get; set; }

    public virtual DbSet<AreatriggerTeleport> AreatriggerTeleports { get; set; }

    public virtual DbSet<AuctionhouseDbc> AuctionhouseDbcs { get; set; }

    public virtual DbSet<BankbagslotpricesDbc> BankbagslotpricesDbcs { get; set; }

    public virtual DbSet<BarbershopstyleDbc> BarbershopstyleDbcs { get; set; }

    public virtual DbSet<BattlegroundTemplate> BattlegroundTemplates { get; set; }

    public virtual DbSet<BattlemasterEntry> BattlemasterEntries { get; set; }

    public virtual DbSet<BattlemasterlistDbc> BattlemasterlistDbcs { get; set; }

    public virtual DbSet<BroadcastText> BroadcastTexts { get; set; }

    public virtual DbSet<BroadcastTextLocale> BroadcastTextLocales { get; set; }

    public virtual DbSet<CharstartoutfitDbc> CharstartoutfitDbcs { get; set; }

    public virtual DbSet<ChartitlesDbc> ChartitlesDbcs { get; set; }

    public virtual DbSet<ChatchannelsDbc> ChatchannelsDbcs { get; set; }

    public virtual DbSet<ChrclassesDbc> ChrclassesDbcs { get; set; }

    public virtual DbSet<ChrracesDbc> ChrracesDbcs { get; set; }

    public virtual DbSet<CinematiccameraDbc> CinematiccameraDbcs { get; set; }

    public virtual DbSet<CinematicsequencesDbc> CinematicsequencesDbcs { get; set; }

    public virtual DbSet<Command> Commands { get; set; }

    public virtual DbSet<Condition> Conditions { get; set; }

    public virtual DbSet<Creature> Creatures { get; set; }

    public virtual DbSet<CreatureAddon> CreatureAddons { get; set; }

    public virtual DbSet<CreatureClasslevelstat> CreatureClasslevelstats { get; set; }

    public virtual DbSet<CreatureEquipTemplate> CreatureEquipTemplates { get; set; }

    public virtual DbSet<CreatureFormation> CreatureFormations { get; set; }

    public virtual DbSet<CreatureLootTemplate> CreatureLootTemplates { get; set; }

    public virtual DbSet<CreatureModelInfo> CreatureModelInfos { get; set; }

    public virtual DbSet<CreatureMovementOverride> CreatureMovementOverrides { get; set; }

    public virtual DbSet<CreatureOnkillReputation> CreatureOnkillReputations { get; set; }

    public virtual DbSet<CreatureQuestender> CreatureQuestenders { get; set; }

    public virtual DbSet<CreatureQuestitem> CreatureQuestitems { get; set; }

    public virtual DbSet<CreatureQueststarter> CreatureQueststarters { get; set; }

    public virtual DbSet<CreatureSummonGroup> CreatureSummonGroups { get; set; }

    public virtual DbSet<CreatureTemplate> CreatureTemplates { get; set; }

    public virtual DbSet<CreatureTemplateAddon> CreatureTemplateAddons { get; set; }

    public virtual DbSet<CreatureTemplateLocale> CreatureTemplateLocales { get; set; }

    public virtual DbSet<CreatureTemplateMovement> CreatureTemplateMovements { get; set; }

    public virtual DbSet<CreatureTemplateResistance> CreatureTemplateResistances { get; set; }

    public virtual DbSet<CreatureTemplateSpell> CreatureTemplateSpells { get; set; }

    public virtual DbSet<CreatureText> CreatureTexts { get; set; }

    public virtual DbSet<CreatureTextLocale> CreatureTextLocales { get; set; }

    public virtual DbSet<CreaturedisplayinfoDbc> CreaturedisplayinfoDbcs { get; set; }

    public virtual DbSet<CreaturedisplayinfoextraDbc> CreaturedisplayinfoextraDbcs { get; set; }

    public virtual DbSet<CreaturefamilyDbc> CreaturefamilyDbcs { get; set; }

    public virtual DbSet<CreaturemodeldataDbc> CreaturemodeldataDbcs { get; set; }

    public virtual DbSet<CreaturespelldataDbc> CreaturespelldataDbcs { get; set; }

    public virtual DbSet<CreaturetypeDbc> CreaturetypeDbcs { get; set; }

    public virtual DbSet<CurrencytypesDbc> CurrencytypesDbcs { get; set; }

    public virtual DbSet<DestructiblemodeldataDbc> DestructiblemodeldataDbcs { get; set; }

    public virtual DbSet<Disable> Disables { get; set; }

    public virtual DbSet<DisenchantLootTemplate> DisenchantLootTemplates { get; set; }

    public virtual DbSet<DungeonAccessRequirement> DungeonAccessRequirements { get; set; }

    public virtual DbSet<DungeonAccessTemplate> DungeonAccessTemplates { get; set; }

    public virtual DbSet<DungeonencounterDbc> DungeonencounterDbcs { get; set; }

    public virtual DbSet<DurabilitycostsDbc> DurabilitycostsDbcs { get; set; }

    public virtual DbSet<DurabilityqualityDbc> DurabilityqualityDbcs { get; set; }

    public virtual DbSet<EmotesDbc> EmotesDbcs { get; set; }

    public virtual DbSet<EmotestextDbc> EmotestextDbcs { get; set; }

    public virtual DbSet<EventScript> EventScripts { get; set; }

    public virtual DbSet<ExplorationBasexp> ExplorationBasexps { get; set; }

    public virtual DbSet<FactionDbc> FactionDbcs { get; set; }

    public virtual DbSet<FactiontemplateDbc> FactiontemplateDbcs { get; set; }

    public virtual DbSet<FishingLootTemplate> FishingLootTemplates { get; set; }

    public virtual DbSet<GameEvent> GameEvents { get; set; }

    public virtual DbSet<GameEventArenaSeason> GameEventArenaSeasons { get; set; }

    public virtual DbSet<GameEventBattlegroundHoliday> GameEventBattlegroundHolidays { get; set; }

    public virtual DbSet<GameEventCondition> GameEventConditions { get; set; }

    public virtual DbSet<GameEventCreature> GameEventCreatures { get; set; }

    public virtual DbSet<GameEventCreatureQuest> GameEventCreatureQuests { get; set; }

    public virtual DbSet<GameEventGameobject> GameEventGameobjects { get; set; }

    public virtual DbSet<GameEventGameobjectQuest> GameEventGameobjectQuests { get; set; }

    public virtual DbSet<GameEventModelEquip> GameEventModelEquips { get; set; }

    public virtual DbSet<GameEventNpcVendor> GameEventNpcVendors { get; set; }

    public virtual DbSet<GameEventNpcflag> GameEventNpcflags { get; set; }

    public virtual DbSet<GameEventPool> GameEventPools { get; set; }

    public virtual DbSet<GameEventPrerequisite> GameEventPrerequisites { get; set; }

    public virtual DbSet<GameEventQuestCondition> GameEventQuestConditions { get; set; }

    public virtual DbSet<GameEventSeasonalQuestrelation> GameEventSeasonalQuestrelations { get; set; }

    public virtual DbSet<GameGraveyard> GameGraveyards { get; set; }

    public virtual DbSet<GameTele> GameTeles { get; set; }

    public virtual DbSet<GameWeather> GameWeathers { get; set; }

    public virtual DbSet<Gameobject> Gameobjects { get; set; }

    public virtual DbSet<GameobjectAddon> GameobjectAddons { get; set; }

    public virtual DbSet<GameobjectLootTemplate> GameobjectLootTemplates { get; set; }

    public virtual DbSet<GameobjectQuestender> GameobjectQuestenders { get; set; }

    public virtual DbSet<GameobjectQuestitem> GameobjectQuestitems { get; set; }

    public virtual DbSet<GameobjectQueststarter> GameobjectQueststarters { get; set; }

    public virtual DbSet<GameobjectTemplate> GameobjectTemplates { get; set; }

    public virtual DbSet<GameobjectTemplateAddon> GameobjectTemplateAddons { get; set; }

    public virtual DbSet<GameobjectTemplateLocale> GameobjectTemplateLocales { get; set; }

    public virtual DbSet<GameobjectartkitDbc> GameobjectartkitDbcs { get; set; }

    public virtual DbSet<GameobjectdisplayinfoDbc> GameobjectdisplayinfoDbcs { get; set; }

    public virtual DbSet<GempropertiesDbc> GempropertiesDbcs { get; set; }

    public virtual DbSet<GlyphpropertiesDbc> GlyphpropertiesDbcs { get; set; }

    public virtual DbSet<GlyphslotDbc> GlyphslotDbcs { get; set; }

    public virtual DbSet<GossipMenu> GossipMenus { get; set; }

    public virtual DbSet<GossipMenuOption> GossipMenuOptions { get; set; }

    public virtual DbSet<GossipMenuOptionLocale> GossipMenuOptionLocales { get; set; }

    public virtual DbSet<GraveyardZone> GraveyardZones { get; set; }

    public virtual DbSet<GtbarbershopcostbaseDbc> GtbarbershopcostbaseDbcs { get; set; }

    public virtual DbSet<GtchancetomeleecritDbc> GtchancetomeleecritDbcs { get; set; }

    public virtual DbSet<GtchancetomeleecritbaseDbc> GtchancetomeleecritbaseDbcs { get; set; }

    public virtual DbSet<GtchancetospellcritDbc> GtchancetospellcritDbcs { get; set; }

    public virtual DbSet<GtchancetospellcritbaseDbc> GtchancetospellcritbaseDbcs { get; set; }

    public virtual DbSet<GtcombatratingsDbc> GtcombatratingsDbcs { get; set; }

    public virtual DbSet<GtnpcmanacostscalerDbc> GtnpcmanacostscalerDbcs { get; set; }

    public virtual DbSet<GtoctclasscombatratingscalarDbc> GtoctclasscombatratingscalarDbcs { get; set; }

    public virtual DbSet<GtoctregenhpDbc> GtoctregenhpDbcs { get; set; }

    public virtual DbSet<GtregenhppersptDbc> GtregenhppersptDbcs { get; set; }

    public virtual DbSet<GtregenmppersptDbc> GtregenmppersptDbcs { get; set; }

    public virtual DbSet<HolidayDate> HolidayDates { get; set; }

    public virtual DbSet<HolidaysDbc> HolidaysDbcs { get; set; }

    public virtual DbSet<InstanceEncounter> InstanceEncounters { get; set; }

    public virtual DbSet<InstanceTemplate> InstanceTemplates { get; set; }

    public virtual DbSet<ItemDbc> ItemDbcs { get; set; }

    public virtual DbSet<ItemEnchantmentTemplate> ItemEnchantmentTemplates { get; set; }

    public virtual DbSet<ItemLootTemplate> ItemLootTemplates { get; set; }

    public virtual DbSet<ItemSetName> ItemSetNames { get; set; }

    public virtual DbSet<ItemSetNamesLocale> ItemSetNamesLocales { get; set; }

    public virtual DbSet<ItemTemplate> ItemTemplates { get; set; }

    public virtual DbSet<ItemTemplateLocale> ItemTemplateLocales { get; set; }

    public virtual DbSet<ItembagfamilyDbc> ItembagfamilyDbcs { get; set; }

    public virtual DbSet<ItemdisplayinfoDbc> ItemdisplayinfoDbcs { get; set; }

    public virtual DbSet<ItemextendedcostDbc> ItemextendedcostDbcs { get; set; }

    public virtual DbSet<ItemlimitcategoryDbc> ItemlimitcategoryDbcs { get; set; }

    public virtual DbSet<ItemrandompropertiesDbc> ItemrandompropertiesDbcs { get; set; }

    public virtual DbSet<ItemrandomsuffixDbc> ItemrandomsuffixDbcs { get; set; }

    public virtual DbSet<ItemsetDbc> ItemsetDbcs { get; set; }

    public virtual DbSet<LfgDungeonReward> LfgDungeonRewards { get; set; }

    public virtual DbSet<LfgDungeonTemplate> LfgDungeonTemplates { get; set; }

    public virtual DbSet<LfgdungeonsDbc> LfgdungeonsDbcs { get; set; }

    public virtual DbSet<LightDbc> LightDbcs { get; set; }

    public virtual DbSet<LinkedRespawn> LinkedRespawns { get; set; }

    public virtual DbSet<LiquidtypeDbc> LiquidtypeDbcs { get; set; }

    public virtual DbSet<LockDbc> LockDbcs { get; set; }

    public virtual DbSet<MailLevelReward> MailLevelRewards { get; set; }

    public virtual DbSet<MailLootTemplate> MailLootTemplates { get; set; }

    public virtual DbSet<MailtemplateDbc> MailtemplateDbcs { get; set; }

    public virtual DbSet<MapDbc> MapDbcs { get; set; }

    public virtual DbSet<MapdifficultyDbc> MapdifficultyDbcs { get; set; }

    public virtual DbSet<MillingLootTemplate> MillingLootTemplates { get; set; }

    public virtual DbSet<MovieDbc> MovieDbcs { get; set; }

    public virtual DbSet<NamesprofanityDbc> NamesprofanityDbcs { get; set; }

    public virtual DbSet<NamesreservedDbc> NamesreservedDbcs { get; set; }

    public virtual DbSet<NpcSpellclickSpell> NpcSpellclickSpells { get; set; }

    public virtual DbSet<NpcText> NpcTexts { get; set; }

    public virtual DbSet<NpcTextLocale> NpcTextLocales { get; set; }

    public virtual DbSet<NpcTrainer> NpcTrainers { get; set; }

    public virtual DbSet<NpcVendor> NpcVendors { get; set; }

    public virtual DbSet<OutdoorpvpTemplate> OutdoorpvpTemplates { get; set; }

    public virtual DbSet<OverridespelldataDbc> OverridespelldataDbcs { get; set; }

    public virtual DbSet<PageText> PageTexts { get; set; }

    public virtual DbSet<PageTextLocale> PageTextLocales { get; set; }

    public virtual DbSet<PetLevelstat> PetLevelstats { get; set; }

    public virtual DbSet<PetNameGeneration> PetNameGenerations { get; set; }

    public virtual DbSet<PetNameGenerationLocale> PetNameGenerationLocales { get; set; }

    public virtual DbSet<PickpocketingLootTemplate> PickpocketingLootTemplates { get; set; }

    public virtual DbSet<PlayerClassStat> PlayerClassStats { get; set; }

    public virtual DbSet<PlayerClasslevelstat> PlayerClasslevelstats { get; set; }

    public virtual DbSet<PlayerFactionchangeAchievement> PlayerFactionchangeAchievements { get; set; }

    public virtual DbSet<PlayerFactionchangeItem> PlayerFactionchangeItems { get; set; }

    public virtual DbSet<PlayerFactionchangeQuest> PlayerFactionchangeQuests { get; set; }

    public virtual DbSet<PlayerFactionchangeReputation> PlayerFactionchangeReputations { get; set; }

    public virtual DbSet<PlayerFactionchangeSpell> PlayerFactionchangeSpells { get; set; }

    public virtual DbSet<PlayerFactionchangeTitle> PlayerFactionchangeTitles { get; set; }

    public virtual DbSet<PlayerLootTemplate> PlayerLootTemplates { get; set; }

    public virtual DbSet<PlayerRaceStat> PlayerRaceStats { get; set; }

    public virtual DbSet<PlayerXpForLevel> PlayerXpForLevels { get; set; }

    public virtual DbSet<Playercreateinfo> Playercreateinfos { get; set; }

    public virtual DbSet<PlayercreateinfoAction> PlayercreateinfoActions { get; set; }

    public virtual DbSet<PlayercreateinfoCastSpell> PlayercreateinfoCastSpells { get; set; }

    public virtual DbSet<PlayercreateinfoItem> PlayercreateinfoItems { get; set; }

    public virtual DbSet<PlayercreateinfoSkill> PlayercreateinfoSkills { get; set; }

    public virtual DbSet<PlayercreateinfoSpellCustom> PlayercreateinfoSpellCustoms { get; set; }

    public virtual DbSet<PointsOfInterest> PointsOfInterests { get; set; }

    public virtual DbSet<PointsOfInterestLocale> PointsOfInterestLocales { get; set; }

    public virtual DbSet<PoolCreature> PoolCreatures { get; set; }

    public virtual DbSet<PoolGameobject> PoolGameobjects { get; set; }

    public virtual DbSet<PoolPool> PoolPools { get; set; }

    public virtual DbSet<PoolQuest> PoolQuests { get; set; }

    public virtual DbSet<PoolTemplate> PoolTemplates { get; set; }

    public virtual DbSet<PowerdisplayDbc> PowerdisplayDbcs { get; set; }

    public virtual DbSet<ProspectingLootTemplate> ProspectingLootTemplates { get; set; }

    public virtual DbSet<PvpdifficultyDbc> PvpdifficultyDbcs { get; set; }

    public virtual DbSet<QuestDetail> QuestDetails { get; set; }

    public virtual DbSet<QuestGreeting> QuestGreetings { get; set; }

    public virtual DbSet<QuestGreetingLocale> QuestGreetingLocales { get; set; }

    public virtual DbSet<QuestMailSender> QuestMailSenders { get; set; }

    public virtual DbSet<QuestMoneyReward> QuestMoneyRewards { get; set; }

    public virtual DbSet<QuestOfferReward> QuestOfferRewards { get; set; }

    public virtual DbSet<QuestOfferRewardLocale> QuestOfferRewardLocales { get; set; }

    public virtual DbSet<QuestPoi> QuestPois { get; set; }

    public virtual DbSet<QuestPoiPoint> QuestPoiPoints { get; set; }

    public virtual DbSet<QuestRequestItem> QuestRequestItems { get; set; }

    public virtual DbSet<QuestRequestItemsLocale> QuestRequestItemsLocales { get; set; }

    public virtual DbSet<QuestTemplate> QuestTemplates { get; set; }

    public virtual DbSet<QuestTemplateAddon> QuestTemplateAddons { get; set; }

    public virtual DbSet<QuestTemplateLocale> QuestTemplateLocales { get; set; }

    public virtual DbSet<QuestfactionrewardDbc> QuestfactionrewardDbcs { get; set; }

    public virtual DbSet<QuestsortDbc> QuestsortDbcs { get; set; }

    public virtual DbSet<QuestxpDbc> QuestxpDbcs { get; set; }

    public virtual DbSet<RandproppointsDbc> RandproppointsDbcs { get; set; }

    public virtual DbSet<ReferenceLootTemplate> ReferenceLootTemplates { get; set; }

    public virtual DbSet<ReputationRewardRate> ReputationRewardRates { get; set; }

    public virtual DbSet<ReputationSpilloverTemplate> ReputationSpilloverTemplates { get; set; }

    public virtual DbSet<ScalingstatdistributionDbc> ScalingstatdistributionDbcs { get; set; }

    public virtual DbSet<ScalingstatvaluesDbc> ScalingstatvaluesDbcs { get; set; }

    public virtual DbSet<ScriptWaypoint> ScriptWaypoints { get; set; }

    public virtual DbSet<SkillDiscoveryTemplate> SkillDiscoveryTemplates { get; set; }

    public virtual DbSet<SkillExtraItemTemplate> SkillExtraItemTemplates { get; set; }

    public virtual DbSet<SkillFishingBaseLevel> SkillFishingBaseLevels { get; set; }

    public virtual DbSet<SkillPerfectItemTemplate> SkillPerfectItemTemplates { get; set; }

    public virtual DbSet<SkilllineDbc> SkilllineDbcs { get; set; }

    public virtual DbSet<SkilllineabilityDbc> SkilllineabilityDbcs { get; set; }

    public virtual DbSet<SkillraceclassinfoDbc> SkillraceclassinfoDbcs { get; set; }

    public virtual DbSet<SkilltiersDbc> SkilltiersDbcs { get; set; }

    public virtual DbSet<SkinningLootTemplate> SkinningLootTemplates { get; set; }

    public virtual DbSet<SmartScript> SmartScripts { get; set; }

    public virtual DbSet<SoundentriesDbc> SoundentriesDbcs { get; set; }

    public virtual DbSet<SpellArea> SpellAreas { get; set; }

    public virtual DbSet<SpellBonusDatum> SpellBonusData { get; set; }

    public virtual DbSet<SpellCooldownOverride> SpellCooldownOverrides { get; set; }

    public virtual DbSet<SpellCustomAttr> SpellCustomAttrs { get; set; }

    public virtual DbSet<SpellDbc> SpellDbcs { get; set; }

    public virtual DbSet<SpellEnchantProcDatum> SpellEnchantProcData { get; set; }

    public virtual DbSet<SpellGroup> SpellGroups { get; set; }

    public virtual DbSet<SpellGroupStackRule> SpellGroupStackRules { get; set; }

    public virtual DbSet<SpellLinkedSpell> SpellLinkedSpells { get; set; }

    public virtual DbSet<SpellLootTemplate> SpellLootTemplates { get; set; }

    public virtual DbSet<SpellMixology> SpellMixologies { get; set; }

    public virtual DbSet<SpellPetAura> SpellPetAuras { get; set; }

    public virtual DbSet<SpellProc> SpellProcs { get; set; }

    public virtual DbSet<SpellProcEvent> SpellProcEvents { get; set; }

    public virtual DbSet<SpellRank> SpellRanks { get; set; }

    public virtual DbSet<SpellRequired> SpellRequireds { get; set; }

    public virtual DbSet<SpellScript> SpellScripts { get; set; }

    public virtual DbSet<SpellScriptName> SpellScriptNames { get; set; }

    public virtual DbSet<SpellTargetPosition> SpellTargetPositions { get; set; }

    public virtual DbSet<SpellThreat> SpellThreats { get; set; }

    public virtual DbSet<SpellcasttimesDbc> SpellcasttimesDbcs { get; set; }

    public virtual DbSet<SpellcategoryDbc> SpellcategoryDbcs { get; set; }

    public virtual DbSet<SpelldifficultyDbc> SpelldifficultyDbcs { get; set; }

    public virtual DbSet<SpelldurationDbc> SpelldurationDbcs { get; set; }

    public virtual DbSet<SpellfocusobjectDbc> SpellfocusobjectDbcs { get; set; }

    public virtual DbSet<SpellitemenchantmentDbc> SpellitemenchantmentDbcs { get; set; }

    public virtual DbSet<SpellitemenchantmentconditionDbc> SpellitemenchantmentconditionDbcs { get; set; }

    public virtual DbSet<SpellradiusDbc> SpellradiusDbcs { get; set; }

    public virtual DbSet<SpellrangeDbc> SpellrangeDbcs { get; set; }

    public virtual DbSet<SpellrunecostDbc> SpellrunecostDbcs { get; set; }

    public virtual DbSet<SpellshapeshiftformDbc> SpellshapeshiftformDbcs { get; set; }

    public virtual DbSet<SpellvisualDbc> SpellvisualDbcs { get; set; }

    public virtual DbSet<StableslotpricesDbc> StableslotpricesDbcs { get; set; }

    public virtual DbSet<SummonpropertiesDbc> SummonpropertiesDbcs { get; set; }

    public virtual DbSet<TalentDbc> TalentDbcs { get; set; }

    public virtual DbSet<TalenttabDbc> TalenttabDbcs { get; set; }

    public virtual DbSet<TaxinodesDbc> TaxinodesDbcs { get; set; }

    public virtual DbSet<TaxipathDbc> TaxipathDbcs { get; set; }

    public virtual DbSet<TaxipathnodeDbc> TaxipathnodeDbcs { get; set; }

    public virtual DbSet<TeamcontributionpointsDbc> TeamcontributionpointsDbcs { get; set; }

    public virtual DbSet<TotemcategoryDbc> TotemcategoryDbcs { get; set; }

    public virtual DbSet<Transport> Transports { get; set; }

    public virtual DbSet<TransportanimationDbc> TransportanimationDbcs { get; set; }

    public virtual DbSet<TransportrotationDbc> TransportrotationDbcs { get; set; }

    public virtual DbSet<Update> Updates { get; set; }

    public virtual DbSet<UpdatesInclude> UpdatesIncludes { get; set; }

    public virtual DbSet<VehicleAccessory> VehicleAccessories { get; set; }

    public virtual DbSet<VehicleDbc> VehicleDbcs { get; set; }

    public virtual DbSet<VehicleTemplateAccessory> VehicleTemplateAccessories { get; set; }

    public virtual DbSet<VehicleseatDbc> VehicleseatDbcs { get; set; }

    public virtual DbSet<Models.Acore.World.Version> Versions { get; set; }

    public virtual DbSet<WardenCheck> WardenChecks { get; set; }

    public virtual DbSet<Waypoint> Waypoints { get; set; }

    public virtual DbSet<WaypointDatum> WaypointData { get; set; }

    public virtual DbSet<WaypointScript> WaypointScripts { get; set; }

    public virtual DbSet<WmoareatableDbc> WmoareatableDbcs { get; set; }

    public virtual DbSet<WorldmapareaDbc> WorldmapareaDbcs { get; set; }

    public virtual DbSet<WorldmapoverlayDbc> WorldmapoverlayDbcs { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AchievementCategoryDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("achievement_category_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.NameLangDeDe).HasMaxLength(100).HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn).HasMaxLength(100).HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb).HasMaxLength(100).HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw).HasMaxLength(100).HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs).HasMaxLength(100).HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs).HasMaxLength(100).HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx).HasMaxLength(100).HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr).HasMaxLength(100).HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt).HasMaxLength(100).HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr).HasMaxLength(100).HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr).HasMaxLength(100).HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt).HasMaxLength(100).HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu).HasMaxLength(100).HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk).HasMaxLength(100).HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn).HasMaxLength(100).HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw).HasMaxLength(100).HasColumnName("Name_Lang_zhTW");
            entity.Property(e => e.UiOrder).HasColumnName("Ui_Order");
        });

        modelBuilder.Entity<AchievementCriteriaDatum>(entity =>
        {
            entity.HasKey(e => new { e.CriteriaId, e.Type }).HasName("PRIMARY");

            entity.ToTable("achievement_criteria_data", tb => tb.HasComment("Achievment system"));

            entity.Property(e => e.CriteriaId).HasColumnName("criteria_id");
            entity.Property(e => e.Type).HasColumnName("type");
            entity
                .Property(e => e.ScriptName)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.Value1).HasColumnName("value1");
            entity.Property(e => e.Value2).HasColumnName("value2");
        });

        modelBuilder.Entity<AchievementCriteriaDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("achievement_criteria_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AchievementId).HasColumnName("Achievement_Id");
            entity.Property(e => e.AssetId).HasColumnName("Asset_Id");
            entity
                .Property(e => e.DescriptionLangDeDe)
                .HasMaxLength(100)
                .HasColumnName("Description_Lang_deDE");
            entity
                .Property(e => e.DescriptionLangEnCn)
                .HasMaxLength(100)
                .HasColumnName("Description_Lang_enCN");
            entity
                .Property(e => e.DescriptionLangEnGb)
                .HasMaxLength(100)
                .HasColumnName("Description_Lang_enGB");
            entity
                .Property(e => e.DescriptionLangEnTw)
                .HasMaxLength(100)
                .HasColumnName("Description_Lang_enTW");
            entity
                .Property(e => e.DescriptionLangEnUs)
                .HasMaxLength(100)
                .HasColumnName("Description_Lang_enUS");
            entity
                .Property(e => e.DescriptionLangEsEs)
                .HasMaxLength(100)
                .HasColumnName("Description_Lang_esES");
            entity
                .Property(e => e.DescriptionLangEsMx)
                .HasMaxLength(100)
                .HasColumnName("Description_Lang_esMX");
            entity
                .Property(e => e.DescriptionLangFrFr)
                .HasMaxLength(100)
                .HasColumnName("Description_Lang_frFR");
            entity
                .Property(e => e.DescriptionLangItIt)
                .HasMaxLength(100)
                .HasColumnName("Description_Lang_itIT");
            entity
                .Property(e => e.DescriptionLangKoKr)
                .HasMaxLength(100)
                .HasColumnName("Description_Lang_koKR");
            entity.Property(e => e.DescriptionLangMask).HasColumnName("Description_Lang_Mask");
            entity
                .Property(e => e.DescriptionLangPtBr)
                .HasMaxLength(100)
                .HasColumnName("Description_Lang_ptBR");
            entity
                .Property(e => e.DescriptionLangPtPt)
                .HasMaxLength(100)
                .HasColumnName("Description_Lang_ptPT");
            entity
                .Property(e => e.DescriptionLangRuRu)
                .HasMaxLength(100)
                .HasColumnName("Description_Lang_ruRU");
            entity
                .Property(e => e.DescriptionLangUnk)
                .HasMaxLength(100)
                .HasColumnName("Description_Lang_Unk");
            entity
                .Property(e => e.DescriptionLangZhCn)
                .HasMaxLength(100)
                .HasColumnName("Description_Lang_zhCN");
            entity
                .Property(e => e.DescriptionLangZhTw)
                .HasMaxLength(100)
                .HasColumnName("Description_Lang_zhTW");
            entity.Property(e => e.FailAsset).HasColumnName("Fail_Asset");
            entity.Property(e => e.FailEvent).HasColumnName("Fail_Event");
            entity.Property(e => e.StartAsset).HasColumnName("Start_Asset");
            entity.Property(e => e.StartEvent).HasColumnName("Start_Event");
            entity.Property(e => e.TimerAssetId).HasColumnName("Timer_Asset_Id");
            entity.Property(e => e.TimerStartEvent).HasColumnName("Timer_Start_Event");
            entity.Property(e => e.TimerTime).HasColumnName("Timer_Time");
            entity.Property(e => e.UiOrder).HasColumnName("Ui_Order");
        });

        modelBuilder.Entity<AchievementDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("achievement_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity
                .Property(e => e.DescriptionLangDeDe)
                .HasMaxLength(200)
                .HasColumnName("Description_Lang_deDE");
            entity
                .Property(e => e.DescriptionLangEnCn)
                .HasMaxLength(200)
                .HasColumnName("Description_Lang_enCN");
            entity
                .Property(e => e.DescriptionLangEnGb)
                .HasMaxLength(200)
                .HasColumnName("Description_Lang_enGB");
            entity
                .Property(e => e.DescriptionLangEnTw)
                .HasMaxLength(200)
                .HasColumnName("Description_Lang_enTW");
            entity
                .Property(e => e.DescriptionLangEnUs)
                .HasMaxLength(200)
                .HasColumnName("Description_Lang_enUS");
            entity
                .Property(e => e.DescriptionLangEsEs)
                .HasMaxLength(200)
                .HasColumnName("Description_Lang_esES");
            entity
                .Property(e => e.DescriptionLangEsMx)
                .HasMaxLength(200)
                .HasColumnName("Description_Lang_esMX");
            entity
                .Property(e => e.DescriptionLangFrFr)
                .HasMaxLength(200)
                .HasColumnName("Description_Lang_frFR");
            entity
                .Property(e => e.DescriptionLangItIt)
                .HasMaxLength(200)
                .HasColumnName("Description_Lang_itIT");
            entity
                .Property(e => e.DescriptionLangKoKr)
                .HasMaxLength(200)
                .HasColumnName("Description_Lang_koKR");
            entity.Property(e => e.DescriptionLangMask).HasColumnName("Description_Lang_Mask");
            entity
                .Property(e => e.DescriptionLangPtBr)
                .HasMaxLength(200)
                .HasColumnName("Description_Lang_ptBR");
            entity
                .Property(e => e.DescriptionLangPtPt)
                .HasMaxLength(200)
                .HasColumnName("Description_Lang_ptPT");
            entity
                .Property(e => e.DescriptionLangRuRu)
                .HasMaxLength(200)
                .HasColumnName("Description_Lang_ruRU");
            entity
                .Property(e => e.DescriptionLangUnk)
                .HasMaxLength(100)
                .HasColumnName("Description_Lang_Unk");
            entity
                .Property(e => e.DescriptionLangZhCn)
                .HasMaxLength(200)
                .HasColumnName("Description_Lang_zhCN");
            entity
                .Property(e => e.DescriptionLangZhTw)
                .HasMaxLength(200)
                .HasColumnName("Description_Lang_zhTW");
            entity.Property(e => e.IconId).HasColumnName("IconID");
            entity.Property(e => e.InstanceId).HasColumnName("Instance_Id");
            entity.Property(e => e.MinimumCriteria).HasColumnName("Minimum_Criteria");
            entity
                .Property(e => e.RewardLangDeDe)
                .HasMaxLength(100)
                .HasColumnName("Reward_Lang_deDE");
            entity
                .Property(e => e.RewardLangEnCn)
                .HasMaxLength(100)
                .HasColumnName("Reward_Lang_enCN");
            entity
                .Property(e => e.RewardLangEnGb)
                .HasMaxLength(100)
                .HasColumnName("Reward_Lang_enGB");
            entity
                .Property(e => e.RewardLangEnTw)
                .HasMaxLength(100)
                .HasColumnName("Reward_Lang_enTW");
            entity
                .Property(e => e.RewardLangEnUs)
                .HasMaxLength(100)
                .HasColumnName("Reward_Lang_enUS");
            entity
                .Property(e => e.RewardLangEsEs)
                .HasMaxLength(100)
                .HasColumnName("Reward_Lang_esES");
            entity
                .Property(e => e.RewardLangEsMx)
                .HasMaxLength(100)
                .HasColumnName("Reward_Lang_esMX");
            entity
                .Property(e => e.RewardLangFrFr)
                .HasMaxLength(100)
                .HasColumnName("Reward_Lang_frFR");
            entity
                .Property(e => e.RewardLangItIt)
                .HasMaxLength(100)
                .HasColumnName("Reward_Lang_itIT");
            entity
                .Property(e => e.RewardLangKoKr)
                .HasMaxLength(100)
                .HasColumnName("Reward_Lang_koKR");
            entity.Property(e => e.RewardLangMask).HasColumnName("Reward_Lang_Mask");
            entity
                .Property(e => e.RewardLangPtBr)
                .HasMaxLength(100)
                .HasColumnName("Reward_Lang_ptBR");
            entity
                .Property(e => e.RewardLangPtPt)
                .HasMaxLength(100)
                .HasColumnName("Reward_Lang_ptPT");
            entity
                .Property(e => e.RewardLangRuRu)
                .HasMaxLength(100)
                .HasColumnName("Reward_Lang_ruRU");
            entity
                .Property(e => e.RewardLangUnk)
                .HasMaxLength(100)
                .HasColumnName("Reward_Lang_Unk");
            entity
                .Property(e => e.RewardLangZhCn)
                .HasMaxLength(100)
                .HasColumnName("Reward_Lang_zhCN");
            entity
                .Property(e => e.RewardLangZhTw)
                .HasMaxLength(100)
                .HasColumnName("Reward_Lang_zhTW");
            entity.Property(e => e.SharesCriteria).HasColumnName("Shares_Criteria");
            entity
                .Property(e => e.TitleLangDeDe)
                .HasMaxLength(100)
                .HasColumnName("Title_Lang_deDE");
            entity
                .Property(e => e.TitleLangEnCn)
                .HasMaxLength(100)
                .HasColumnName("Title_Lang_enCN");
            entity
                .Property(e => e.TitleLangEnGb)
                .HasMaxLength(100)
                .HasColumnName("Title_Lang_enGB");
            entity
                .Property(e => e.TitleLangEnTw)
                .HasMaxLength(100)
                .HasColumnName("Title_Lang_enTW");
            entity
                .Property(e => e.TitleLangEnUs)
                .HasMaxLength(100)
                .HasColumnName("Title_Lang_enUS");
            entity
                .Property(e => e.TitleLangEsEs)
                .HasMaxLength(100)
                .HasColumnName("Title_Lang_esES");
            entity
                .Property(e => e.TitleLangEsMx)
                .HasMaxLength(100)
                .HasColumnName("Title_Lang_esMX");
            entity
                .Property(e => e.TitleLangFrFr)
                .HasMaxLength(100)
                .HasColumnName("Title_Lang_frFR");
            entity
                .Property(e => e.TitleLangItIt)
                .HasMaxLength(100)
                .HasColumnName("Title_Lang_itIT");
            entity
                .Property(e => e.TitleLangKoKr)
                .HasMaxLength(100)
                .HasColumnName("Title_Lang_koKR");
            entity.Property(e => e.TitleLangMask).HasColumnName("Title_Lang_Mask");
            entity
                .Property(e => e.TitleLangPtBr)
                .HasMaxLength(100)
                .HasColumnName("Title_Lang_ptBR");
            entity
                .Property(e => e.TitleLangPtPt)
                .HasMaxLength(100)
                .HasColumnName("Title_Lang_ptPT");
            entity
                .Property(e => e.TitleLangRuRu)
                .HasMaxLength(100)
                .HasColumnName("Title_Lang_ruRU");
            entity.Property(e => e.TitleLangUnk).HasMaxLength(100).HasColumnName("Title_Lang_Unk");
            entity
                .Property(e => e.TitleLangZhCn)
                .HasMaxLength(100)
                .HasColumnName("Title_Lang_zhCN");
            entity
                .Property(e => e.TitleLangZhTw)
                .HasMaxLength(100)
                .HasColumnName("Title_Lang_zhTW");
            entity.Property(e => e.UiOrder).HasColumnName("Ui_Order");
        });

        modelBuilder.Entity<AchievementReward>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("achievement_reward", tb => tb.HasComment("Loot System"));

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Body).HasColumnType("text");
            entity.Property(e => e.ItemId).HasColumnName("ItemID");
            entity.Property(e => e.MailTemplateId).HasColumnName("MailTemplateID");
            entity.Property(e => e.Subject).HasMaxLength(255);
        });

        modelBuilder.Entity<AchievementRewardLocale>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Locale }).HasName("PRIMARY");

            entity.ToTable("achievement_reward_locale");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Locale).HasMaxLength(4);
            entity.Property(e => e.Subject).HasColumnType("text");
            entity.Property(e => e.Text).HasColumnType("text");
        });

        modelBuilder.Entity<AcoreString>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity.ToTable("acore_string");

            entity.Property(e => e.Entry).HasColumnName("entry");
            entity
                .Property(e => e.ContentDefault)
                .HasColumnType("text")
                .HasColumnName("content_default");
            entity.Property(e => e.LocaleDeDe).HasColumnType("text").HasColumnName("locale_deDE");
            entity.Property(e => e.LocaleEsEs).HasColumnType("text").HasColumnName("locale_esES");
            entity.Property(e => e.LocaleEsMx).HasColumnType("text").HasColumnName("locale_esMX");
            entity.Property(e => e.LocaleFrFr).HasColumnType("text").HasColumnName("locale_frFR");
            entity.Property(e => e.LocaleKoKr).HasColumnType("text").HasColumnName("locale_koKR");
            entity.Property(e => e.LocaleRuRu).HasColumnType("text").HasColumnName("locale_ruRU");
            entity.Property(e => e.LocaleZhCn).HasColumnType("text").HasColumnName("locale_zhCN");
            entity.Property(e => e.LocaleZhTw).HasColumnType("text").HasColumnName("locale_zhTW");
        });

        modelBuilder.Entity<AreagroupDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("areagroup_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AreaId1).HasColumnName("AreaID_1");
            entity.Property(e => e.AreaId2).HasColumnName("AreaID_2");
            entity.Property(e => e.AreaId3).HasColumnName("AreaID_3");
            entity.Property(e => e.AreaId4).HasColumnName("AreaID_4");
            entity.Property(e => e.AreaId5).HasColumnName("AreaID_5");
            entity.Property(e => e.AreaId6).HasColumnName("AreaID_6");
            entity.Property(e => e.NextAreaId).HasColumnName("NextAreaID");
        });

        modelBuilder.Entity<AreapoiDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("areapoi_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AreaId).HasColumnName("AreaID");
            entity.Property(e => e.ContinentId).HasColumnName("ContinentID");
            entity
                .Property(e => e.DescriptionLangDeDe)
                .HasMaxLength(100)
                .HasColumnName("Description_Lang_deDE");
            entity
                .Property(e => e.DescriptionLangEnCn)
                .HasMaxLength(100)
                .HasColumnName("Description_Lang_enCN");
            entity
                .Property(e => e.DescriptionLangEnGb)
                .HasMaxLength(100)
                .HasColumnName("Description_Lang_enGB");
            entity
                .Property(e => e.DescriptionLangEnTw)
                .HasMaxLength(100)
                .HasColumnName("Description_Lang_enTW");
            entity
                .Property(e => e.DescriptionLangEnUs)
                .HasMaxLength(100)
                .HasColumnName("Description_Lang_enUS");
            entity
                .Property(e => e.DescriptionLangEsEs)
                .HasMaxLength(100)
                .HasColumnName("Description_Lang_esES");
            entity
                .Property(e => e.DescriptionLangEsMx)
                .HasMaxLength(100)
                .HasColumnName("Description_Lang_esMX");
            entity
                .Property(e => e.DescriptionLangFrFr)
                .HasMaxLength(100)
                .HasColumnName("Description_Lang_frFR");
            entity
                .Property(e => e.DescriptionLangItIt)
                .HasMaxLength(100)
                .HasColumnName("Description_Lang_itIT");
            entity
                .Property(e => e.DescriptionLangKoKr)
                .HasMaxLength(100)
                .HasColumnName("Description_Lang_koKR");
            entity.Property(e => e.DescriptionLangMask).HasColumnName("Description_Lang_Mask");
            entity
                .Property(e => e.DescriptionLangPtBr)
                .HasMaxLength(100)
                .HasColumnName("Description_Lang_ptBR");
            entity
                .Property(e => e.DescriptionLangPtPt)
                .HasMaxLength(100)
                .HasColumnName("Description_Lang_ptPT");
            entity
                .Property(e => e.DescriptionLangRuRu)
                .HasMaxLength(100)
                .HasColumnName("Description_Lang_ruRU");
            entity
                .Property(e => e.DescriptionLangUnk)
                .HasMaxLength(100)
                .HasColumnName("Description_Lang_Unk");
            entity
                .Property(e => e.DescriptionLangZhCn)
                .HasMaxLength(100)
                .HasColumnName("Description_Lang_zhCN");
            entity
                .Property(e => e.DescriptionLangZhTw)
                .HasMaxLength(100)
                .HasColumnName("Description_Lang_zhTW");
            entity.Property(e => e.FactionId).HasColumnName("FactionID");
            entity.Property(e => e.Icon1).HasColumnName("Icon_1");
            entity.Property(e => e.Icon2).HasColumnName("Icon_2");
            entity.Property(e => e.Icon3).HasColumnName("Icon_3");
            entity.Property(e => e.Icon4).HasColumnName("Icon_4");
            entity.Property(e => e.Icon5).HasColumnName("Icon_5");
            entity.Property(e => e.Icon6).HasColumnName("Icon_6");
            entity.Property(e => e.Icon7).HasColumnName("Icon_7");
            entity.Property(e => e.Icon8).HasColumnName("Icon_8");
            entity.Property(e => e.Icon9).HasColumnName("Icon_9");
            entity.Property(e => e.NameLangDeDe).HasMaxLength(100).HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn).HasMaxLength(100).HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb).HasMaxLength(100).HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw).HasMaxLength(100).HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs).HasMaxLength(100).HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs).HasMaxLength(100).HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx).HasMaxLength(100).HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr).HasMaxLength(100).HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt).HasMaxLength(100).HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr).HasMaxLength(100).HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr).HasMaxLength(100).HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt).HasMaxLength(100).HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu).HasMaxLength(100).HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk).HasMaxLength(100).HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn).HasMaxLength(100).HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw).HasMaxLength(100).HasColumnName("Name_Lang_zhTW");
            entity.Property(e => e.WorldStateId).HasColumnName("WorldStateID");
        });

        modelBuilder.Entity<AreatableDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("areatable_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AmbienceId).HasColumnName("AmbienceID");
            entity.Property(e => e.AmbientMultiplier).HasColumnName("Ambient_Multiplier");
            entity
                .Property(e => e.AreaNameLangDeDe)
                .HasMaxLength(100)
                .HasColumnName("AreaName_Lang_deDE");
            entity
                .Property(e => e.AreaNameLangEnCn)
                .HasMaxLength(100)
                .HasColumnName("AreaName_Lang_enCN");
            entity
                .Property(e => e.AreaNameLangEnGb)
                .HasMaxLength(100)
                .HasColumnName("AreaName_Lang_enGB");
            entity
                .Property(e => e.AreaNameLangEnTw)
                .HasMaxLength(100)
                .HasColumnName("AreaName_Lang_enTW");
            entity
                .Property(e => e.AreaNameLangEnUs)
                .HasMaxLength(100)
                .HasColumnName("AreaName_Lang_enUS");
            entity
                .Property(e => e.AreaNameLangEsEs)
                .HasMaxLength(100)
                .HasColumnName("AreaName_Lang_esES");
            entity
                .Property(e => e.AreaNameLangEsMx)
                .HasMaxLength(100)
                .HasColumnName("AreaName_Lang_esMX");
            entity
                .Property(e => e.AreaNameLangFrFr)
                .HasMaxLength(100)
                .HasColumnName("AreaName_Lang_frFR");
            entity
                .Property(e => e.AreaNameLangItIt)
                .HasMaxLength(100)
                .HasColumnName("AreaName_Lang_itIT");
            entity
                .Property(e => e.AreaNameLangKoKr)
                .HasMaxLength(100)
                .HasColumnName("AreaName_Lang_koKR");
            entity.Property(e => e.AreaNameLangMask).HasColumnName("AreaName_Lang_Mask");
            entity
                .Property(e => e.AreaNameLangPtBr)
                .HasMaxLength(100)
                .HasColumnName("AreaName_Lang_ptBR");
            entity
                .Property(e => e.AreaNameLangPtPt)
                .HasMaxLength(100)
                .HasColumnName("AreaName_Lang_ptPT");
            entity
                .Property(e => e.AreaNameLangRuRu)
                .HasMaxLength(100)
                .HasColumnName("AreaName_Lang_ruRU");
            entity
                .Property(e => e.AreaNameLangUnk)
                .HasMaxLength(100)
                .HasColumnName("AreaName_Lang_Unk");
            entity
                .Property(e => e.AreaNameLangZhCn)
                .HasMaxLength(100)
                .HasColumnName("AreaName_Lang_zhCN");
            entity
                .Property(e => e.AreaNameLangZhTw)
                .HasMaxLength(100)
                .HasColumnName("AreaName_Lang_zhTW");
            entity.Property(e => e.ContinentId).HasColumnName("ContinentID");
            entity.Property(e => e.LiquidTypeId1).HasColumnName("LiquidTypeID_1");
            entity.Property(e => e.LiquidTypeId2).HasColumnName("LiquidTypeID_2");
            entity.Property(e => e.LiquidTypeId3).HasColumnName("LiquidTypeID_3");
            entity.Property(e => e.LiquidTypeId4).HasColumnName("LiquidTypeID_4");
            entity.Property(e => e.ParentAreaId).HasColumnName("ParentAreaID");
        });

        modelBuilder.Entity<Areatrigger>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity.ToTable("areatrigger");

            entity.Property(e => e.Entry).HasColumnName("entry");
            entity
                .Property(e => e.Height)
                .HasComment("Most commonly used when size is 0, but not always")
                .HasColumnName("height");
            entity
                .Property(e => e.Length)
                .HasComment("Most commonly used when size is 0, but not always")
                .HasColumnName("length");
            entity.Property(e => e.Map).HasColumnName("map");
            entity
                .Property(e => e.Orientation)
                .HasComment("Most commonly used when size is 0, but not always")
                .HasColumnName("orientation");
            entity
                .Property(e => e.Radius)
                .HasComment("Seems to be a box of size yards with center at x,y,z")
                .HasColumnName("radius");
            entity
                .Property(e => e.Width)
                .HasComment("Most commonly used when size is 0, but not always")
                .HasColumnName("width");
            entity.Property(e => e.X).HasColumnName("x");
            entity.Property(e => e.Y).HasColumnName("y");
            entity.Property(e => e.Z).HasColumnName("z");
        });

        modelBuilder.Entity<AreatriggerInvolvedrelation>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("areatrigger_involvedrelation", tb => tb.HasComment("Trigger System"));

            entity.Property(e => e.Id).HasComment("Identifier").HasColumnName("id");
            entity.Property(e => e.Quest).HasComment("Quest Identifier").HasColumnName("quest");
        });

        modelBuilder.Entity<AreatriggerScript>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity.ToTable("areatrigger_scripts");

            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.ScriptName).HasMaxLength(64).IsFixedLength();
        });

        modelBuilder.Entity<AreatriggerTavern>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("areatrigger_tavern", tb => tb.HasComment("Trigger System"));

            entity.Property(e => e.Id).HasComment("Identifier").HasColumnName("id");
            entity.Property(e => e.Faction).HasColumnName("faction");
            entity.Property(e => e.Name).HasColumnType("text").HasColumnName("name");
        });

        modelBuilder.Entity<AreatriggerTeleport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("areatrigger_teleport", tb => tb.HasComment("Trigger System"));

            entity.HasIndex(e => e.Name, "name");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name).HasColumnType("text");
            entity.Property(e => e.TargetMap).HasColumnName("target_map");
            entity.Property(e => e.TargetOrientation).HasColumnName("target_orientation");
            entity.Property(e => e.TargetPositionX).HasColumnName("target_position_x");
            entity.Property(e => e.TargetPositionY).HasColumnName("target_position_y");
            entity.Property(e => e.TargetPositionZ).HasColumnName("target_position_z");
        });

        modelBuilder.Entity<AuctionhouseDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("auctionhouse_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FactionId).HasColumnName("FactionID");
            entity.Property(e => e.NameLangDeDe).HasMaxLength(100).HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn).HasMaxLength(100).HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb).HasMaxLength(100).HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw).HasMaxLength(100).HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs).HasMaxLength(100).HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs).HasMaxLength(100).HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx).HasMaxLength(100).HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr).HasMaxLength(100).HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt).HasMaxLength(100).HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr).HasMaxLength(100).HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr).HasMaxLength(100).HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt).HasMaxLength(100).HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu).HasMaxLength(100).HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk).HasMaxLength(100).HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn).HasMaxLength(100).HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw).HasMaxLength(100).HasColumnName("Name_Lang_zhTW");
        });

        modelBuilder.Entity<BankbagslotpricesDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("bankbagslotprices_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<BarbershopstyleDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("barbershopstyle_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CostModifier).HasColumnName("Cost_Modifier");
            entity
                .Property(e => e.DescriptionLangDeDe)
                .HasMaxLength(100)
                .HasColumnName("Description_Lang_deDE");
            entity
                .Property(e => e.DescriptionLangEnCn)
                .HasMaxLength(100)
                .HasColumnName("Description_Lang_enCN");
            entity
                .Property(e => e.DescriptionLangEnGb)
                .HasMaxLength(100)
                .HasColumnName("Description_Lang_enGB");
            entity
                .Property(e => e.DescriptionLangEnTw)
                .HasMaxLength(100)
                .HasColumnName("Description_Lang_enTW");
            entity
                .Property(e => e.DescriptionLangEnUs)
                .HasMaxLength(100)
                .HasColumnName("Description_Lang_enUS");
            entity
                .Property(e => e.DescriptionLangEsEs)
                .HasMaxLength(100)
                .HasColumnName("Description_Lang_esES");
            entity
                .Property(e => e.DescriptionLangEsMx)
                .HasMaxLength(100)
                .HasColumnName("Description_Lang_esMX");
            entity
                .Property(e => e.DescriptionLangFrFr)
                .HasMaxLength(100)
                .HasColumnName("Description_Lang_frFR");
            entity
                .Property(e => e.DescriptionLangItIt)
                .HasMaxLength(100)
                .HasColumnName("Description_Lang_itIT");
            entity
                .Property(e => e.DescriptionLangKoKr)
                .HasMaxLength(100)
                .HasColumnName("Description_Lang_koKR");
            entity.Property(e => e.DescriptionLangMask).HasColumnName("Description_Lang_Mask");
            entity
                .Property(e => e.DescriptionLangPtBr)
                .HasMaxLength(100)
                .HasColumnName("Description_Lang_ptBR");
            entity
                .Property(e => e.DescriptionLangPtPt)
                .HasMaxLength(100)
                .HasColumnName("Description_Lang_ptPT");
            entity
                .Property(e => e.DescriptionLangRuRu)
                .HasMaxLength(100)
                .HasColumnName("Description_Lang_ruRU");
            entity
                .Property(e => e.DescriptionLangUnk)
                .HasMaxLength(100)
                .HasColumnName("Description_Lang_Unk");
            entity
                .Property(e => e.DescriptionLangZhCn)
                .HasMaxLength(100)
                .HasColumnName("Description_Lang_zhCN");
            entity
                .Property(e => e.DescriptionLangZhTw)
                .HasMaxLength(100)
                .HasColumnName("Description_Lang_zhTW");
            entity
                .Property(e => e.DisplayNameLangDeDe)
                .HasMaxLength(100)
                .HasColumnName("DisplayName_Lang_deDE");
            entity
                .Property(e => e.DisplayNameLangEnCn)
                .HasMaxLength(100)
                .HasColumnName("DisplayName_Lang_enCN");
            entity
                .Property(e => e.DisplayNameLangEnGb)
                .HasMaxLength(100)
                .HasColumnName("DisplayName_Lang_enGB");
            entity
                .Property(e => e.DisplayNameLangEnTw)
                .HasMaxLength(100)
                .HasColumnName("DisplayName_Lang_enTW");
            entity
                .Property(e => e.DisplayNameLangEnUs)
                .HasMaxLength(100)
                .HasColumnName("DisplayName_Lang_enUS");
            entity
                .Property(e => e.DisplayNameLangEsEs)
                .HasMaxLength(100)
                .HasColumnName("DisplayName_Lang_esES");
            entity
                .Property(e => e.DisplayNameLangEsMx)
                .HasMaxLength(100)
                .HasColumnName("DisplayName_Lang_esMX");
            entity
                .Property(e => e.DisplayNameLangFrFr)
                .HasMaxLength(100)
                .HasColumnName("DisplayName_Lang_frFR");
            entity
                .Property(e => e.DisplayNameLangItIt)
                .HasMaxLength(100)
                .HasColumnName("DisplayName_Lang_itIT");
            entity
                .Property(e => e.DisplayNameLangKoKr)
                .HasMaxLength(100)
                .HasColumnName("DisplayName_Lang_koKR");
            entity.Property(e => e.DisplayNameLangMask).HasColumnName("DisplayName_Lang_Mask");
            entity
                .Property(e => e.DisplayNameLangPtBr)
                .HasMaxLength(100)
                .HasColumnName("DisplayName_Lang_ptBR");
            entity
                .Property(e => e.DisplayNameLangPtPt)
                .HasMaxLength(100)
                .HasColumnName("DisplayName_Lang_ptPT");
            entity
                .Property(e => e.DisplayNameLangRuRu)
                .HasMaxLength(100)
                .HasColumnName("DisplayName_Lang_ruRU");
            entity
                .Property(e => e.DisplayNameLangUnk)
                .HasMaxLength(100)
                .HasColumnName("DisplayName_Lang_Unk");
            entity
                .Property(e => e.DisplayNameLangZhCn)
                .HasMaxLength(100)
                .HasColumnName("DisplayName_Lang_zhCN");
            entity
                .Property(e => e.DisplayNameLangZhTw)
                .HasMaxLength(100)
                .HasColumnName("DisplayName_Lang_zhTW");
        });

        modelBuilder.Entity<BattlegroundTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("battleground_template");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Comment).HasMaxLength(38).IsFixedLength();
            entity
                .Property(e => e.ScriptName)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.Weight).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<BattlemasterEntry>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity.ToTable("battlemaster_entry");

            entity.Property(e => e.Entry).HasComment("Entry of a creature").HasColumnName("entry");
            entity
                .Property(e => e.BgTemplate)
                .HasComment("Battleground template id")
                .HasColumnName("bg_template");
        });

        modelBuilder.Entity<BattlemasterlistDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("battlemasterlist_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MapId1).HasColumnName("MapID_1");
            entity.Property(e => e.MapId2).HasColumnName("MapID_2");
            entity.Property(e => e.MapId3).HasColumnName("MapID_3");
            entity.Property(e => e.MapId4).HasColumnName("MapID_4");
            entity.Property(e => e.MapId5).HasColumnName("MapID_5");
            entity.Property(e => e.MapId6).HasColumnName("MapID_6");
            entity.Property(e => e.MapId7).HasColumnName("MapID_7");
            entity.Property(e => e.MapId8).HasColumnName("MapID_8");
            entity.Property(e => e.NameLangDeDe).HasMaxLength(100).HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn).HasMaxLength(100).HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb).HasMaxLength(100).HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw).HasMaxLength(100).HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs).HasMaxLength(100).HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs).HasMaxLength(100).HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx).HasMaxLength(100).HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr).HasMaxLength(100).HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt).HasMaxLength(100).HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr).HasMaxLength(100).HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr).HasMaxLength(100).HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt).HasMaxLength(100).HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu).HasMaxLength(100).HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk).HasMaxLength(100).HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn).HasMaxLength(100).HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw).HasMaxLength(100).HasColumnName("Name_Lang_zhTW");
        });

        modelBuilder.Entity<BroadcastText>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("broadcast_text");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.EmoteId1).HasColumnName("EmoteID1");
            entity.Property(e => e.EmoteId2).HasColumnName("EmoteID2");
            entity.Property(e => e.EmoteId3).HasColumnName("EmoteID3");
            entity.Property(e => e.EmotesId).HasColumnName("EmotesID");
            entity.Property(e => e.LanguageId).HasColumnName("LanguageID");
            entity.Property(e => e.VerifiedBuild).HasDefaultValueSql("'0'");
        });

        modelBuilder.Entity<BroadcastTextLocale>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Locale }).HasName("PRIMARY");

            entity.ToTable("broadcast_text_locale");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Locale).HasMaxLength(4).HasColumnName("locale");
            entity.Property(e => e.FemaleText).HasColumnType("text");
            entity.Property(e => e.MaleText).HasColumnType("text");
            entity.Property(e => e.VerifiedBuild).HasDefaultValueSql("'0'");
        });

        modelBuilder.Entity<CharstartoutfitDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("charstartoutfit_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.DisplayItemId1).HasColumnName("DisplayItemID_1");
            entity.Property(e => e.DisplayItemId10).HasColumnName("DisplayItemID_10");
            entity.Property(e => e.DisplayItemId11).HasColumnName("DisplayItemID_11");
            entity.Property(e => e.DisplayItemId12).HasColumnName("DisplayItemID_12");
            entity.Property(e => e.DisplayItemId13).HasColumnName("DisplayItemID_13");
            entity.Property(e => e.DisplayItemId14).HasColumnName("DisplayItemID_14");
            entity.Property(e => e.DisplayItemId15).HasColumnName("DisplayItemID_15");
            entity.Property(e => e.DisplayItemId16).HasColumnName("DisplayItemID_16");
            entity.Property(e => e.DisplayItemId17).HasColumnName("DisplayItemID_17");
            entity.Property(e => e.DisplayItemId18).HasColumnName("DisplayItemID_18");
            entity.Property(e => e.DisplayItemId19).HasColumnName("DisplayItemID_19");
            entity.Property(e => e.DisplayItemId2).HasColumnName("DisplayItemID_2");
            entity.Property(e => e.DisplayItemId20).HasColumnName("DisplayItemID_20");
            entity.Property(e => e.DisplayItemId21).HasColumnName("DisplayItemID_21");
            entity.Property(e => e.DisplayItemId22).HasColumnName("DisplayItemID_22");
            entity.Property(e => e.DisplayItemId23).HasColumnName("DisplayItemID_23");
            entity.Property(e => e.DisplayItemId24).HasColumnName("DisplayItemID_24");
            entity.Property(e => e.DisplayItemId3).HasColumnName("DisplayItemID_3");
            entity.Property(e => e.DisplayItemId4).HasColumnName("DisplayItemID_4");
            entity.Property(e => e.DisplayItemId5).HasColumnName("DisplayItemID_5");
            entity.Property(e => e.DisplayItemId6).HasColumnName("DisplayItemID_6");
            entity.Property(e => e.DisplayItemId7).HasColumnName("DisplayItemID_7");
            entity.Property(e => e.DisplayItemId8).HasColumnName("DisplayItemID_8");
            entity.Property(e => e.DisplayItemId9).HasColumnName("DisplayItemID_9");
            entity.Property(e => e.InventoryType1).HasColumnName("InventoryType_1");
            entity.Property(e => e.InventoryType10).HasColumnName("InventoryType_10");
            entity.Property(e => e.InventoryType11).HasColumnName("InventoryType_11");
            entity.Property(e => e.InventoryType12).HasColumnName("InventoryType_12");
            entity.Property(e => e.InventoryType13).HasColumnName("InventoryType_13");
            entity.Property(e => e.InventoryType14).HasColumnName("InventoryType_14");
            entity.Property(e => e.InventoryType15).HasColumnName("InventoryType_15");
            entity.Property(e => e.InventoryType16).HasColumnName("InventoryType_16");
            entity.Property(e => e.InventoryType17).HasColumnName("InventoryType_17");
            entity.Property(e => e.InventoryType18).HasColumnName("InventoryType_18");
            entity.Property(e => e.InventoryType19).HasColumnName("InventoryType_19");
            entity.Property(e => e.InventoryType2).HasColumnName("InventoryType_2");
            entity.Property(e => e.InventoryType20).HasColumnName("InventoryType_20");
            entity.Property(e => e.InventoryType21).HasColumnName("InventoryType_21");
            entity.Property(e => e.InventoryType22).HasColumnName("InventoryType_22");
            entity.Property(e => e.InventoryType23).HasColumnName("InventoryType_23");
            entity.Property(e => e.InventoryType24).HasColumnName("InventoryType_24");
            entity.Property(e => e.InventoryType3).HasColumnName("InventoryType_3");
            entity.Property(e => e.InventoryType4).HasColumnName("InventoryType_4");
            entity.Property(e => e.InventoryType5).HasColumnName("InventoryType_5");
            entity.Property(e => e.InventoryType6).HasColumnName("InventoryType_6");
            entity.Property(e => e.InventoryType7).HasColumnName("InventoryType_7");
            entity.Property(e => e.InventoryType8).HasColumnName("InventoryType_8");
            entity.Property(e => e.InventoryType9).HasColumnName("InventoryType_9");
            entity.Property(e => e.ItemId1).HasColumnName("ItemID_1");
            entity.Property(e => e.ItemId10).HasColumnName("ItemID_10");
            entity.Property(e => e.ItemId11).HasColumnName("ItemID_11");
            entity.Property(e => e.ItemId12).HasColumnName("ItemID_12");
            entity.Property(e => e.ItemId13).HasColumnName("ItemID_13");
            entity.Property(e => e.ItemId14).HasColumnName("ItemID_14");
            entity.Property(e => e.ItemId15).HasColumnName("ItemID_15");
            entity.Property(e => e.ItemId16).HasColumnName("ItemID_16");
            entity.Property(e => e.ItemId17).HasColumnName("ItemID_17");
            entity.Property(e => e.ItemId18).HasColumnName("ItemID_18");
            entity.Property(e => e.ItemId19).HasColumnName("ItemID_19");
            entity.Property(e => e.ItemId2).HasColumnName("ItemID_2");
            entity.Property(e => e.ItemId20).HasColumnName("ItemID_20");
            entity.Property(e => e.ItemId21).HasColumnName("ItemID_21");
            entity.Property(e => e.ItemId22).HasColumnName("ItemID_22");
            entity.Property(e => e.ItemId23).HasColumnName("ItemID_23");
            entity.Property(e => e.ItemId24).HasColumnName("ItemID_24");
            entity.Property(e => e.ItemId3).HasColumnName("ItemID_3");
            entity.Property(e => e.ItemId4).HasColumnName("ItemID_4");
            entity.Property(e => e.ItemId5).HasColumnName("ItemID_5");
            entity.Property(e => e.ItemId6).HasColumnName("ItemID_6");
            entity.Property(e => e.ItemId7).HasColumnName("ItemID_7");
            entity.Property(e => e.ItemId8).HasColumnName("ItemID_8");
            entity.Property(e => e.ItemId9).HasColumnName("ItemID_9");
            entity.Property(e => e.OutfitId).HasColumnName("OutfitID");
            entity.Property(e => e.RaceId).HasColumnName("RaceID");
            entity.Property(e => e.SexId).HasColumnName("SexID");
        });

        modelBuilder.Entity<ChartitlesDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("chartitles_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ConditionId).HasColumnName("Condition_ID");
            entity.Property(e => e.MaskId).HasColumnName("Mask_ID");
            entity
                .Property(e => e.Name1LangDeDe)
                .HasMaxLength(100)
                .HasColumnName("Name1_Lang_deDE");
            entity
                .Property(e => e.Name1LangEnCn)
                .HasMaxLength(100)
                .HasColumnName("Name1_Lang_enCN");
            entity
                .Property(e => e.Name1LangEnGb)
                .HasMaxLength(100)
                .HasColumnName("Name1_Lang_enGB");
            entity
                .Property(e => e.Name1LangEnTw)
                .HasMaxLength(100)
                .HasColumnName("Name1_Lang_enTW");
            entity
                .Property(e => e.Name1LangEnUs)
                .HasMaxLength(100)
                .HasColumnName("Name1_Lang_enUS");
            entity
                .Property(e => e.Name1LangEsEs)
                .HasMaxLength(100)
                .HasColumnName("Name1_Lang_esES");
            entity
                .Property(e => e.Name1LangEsMx)
                .HasMaxLength(100)
                .HasColumnName("Name1_Lang_esMX");
            entity
                .Property(e => e.Name1LangFrFr)
                .HasMaxLength(100)
                .HasColumnName("Name1_Lang_frFR");
            entity
                .Property(e => e.Name1LangItIt)
                .HasMaxLength(100)
                .HasColumnName("Name1_Lang_itIT");
            entity
                .Property(e => e.Name1LangKoKr)
                .HasMaxLength(100)
                .HasColumnName("Name1_Lang_koKR");
            entity.Property(e => e.Name1LangMask).HasColumnName("Name1_Lang_Mask");
            entity
                .Property(e => e.Name1LangPtBr)
                .HasMaxLength(100)
                .HasColumnName("Name1_Lang_ptBR");
            entity
                .Property(e => e.Name1LangPtPt)
                .HasMaxLength(100)
                .HasColumnName("Name1_Lang_ptPT");
            entity
                .Property(e => e.Name1LangRuRu)
                .HasMaxLength(100)
                .HasColumnName("Name1_Lang_ruRU");
            entity.Property(e => e.Name1LangUnk).HasMaxLength(100).HasColumnName("Name1_Lang_Unk");
            entity
                .Property(e => e.Name1LangZhCn)
                .HasMaxLength(100)
                .HasColumnName("Name1_Lang_zhCN");
            entity
                .Property(e => e.Name1LangZhTw)
                .HasMaxLength(100)
                .HasColumnName("Name1_Lang_zhTW");
            entity.Property(e => e.NameLangDeDe).HasMaxLength(100).HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn).HasMaxLength(100).HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb).HasMaxLength(100).HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw).HasMaxLength(100).HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs).HasMaxLength(100).HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs).HasMaxLength(100).HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx).HasMaxLength(100).HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr).HasMaxLength(100).HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt).HasMaxLength(100).HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr).HasMaxLength(100).HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr).HasMaxLength(100).HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt).HasMaxLength(100).HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu).HasMaxLength(100).HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk).HasMaxLength(100).HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn).HasMaxLength(100).HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw).HasMaxLength(100).HasColumnName("Name_Lang_zhTW");
        });

        modelBuilder.Entity<ChatchannelsDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("chatchannels_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.NameLangDeDe).HasMaxLength(100).HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn).HasMaxLength(100).HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb).HasMaxLength(100).HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw).HasMaxLength(100).HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs).HasMaxLength(100).HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs).HasMaxLength(100).HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx).HasMaxLength(100).HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr).HasMaxLength(100).HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt).HasMaxLength(100).HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr).HasMaxLength(100).HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr).HasMaxLength(100).HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt).HasMaxLength(100).HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu).HasMaxLength(100).HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk).HasMaxLength(100).HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn).HasMaxLength(100).HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw).HasMaxLength(100).HasColumnName("Name_Lang_zhTW");
            entity
                .Property(e => e.ShortcutLangDeDe)
                .HasMaxLength(100)
                .HasColumnName("Shortcut_Lang_deDE");
            entity
                .Property(e => e.ShortcutLangEnCn)
                .HasMaxLength(100)
                .HasColumnName("Shortcut_Lang_enCN");
            entity
                .Property(e => e.ShortcutLangEnGb)
                .HasMaxLength(100)
                .HasColumnName("Shortcut_Lang_enGB");
            entity
                .Property(e => e.ShortcutLangEnTw)
                .HasMaxLength(100)
                .HasColumnName("Shortcut_Lang_enTW");
            entity
                .Property(e => e.ShortcutLangEnUs)
                .HasMaxLength(100)
                .HasColumnName("Shortcut_Lang_enUS");
            entity
                .Property(e => e.ShortcutLangEsEs)
                .HasMaxLength(100)
                .HasColumnName("Shortcut_Lang_esES");
            entity
                .Property(e => e.ShortcutLangEsMx)
                .HasMaxLength(100)
                .HasColumnName("Shortcut_Lang_esMX");
            entity
                .Property(e => e.ShortcutLangFrFr)
                .HasMaxLength(100)
                .HasColumnName("Shortcut_Lang_frFR");
            entity
                .Property(e => e.ShortcutLangItIt)
                .HasMaxLength(100)
                .HasColumnName("Shortcut_Lang_itIT");
            entity
                .Property(e => e.ShortcutLangKoKr)
                .HasMaxLength(100)
                .HasColumnName("Shortcut_Lang_koKR");
            entity.Property(e => e.ShortcutLangMask).HasColumnName("Shortcut_Lang_Mask");
            entity
                .Property(e => e.ShortcutLangPtBr)
                .HasMaxLength(100)
                .HasColumnName("Shortcut_Lang_ptBR");
            entity
                .Property(e => e.ShortcutLangPtPt)
                .HasMaxLength(100)
                .HasColumnName("Shortcut_Lang_ptPT");
            entity
                .Property(e => e.ShortcutLangRuRu)
                .HasMaxLength(100)
                .HasColumnName("Shortcut_Lang_ruRU");
            entity
                .Property(e => e.ShortcutLangUnk)
                .HasMaxLength(100)
                .HasColumnName("Shortcut_Lang_Unk");
            entity
                .Property(e => e.ShortcutLangZhCn)
                .HasMaxLength(100)
                .HasColumnName("Shortcut_Lang_zhCN");
            entity
                .Property(e => e.ShortcutLangZhTw)
                .HasMaxLength(100)
                .HasColumnName("Shortcut_Lang_zhTW");
        });

        modelBuilder.Entity<ChrclassesDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("chrclasses_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CinematicSequenceId).HasColumnName("CinematicSequenceID");
            entity.Property(e => e.Filename).HasMaxLength(100);
            entity
                .Property(e => e.NameFemaleLangDeDe)
                .HasMaxLength(100)
                .HasColumnName("Name_Female_Lang_deDE");
            entity
                .Property(e => e.NameFemaleLangEnCn)
                .HasMaxLength(100)
                .HasColumnName("Name_Female_Lang_enCN");
            entity
                .Property(e => e.NameFemaleLangEnGb)
                .HasMaxLength(100)
                .HasColumnName("Name_Female_Lang_enGB");
            entity
                .Property(e => e.NameFemaleLangEnTw)
                .HasMaxLength(100)
                .HasColumnName("Name_Female_Lang_enTW");
            entity
                .Property(e => e.NameFemaleLangEnUs)
                .HasMaxLength(100)
                .HasColumnName("Name_Female_Lang_enUS");
            entity
                .Property(e => e.NameFemaleLangEsEs)
                .HasMaxLength(100)
                .HasColumnName("Name_Female_Lang_esES");
            entity
                .Property(e => e.NameFemaleLangEsMx)
                .HasMaxLength(100)
                .HasColumnName("Name_Female_Lang_esMX");
            entity
                .Property(e => e.NameFemaleLangFrFr)
                .HasMaxLength(100)
                .HasColumnName("Name_Female_Lang_frFR");
            entity
                .Property(e => e.NameFemaleLangItIt)
                .HasMaxLength(100)
                .HasColumnName("Name_Female_Lang_itIT");
            entity
                .Property(e => e.NameFemaleLangKoKr)
                .HasMaxLength(100)
                .HasColumnName("Name_Female_Lang_koKR");
            entity.Property(e => e.NameFemaleLangMask).HasColumnName("Name_Female_Lang_Mask");
            entity
                .Property(e => e.NameFemaleLangPtBr)
                .HasMaxLength(100)
                .HasColumnName("Name_Female_Lang_ptBR");
            entity
                .Property(e => e.NameFemaleLangPtPt)
                .HasMaxLength(100)
                .HasColumnName("Name_Female_Lang_ptPT");
            entity
                .Property(e => e.NameFemaleLangRuRu)
                .HasMaxLength(100)
                .HasColumnName("Name_Female_Lang_ruRU");
            entity
                .Property(e => e.NameFemaleLangUnk)
                .HasMaxLength(100)
                .HasColumnName("Name_Female_Lang_Unk");
            entity
                .Property(e => e.NameFemaleLangZhCn)
                .HasMaxLength(100)
                .HasColumnName("Name_Female_Lang_zhCN");
            entity
                .Property(e => e.NameFemaleLangZhTw)
                .HasMaxLength(100)
                .HasColumnName("Name_Female_Lang_zhTW");
            entity.Property(e => e.NameLangDeDe).HasMaxLength(100).HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn).HasMaxLength(100).HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb).HasMaxLength(100).HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw).HasMaxLength(100).HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs).HasMaxLength(100).HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs).HasMaxLength(100).HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx).HasMaxLength(100).HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr).HasMaxLength(100).HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt).HasMaxLength(100).HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr).HasMaxLength(100).HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr).HasMaxLength(100).HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt).HasMaxLength(100).HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu).HasMaxLength(100).HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk).HasMaxLength(100).HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn).HasMaxLength(100).HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw).HasMaxLength(100).HasColumnName("Name_Lang_zhTW");
            entity
                .Property(e => e.NameMaleLangDeDe)
                .HasMaxLength(100)
                .HasColumnName("Name_Male_Lang_deDE");
            entity
                .Property(e => e.NameMaleLangEnCn)
                .HasMaxLength(100)
                .HasColumnName("Name_Male_Lang_enCN");
            entity
                .Property(e => e.NameMaleLangEnGb)
                .HasMaxLength(100)
                .HasColumnName("Name_Male_Lang_enGB");
            entity
                .Property(e => e.NameMaleLangEnTw)
                .HasMaxLength(100)
                .HasColumnName("Name_Male_Lang_enTW");
            entity
                .Property(e => e.NameMaleLangEnUs)
                .HasMaxLength(100)
                .HasColumnName("Name_Male_Lang_enUS");
            entity
                .Property(e => e.NameMaleLangEsEs)
                .HasMaxLength(100)
                .HasColumnName("Name_Male_Lang_esES");
            entity
                .Property(e => e.NameMaleLangEsMx)
                .HasMaxLength(100)
                .HasColumnName("Name_Male_Lang_esMX");
            entity
                .Property(e => e.NameMaleLangFrFr)
                .HasMaxLength(100)
                .HasColumnName("Name_Male_Lang_frFR");
            entity
                .Property(e => e.NameMaleLangItIt)
                .HasMaxLength(100)
                .HasColumnName("Name_Male_Lang_itIT");
            entity
                .Property(e => e.NameMaleLangKoKr)
                .HasMaxLength(100)
                .HasColumnName("Name_Male_Lang_koKR");
            entity.Property(e => e.NameMaleLangMask).HasColumnName("Name_Male_Lang_Mask");
            entity
                .Property(e => e.NameMaleLangPtBr)
                .HasMaxLength(100)
                .HasColumnName("Name_Male_Lang_ptBR");
            entity
                .Property(e => e.NameMaleLangPtPt)
                .HasMaxLength(100)
                .HasColumnName("Name_Male_Lang_ptPT");
            entity
                .Property(e => e.NameMaleLangRuRu)
                .HasMaxLength(100)
                .HasColumnName("Name_Male_Lang_ruRU");
            entity
                .Property(e => e.NameMaleLangUnk)
                .HasMaxLength(100)
                .HasColumnName("Name_Male_Lang_Unk");
            entity
                .Property(e => e.NameMaleLangZhCn)
                .HasMaxLength(100)
                .HasColumnName("Name_Male_Lang_zhCN");
            entity
                .Property(e => e.NameMaleLangZhTw)
                .HasMaxLength(100)
                .HasColumnName("Name_Male_Lang_zhTW");
            entity.Property(e => e.RequiredExpansion).HasColumnName("Required_Expansion");
        });

        modelBuilder.Entity<ChrracesDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("chrraces_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CinematicSequenceId).HasColumnName("CinematicSequenceID");
            entity.Property(e => e.ClientFilestring).HasMaxLength(100);
            entity.Property(e => e.ClientPrefix).HasMaxLength(100);
            entity.Property(e => e.ExplorationSoundId).HasColumnName("ExplorationSoundID");
            entity
                .Property(e => e.FacialHairCustomization1)
                .HasMaxLength(100)
                .HasColumnName("FacialHairCustomization_1");
            entity
                .Property(e => e.FacialHairCustomization2)
                .HasMaxLength(100)
                .HasColumnName("FacialHairCustomization_2");
            entity.Property(e => e.FactionId).HasColumnName("FactionID");
            entity.Property(e => e.HairCustomization).HasMaxLength(100);
            entity
                .Property(e => e.NameFemaleLangDeDe)
                .HasMaxLength(100)
                .HasColumnName("Name_Female_Lang_deDE");
            entity
                .Property(e => e.NameFemaleLangEnCn)
                .HasMaxLength(100)
                .HasColumnName("Name_Female_Lang_enCN");
            entity
                .Property(e => e.NameFemaleLangEnGb)
                .HasMaxLength(100)
                .HasColumnName("Name_Female_Lang_enGB");
            entity
                .Property(e => e.NameFemaleLangEnTw)
                .HasMaxLength(100)
                .HasColumnName("Name_Female_Lang_enTW");
            entity
                .Property(e => e.NameFemaleLangEnUs)
                .HasMaxLength(100)
                .HasColumnName("Name_Female_Lang_enUS");
            entity
                .Property(e => e.NameFemaleLangEsEs)
                .HasMaxLength(100)
                .HasColumnName("Name_Female_Lang_esES");
            entity
                .Property(e => e.NameFemaleLangEsMx)
                .HasMaxLength(100)
                .HasColumnName("Name_Female_Lang_esMX");
            entity
                .Property(e => e.NameFemaleLangFrFr)
                .HasMaxLength(100)
                .HasColumnName("Name_Female_Lang_frFR");
            entity
                .Property(e => e.NameFemaleLangItIt)
                .HasMaxLength(100)
                .HasColumnName("Name_Female_Lang_itIT");
            entity
                .Property(e => e.NameFemaleLangKoKr)
                .HasMaxLength(100)
                .HasColumnName("Name_Female_Lang_koKR");
            entity.Property(e => e.NameFemaleLangMask).HasColumnName("Name_Female_Lang_Mask");
            entity
                .Property(e => e.NameFemaleLangPtBr)
                .HasMaxLength(100)
                .HasColumnName("Name_Female_Lang_ptBR");
            entity
                .Property(e => e.NameFemaleLangPtPt)
                .HasMaxLength(100)
                .HasColumnName("Name_Female_Lang_ptPT");
            entity
                .Property(e => e.NameFemaleLangRuRu)
                .HasMaxLength(100)
                .HasColumnName("Name_Female_Lang_ruRU");
            entity
                .Property(e => e.NameFemaleLangUnk)
                .HasMaxLength(100)
                .HasColumnName("Name_Female_Lang_Unk");
            entity
                .Property(e => e.NameFemaleLangZhCn)
                .HasMaxLength(100)
                .HasColumnName("Name_Female_Lang_zhCN");
            entity
                .Property(e => e.NameFemaleLangZhTw)
                .HasMaxLength(100)
                .HasColumnName("Name_Female_Lang_zhTW");
            entity.Property(e => e.NameLangDeDe).HasMaxLength(100).HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn).HasMaxLength(100).HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb).HasMaxLength(100).HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw).HasMaxLength(100).HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs).HasMaxLength(100).HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs).HasMaxLength(100).HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx).HasMaxLength(100).HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr).HasMaxLength(100).HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt).HasMaxLength(100).HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr).HasMaxLength(100).HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr).HasMaxLength(100).HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt).HasMaxLength(100).HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu).HasMaxLength(100).HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk).HasMaxLength(100).HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn).HasMaxLength(100).HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw).HasMaxLength(100).HasColumnName("Name_Lang_zhTW");
            entity
                .Property(e => e.NameMaleLangDeDe)
                .HasMaxLength(100)
                .HasColumnName("Name_Male_Lang_deDE");
            entity
                .Property(e => e.NameMaleLangEnCn)
                .HasMaxLength(100)
                .HasColumnName("Name_Male_Lang_enCN");
            entity
                .Property(e => e.NameMaleLangEnGb)
                .HasMaxLength(100)
                .HasColumnName("Name_Male_Lang_enGB");
            entity
                .Property(e => e.NameMaleLangEnTw)
                .HasMaxLength(100)
                .HasColumnName("Name_Male_Lang_enTW");
            entity
                .Property(e => e.NameMaleLangEnUs)
                .HasMaxLength(100)
                .HasColumnName("Name_Male_Lang_enUS");
            entity
                .Property(e => e.NameMaleLangEsEs)
                .HasMaxLength(100)
                .HasColumnName("Name_Male_Lang_esES");
            entity
                .Property(e => e.NameMaleLangEsMx)
                .HasMaxLength(100)
                .HasColumnName("Name_Male_Lang_esMX");
            entity
                .Property(e => e.NameMaleLangFrFr)
                .HasMaxLength(100)
                .HasColumnName("Name_Male_Lang_frFR");
            entity
                .Property(e => e.NameMaleLangItIt)
                .HasMaxLength(100)
                .HasColumnName("Name_Male_Lang_itIT");
            entity
                .Property(e => e.NameMaleLangKoKr)
                .HasMaxLength(100)
                .HasColumnName("Name_Male_Lang_koKR");
            entity.Property(e => e.NameMaleLangMask).HasColumnName("Name_Male_Lang_Mask");
            entity
                .Property(e => e.NameMaleLangPtBr)
                .HasMaxLength(100)
                .HasColumnName("Name_Male_Lang_ptBR");
            entity
                .Property(e => e.NameMaleLangPtPt)
                .HasMaxLength(100)
                .HasColumnName("Name_Male_Lang_ptPT");
            entity
                .Property(e => e.NameMaleLangRuRu)
                .HasMaxLength(100)
                .HasColumnName("Name_Male_Lang_ruRU");
            entity
                .Property(e => e.NameMaleLangUnk)
                .HasMaxLength(100)
                .HasColumnName("Name_Male_Lang_Unk");
            entity
                .Property(e => e.NameMaleLangZhCn)
                .HasMaxLength(100)
                .HasColumnName("Name_Male_Lang_zhCN");
            entity
                .Property(e => e.NameMaleLangZhTw)
                .HasMaxLength(100)
                .HasColumnName("Name_Male_Lang_zhTW");
            entity.Property(e => e.RequiredExpansion).HasColumnName("Required_Expansion");
            entity.Property(e => e.ResSicknessSpellId).HasColumnName("ResSicknessSpellID");
            entity.Property(e => e.SplashSoundId).HasColumnName("SplashSoundID");
        });

        modelBuilder.Entity<CinematiccameraDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("cinematiccamera_dbc", tb => tb.HasComment("Cinematic camera DBC"));

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.LocationX).HasColumnName("locationX");
            entity.Property(e => e.LocationY).HasColumnName("locationY");
            entity.Property(e => e.LocationZ).HasColumnName("locationZ");
            entity.Property(e => e.Model).HasMaxLength(100).HasColumnName("model");
            entity.Property(e => e.Rotation).HasColumnName("rotation");
            entity.Property(e => e.SoundEntry).HasColumnName("soundEntry");
        });

        modelBuilder.Entity<CinematicsequencesDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("cinematicsequences_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Camera1).HasColumnName("Camera_1");
            entity.Property(e => e.Camera2).HasColumnName("Camera_2");
            entity.Property(e => e.Camera3).HasColumnName("Camera_3");
            entity.Property(e => e.Camera4).HasColumnName("Camera_4");
            entity.Property(e => e.Camera5).HasColumnName("Camera_5");
            entity.Property(e => e.Camera6).HasColumnName("Camera_6");
            entity.Property(e => e.Camera7).HasColumnName("Camera_7");
            entity.Property(e => e.Camera8).HasColumnName("Camera_8");
            entity.Property(e => e.SoundId).HasColumnName("SoundID");
        });

        modelBuilder.Entity<Command>(entity =>
        {
            entity.HasKey(e => e.Name).HasName("PRIMARY");

            entity.ToTable("command", tb => tb.HasComment("Chat System"));

            entity
                .Property(e => e.Name)
                .HasMaxLength(50)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Help).HasColumnName("help");
            entity.Property(e => e.Security).HasColumnName("security");
        });

        modelBuilder.Entity<Condition>(entity =>
        {
            entity
                .HasKey(e => new
                {
                    e.SourceTypeOrReferenceId,
                    e.SourceGroup,
                    e.SourceEntry,
                    e.SourceId,
                    e.ElseGroup,
                    e.ConditionTypeOrReference,
                    e.ConditionTarget,
                    e.ConditionValue1,
                    e.ConditionValue2,
                    e.ConditionValue3
                })
                .HasName("PRIMARY");

            entity.ToTable("conditions", tb => tb.HasComment("Condition System"));

            entity.Property(e => e.Comment).HasMaxLength(255);
            entity
                .Property(e => e.ScriptName)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .IsFixedLength();
        });

        modelBuilder.Entity<Creature>(entity =>
        {
            entity.HasKey(e => e.Guid).HasName("PRIMARY");

            entity.ToTable("creature", tb => tb.HasComment("Creature System"));

            entity.HasIndex(e => e.Id1, "idx_id");

            entity.HasIndex(e => e.Map, "idx_map");

            entity
                .Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            entity.Property(e => e.AreaId).HasComment("Area Identifier").HasColumnName("areaId");
            entity.Property(e => e.Comment).HasColumnType("text");
            entity.Property(e => e.Curhealth).HasDefaultValueSql("'1'").HasColumnName("curhealth");
            entity.Property(e => e.Curmana).HasColumnName("curmana");
            entity.Property(e => e.Currentwaypoint).HasColumnName("currentwaypoint");
            entity.Property(e => e.Dynamicflags).HasColumnName("dynamicflags");
            entity.Property(e => e.EquipmentId).HasColumnName("equipment_id");
            entity.Property(e => e.Id1).HasComment("Creature Identifier").HasColumnName("id1");
            entity.Property(e => e.Id2).HasComment("Creature Identifier").HasColumnName("id2");
            entity.Property(e => e.Id3).HasComment("Creature Identifier").HasColumnName("id3");
            entity.Property(e => e.Map).HasComment("Map Identifier").HasColumnName("map");
            entity.Property(e => e.Npcflag).HasColumnName("npcflag");
            entity.Property(e => e.Orientation).HasColumnName("orientation");
            entity.Property(e => e.PhaseMask).HasDefaultValueSql("'1'").HasColumnName("phaseMask");
            entity.Property(e => e.PositionX).HasColumnName("position_x");
            entity.Property(e => e.PositionY).HasColumnName("position_y");
            entity.Property(e => e.PositionZ).HasColumnName("position_z");
            entity
                .Property(e => e.ScriptName)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.SpawnMask).HasDefaultValueSql("'1'").HasColumnName("spawnMask");
            entity
                .Property(e => e.Spawntimesecs)
                .HasDefaultValueSql("'120'")
                .HasColumnName("spawntimesecs");
            entity.Property(e => e.UnitFlags).HasColumnName("unit_flags");
            entity.Property(e => e.WanderDistance).HasColumnName("wander_distance");
            entity.Property(e => e.ZoneId).HasComment("Zone Identifier").HasColumnName("zoneId");
        });

        modelBuilder.Entity<CreatureAddon>(entity =>
        {
            entity.HasKey(e => e.Guid).HasName("PRIMARY");

            entity.ToTable("creature_addon");

            entity.Property(e => e.Guid).HasColumnName("guid");
            entity.Property(e => e.Auras).HasColumnType("text").HasColumnName("auras");
            entity.Property(e => e.Bytes1).HasColumnName("bytes1");
            entity.Property(e => e.Bytes2).HasColumnName("bytes2");
            entity.Property(e => e.Emote).HasColumnName("emote");
            entity.Property(e => e.Mount).HasColumnName("mount");
            entity.Property(e => e.PathId).HasColumnName("path_id");
            entity.Property(e => e.VisibilityDistanceType).HasColumnName("visibilityDistanceType");
        });

        modelBuilder.Entity<CreatureClasslevelstat>(entity =>
        {
            entity.HasKey(e => new { e.Level, e.Class }).HasName("PRIMARY");

            entity.ToTable("creature_classlevelstats");

            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.Class).HasColumnName("class");
            entity.Property(e => e.Attackpower).HasColumnName("attackpower");
            entity.Property(e => e.Basearmor).HasDefaultValueSql("'1'").HasColumnName("basearmor");
            entity.Property(e => e.Basehp0).HasDefaultValueSql("'1'").HasColumnName("basehp0");
            entity.Property(e => e.Basehp1).HasDefaultValueSql("'1'").HasColumnName("basehp1");
            entity.Property(e => e.Basehp2).HasDefaultValueSql("'1'").HasColumnName("basehp2");
            entity.Property(e => e.Basemana).HasColumnName("basemana");
            entity.Property(e => e.Comment).HasColumnType("text").HasColumnName("comment");
            entity.Property(e => e.DamageBase).HasColumnName("damage_base");
            entity.Property(e => e.DamageExp1).HasColumnName("damage_exp1");
            entity.Property(e => e.DamageExp2).HasColumnName("damage_exp2");
            entity.Property(e => e.Rangedattackpower).HasColumnName("rangedattackpower");
        });

        modelBuilder.Entity<CreatureEquipTemplate>(entity =>
        {
            entity.HasKey(e => new { e.CreatureId, e.Id }).HasName("PRIMARY");

            entity.ToTable("creature_equip_template");

            entity.Property(e => e.CreatureId).HasColumnName("CreatureID");
            entity.Property(e => e.Id).HasDefaultValueSql("'1'").HasColumnName("ID");
            entity.Property(e => e.ItemId1).HasColumnName("ItemID1");
            entity.Property(e => e.ItemId2).HasColumnName("ItemID2");
            entity.Property(e => e.ItemId3).HasColumnName("ItemID3");
        });

        modelBuilder.Entity<CreatureFormation>(entity =>
        {
            entity.HasKey(e => e.MemberGuid).HasName("PRIMARY");

            entity.ToTable("creature_formations");

            entity.Property(e => e.MemberGuid).HasColumnName("memberGUID");
            entity.Property(e => e.Angle).HasColumnName("angle");
            entity.Property(e => e.Dist).HasColumnName("dist");
            entity.Property(e => e.GroupAi).HasColumnName("groupAI");
            entity.Property(e => e.LeaderGuid).HasColumnName("leaderGUID");
            entity.Property(e => e.Point1).HasColumnName("point_1");
            entity.Property(e => e.Point2).HasColumnName("point_2");
        });

        modelBuilder.Entity<CreatureLootTemplate>(entity =>
        {
            entity
                .HasKey(e => new
                {
                    e.Entry,
                    e.Item,
                    e.Reference,
                    e.GroupId
                })
                .HasName("PRIMARY");

            entity.ToTable("creature_loot_template", tb => tb.HasComment("Loot System"));

            entity.Property(e => e.Chance).HasDefaultValueSql("'100'");
            entity.Property(e => e.Comment).HasMaxLength(255);
            entity.Property(e => e.LootMode).HasDefaultValueSql("'1'");
            entity.Property(e => e.MaxCount).HasDefaultValueSql("'1'");
            entity.Property(e => e.MinCount).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<CreatureModelInfo>(entity =>
        {
            entity.HasKey(e => e.DisplayId).HasName("PRIMARY");

            entity.ToTable(
                "creature_model_info",
                tb => tb.HasComment("Creature System (Model related info)")
            );

            entity.Property(e => e.DisplayId).HasColumnName("DisplayID");
            entity.Property(e => e.DisplayIdOtherGender).HasColumnName("DisplayID_Other_Gender");
            entity.Property(e => e.Gender).HasDefaultValueSql("'2'");
        });

        modelBuilder.Entity<CreatureMovementOverride>(entity =>
        {
            entity.HasKey(e => e.SpawnId).HasName("PRIMARY");

            entity.ToTable("creature_movement_override");

            entity
                .Property(e => e.InteractionPauseTimer)
                .HasComment(
                    "Time (in milliseconds) during which creature will not move after interaction with player"
                );
        });

        modelBuilder.Entity<CreatureOnkillReputation>(entity =>
        {
            entity.HasKey(e => e.CreatureId).HasName("PRIMARY");

            entity.ToTable(
                "creature_onkill_reputation",
                tb => tb.HasComment("Creature OnKill Reputation gain")
            );

            entity
                .Property(e => e.CreatureId)
                .HasComment("Creature Identifier")
                .HasColumnName("creature_id");
        });

        modelBuilder.Entity<CreatureQuestender>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Quest }).HasName("PRIMARY");

            entity.ToTable("creature_questender", tb => tb.HasComment("Creature System"));

            entity.Property(e => e.Id).HasComment("Identifier").HasColumnName("id");
            entity.Property(e => e.Quest).HasComment("Quest Identifier").HasColumnName("quest");
        });

        modelBuilder.Entity<CreatureQuestitem>(entity =>
        {
            entity.HasKey(e => new { e.CreatureEntry, e.Idx }).HasName("PRIMARY");

            entity.ToTable("creature_questitem");
        });

        modelBuilder.Entity<CreatureQueststarter>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Quest }).HasName("PRIMARY");

            entity.ToTable("creature_queststarter", tb => tb.HasComment("Creature System"));

            entity.Property(e => e.Id).HasComment("Identifier").HasColumnName("id");
            entity.Property(e => e.Quest).HasComment("Quest Identifier").HasColumnName("quest");
        });

        modelBuilder.Entity<CreatureSummonGroup>(entity =>
        {
            entity.HasNoKey().ToTable("creature_summon_groups");

            entity.Property(e => e.Comment).HasMaxLength(255).HasDefaultValueSql("''");
            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.GroupId).HasColumnName("groupId");
            entity.Property(e => e.Orientation).HasColumnName("orientation");
            entity.Property(e => e.PositionX).HasColumnName("position_x");
            entity.Property(e => e.PositionY).HasColumnName("position_y");
            entity.Property(e => e.PositionZ).HasColumnName("position_z");
            entity.Property(e => e.SummonTime).HasColumnName("summonTime");
            entity.Property(e => e.SummonType).HasColumnName("summonType");
            entity.Property(e => e.SummonerId).HasColumnName("summonerId");
            entity.Property(e => e.SummonerType).HasColumnName("summonerType");
        });

        modelBuilder.Entity<CreatureTemplate>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity.ToTable("creature_template", tb => tb.HasComment("Creature System"));

            entity.HasIndex(e => e.Name, "idx_name");

            entity.Property(e => e.Entry).HasColumnName("entry");
            entity
                .Property(e => e.Ainame)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .IsFixedLength()
                .HasColumnName("AIName");
            entity.Property(e => e.ArmorModifier).HasDefaultValueSql("'1'");
            entity.Property(e => e.BaseVariance).HasDefaultValueSql("'1'");
            entity.Property(e => e.DamageModifier).HasDefaultValueSql("'1'");
            entity
                .Property(e => e.DetectionRange)
                .HasDefaultValueSql("'20'")
                .HasColumnName("detection_range");
            entity.Property(e => e.DifficultyEntry1).HasColumnName("difficulty_entry_1");
            entity.Property(e => e.DifficultyEntry2).HasColumnName("difficulty_entry_2");
            entity.Property(e => e.DifficultyEntry3).HasColumnName("difficulty_entry_3");
            entity.Property(e => e.Dmgschool).HasColumnName("dmgschool");
            entity.Property(e => e.Dynamicflags).HasColumnName("dynamicflags");
            entity.Property(e => e.Exp).HasColumnName("exp");
            entity.Property(e => e.ExperienceModifier).HasDefaultValueSql("'1'");
            entity.Property(e => e.Faction).HasColumnName("faction");
            entity.Property(e => e.Family).HasColumnName("family");
            entity.Property(e => e.FlagsExtra).HasColumnName("flags_extra");
            entity.Property(e => e.GossipMenuId).HasColumnName("gossip_menu_id");
            entity.Property(e => e.HealthModifier).HasDefaultValueSql("'1'");
            entity.Property(e => e.HoverHeight).HasDefaultValueSql("'1'");
            entity.Property(e => e.IconName).HasMaxLength(100).IsFixedLength();
            entity.Property(e => e.Lootid).HasColumnName("lootid");
            entity.Property(e => e.ManaModifier).HasDefaultValueSql("'1'");
            entity.Property(e => e.Maxgold).HasColumnName("maxgold");
            entity.Property(e => e.Maxlevel).HasDefaultValueSql("'1'").HasColumnName("maxlevel");
            entity.Property(e => e.MechanicImmuneMask).HasColumnName("mechanic_immune_mask");
            entity.Property(e => e.Mingold).HasColumnName("mingold");
            entity.Property(e => e.Minlevel).HasDefaultValueSql("'1'").HasColumnName("minlevel");
            entity.Property(e => e.Modelid1).HasColumnName("modelid1");
            entity.Property(e => e.Modelid2).HasColumnName("modelid2");
            entity.Property(e => e.Modelid3).HasColumnName("modelid3");
            entity.Property(e => e.Modelid4).HasColumnName("modelid4");
            entity.Property(e => e.MovementId).HasColumnName("movementId");
            entity
                .Property(e => e.Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("'0'")
                .IsFixedLength()
                .HasColumnName("name");
            entity.Property(e => e.Npcflag).HasColumnName("npcflag");
            entity.Property(e => e.Pickpocketloot).HasColumnName("pickpocketloot");
            entity.Property(e => e.RangeVariance).HasDefaultValueSql("'1'");
            entity.Property(e => e.Rank).HasColumnName("rank");
            entity.Property(e => e.RegenHealth).HasDefaultValueSql("'1'");
            entity.Property(e => e.Scale).HasDefaultValueSql("'1'").HasColumnName("scale");
            entity
                .Property(e => e.ScriptName)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.Skinloot).HasColumnName("skinloot");
            entity
                .Property(e => e.SpeedFlight)
                .HasDefaultValueSql("'1'")
                .HasColumnName("speed_flight");
            entity
                .Property(e => e.SpeedRun)
                .HasDefaultValueSql("'1.14286'")
                .HasComment("Result of 8.0/7.0, most common value")
                .HasColumnName("speed_run");
            entity.Property(e => e.SpeedSwim).HasDefaultValueSql("'1'").HasColumnName("speed_swim");
            entity
                .Property(e => e.SpeedWalk)
                .HasDefaultValueSql("'1'")
                .HasComment("Result of 2.5/2.5, most common value")
                .HasColumnName("speed_walk");
            entity.Property(e => e.SpellSchoolImmuneMask).HasColumnName("spell_school_immune_mask");
            entity
                .Property(e => e.Subname)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("subname");
            entity.Property(e => e.TrainerClass).HasColumnName("trainer_class");
            entity.Property(e => e.TrainerRace).HasColumnName("trainer_race");
            entity.Property(e => e.TrainerSpell).HasColumnName("trainer_spell");
            entity.Property(e => e.TrainerType).HasColumnName("trainer_type");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.TypeFlags).HasColumnName("type_flags");
            entity.Property(e => e.UnitClass).HasColumnName("unit_class");
            entity.Property(e => e.UnitFlags).HasColumnName("unit_flags");
            entity.Property(e => e.UnitFlags2).HasColumnName("unit_flags2");
        });

        modelBuilder.Entity<CreatureTemplateAddon>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity.ToTable("creature_template_addon");

            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.Auras).HasColumnType("text").HasColumnName("auras");
            entity.Property(e => e.Bytes1).HasColumnName("bytes1");
            entity.Property(e => e.Bytes2).HasColumnName("bytes2");
            entity.Property(e => e.Emote).HasColumnName("emote");
            entity.Property(e => e.Mount).HasColumnName("mount");
            entity.Property(e => e.PathId).HasColumnName("path_id");
            entity.Property(e => e.VisibilityDistanceType).HasColumnName("visibilityDistanceType");
        });

        modelBuilder.Entity<CreatureTemplateLocale>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Locale }).HasName("PRIMARY");

            entity.ToTable("creature_template_locale");

            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.Locale).HasMaxLength(4).HasColumnName("locale");
            entity.Property(e => e.Name).HasColumnType("text");
            entity.Property(e => e.Title).HasColumnType("text");
        });

        modelBuilder.Entity<CreatureTemplateMovement>(entity =>
        {
            entity.HasKey(e => e.CreatureId).HasName("PRIMARY");

            entity.ToTable("creature_template_movement");

            entity
                .Property(e => e.InteractionPauseTimer)
                .HasComment(
                    "Time (in milliseconds) during which creature will not move after interaction with player"
                );
        });

        modelBuilder.Entity<CreatureTemplateResistance>(entity =>
        {
            entity.HasKey(e => new { e.CreatureId, e.School }).HasName("PRIMARY");

            entity.ToTable("creature_template_resistance");

            entity.Property(e => e.CreatureId).HasColumnName("CreatureID");
        });

        modelBuilder.Entity<CreatureTemplateSpell>(entity =>
        {
            entity.HasKey(e => new { e.CreatureId, e.Index }).HasName("PRIMARY");

            entity.ToTable("creature_template_spell");

            entity.Property(e => e.CreatureId).HasColumnName("CreatureID");
        });

        modelBuilder.Entity<CreatureText>(entity =>
        {
            entity
                .HasKey(e => new
                {
                    e.CreatureId,
                    e.GroupId,
                    e.Id
                })
                .HasName("PRIMARY");

            entity.ToTable("creature_text");

            entity.Property(e => e.CreatureId).HasColumnName("CreatureID");
            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity
                .Property(e => e.Comment)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("comment");
        });

        modelBuilder.Entity<CreatureTextLocale>(entity =>
        {
            entity
                .HasKey(e => new
                {
                    e.CreatureId,
                    e.GroupId,
                    e.Id,
                    e.Locale
                })
                .HasName("PRIMARY");

            entity.ToTable("creature_text_locale");

            entity.Property(e => e.CreatureId).HasColumnName("CreatureID");
            entity.Property(e => e.GroupId).HasColumnName("GroupID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Locale).HasMaxLength(4);
            entity.Property(e => e.Text).HasColumnType("text");
        });

        modelBuilder.Entity<CreaturedisplayinfoDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("creaturedisplayinfo_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BloodId).HasColumnName("BloodID");
            entity.Property(e => e.ExtendedDisplayInfoId).HasColumnName("ExtendedDisplayInfoID");
            entity.Property(e => e.ModelId).HasColumnName("ModelID");
            entity.Property(e => e.NpcsoundId).HasColumnName("NPCSoundID");
            entity.Property(e => e.ObjectEffectPackageId).HasColumnName("ObjectEffectPackageID");
            entity.Property(e => e.ParticleColorId).HasColumnName("ParticleColorID");
            entity.Property(e => e.PortraitTextureName).HasMaxLength(100);
            entity.Property(e => e.SoundId).HasColumnName("SoundID");
            entity
                .Property(e => e.TextureVariation1)
                .HasMaxLength(100)
                .HasColumnName("TextureVariation_1");
            entity
                .Property(e => e.TextureVariation2)
                .HasMaxLength(100)
                .HasColumnName("TextureVariation_2");
            entity
                .Property(e => e.TextureVariation3)
                .HasMaxLength(100)
                .HasColumnName("TextureVariation_3");
        });

        modelBuilder.Entity<CreaturedisplayinfoextraDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("creaturedisplayinfoextra_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BakeName).HasMaxLength(100);
            entity.Property(e => e.DisplayRaceId).HasColumnName("DisplayRaceID");
            entity.Property(e => e.DisplaySexId).HasColumnName("DisplaySexID");
            entity.Property(e => e.FaceId).HasColumnName("FaceID");
            entity.Property(e => e.FacialHairId).HasColumnName("FacialHairID");
            entity.Property(e => e.HairColorId).HasColumnName("HairColorID");
            entity.Property(e => e.HairStyleId).HasColumnName("HairStyleID");
            entity.Property(e => e.NpcitemDisplay1).HasColumnName("NPCItemDisplay1");
            entity.Property(e => e.NpcitemDisplay10).HasColumnName("NPCItemDisplay10");
            entity.Property(e => e.NpcitemDisplay11).HasColumnName("NPCItemDisplay11");
            entity.Property(e => e.NpcitemDisplay2).HasColumnName("NPCItemDisplay2");
            entity.Property(e => e.NpcitemDisplay3).HasColumnName("NPCItemDisplay3");
            entity.Property(e => e.NpcitemDisplay4).HasColumnName("NPCItemDisplay4");
            entity.Property(e => e.NpcitemDisplay5).HasColumnName("NPCItemDisplay5");
            entity.Property(e => e.NpcitemDisplay6).HasColumnName("NPCItemDisplay6");
            entity.Property(e => e.NpcitemDisplay7).HasColumnName("NPCItemDisplay7");
            entity.Property(e => e.NpcitemDisplay8).HasColumnName("NPCItemDisplay8");
            entity.Property(e => e.NpcitemDisplay9).HasColumnName("NPCItemDisplay9");
            entity.Property(e => e.SkinId).HasColumnName("SkinID");
        });

        modelBuilder.Entity<CreaturefamilyDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("creaturefamily_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CategoryEnumId).HasColumnName("CategoryEnumID");
            entity.Property(e => e.IconFile).HasMaxLength(100);
            entity.Property(e => e.NameLangDeDe).HasMaxLength(100).HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn).HasMaxLength(100).HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb).HasMaxLength(100).HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw).HasMaxLength(100).HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs).HasMaxLength(100).HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs).HasMaxLength(100).HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx).HasMaxLength(100).HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr).HasMaxLength(100).HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt).HasMaxLength(100).HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr).HasMaxLength(100).HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr).HasMaxLength(100).HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt).HasMaxLength(100).HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu).HasMaxLength(100).HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk).HasMaxLength(100).HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn).HasMaxLength(100).HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw).HasMaxLength(100).HasColumnName("Name_Lang_zhTW");
            entity.Property(e => e.SkillLine1).HasColumnName("SkillLine_1");
            entity.Property(e => e.SkillLine2).HasColumnName("SkillLine_2");
        });

        modelBuilder.Entity<CreaturemodeldataDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("creaturemodeldata_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BloodId).HasColumnName("BloodID");
            entity.Property(e => e.FoleyMaterialId).HasColumnName("FoleyMaterialID");
            entity.Property(e => e.FootprintTextureId).HasColumnName("FootprintTextureID");
            entity.Property(e => e.ModelName).HasMaxLength(100);
            entity.Property(e => e.SoundId).HasColumnName("SoundID");
        });

        modelBuilder.Entity<CreaturespelldataDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("creaturespelldata_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Availability1).HasColumnName("Availability_1");
            entity.Property(e => e.Availability2).HasColumnName("Availability_2");
            entity.Property(e => e.Availability3).HasColumnName("Availability_3");
            entity.Property(e => e.Availability4).HasColumnName("Availability_4");
            entity.Property(e => e.Spells1).HasColumnName("Spells_1");
            entity.Property(e => e.Spells2).HasColumnName("Spells_2");
            entity.Property(e => e.Spells3).HasColumnName("Spells_3");
            entity.Property(e => e.Spells4).HasColumnName("Spells_4");
        });

        modelBuilder.Entity<CreaturetypeDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("creaturetype_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.NameLangDeDe).HasMaxLength(100).HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn).HasMaxLength(100).HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb).HasMaxLength(100).HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw).HasMaxLength(100).HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs).HasMaxLength(100).HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs).HasMaxLength(100).HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx).HasMaxLength(100).HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr).HasMaxLength(100).HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt).HasMaxLength(100).HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr).HasMaxLength(100).HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr).HasMaxLength(100).HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt).HasMaxLength(100).HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu).HasMaxLength(100).HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk).HasMaxLength(100).HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn).HasMaxLength(100).HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw).HasMaxLength(100).HasColumnName("Name_Lang_zhTW");
        });

        modelBuilder.Entity<CurrencytypesDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("currencytypes_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.ItemId).HasColumnName("ItemID");
        });

        modelBuilder.Entity<DestructiblemodeldataDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("destructiblemodeldata_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<Disable>(entity =>
        {
            entity.HasKey(e => new { e.SourceType, e.Entry }).HasName("PRIMARY");

            entity.ToTable("disables");

            entity.Property(e => e.SourceType).HasColumnName("sourceType");
            entity.Property(e => e.Entry).HasColumnName("entry");
            entity
                .Property(e => e.Comment)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("comment");
            entity.Property(e => e.Flags).HasColumnName("flags");
            entity
                .Property(e => e.Params0)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("params_0");
            entity
                .Property(e => e.Params1)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("params_1");
        });

        modelBuilder.Entity<DisenchantLootTemplate>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Item }).HasName("PRIMARY");

            entity.ToTable("disenchant_loot_template", tb => tb.HasComment("Loot System"));

            entity.Property(e => e.Chance).HasDefaultValueSql("'100'");
            entity.Property(e => e.Comment).HasMaxLength(255);
            entity.Property(e => e.LootMode).HasDefaultValueSql("'1'");
            entity.Property(e => e.MaxCount).HasDefaultValueSql("'1'");
            entity.Property(e => e.MinCount).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<DungeonAccessRequirement>(entity =>
        {
            entity
                .HasKey(e => new
                {
                    e.DungeonAccessId,
                    e.RequirementType,
                    e.RequirementId
                })
                .HasName("PRIMARY");

            entity.ToTable(
                "dungeon_access_requirements",
                tb =>
                    tb.HasComment(
                        "Add (multiple) requirements before being able to enter a dungeon/raid"
                    )
            );

            entity
                .Property(e => e.DungeonAccessId)
                .HasComment("ID from dungeon_access_template")
                .HasColumnName("dungeon_access_id");
            entity
                .Property(e => e.RequirementType)
                .HasComment("0 = achiev, 1 = quest, 2 = item")
                .HasColumnName("requirement_type");
            entity
                .Property(e => e.RequirementId)
                .HasComment("Achiev/quest/item ID")
                .HasColumnName("requirement_id");
            entity.Property(e => e.Comment).HasMaxLength(255).HasColumnName("comment");
            entity
                .Property(e => e.Faction)
                .HasDefaultValueSql("'2'")
                .HasComment("0 = Alliance, 1 = Horde, 2 = Both factions")
                .HasColumnName("faction");
            entity
                .Property(e => e.LeaderOnly)
                .HasComment(
                    "0 = check the requirement for the player trying to enter, 1 = check the requirement for the party leader"
                )
                .HasColumnName("leader_only");
            entity
                .Property(e => e.Priority)
                .HasComment(
                    "Priority order for the requirement, sorted by type. 0 is the highest priority"
                )
                .HasColumnName("priority");
            entity
                .Property(e => e.RequirementNote)
                .HasMaxLength(255)
                .HasComment(
                    "Optional msg shown ingame to player if he cannot enter. You can add extra info"
                )
                .HasColumnName("requirement_note");
        });

        modelBuilder.Entity<DungeonAccessTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable(
                "dungeon_access_template",
                tb => tb.HasComment("Dungeon/raid access template and single requirements")
            );

            entity.HasIndex(e => e.MapId, "FK_dungeon_access_template__instance_template");

            entity
                .Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasComment("The dungeon template ID")
                .HasColumnName("id");
            entity
                .Property(e => e.Comment)
                .HasMaxLength(255)
                .HasComment("Dungeon Name 5/10/25/40 man - Normal/Heroic")
                .HasColumnName("comment");
            entity
                .Property(e => e.Difficulty)
                .HasComment(
                    "5 man: 0 = normal, 1 = heroic, 2 = epic (not implemented) | 10 man: 0 = normal, 2 = heroic | 25 man: 1 = normal, 3 = heroic"
                )
                .HasColumnName("difficulty");
            entity
                .Property(e => e.MapId)
                .HasComment("Map ID from instance_template")
                .HasColumnName("map_id");
            entity.Property(e => e.MaxLevel).HasColumnName("max_level");
            entity
                .Property(e => e.MinAvgItemLevel)
                .HasComment("Min average ilvl required to enter")
                .HasColumnName("min_avg_item_level");
            entity.Property(e => e.MinLevel).HasColumnName("min_level");
        });

        modelBuilder.Entity<DungeonencounterDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("dungeonencounter_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MapId).HasColumnName("MapID");
            entity.Property(e => e.NameLangDeDe).HasMaxLength(100).HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn).HasMaxLength(100).HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb).HasMaxLength(100).HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw).HasMaxLength(100).HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs).HasMaxLength(100).HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs).HasMaxLength(100).HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx).HasMaxLength(100).HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr).HasMaxLength(100).HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt).HasMaxLength(100).HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr).HasMaxLength(100).HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr).HasMaxLength(100).HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt).HasMaxLength(100).HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu).HasMaxLength(100).HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk).HasMaxLength(100).HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn).HasMaxLength(100).HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw).HasMaxLength(100).HasColumnName("Name_Lang_zhTW");
            entity.Property(e => e.SpellIconId).HasColumnName("SpellIconID");
        });

        modelBuilder.Entity<DurabilitycostsDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("durabilitycosts_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ArmorSubClassCost1).HasColumnName("ArmorSubClassCost_1");
            entity.Property(e => e.ArmorSubClassCost2).HasColumnName("ArmorSubClassCost_2");
            entity.Property(e => e.ArmorSubClassCost3).HasColumnName("ArmorSubClassCost_3");
            entity.Property(e => e.ArmorSubClassCost4).HasColumnName("ArmorSubClassCost_4");
            entity.Property(e => e.ArmorSubClassCost5).HasColumnName("ArmorSubClassCost_5");
            entity.Property(e => e.ArmorSubClassCost6).HasColumnName("ArmorSubClassCost_6");
            entity.Property(e => e.ArmorSubClassCost7).HasColumnName("ArmorSubClassCost_7");
            entity.Property(e => e.ArmorSubClassCost8).HasColumnName("ArmorSubClassCost_8");
            entity.Property(e => e.WeaponSubClassCost1).HasColumnName("WeaponSubClassCost_1");
            entity.Property(e => e.WeaponSubClassCost10).HasColumnName("WeaponSubClassCost_10");
            entity.Property(e => e.WeaponSubClassCost11).HasColumnName("WeaponSubClassCost_11");
            entity.Property(e => e.WeaponSubClassCost12).HasColumnName("WeaponSubClassCost_12");
            entity.Property(e => e.WeaponSubClassCost13).HasColumnName("WeaponSubClassCost_13");
            entity.Property(e => e.WeaponSubClassCost14).HasColumnName("WeaponSubClassCost_14");
            entity.Property(e => e.WeaponSubClassCost15).HasColumnName("WeaponSubClassCost_15");
            entity.Property(e => e.WeaponSubClassCost16).HasColumnName("WeaponSubClassCost_16");
            entity.Property(e => e.WeaponSubClassCost17).HasColumnName("WeaponSubClassCost_17");
            entity.Property(e => e.WeaponSubClassCost18).HasColumnName("WeaponSubClassCost_18");
            entity.Property(e => e.WeaponSubClassCost19).HasColumnName("WeaponSubClassCost_19");
            entity.Property(e => e.WeaponSubClassCost2).HasColumnName("WeaponSubClassCost_2");
            entity.Property(e => e.WeaponSubClassCost20).HasColumnName("WeaponSubClassCost_20");
            entity.Property(e => e.WeaponSubClassCost21).HasColumnName("WeaponSubClassCost_21");
            entity.Property(e => e.WeaponSubClassCost3).HasColumnName("WeaponSubClassCost_3");
            entity.Property(e => e.WeaponSubClassCost4).HasColumnName("WeaponSubClassCost_4");
            entity.Property(e => e.WeaponSubClassCost5).HasColumnName("WeaponSubClassCost_5");
            entity.Property(e => e.WeaponSubClassCost6).HasColumnName("WeaponSubClassCost_6");
            entity.Property(e => e.WeaponSubClassCost7).HasColumnName("WeaponSubClassCost_7");
            entity.Property(e => e.WeaponSubClassCost8).HasColumnName("WeaponSubClassCost_8");
            entity.Property(e => e.WeaponSubClassCost9).HasColumnName("WeaponSubClassCost_9");
        });

        modelBuilder.Entity<DurabilityqualityDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("durabilityquality_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<EmotesDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("emotes_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AnimId).HasColumnName("AnimID");
            entity.Property(e => e.EmoteSlashCommand).HasMaxLength(100);
            entity.Property(e => e.EventSoundId).HasColumnName("EventSoundID");
        });

        modelBuilder.Entity<EmotestextDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("emotestext_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.EmoteId).HasColumnName("EmoteID");
            entity.Property(e => e.EmoteText1).HasColumnName("EmoteText_1");
            entity.Property(e => e.EmoteText10).HasColumnName("EmoteText_10");
            entity.Property(e => e.EmoteText11).HasColumnName("EmoteText_11");
            entity.Property(e => e.EmoteText12).HasColumnName("EmoteText_12");
            entity.Property(e => e.EmoteText13).HasColumnName("EmoteText_13");
            entity.Property(e => e.EmoteText14).HasColumnName("EmoteText_14");
            entity.Property(e => e.EmoteText15).HasColumnName("EmoteText_15");
            entity.Property(e => e.EmoteText16).HasColumnName("EmoteText_16");
            entity.Property(e => e.EmoteText2).HasColumnName("EmoteText_2");
            entity.Property(e => e.EmoteText3).HasColumnName("EmoteText_3");
            entity.Property(e => e.EmoteText4).HasColumnName("EmoteText_4");
            entity.Property(e => e.EmoteText5).HasColumnName("EmoteText_5");
            entity.Property(e => e.EmoteText6).HasColumnName("EmoteText_6");
            entity.Property(e => e.EmoteText7).HasColumnName("EmoteText_7");
            entity.Property(e => e.EmoteText8).HasColumnName("EmoteText_8");
            entity.Property(e => e.EmoteText9).HasColumnName("EmoteText_9");
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<EventScript>(entity =>
        {
            entity.HasNoKey().ToTable("event_scripts");

            entity.Property(e => e.Command).HasColumnName("command");
            entity.Property(e => e.Dataint).HasColumnName("dataint");
            entity.Property(e => e.Datalong).HasColumnName("datalong");
            entity.Property(e => e.Datalong2).HasColumnName("datalong2");
            entity.Property(e => e.Delay).HasColumnName("delay");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.O).HasColumnName("o");
            entity.Property(e => e.X).HasColumnName("x");
            entity.Property(e => e.Y).HasColumnName("y");
            entity.Property(e => e.Z).HasColumnName("z");
        });

        modelBuilder.Entity<ExplorationBasexp>(entity =>
        {
            entity.HasKey(e => e.Level).HasName("PRIMARY");

            entity.ToTable("exploration_basexp", tb => tb.HasComment("Exploration System"));

            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.Basexp).HasColumnName("basexp");
        });

        modelBuilder.Entity<FactionDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("faction_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity
                .Property(e => e.DescriptionLangDeDe)
                .HasMaxLength(300)
                .HasColumnName("Description_Lang_deDE");
            entity
                .Property(e => e.DescriptionLangEnCn)
                .HasMaxLength(300)
                .HasColumnName("Description_Lang_enCN");
            entity
                .Property(e => e.DescriptionLangEnGb)
                .HasMaxLength(300)
                .HasColumnName("Description_Lang_enGB");
            entity
                .Property(e => e.DescriptionLangEnTw)
                .HasMaxLength(300)
                .HasColumnName("Description_Lang_enTW");
            entity
                .Property(e => e.DescriptionLangEnUs)
                .HasMaxLength(300)
                .HasColumnName("Description_Lang_enUS");
            entity
                .Property(e => e.DescriptionLangEsEs)
                .HasMaxLength(300)
                .HasColumnName("Description_Lang_esES");
            entity
                .Property(e => e.DescriptionLangEsMx)
                .HasMaxLength(300)
                .HasColumnName("Description_Lang_esMX");
            entity
                .Property(e => e.DescriptionLangFrFr)
                .HasMaxLength(300)
                .HasColumnName("Description_Lang_frFR");
            entity
                .Property(e => e.DescriptionLangItIt)
                .HasMaxLength(300)
                .HasColumnName("Description_Lang_itIT");
            entity
                .Property(e => e.DescriptionLangKoKr)
                .HasMaxLength(300)
                .HasColumnName("Description_Lang_koKR");
            entity.Property(e => e.DescriptionLangMask).HasColumnName("Description_Lang_Mask");
            entity
                .Property(e => e.DescriptionLangPtBr)
                .HasMaxLength(300)
                .HasColumnName("Description_Lang_ptBR");
            entity
                .Property(e => e.DescriptionLangPtPt)
                .HasMaxLength(300)
                .HasColumnName("Description_Lang_ptPT");
            entity
                .Property(e => e.DescriptionLangRuRu)
                .HasMaxLength(300)
                .HasColumnName("Description_Lang_ruRU");
            entity
                .Property(e => e.DescriptionLangUnk)
                .HasMaxLength(100)
                .HasColumnName("Description_Lang_Unk");
            entity
                .Property(e => e.DescriptionLangZhCn)
                .HasMaxLength(300)
                .HasColumnName("Description_Lang_zhCN");
            entity
                .Property(e => e.DescriptionLangZhTw)
                .HasMaxLength(300)
                .HasColumnName("Description_Lang_zhTW");
            entity.Property(e => e.NameLangDeDe).HasMaxLength(100).HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn).HasMaxLength(100).HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb).HasMaxLength(100).HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw).HasMaxLength(100).HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs).HasMaxLength(100).HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs).HasMaxLength(100).HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx).HasMaxLength(100).HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr).HasMaxLength(100).HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt).HasMaxLength(100).HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr).HasMaxLength(100).HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr).HasMaxLength(100).HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt).HasMaxLength(100).HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu).HasMaxLength(100).HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk).HasMaxLength(100).HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn).HasMaxLength(100).HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw).HasMaxLength(100).HasColumnName("Name_Lang_zhTW");
            entity.Property(e => e.ParentFactionCap1).HasColumnName("ParentFactionCap_1");
            entity.Property(e => e.ParentFactionCap2).HasColumnName("ParentFactionCap_2");
            entity.Property(e => e.ParentFactionId).HasColumnName("ParentFactionID");
            entity.Property(e => e.ParentFactionMod1).HasColumnName("ParentFactionMod_1");
            entity.Property(e => e.ParentFactionMod2).HasColumnName("ParentFactionMod_2");
            entity.Property(e => e.ReputationBase1).HasColumnName("ReputationBase_1");
            entity.Property(e => e.ReputationBase2).HasColumnName("ReputationBase_2");
            entity.Property(e => e.ReputationBase3).HasColumnName("ReputationBase_3");
            entity.Property(e => e.ReputationBase4).HasColumnName("ReputationBase_4");
            entity.Property(e => e.ReputationClassMask1).HasColumnName("ReputationClassMask_1");
            entity.Property(e => e.ReputationClassMask2).HasColumnName("ReputationClassMask_2");
            entity.Property(e => e.ReputationClassMask3).HasColumnName("ReputationClassMask_3");
            entity.Property(e => e.ReputationClassMask4).HasColumnName("ReputationClassMask_4");
            entity.Property(e => e.ReputationFlags1).HasColumnName("ReputationFlags_1");
            entity.Property(e => e.ReputationFlags2).HasColumnName("ReputationFlags_2");
            entity.Property(e => e.ReputationFlags3).HasColumnName("ReputationFlags_3");
            entity.Property(e => e.ReputationFlags4).HasColumnName("ReputationFlags_4");
            entity.Property(e => e.ReputationRaceMask1).HasColumnName("ReputationRaceMask_1");
            entity.Property(e => e.ReputationRaceMask2).HasColumnName("ReputationRaceMask_2");
            entity.Property(e => e.ReputationRaceMask3).HasColumnName("ReputationRaceMask_3");
            entity.Property(e => e.ReputationRaceMask4).HasColumnName("ReputationRaceMask_4");
        });

        modelBuilder.Entity<FactiontemplateDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("factiontemplate_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Enemies1).HasColumnName("Enemies_1");
            entity.Property(e => e.Enemies2).HasColumnName("Enemies_2");
            entity.Property(e => e.Enemies3).HasColumnName("Enemies_3");
            entity.Property(e => e.Enemies4).HasColumnName("Enemies_4");
            entity.Property(e => e.Friend1).HasColumnName("Friend_1");
            entity.Property(e => e.Friend2).HasColumnName("Friend_2");
            entity.Property(e => e.Friend3).HasColumnName("Friend_3");
            entity.Property(e => e.Friend4).HasColumnName("Friend_4");
        });

        modelBuilder.Entity<FishingLootTemplate>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Item }).HasName("PRIMARY");

            entity.ToTable("fishing_loot_template", tb => tb.HasComment("Loot System"));

            entity.Property(e => e.Chance).HasDefaultValueSql("'100'");
            entity.Property(e => e.Comment).HasMaxLength(255);
            entity.Property(e => e.LootMode).HasDefaultValueSql("'1'");
            entity.Property(e => e.MaxCount).HasDefaultValueSql("'1'");
            entity.Property(e => e.MinCount).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<GameEvent>(entity =>
        {
            entity.HasKey(e => e.EventEntry).HasName("PRIMARY");

            entity.ToTable("game_event");

            entity
                .Property(e => e.EventEntry)
                .HasComment("Entry of the game event")
                .HasColumnName("eventEntry");
            entity
                .Property(e => e.Announce)
                .HasDefaultValueSql("'2'")
                .HasComment("0 dont announce, 1 announce, 2 value from config")
                .HasColumnName("announce");
            entity
                .Property(e => e.Description)
                .HasMaxLength(255)
                .HasComment("Description of the event displayed in console")
                .HasColumnName("description");
            entity
                .Property(e => e.EndTime)
                .HasDefaultValueSql("'2000-01-01 17:00:00'")
                .HasComment("Absolute end date, the event will never start after")
                .HasColumnType("timestamp")
                .HasColumnName("end_time");
            entity
                .Property(e => e.Holiday)
                .HasComment("Client side holiday id")
                .HasColumnName("holiday");
            entity.Property(e => e.HolidayStage).HasColumnName("holidayStage");
            entity
                .Property(e => e.Length)
                .HasDefaultValueSql("'2592000'")
                .HasComment("Length in minutes of the event")
                .HasColumnName("length");
            entity
                .Property(e => e.Occurence)
                .HasDefaultValueSql("'5184000'")
                .HasComment("Delay in minutes between occurences of the event")
                .HasColumnName("occurence");
            entity
                .Property(e => e.StartTime)
                .HasDefaultValueSql("'2000-01-01 17:00:00'")
                .HasComment("Absolute start date, the event will never start before")
                .HasColumnType("timestamp")
                .HasColumnName("start_time");
            entity
                .Property(e => e.WorldEvent)
                .HasComment("0 if normal event, 1 if world event")
                .HasColumnName("world_event");
        });

        modelBuilder.Entity<GameEventArenaSeason>(entity =>
        {
            entity.HasNoKey().ToTable("game_event_arena_seasons");

            entity.HasIndex(e => new { e.Season, e.EventEntry }, "season").IsUnique();

            entity
                .Property(e => e.EventEntry)
                .HasComment("Entry of the game event")
                .HasColumnName("eventEntry");
            entity
                .Property(e => e.Season)
                .HasComment("Arena season number")
                .HasColumnName("season");
        });

        modelBuilder.Entity<GameEventBattlegroundHoliday>(entity =>
        {
            entity.HasKey(e => e.EventEntry).HasName("PRIMARY");

            entity.ToTable("game_event_battleground_holiday");

            entity
                .Property(e => e.EventEntry)
                .HasComment("Entry of the game event")
                .HasColumnName("eventEntry");
            entity.Property(e => e.Bgflag).HasColumnName("bgflag");
        });

        modelBuilder.Entity<GameEventCondition>(entity =>
        {
            entity.HasKey(e => new { e.EventEntry, e.ConditionId }).HasName("PRIMARY");

            entity.ToTable("game_event_condition");

            entity
                .Property(e => e.EventEntry)
                .HasComment("Entry of the game event")
                .HasColumnName("eventEntry");
            entity.Property(e => e.ConditionId).HasColumnName("condition_id");
            entity
                .Property(e => e.Description)
                .HasMaxLength(25)
                .HasDefaultValueSql("''")
                .HasColumnName("description");
            entity.Property(e => e.DoneWorldStateField).HasColumnName("done_world_state_field");
            entity.Property(e => e.MaxWorldStateField).HasColumnName("max_world_state_field");
            entity.Property(e => e.ReqNum).HasDefaultValueSql("'0'").HasColumnName("req_num");
        });

        modelBuilder.Entity<GameEventCreature>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.EventEntry }).HasName("PRIMARY");

            entity.ToTable("game_event_creature");

            entity.Property(e => e.Guid).HasColumnName("guid");
            entity
                .Property(e => e.EventEntry)
                .HasComment("Entry of the game event. Put negative entry to remove during event.")
                .HasColumnName("eventEntry");
        });

        modelBuilder.Entity<GameEventCreatureQuest>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Quest }).HasName("PRIMARY");

            entity.ToTable("game_event_creature_quest");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Quest).HasColumnName("quest");
            entity
                .Property(e => e.EventEntry)
                .HasComment("Entry of the game event.")
                .HasColumnName("eventEntry");
        });

        modelBuilder.Entity<GameEventGameobject>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.EventEntry }).HasName("PRIMARY");

            entity.ToTable("game_event_gameobject");

            entity.Property(e => e.Guid).HasColumnName("guid");
            entity
                .Property(e => e.EventEntry)
                .HasComment("Entry of the game event. Put negative entry to remove during event.")
                .HasColumnName("eventEntry");
        });

        modelBuilder.Entity<GameEventGameobjectQuest>(entity =>
        {
            entity
                .HasKey(e => new
                {
                    e.Id,
                    e.Quest,
                    e.EventEntry
                })
                .HasName("PRIMARY");

            entity.ToTable("game_event_gameobject_quest");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Quest).HasColumnName("quest");
            entity
                .Property(e => e.EventEntry)
                .HasComment("Entry of the game event")
                .HasColumnName("eventEntry");
        });

        modelBuilder.Entity<GameEventModelEquip>(entity =>
        {
            entity.HasKey(e => e.Guid).HasName("PRIMARY");

            entity.ToTable("game_event_model_equip");

            entity.Property(e => e.Guid).HasColumnName("guid");
            entity.Property(e => e.EquipmentId).HasColumnName("equipment_id");
            entity
                .Property(e => e.EventEntry)
                .HasComment("Entry of the game event.")
                .HasColumnName("eventEntry");
            entity.Property(e => e.Modelid).HasColumnName("modelid");
        });

        modelBuilder.Entity<GameEventNpcVendor>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.Item }).HasName("PRIMARY");

            entity.ToTable("game_event_npc_vendor");

            entity.HasIndex(e => e.Slot, "slot");

            entity.Property(e => e.Guid).HasColumnName("guid");
            entity.Property(e => e.Item).HasColumnName("item");
            entity
                .Property(e => e.EventEntry)
                .HasComment("Entry of the game event.")
                .HasColumnName("eventEntry");
            entity.Property(e => e.Incrtime).HasColumnName("incrtime");
            entity.Property(e => e.Maxcount).HasColumnName("maxcount");
            entity.Property(e => e.Slot).HasColumnName("slot");
        });

        modelBuilder.Entity<GameEventNpcflag>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.EventEntry }).HasName("PRIMARY");

            entity.ToTable("game_event_npcflag");

            entity.Property(e => e.Guid).HasColumnName("guid");
            entity
                .Property(e => e.EventEntry)
                .HasComment("Entry of the game event")
                .HasColumnName("eventEntry");
            entity.Property(e => e.Npcflag).HasColumnName("npcflag");
        });

        modelBuilder.Entity<GameEventPool>(entity =>
        {
            entity.HasKey(e => e.PoolEntry).HasName("PRIMARY");

            entity.ToTable("game_event_pool");

            entity
                .Property(e => e.PoolEntry)
                .HasComment("Id of the pool")
                .HasColumnName("pool_entry");
            entity
                .Property(e => e.EventEntry)
                .HasComment("Entry of the game event. Put negative entry to remove during event.")
                .HasColumnName("eventEntry");
        });

        modelBuilder.Entity<GameEventPrerequisite>(entity =>
        {
            entity.HasKey(e => new { e.EventEntry, e.PrerequisiteEvent }).HasName("PRIMARY");

            entity.ToTable("game_event_prerequisite");

            entity
                .Property(e => e.EventEntry)
                .HasComment("Entry of the game event")
                .HasColumnName("eventEntry");
            entity.Property(e => e.PrerequisiteEvent).HasColumnName("prerequisite_event");
        });

        modelBuilder.Entity<GameEventQuestCondition>(entity =>
        {
            entity.HasKey(e => e.Quest).HasName("PRIMARY");

            entity.ToTable("game_event_quest_condition");

            entity.Property(e => e.Quest).HasColumnName("quest");
            entity.Property(e => e.ConditionId).HasColumnName("condition_id");
            entity
                .Property(e => e.EventEntry)
                .HasComment("Entry of the game event.")
                .HasColumnName("eventEntry");
            entity.Property(e => e.Num).HasDefaultValueSql("'0'").HasColumnName("num");
        });

        modelBuilder.Entity<GameEventSeasonalQuestrelation>(entity =>
        {
            entity.HasKey(e => new { e.QuestId, e.EventEntry }).HasName("PRIMARY");

            entity.ToTable(
                "game_event_seasonal_questrelation",
                tb => tb.HasComment("Player System")
            );

            entity.HasIndex(e => e.QuestId, "idx_quest");

            entity.Property(e => e.QuestId).HasComment("Quest Identifier").HasColumnName("questId");
            entity
                .Property(e => e.EventEntry)
                .HasComment("Entry of the game event")
                .HasColumnName("eventEntry");
        });

        modelBuilder.Entity<GameGraveyard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("game_graveyard");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Comment).HasMaxLength(255);
            entity.Property(e => e.X).HasColumnName("x");
            entity.Property(e => e.Y).HasColumnName("y");
            entity.Property(e => e.Z).HasColumnName("z");
        });

        modelBuilder.Entity<GameTele>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("game_tele", tb => tb.HasComment("Tele Command"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Map).HasColumnName("map");
            entity
                .Property(e => e.Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Orientation).HasColumnName("orientation");
            entity.Property(e => e.PositionX).HasColumnName("position_x");
            entity.Property(e => e.PositionY).HasColumnName("position_y");
            entity.Property(e => e.PositionZ).HasColumnName("position_z");
        });

        modelBuilder.Entity<GameWeather>(entity =>
        {
            entity.HasKey(e => e.Zone).HasName("PRIMARY");

            entity.ToTable("game_weather", tb => tb.HasComment("Weather System"));

            entity.Property(e => e.Zone).HasColumnName("zone");
            entity
                .Property(e => e.FallRainChance)
                .HasDefaultValueSql("'25'")
                .HasColumnName("fall_rain_chance");
            entity
                .Property(e => e.FallSnowChance)
                .HasDefaultValueSql("'25'")
                .HasColumnName("fall_snow_chance");
            entity
                .Property(e => e.FallStormChance)
                .HasDefaultValueSql("'25'")
                .HasColumnName("fall_storm_chance");
            entity
                .Property(e => e.ScriptName)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity
                .Property(e => e.SpringRainChance)
                .HasDefaultValueSql("'25'")
                .HasColumnName("spring_rain_chance");
            entity
                .Property(e => e.SpringSnowChance)
                .HasDefaultValueSql("'25'")
                .HasColumnName("spring_snow_chance");
            entity
                .Property(e => e.SpringStormChance)
                .HasDefaultValueSql("'25'")
                .HasColumnName("spring_storm_chance");
            entity
                .Property(e => e.SummerRainChance)
                .HasDefaultValueSql("'25'")
                .HasColumnName("summer_rain_chance");
            entity
                .Property(e => e.SummerSnowChance)
                .HasDefaultValueSql("'25'")
                .HasColumnName("summer_snow_chance");
            entity
                .Property(e => e.SummerStormChance)
                .HasDefaultValueSql("'25'")
                .HasColumnName("summer_storm_chance");
            entity
                .Property(e => e.WinterRainChance)
                .HasDefaultValueSql("'25'")
                .HasColumnName("winter_rain_chance");
            entity
                .Property(e => e.WinterSnowChance)
                .HasDefaultValueSql("'25'")
                .HasColumnName("winter_snow_chance");
            entity
                .Property(e => e.WinterStormChance)
                .HasDefaultValueSql("'25'")
                .HasColumnName("winter_storm_chance");
        });

        modelBuilder.Entity<Gameobject>(entity =>
        {
            entity.HasKey(e => e.Guid).HasName("PRIMARY");

            entity.ToTable("gameobject", tb => tb.HasComment("Gameobject System"));

            entity
                .Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            entity.Property(e => e.Animprogress).HasColumnName("animprogress");
            entity.Property(e => e.AreaId).HasComment("Area Identifier").HasColumnName("areaId");
            entity.Property(e => e.Comment).HasColumnType("text");
            entity.Property(e => e.Id).HasComment("Gameobject Identifier").HasColumnName("id");
            entity.Property(e => e.Map).HasComment("Map Identifier").HasColumnName("map");
            entity.Property(e => e.Orientation).HasColumnName("orientation");
            entity.Property(e => e.PhaseMask).HasDefaultValueSql("'1'").HasColumnName("phaseMask");
            entity.Property(e => e.PositionX).HasColumnName("position_x");
            entity.Property(e => e.PositionY).HasColumnName("position_y");
            entity.Property(e => e.PositionZ).HasColumnName("position_z");
            entity.Property(e => e.Rotation0).HasColumnName("rotation0");
            entity.Property(e => e.Rotation1).HasColumnName("rotation1");
            entity.Property(e => e.Rotation2).HasColumnName("rotation2");
            entity.Property(e => e.Rotation3).HasColumnName("rotation3");
            entity
                .Property(e => e.ScriptName)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .IsFixedLength();
            entity.Property(e => e.SpawnMask).HasDefaultValueSql("'1'").HasColumnName("spawnMask");
            entity.Property(e => e.Spawntimesecs).HasColumnName("spawntimesecs");
            entity.Property(e => e.State).HasColumnName("state");
            entity.Property(e => e.ZoneId).HasComment("Zone Identifier").HasColumnName("zoneId");
        });

        modelBuilder.Entity<GameobjectAddon>(entity =>
        {
            entity.HasKey(e => e.Guid).HasName("PRIMARY");

            entity.ToTable("gameobject_addon");

            entity.Property(e => e.Guid).HasColumnName("guid");
            entity.Property(e => e.InvisibilityType).HasColumnName("invisibilityType");
            entity.Property(e => e.InvisibilityValue).HasColumnName("invisibilityValue");
        });

        modelBuilder.Entity<GameobjectLootTemplate>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Item }).HasName("PRIMARY");

            entity.ToTable("gameobject_loot_template", tb => tb.HasComment("Loot System"));

            entity.Property(e => e.Chance).HasDefaultValueSql("'100'");
            entity.Property(e => e.Comment).HasMaxLength(255);
            entity.Property(e => e.LootMode).HasDefaultValueSql("'1'");
            entity.Property(e => e.MaxCount).HasDefaultValueSql("'1'");
            entity.Property(e => e.MinCount).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<GameobjectQuestender>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Quest }).HasName("PRIMARY");

            entity.ToTable("gameobject_questender");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Quest).HasComment("Quest Identifier").HasColumnName("quest");
        });

        modelBuilder.Entity<GameobjectQuestitem>(entity =>
        {
            entity.HasKey(e => new { e.GameObjectEntry, e.Idx }).HasName("PRIMARY");

            entity.ToTable("gameobject_questitem");
        });

        modelBuilder.Entity<GameobjectQueststarter>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Quest }).HasName("PRIMARY");

            entity.ToTable("gameobject_queststarter");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Quest).HasComment("Quest Identifier").HasColumnName("quest");
        });

        modelBuilder.Entity<GameobjectTemplate>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity.ToTable("gameobject_template", tb => tb.HasComment("Gameobject System"));

            entity.HasIndex(e => e.Name, "idx_name");

            entity.Property(e => e.Entry).HasColumnName("entry");
            entity
                .Property(e => e.Ainame)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .IsFixedLength()
                .HasColumnName("AIName");
            entity
                .Property(e => e.CastBarCaption)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("castBarCaption");
            entity.Property(e => e.DisplayId).HasColumnName("displayId");
            entity.Property(e => e.IconName).HasMaxLength(100).HasDefaultValueSql("''");
            entity
                .Property(e => e.Name)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.ScriptName).HasMaxLength(64).HasDefaultValueSql("''");
            entity.Property(e => e.Size).HasDefaultValueSql("'1'").HasColumnName("size");
            entity.Property(e => e.Type).HasColumnName("type");
            entity
                .Property(e => e.Unk1)
                .HasMaxLength(100)
                .HasDefaultValueSql("''")
                .HasColumnName("unk1");
        });

        modelBuilder.Entity<GameobjectTemplateAddon>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity.ToTable("gameobject_template_addon");

            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.Artkit0).HasColumnName("artkit0");
            entity.Property(e => e.Artkit1).HasColumnName("artkit1");
            entity.Property(e => e.Artkit2).HasColumnName("artkit2");
            entity.Property(e => e.Artkit3).HasColumnName("artkit3");
            entity.Property(e => e.Faction).HasColumnName("faction");
            entity.Property(e => e.Flags).HasColumnName("flags");
            entity.Property(e => e.Maxgold).HasColumnName("maxgold");
            entity.Property(e => e.Mingold).HasColumnName("mingold");
        });

        modelBuilder.Entity<GameobjectTemplateLocale>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Locale }).HasName("PRIMARY");

            entity.ToTable("gameobject_template_locale");

            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.Locale).HasMaxLength(4).HasColumnName("locale");
            entity
                .Property(e => e.CastBarCaption)
                .HasColumnType("text")
                .HasColumnName("castBarCaption");
            entity.Property(e => e.Name).HasColumnType("text").HasColumnName("name");
        });

        modelBuilder.Entity<GameobjectartkitDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("gameobjectartkit_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AttachModel1).HasColumnName("Attach_Model_1");
            entity.Property(e => e.AttachModel2).HasColumnName("Attach_Model_2");
            entity.Property(e => e.AttachModel3).HasColumnName("Attach_Model_3");
            entity.Property(e => e.AttachModel4).HasColumnName("Attach_Model_4");
            entity.Property(e => e.Texture1).HasColumnName("Texture_1");
            entity.Property(e => e.Texture2).HasColumnName("Texture_2");
            entity.Property(e => e.Texture3).HasColumnName("Texture_3");
        });

        modelBuilder.Entity<GameobjectdisplayinfoDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("gameobjectdisplayinfo_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ModelName).HasMaxLength(200);
            entity.Property(e => e.ObjectEffectPackageId).HasColumnName("ObjectEffectPackageID");
            entity.Property(e => e.Sound1).HasColumnName("Sound_1");
            entity.Property(e => e.Sound10).HasColumnName("Sound_10");
            entity.Property(e => e.Sound2).HasColumnName("Sound_2");
            entity.Property(e => e.Sound3).HasColumnName("Sound_3");
            entity.Property(e => e.Sound4).HasColumnName("Sound_4");
            entity.Property(e => e.Sound5).HasColumnName("Sound_5");
            entity.Property(e => e.Sound6).HasColumnName("Sound_6");
            entity.Property(e => e.Sound7).HasColumnName("Sound_7");
            entity.Property(e => e.Sound8).HasColumnName("Sound_8");
            entity.Property(e => e.Sound9).HasColumnName("Sound_9");
        });

        modelBuilder.Entity<GempropertiesDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("gemproperties_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.EnchantId).HasColumnName("Enchant_Id");
            entity.Property(e => e.MaxcountInv).HasColumnName("Maxcount_Inv");
            entity.Property(e => e.MaxcountItem).HasColumnName("Maxcount_Item");
        });

        modelBuilder.Entity<GlyphpropertiesDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("glyphproperties_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.SpellIconId).HasColumnName("SpellIconID");
            entity.Property(e => e.SpellId).HasColumnName("SpellID");
        });

        modelBuilder.Entity<GlyphslotDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("glyphslot_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<GossipMenu>(entity =>
        {
            entity.HasKey(e => new { e.MenuId, e.TextId }).HasName("PRIMARY");

            entity.ToTable("gossip_menu");

            entity.Property(e => e.MenuId).HasColumnName("MenuID");
            entity.Property(e => e.TextId).HasColumnName("TextID");
        });

        modelBuilder.Entity<GossipMenuOption>(entity =>
        {
            entity.HasKey(e => new { e.MenuId, e.OptionId }).HasName("PRIMARY");

            entity.ToTable("gossip_menu_option");

            entity.Property(e => e.MenuId).HasColumnName("MenuID");
            entity.Property(e => e.OptionId).HasColumnName("OptionID");
            entity.Property(e => e.ActionMenuId).HasColumnName("ActionMenuID");
            entity.Property(e => e.ActionPoiId).HasColumnName("ActionPoiID");
            entity.Property(e => e.BoxBroadcastTextId).HasColumnName("BoxBroadcastTextID");
            entity.Property(e => e.BoxText).HasColumnType("text");
            entity.Property(e => e.OptionBroadcastTextId).HasColumnName("OptionBroadcastTextID");
            entity.Property(e => e.OptionText).HasColumnType("text");
        });

        modelBuilder.Entity<GossipMenuOptionLocale>(entity =>
        {
            entity
                .HasKey(e => new
                {
                    e.MenuId,
                    e.OptionId,
                    e.Locale
                })
                .HasName("PRIMARY");

            entity.ToTable("gossip_menu_option_locale");

            entity.Property(e => e.MenuId).HasColumnName("MenuID");
            entity.Property(e => e.OptionId).HasColumnName("OptionID");
            entity.Property(e => e.Locale).HasMaxLength(4);
            entity.Property(e => e.BoxText).HasColumnType("text");
            entity.Property(e => e.OptionText).HasColumnType("text");
        });

        modelBuilder.Entity<GraveyardZone>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.GhostZone }).HasName("PRIMARY");

            entity.ToTable("graveyard_zone", tb => tb.HasComment("Trigger System"));

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Comment).HasColumnType("text");
        });

        modelBuilder.Entity<GtbarbershopcostbaseDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("gtbarbershopcostbase_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<GtchancetomeleecritDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("gtchancetomeleecrit_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<GtchancetomeleecritbaseDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("gtchancetomeleecritbase_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<GtchancetospellcritDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("gtchancetospellcrit_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<GtchancetospellcritbaseDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("gtchancetospellcritbase_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<GtcombatratingsDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("gtcombatratings_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<GtnpcmanacostscalerDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("gtnpcmanacostscaler_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<GtoctclasscombatratingscalarDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("gtoctclasscombatratingscalar_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<GtoctregenhpDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("gtoctregenhp_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<GtregenhppersptDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("gtregenhpperspt_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<GtregenmppersptDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("gtregenmpperspt_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<HolidayDate>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.DateId }).HasName("PRIMARY");

            entity.ToTable("holiday_dates");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DateId).HasColumnName("date_id");
            entity.Property(e => e.DateValue).HasColumnName("date_value");
            entity.Property(e => e.HolidayDuration).HasColumnName("holiday_duration");
        });

        modelBuilder.Entity<HolidaysDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("holidays_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CalendarFlags1).HasColumnName("CalendarFlags_1");
            entity.Property(e => e.CalendarFlags10).HasColumnName("CalendarFlags_10");
            entity.Property(e => e.CalendarFlags2).HasColumnName("CalendarFlags_2");
            entity.Property(e => e.CalendarFlags3).HasColumnName("CalendarFlags_3");
            entity.Property(e => e.CalendarFlags4).HasColumnName("CalendarFlags_4");
            entity.Property(e => e.CalendarFlags5).HasColumnName("CalendarFlags_5");
            entity.Property(e => e.CalendarFlags6).HasColumnName("CalendarFlags_6");
            entity.Property(e => e.CalendarFlags7).HasColumnName("CalendarFlags_7");
            entity.Property(e => e.CalendarFlags8).HasColumnName("CalendarFlags_8");
            entity.Property(e => e.CalendarFlags9).HasColumnName("CalendarFlags_9");
            entity.Property(e => e.Date1).HasColumnName("Date_1");
            entity.Property(e => e.Date10).HasColumnName("Date_10");
            entity.Property(e => e.Date11).HasColumnName("Date_11");
            entity.Property(e => e.Date12).HasColumnName("Date_12");
            entity.Property(e => e.Date13).HasColumnName("Date_13");
            entity.Property(e => e.Date14).HasColumnName("Date_14");
            entity.Property(e => e.Date15).HasColumnName("Date_15");
            entity.Property(e => e.Date16).HasColumnName("Date_16");
            entity.Property(e => e.Date17).HasColumnName("Date_17");
            entity.Property(e => e.Date18).HasColumnName("Date_18");
            entity.Property(e => e.Date19).HasColumnName("Date_19");
            entity.Property(e => e.Date2).HasColumnName("Date_2");
            entity.Property(e => e.Date20).HasColumnName("Date_20");
            entity.Property(e => e.Date21).HasColumnName("Date_21");
            entity.Property(e => e.Date22).HasColumnName("Date_22");
            entity.Property(e => e.Date23).HasColumnName("Date_23");
            entity.Property(e => e.Date24).HasColumnName("Date_24");
            entity.Property(e => e.Date25).HasColumnName("Date_25");
            entity.Property(e => e.Date26).HasColumnName("Date_26");
            entity.Property(e => e.Date3).HasColumnName("Date_3");
            entity.Property(e => e.Date4).HasColumnName("Date_4");
            entity.Property(e => e.Date5).HasColumnName("Date_5");
            entity.Property(e => e.Date6).HasColumnName("Date_6");
            entity.Property(e => e.Date7).HasColumnName("Date_7");
            entity.Property(e => e.Date8).HasColumnName("Date_8");
            entity.Property(e => e.Date9).HasColumnName("Date_9");
            entity.Property(e => e.Duration1).HasColumnName("Duration_1");
            entity.Property(e => e.Duration10).HasColumnName("Duration_10");
            entity.Property(e => e.Duration2).HasColumnName("Duration_2");
            entity.Property(e => e.Duration3).HasColumnName("Duration_3");
            entity.Property(e => e.Duration4).HasColumnName("Duration_4");
            entity.Property(e => e.Duration5).HasColumnName("Duration_5");
            entity.Property(e => e.Duration6).HasColumnName("Duration_6");
            entity.Property(e => e.Duration7).HasColumnName("Duration_7");
            entity.Property(e => e.Duration8).HasColumnName("Duration_8");
            entity.Property(e => e.Duration9).HasColumnName("Duration_9");
            entity.Property(e => e.HolidayDescriptionId).HasColumnName("HolidayDescriptionID");
            entity.Property(e => e.HolidayNameId).HasColumnName("HolidayNameID");
            entity.Property(e => e.TextureFilename).HasMaxLength(100);
        });

        modelBuilder.Entity<InstanceEncounter>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity.ToTable("instance_encounters");

            entity
                .Property(e => e.Entry)
                .HasComment("Unique entry from DungeonEncounter.dbc")
                .HasColumnName("entry");
            entity
                .Property(e => e.Comment)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("comment");
            entity.Property(e => e.CreditEntry).HasColumnName("creditEntry");
            entity.Property(e => e.CreditType).HasColumnName("creditType");
            entity
                .Property(e => e.LastEncounterDungeon)
                .HasComment(
                    "If not 0, LfgDungeon.dbc entry for the instance it is last encounter in"
                )
                .HasColumnName("lastEncounterDungeon");
        });

        modelBuilder.Entity<InstanceTemplate>(entity =>
        {
            entity.HasKey(e => e.Map).HasName("PRIMARY");

            entity.ToTable("instance_template");

            entity.Property(e => e.Map).HasColumnName("map");
            entity.Property(e => e.AllowMount).HasColumnName("allowMount");
            entity.Property(e => e.Parent).HasColumnName("parent");
            entity
                .Property(e => e.Script)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("script");
        });

        modelBuilder.Entity<ItemDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("item_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.DisplayInfoId).HasColumnName("DisplayInfoID");
            entity
                .Property(e => e.SoundOverrideSubclassid)
                .HasColumnName("Sound_Override_Subclassid");
            entity.Property(e => e.SubclassId).HasColumnName("SubclassID");
        });

        modelBuilder.Entity<ItemEnchantmentTemplate>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Ench }).HasName("PRIMARY");

            entity.ToTable(
                "item_enchantment_template",
                tb => tb.HasComment("Item Random Enchantment System")
            );

            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.Ench).HasColumnName("ench");
            entity.Property(e => e.Chance).HasColumnName("chance");
        });

        modelBuilder.Entity<ItemLootTemplate>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Item }).HasName("PRIMARY");

            entity.ToTable("item_loot_template", tb => tb.HasComment("Loot System"));

            entity.Property(e => e.Chance).HasDefaultValueSql("'100'");
            entity.Property(e => e.Comment).HasMaxLength(255);
            entity.Property(e => e.LootMode).HasDefaultValueSql("'1'");
            entity.Property(e => e.MaxCount).HasDefaultValueSql("'1'");
            entity.Property(e => e.MinCount).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<ItemSetName>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity.ToTable("item_set_names");

            entity.Property(e => e.Entry).HasColumnName("entry");
            entity
                .Property(e => e.Name)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
        });

        modelBuilder.Entity<ItemSetNamesLocale>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Locale }).HasName("PRIMARY");

            entity.ToTable("item_set_names_locale");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Locale).HasMaxLength(4).HasColumnName("locale");
            entity.Property(e => e.Name).HasColumnType("text");
        });

        modelBuilder.Entity<ItemTemplate>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity.ToTable("item_template", tb => tb.HasComment("Item System"));

            entity.HasIndex(e => e.Name, "idx_name");

            entity.HasIndex(e => e.Class, "items_index");

            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.AllowableClass).HasDefaultValueSql("'-1'");
            entity.Property(e => e.AllowableRace).HasDefaultValueSql("'-1'");
            entity.Property(e => e.AmmoType).HasColumnName("ammo_type");
            entity.Property(e => e.ArcaneRes).HasColumnName("arcane_res");
            entity.Property(e => e.Area).HasColumnName("area");
            entity.Property(e => e.Armor).HasColumnName("armor");
            entity.Property(e => e.Block).HasColumnName("block");
            entity.Property(e => e.Bonding).HasColumnName("bonding");
            entity.Property(e => e.BuyCount).HasDefaultValueSql("'1'");
            entity.Property(e => e.Class).HasColumnName("class");
            entity.Property(e => e.Delay).HasDefaultValueSql("'1000'").HasColumnName("delay");
            entity
                .Property(e => e.Description)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("description");
            entity.Property(e => e.DisenchantId).HasColumnName("DisenchantID");
            entity.Property(e => e.Displayid).HasColumnName("displayid");
            entity.Property(e => e.DmgMax1).HasColumnName("dmg_max1");
            entity.Property(e => e.DmgMax2).HasColumnName("dmg_max2");
            entity.Property(e => e.DmgMin1).HasColumnName("dmg_min1");
            entity.Property(e => e.DmgMin2).HasColumnName("dmg_min2");
            entity.Property(e => e.DmgType1).HasColumnName("dmg_type1");
            entity.Property(e => e.DmgType2).HasColumnName("dmg_type2");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.FireRes).HasColumnName("fire_res");
            entity.Property(e => e.FlagsCustom).HasColumnName("flagsCustom");
            entity.Property(e => e.FrostRes).HasColumnName("frost_res");
            entity.Property(e => e.HolyRes).HasColumnName("holy_res");
            entity.Property(e => e.Itemset).HasColumnName("itemset");
            entity.Property(e => e.LanguageId).HasColumnName("LanguageID");
            entity.Property(e => e.Lockid).HasColumnName("lockid");
            entity.Property(e => e.MaxMoneyLoot).HasColumnName("maxMoneyLoot");
            entity.Property(e => e.Maxcount).HasColumnName("maxcount");
            entity.Property(e => e.MinMoneyLoot).HasColumnName("minMoneyLoot");
            entity.Property(e => e.Name).HasDefaultValueSql("''").HasColumnName("name");
            entity.Property(e => e.NatureRes).HasColumnName("nature_res");
            entity.Property(e => e.RequiredDisenchantSkill).HasDefaultValueSql("'-1'");
            entity.Property(e => e.Requiredhonorrank).HasColumnName("requiredhonorrank");
            entity.Property(e => e.Requiredspell).HasColumnName("requiredspell");
            entity.Property(e => e.ScriptName).HasMaxLength(64).HasDefaultValueSql("''");
            entity.Property(e => e.ShadowRes).HasColumnName("shadow_res");
            entity.Property(e => e.Sheath).HasColumnName("sheath");
            entity.Property(e => e.SocketBonus).HasColumnName("socketBonus");
            entity.Property(e => e.SocketColor1).HasColumnName("socketColor_1");
            entity.Property(e => e.SocketColor2).HasColumnName("socketColor_2");
            entity.Property(e => e.SocketColor3).HasColumnName("socketColor_3");
            entity.Property(e => e.SocketContent1).HasColumnName("socketContent_1");
            entity.Property(e => e.SocketContent2).HasColumnName("socketContent_2");
            entity.Property(e => e.SocketContent3).HasColumnName("socketContent_3");
            entity.Property(e => e.SoundOverrideSubclass).HasDefaultValueSql("'-1'");
            entity.Property(e => e.Spellcategory1).HasColumnName("spellcategory_1");
            entity.Property(e => e.Spellcategory2).HasColumnName("spellcategory_2");
            entity.Property(e => e.Spellcategory3).HasColumnName("spellcategory_3");
            entity.Property(e => e.Spellcategory4).HasColumnName("spellcategory_4");
            entity.Property(e => e.Spellcategory5).HasColumnName("spellcategory_5");
            entity
                .Property(e => e.Spellcategorycooldown1)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("spellcategorycooldown_1");
            entity
                .Property(e => e.Spellcategorycooldown2)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("spellcategorycooldown_2");
            entity
                .Property(e => e.Spellcategorycooldown3)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("spellcategorycooldown_3");
            entity
                .Property(e => e.Spellcategorycooldown4)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("spellcategorycooldown_4");
            entity
                .Property(e => e.Spellcategorycooldown5)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("spellcategorycooldown_5");
            entity.Property(e => e.Spellcharges1).HasColumnName("spellcharges_1");
            entity.Property(e => e.Spellcharges2).HasColumnName("spellcharges_2");
            entity.Property(e => e.Spellcharges3).HasColumnName("spellcharges_3");
            entity.Property(e => e.Spellcharges4).HasColumnName("spellcharges_4");
            entity.Property(e => e.Spellcharges5).HasColumnName("spellcharges_5");
            entity
                .Property(e => e.Spellcooldown1)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("spellcooldown_1");
            entity
                .Property(e => e.Spellcooldown2)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("spellcooldown_2");
            entity
                .Property(e => e.Spellcooldown3)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("spellcooldown_3");
            entity
                .Property(e => e.Spellcooldown4)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("spellcooldown_4");
            entity
                .Property(e => e.Spellcooldown5)
                .HasDefaultValueSql("'-1'")
                .HasColumnName("spellcooldown_5");
            entity.Property(e => e.Spellid1).HasColumnName("spellid_1");
            entity.Property(e => e.Spellid2).HasColumnName("spellid_2");
            entity.Property(e => e.Spellid3).HasColumnName("spellid_3");
            entity.Property(e => e.Spellid4).HasColumnName("spellid_4");
            entity.Property(e => e.Spellid5).HasColumnName("spellid_5");
            entity.Property(e => e.SpellppmRate1).HasColumnName("spellppmRate_1");
            entity.Property(e => e.SpellppmRate2).HasColumnName("spellppmRate_2");
            entity.Property(e => e.SpellppmRate3).HasColumnName("spellppmRate_3");
            entity.Property(e => e.SpellppmRate4).HasColumnName("spellppmRate_4");
            entity.Property(e => e.SpellppmRate5).HasColumnName("spellppmRate_5");
            entity.Property(e => e.Spelltrigger1).HasColumnName("spelltrigger_1");
            entity.Property(e => e.Spelltrigger2).HasColumnName("spelltrigger_2");
            entity.Property(e => e.Spelltrigger3).HasColumnName("spelltrigger_3");
            entity.Property(e => e.Spelltrigger4).HasColumnName("spelltrigger_4");
            entity.Property(e => e.Spelltrigger5).HasColumnName("spelltrigger_5");
            entity.Property(e => e.Stackable).HasDefaultValueSql("'1'").HasColumnName("stackable");
            entity.Property(e => e.Startquest).HasColumnName("startquest");
            entity.Property(e => e.StatType1).HasColumnName("stat_type1");
            entity.Property(e => e.StatType10).HasColumnName("stat_type10");
            entity.Property(e => e.StatType2).HasColumnName("stat_type2");
            entity.Property(e => e.StatType3).HasColumnName("stat_type3");
            entity.Property(e => e.StatType4).HasColumnName("stat_type4");
            entity.Property(e => e.StatType5).HasColumnName("stat_type5");
            entity.Property(e => e.StatType6).HasColumnName("stat_type6");
            entity.Property(e => e.StatType7).HasColumnName("stat_type7");
            entity.Property(e => e.StatType8).HasColumnName("stat_type8");
            entity.Property(e => e.StatType9).HasColumnName("stat_type9");
            entity.Property(e => e.StatValue1).HasColumnName("stat_value1");
            entity.Property(e => e.StatValue10).HasColumnName("stat_value10");
            entity.Property(e => e.StatValue2).HasColumnName("stat_value2");
            entity.Property(e => e.StatValue3).HasColumnName("stat_value3");
            entity.Property(e => e.StatValue4).HasColumnName("stat_value4");
            entity.Property(e => e.StatValue5).HasColumnName("stat_value5");
            entity.Property(e => e.StatValue6).HasColumnName("stat_value6");
            entity.Property(e => e.StatValue7).HasColumnName("stat_value7");
            entity.Property(e => e.StatValue8).HasColumnName("stat_value8");
            entity.Property(e => e.StatValue9).HasColumnName("stat_value9");
            entity.Property(e => e.Subclass).HasColumnName("subclass");
        });

        modelBuilder.Entity<ItemTemplateLocale>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Locale }).HasName("PRIMARY");

            entity.ToTable("item_template_locale");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Locale).HasMaxLength(4).HasColumnName("locale");
            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.Name).HasColumnType("text");
        });

        modelBuilder.Entity<ItembagfamilyDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("itembagfamily_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.NameLangDeDe).HasMaxLength(100).HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn).HasMaxLength(100).HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb).HasMaxLength(100).HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw).HasMaxLength(100).HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs).HasMaxLength(100).HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs).HasMaxLength(100).HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx).HasMaxLength(100).HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr).HasMaxLength(100).HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt).HasMaxLength(100).HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr).HasMaxLength(100).HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr).HasMaxLength(100).HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt).HasMaxLength(100).HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu).HasMaxLength(100).HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk).HasMaxLength(100).HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn).HasMaxLength(100).HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw).HasMaxLength(100).HasColumnName("Name_Lang_zhTW");
        });

        modelBuilder.Entity<ItemdisplayinfoDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("itemdisplayinfo_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GeosetGroup1).HasColumnName("GeosetGroup_1");
            entity.Property(e => e.GeosetGroup2).HasColumnName("GeosetGroup_2");
            entity.Property(e => e.GeosetGroup3).HasColumnName("GeosetGroup_3");
            entity.Property(e => e.HelmetGeosetVis1).HasColumnName("HelmetGeosetVis_1");
            entity.Property(e => e.HelmetGeosetVis2).HasColumnName("HelmetGeosetVis_2");
            entity
                .Property(e => e.InventoryIcon1)
                .HasMaxLength(100)
                .HasColumnName("InventoryIcon_1");
            entity
                .Property(e => e.InventoryIcon2)
                .HasMaxLength(100)
                .HasColumnName("InventoryIcon_2");
            entity.Property(e => e.ModelName1).HasMaxLength(100).HasColumnName("ModelName_1");
            entity.Property(e => e.ModelName2).HasMaxLength(100).HasColumnName("ModelName_2");
            entity.Property(e => e.ModelTexture1).HasMaxLength(100).HasColumnName("ModelTexture_1");
            entity.Property(e => e.ModelTexture2).HasMaxLength(100).HasColumnName("ModelTexture_2");
            entity.Property(e => e.ParticleColorId).HasColumnName("ParticleColorID");
            entity.Property(e => e.SpellVisualId).HasColumnName("SpellVisualID");
            entity.Property(e => e.Texture1).HasMaxLength(100).HasColumnName("Texture_1");
            entity.Property(e => e.Texture2).HasMaxLength(100).HasColumnName("Texture_2");
            entity.Property(e => e.Texture3).HasMaxLength(100).HasColumnName("Texture_3");
            entity.Property(e => e.Texture4).HasMaxLength(100).HasColumnName("Texture_4");
            entity.Property(e => e.Texture5).HasMaxLength(100).HasColumnName("Texture_5");
            entity.Property(e => e.Texture6).HasMaxLength(100).HasColumnName("Texture_6");
            entity.Property(e => e.Texture7).HasMaxLength(100).HasColumnName("Texture_7");
            entity.Property(e => e.Texture8).HasMaxLength(100).HasColumnName("Texture_8");
        });

        modelBuilder.Entity<ItemextendedcostDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("itemextendedcost_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ItemCount1).HasColumnName("ItemCount_1");
            entity.Property(e => e.ItemCount2).HasColumnName("ItemCount_2");
            entity.Property(e => e.ItemCount3).HasColumnName("ItemCount_3");
            entity.Property(e => e.ItemCount4).HasColumnName("ItemCount_4");
            entity.Property(e => e.ItemCount5).HasColumnName("ItemCount_5");
            entity.Property(e => e.ItemId1).HasColumnName("ItemID_1");
            entity.Property(e => e.ItemId2).HasColumnName("ItemID_2");
            entity.Property(e => e.ItemId3).HasColumnName("ItemID_3");
            entity.Property(e => e.ItemId4).HasColumnName("ItemID_4");
            entity.Property(e => e.ItemId5).HasColumnName("ItemID_5");
        });

        modelBuilder.Entity<ItemlimitcategoryDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("itemlimitcategory_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.NameLangDeDe).HasMaxLength(100).HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn).HasMaxLength(100).HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb).HasMaxLength(100).HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw).HasMaxLength(100).HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs).HasMaxLength(100).HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs).HasMaxLength(100).HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx).HasMaxLength(100).HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr).HasMaxLength(100).HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt).HasMaxLength(100).HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr).HasMaxLength(100).HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr).HasMaxLength(100).HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt).HasMaxLength(100).HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu).HasMaxLength(100).HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk).HasMaxLength(100).HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn).HasMaxLength(100).HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw).HasMaxLength(100).HasColumnName("Name_Lang_zhTW");
        });

        modelBuilder.Entity<ItemrandompropertiesDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("itemrandomproperties_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Enchantment1).HasColumnName("Enchantment_1");
            entity.Property(e => e.Enchantment2).HasColumnName("Enchantment_2");
            entity.Property(e => e.Enchantment3).HasColumnName("Enchantment_3");
            entity.Property(e => e.Enchantment4).HasColumnName("Enchantment_4");
            entity.Property(e => e.Enchantment5).HasColumnName("Enchantment_5");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.NameLangDeDe).HasMaxLength(100).HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn).HasMaxLength(100).HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb).HasMaxLength(100).HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw).HasMaxLength(100).HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs).HasMaxLength(100).HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs).HasMaxLength(100).HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx).HasMaxLength(100).HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr).HasMaxLength(100).HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt).HasMaxLength(100).HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr).HasMaxLength(100).HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr).HasMaxLength(100).HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt).HasMaxLength(100).HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu).HasMaxLength(100).HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk).HasMaxLength(100).HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn).HasMaxLength(100).HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw).HasMaxLength(100).HasColumnName("Name_Lang_zhTW");
        });

        modelBuilder.Entity<ItemrandomsuffixDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("itemrandomsuffix_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AllocationPct1).HasColumnName("AllocationPct_1");
            entity.Property(e => e.AllocationPct2).HasColumnName("AllocationPct_2");
            entity.Property(e => e.AllocationPct3).HasColumnName("AllocationPct_3");
            entity.Property(e => e.AllocationPct4).HasColumnName("AllocationPct_4");
            entity.Property(e => e.AllocationPct5).HasColumnName("AllocationPct_5");
            entity.Property(e => e.Enchantment1).HasColumnName("Enchantment_1");
            entity.Property(e => e.Enchantment2).HasColumnName("Enchantment_2");
            entity.Property(e => e.Enchantment3).HasColumnName("Enchantment_3");
            entity.Property(e => e.Enchantment4).HasColumnName("Enchantment_4");
            entity.Property(e => e.Enchantment5).HasColumnName("Enchantment_5");
            entity.Property(e => e.InternalName).HasMaxLength(100);
            entity.Property(e => e.NameLangDeDe).HasMaxLength(100).HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn).HasMaxLength(100).HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb).HasMaxLength(100).HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw).HasMaxLength(100).HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs).HasMaxLength(100).HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs).HasMaxLength(100).HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx).HasMaxLength(100).HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr).HasMaxLength(100).HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt).HasMaxLength(100).HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr).HasMaxLength(100).HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr).HasMaxLength(100).HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt).HasMaxLength(100).HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu).HasMaxLength(100).HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk).HasMaxLength(100).HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn).HasMaxLength(100).HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw).HasMaxLength(100).HasColumnName("Name_Lang_zhTW");
        });

        modelBuilder.Entity<ItemsetDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("itemset_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ItemId1).HasColumnName("ItemID_1");
            entity.Property(e => e.ItemId10).HasColumnName("ItemID_10");
            entity.Property(e => e.ItemId11).HasColumnName("ItemID_11");
            entity.Property(e => e.ItemId12).HasColumnName("ItemID_12");
            entity.Property(e => e.ItemId13).HasColumnName("ItemID_13");
            entity.Property(e => e.ItemId14).HasColumnName("ItemID_14");
            entity.Property(e => e.ItemId15).HasColumnName("ItemID_15");
            entity.Property(e => e.ItemId16).HasColumnName("ItemID_16");
            entity.Property(e => e.ItemId17).HasColumnName("ItemID_17");
            entity.Property(e => e.ItemId2).HasColumnName("ItemID_2");
            entity.Property(e => e.ItemId3).HasColumnName("ItemID_3");
            entity.Property(e => e.ItemId4).HasColumnName("ItemID_4");
            entity.Property(e => e.ItemId5).HasColumnName("ItemID_5");
            entity.Property(e => e.ItemId6).HasColumnName("ItemID_6");
            entity.Property(e => e.ItemId7).HasColumnName("ItemID_7");
            entity.Property(e => e.ItemId8).HasColumnName("ItemID_8");
            entity.Property(e => e.ItemId9).HasColumnName("ItemID_9");
            entity.Property(e => e.NameLangDeDe).HasMaxLength(100).HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn).HasMaxLength(100).HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb).HasMaxLength(100).HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw).HasMaxLength(100).HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs).HasMaxLength(100).HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs).HasMaxLength(100).HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx).HasMaxLength(100).HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr).HasMaxLength(100).HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt).HasMaxLength(100).HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr).HasMaxLength(100).HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr).HasMaxLength(100).HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt).HasMaxLength(100).HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu).HasMaxLength(100).HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk).HasMaxLength(100).HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn).HasMaxLength(100).HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw).HasMaxLength(100).HasColumnName("Name_Lang_zhTW");
            entity.Property(e => e.SetSpellId1).HasColumnName("SetSpellID_1");
            entity.Property(e => e.SetSpellId2).HasColumnName("SetSpellID_2");
            entity.Property(e => e.SetSpellId3).HasColumnName("SetSpellID_3");
            entity.Property(e => e.SetSpellId4).HasColumnName("SetSpellID_4");
            entity.Property(e => e.SetSpellId5).HasColumnName("SetSpellID_5");
            entity.Property(e => e.SetSpellId6).HasColumnName("SetSpellID_6");
            entity.Property(e => e.SetSpellId7).HasColumnName("SetSpellID_7");
            entity.Property(e => e.SetSpellId8).HasColumnName("SetSpellID_8");
            entity.Property(e => e.SetThreshold1).HasColumnName("SetThreshold_1");
            entity.Property(e => e.SetThreshold2).HasColumnName("SetThreshold_2");
            entity.Property(e => e.SetThreshold3).HasColumnName("SetThreshold_3");
            entity.Property(e => e.SetThreshold4).HasColumnName("SetThreshold_4");
            entity.Property(e => e.SetThreshold5).HasColumnName("SetThreshold_5");
            entity.Property(e => e.SetThreshold6).HasColumnName("SetThreshold_6");
            entity.Property(e => e.SetThreshold7).HasColumnName("SetThreshold_7");
            entity.Property(e => e.SetThreshold8).HasColumnName("SetThreshold_8");
        });

        modelBuilder.Entity<LfgDungeonReward>(entity =>
        {
            entity.HasKey(e => new { e.DungeonId, e.MaxLevel }).HasName("PRIMARY");

            entity.ToTable("lfg_dungeon_rewards");

            entity
                .Property(e => e.DungeonId)
                .HasComment("Dungeon entry from dbc")
                .HasColumnName("dungeonId");
            entity
                .Property(e => e.MaxLevel)
                .HasComment("Max level at which this reward is rewarded")
                .HasColumnName("maxLevel");
            entity
                .Property(e => e.FirstQuestId)
                .HasComment("Quest id with rewards for first dungeon this day")
                .HasColumnName("firstQuestId");
            entity
                .Property(e => e.OtherQuestId)
                .HasComment("Quest id with rewards for Nth dungeon this day")
                .HasColumnName("otherQuestId");
        });

        modelBuilder.Entity<LfgDungeonTemplate>(entity =>
        {
            entity.HasKey(e => e.DungeonId).HasName("PRIMARY");

            entity.ToTable("lfg_dungeon_template");

            entity
                .Property(e => e.DungeonId)
                .HasComment("Unique id from LFGDungeons.dbc")
                .HasColumnName("dungeonId");
            entity.Property(e => e.Name).HasMaxLength(255).HasColumnName("name");
            entity.Property(e => e.Orientation).HasColumnName("orientation");
            entity.Property(e => e.PositionX).HasColumnName("position_x");
            entity.Property(e => e.PositionY).HasColumnName("position_y");
            entity.Property(e => e.PositionZ).HasColumnName("position_z");
        });

        modelBuilder.Entity<LfgdungeonsDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("lfgdungeons_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity
                .Property(e => e.DescriptionLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_deDE");
            entity
                .Property(e => e.DescriptionLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_enCN");
            entity
                .Property(e => e.DescriptionLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_enGB");
            entity
                .Property(e => e.DescriptionLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_enTW");
            entity
                .Property(e => e.DescriptionLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_enUS");
            entity
                .Property(e => e.DescriptionLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_esES");
            entity
                .Property(e => e.DescriptionLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_esMX");
            entity
                .Property(e => e.DescriptionLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_frFR");
            entity
                .Property(e => e.DescriptionLangItIt)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_itIT");
            entity
                .Property(e => e.DescriptionLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_koKR");
            entity.Property(e => e.DescriptionLangMask).HasColumnName("Description_Lang_Mask");
            entity
                .Property(e => e.DescriptionLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_ptBR");
            entity
                .Property(e => e.DescriptionLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_ptPT");
            entity
                .Property(e => e.DescriptionLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_ruRU");
            entity
                .Property(e => e.DescriptionLangUnk)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_Unk");
            entity
                .Property(e => e.DescriptionLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_zhCN");
            entity
                .Property(e => e.DescriptionLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_zhTW");
            entity.Property(e => e.GroupId).HasColumnName("Group_Id");
            entity.Property(e => e.MapId).HasColumnName("MapID");
            entity
                .Property(e => e.NameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_deDE");
            entity
                .Property(e => e.NameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enCN");
            entity
                .Property(e => e.NameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enGB");
            entity
                .Property(e => e.NameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enTW");
            entity
                .Property(e => e.NameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_enUS");
            entity
                .Property(e => e.NameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esES");
            entity
                .Property(e => e.NameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_esMX");
            entity
                .Property(e => e.NameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_frFR");
            entity
                .Property(e => e.NameLangItIt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_itIT");
            entity
                .Property(e => e.NameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity
                .Property(e => e.NameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptBR");
            entity
                .Property(e => e.NameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ptPT");
            entity
                .Property(e => e.NameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_ruRU");
            entity
                .Property(e => e.NameLangUnk)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_Unk");
            entity
                .Property(e => e.NameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhCN");
            entity
                .Property(e => e.NameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Name_Lang_zhTW");
            entity.Property(e => e.OrderIndex).HasColumnName("Order_Index");
            entity.Property(e => e.TargetLevel).HasColumnName("Target_Level");
            entity.Property(e => e.TargetLevelMax).HasColumnName("Target_Level_Max");
            entity.Property(e => e.TargetLevelMin).HasColumnName("Target_Level_Min");
            entity.Property(e => e.TextureFilename).HasColumnType("text");
            entity.Property(e => e.TypeId).HasColumnName("TypeID");
        });

        modelBuilder.Entity<LightDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("light_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ContinentId).HasColumnName("ContinentID");
            entity.Property(e => e.LightParamsId1).HasColumnName("LightParamsID_1");
            entity.Property(e => e.LightParamsId2).HasColumnName("LightParamsID_2");
            entity.Property(e => e.LightParamsId3).HasColumnName("LightParamsID_3");
            entity.Property(e => e.LightParamsId4).HasColumnName("LightParamsID_4");
            entity.Property(e => e.LightParamsId5).HasColumnName("LightParamsID_5");
            entity.Property(e => e.LightParamsId6).HasColumnName("LightParamsID_6");
            entity.Property(e => e.LightParamsId7).HasColumnName("LightParamsID_7");
            entity.Property(e => e.LightParamsId8).HasColumnName("LightParamsID_8");
        });

        modelBuilder.Entity<LinkedRespawn>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.LinkType }).HasName("PRIMARY");

            entity.ToTable("linked_respawn", tb => tb.HasComment("Creature Respawn Link System"));

            entity.Property(e => e.Guid).HasComment("dependent creature").HasColumnName("guid");
            entity.Property(e => e.LinkType).HasColumnName("linkType");
            entity
                .Property(e => e.LinkedGuid)
                .HasComment("master creature")
                .HasColumnName("linkedGuid");
        });

        modelBuilder.Entity<LiquidtypeDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("liquidtype_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Color1).HasColumnName("Color_1");
            entity.Property(e => e.Color2).HasColumnName("Color_2");
            entity.Property(e => e.Float1).HasColumnName("Float_1");
            entity.Property(e => e.Float10).HasColumnName("Float_10");
            entity.Property(e => e.Float11).HasColumnName("Float_11");
            entity.Property(e => e.Float12).HasColumnName("Float_12");
            entity.Property(e => e.Float13).HasColumnName("Float_13");
            entity.Property(e => e.Float14).HasColumnName("Float_14");
            entity.Property(e => e.Float15).HasColumnName("Float_15");
            entity.Property(e => e.Float16).HasColumnName("Float_16");
            entity.Property(e => e.Float17).HasColumnName("Float_17");
            entity.Property(e => e.Float18).HasColumnName("Float_18");
            entity.Property(e => e.Float2).HasColumnName("Float_2");
            entity.Property(e => e.Float3).HasColumnName("Float_3");
            entity.Property(e => e.Float4).HasColumnName("Float_4");
            entity.Property(e => e.Float5).HasColumnName("Float_5");
            entity.Property(e => e.Float6).HasColumnName("Float_6");
            entity.Property(e => e.Float7).HasColumnName("Float_7");
            entity.Property(e => e.Float8).HasColumnName("Float_8");
            entity.Property(e => e.Float9).HasColumnName("Float_9");
            entity.Property(e => e.Int1).HasColumnName("Int_1");
            entity.Property(e => e.Int2).HasColumnName("Int_2");
            entity.Property(e => e.Int3).HasColumnName("Int_3");
            entity.Property(e => e.Int4).HasColumnName("Int_4");
            entity.Property(e => e.LightId).HasColumnName("LightID");
            entity.Property(e => e.MaterialId).HasColumnName("MaterialID");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.SoundId).HasColumnName("SoundID");
            entity.Property(e => e.SpellId).HasColumnName("SpellID");
            entity.Property(e => e.Texture1).HasMaxLength(100).HasColumnName("Texture_1");
            entity.Property(e => e.Texture2).HasMaxLength(100).HasColumnName("Texture_2");
            entity.Property(e => e.Texture3).HasMaxLength(100).HasColumnName("Texture_3");
            entity.Property(e => e.Texture4).HasMaxLength(100).HasColumnName("Texture_4");
            entity.Property(e => e.Texture5).HasMaxLength(100).HasColumnName("Texture_5");
            entity.Property(e => e.Texture6).HasMaxLength(100).HasColumnName("Texture_6");
        });

        modelBuilder.Entity<LockDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("lock_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Action1).HasColumnName("Action_1");
            entity.Property(e => e.Action2).HasColumnName("Action_2");
            entity.Property(e => e.Action3).HasColumnName("Action_3");
            entity.Property(e => e.Action4).HasColumnName("Action_4");
            entity.Property(e => e.Action5).HasColumnName("Action_5");
            entity.Property(e => e.Action6).HasColumnName("Action_6");
            entity.Property(e => e.Action7).HasColumnName("Action_7");
            entity.Property(e => e.Action8).HasColumnName("Action_8");
            entity.Property(e => e.Index1).HasColumnName("Index_1");
            entity.Property(e => e.Index2).HasColumnName("Index_2");
            entity.Property(e => e.Index3).HasColumnName("Index_3");
            entity.Property(e => e.Index4).HasColumnName("Index_4");
            entity.Property(e => e.Index5).HasColumnName("Index_5");
            entity.Property(e => e.Index6).HasColumnName("Index_6");
            entity.Property(e => e.Index7).HasColumnName("Index_7");
            entity.Property(e => e.Index8).HasColumnName("Index_8");
            entity.Property(e => e.Skill1).HasColumnName("Skill_1");
            entity.Property(e => e.Skill2).HasColumnName("Skill_2");
            entity.Property(e => e.Skill3).HasColumnName("Skill_3");
            entity.Property(e => e.Skill4).HasColumnName("Skill_4");
            entity.Property(e => e.Skill5).HasColumnName("Skill_5");
            entity.Property(e => e.Skill6).HasColumnName("Skill_6");
            entity.Property(e => e.Skill7).HasColumnName("Skill_7");
            entity.Property(e => e.Skill8).HasColumnName("Skill_8");
            entity.Property(e => e.Type1).HasColumnName("Type_1");
            entity.Property(e => e.Type2).HasColumnName("Type_2");
            entity.Property(e => e.Type3).HasColumnName("Type_3");
            entity.Property(e => e.Type4).HasColumnName("Type_4");
            entity.Property(e => e.Type5).HasColumnName("Type_5");
            entity.Property(e => e.Type6).HasColumnName("Type_6");
            entity.Property(e => e.Type7).HasColumnName("Type_7");
            entity.Property(e => e.Type8).HasColumnName("Type_8");
        });

        modelBuilder.Entity<MailLevelReward>(entity =>
        {
            entity.HasKey(e => new { e.Level, e.RaceMask }).HasName("PRIMARY");

            entity.ToTable("mail_level_reward", tb => tb.HasComment("Mail System"));

            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.RaceMask).HasColumnName("raceMask");
            entity.Property(e => e.MailTemplateId).HasColumnName("mailTemplateId");
            entity.Property(e => e.SenderEntry).HasColumnName("senderEntry");
        });

        modelBuilder.Entity<MailLootTemplate>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Item }).HasName("PRIMARY");

            entity.ToTable("mail_loot_template", tb => tb.HasComment("Loot System"));

            entity.Property(e => e.Chance).HasDefaultValueSql("'100'");
            entity.Property(e => e.Comment).HasMaxLength(255);
            entity.Property(e => e.LootMode).HasDefaultValueSql("'1'");
            entity.Property(e => e.MaxCount).HasDefaultValueSql("'1'");
            entity.Property(e => e.MinCount).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<MailtemplateDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mailtemplate_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BodyLangDeDe).HasMaxLength(500).HasColumnName("Body_Lang_deDE");
            entity.Property(e => e.BodyLangEnCn).HasMaxLength(500).HasColumnName("Body_Lang_enCN");
            entity.Property(e => e.BodyLangEnGb).HasMaxLength(500).HasColumnName("Body_Lang_enGB");
            entity.Property(e => e.BodyLangEnTw).HasMaxLength(500).HasColumnName("Body_Lang_enTW");
            entity.Property(e => e.BodyLangEnUs).HasMaxLength(500).HasColumnName("Body_Lang_enUS");
            entity.Property(e => e.BodyLangEsEs).HasMaxLength(500).HasColumnName("Body_Lang_esES");
            entity.Property(e => e.BodyLangEsMx).HasMaxLength(500).HasColumnName("Body_Lang_esMX");
            entity.Property(e => e.BodyLangFrFr).HasMaxLength(500).HasColumnName("Body_Lang_frFR");
            entity.Property(e => e.BodyLangItIt).HasMaxLength(500).HasColumnName("Body_Lang_itIT");
            entity.Property(e => e.BodyLangKoKr).HasMaxLength(500).HasColumnName("Body_Lang_koKR");
            entity.Property(e => e.BodyLangMask).HasColumnName("Body_Lang_Mask");
            entity.Property(e => e.BodyLangPtBr).HasMaxLength(500).HasColumnName("Body_Lang_ptBR");
            entity.Property(e => e.BodyLangPtPt).HasMaxLength(500).HasColumnName("Body_Lang_ptPT");
            entity.Property(e => e.BodyLangRuRu).HasMaxLength(500).HasColumnName("Body_Lang_ruRU");
            entity.Property(e => e.BodyLangUnk).HasMaxLength(100).HasColumnName("Body_Lang_Unk");
            entity.Property(e => e.BodyLangZhCn).HasMaxLength(500).HasColumnName("Body_Lang_zhCN");
            entity.Property(e => e.BodyLangZhTw).HasMaxLength(500).HasColumnName("Body_Lang_zhTW");
            entity
                .Property(e => e.SubjectLangDeDe)
                .HasMaxLength(100)
                .HasColumnName("Subject_Lang_deDE");
            entity
                .Property(e => e.SubjectLangEnCn)
                .HasMaxLength(100)
                .HasColumnName("Subject_Lang_enCN");
            entity
                .Property(e => e.SubjectLangEnGb)
                .HasMaxLength(100)
                .HasColumnName("Subject_Lang_enGB");
            entity
                .Property(e => e.SubjectLangEnTw)
                .HasMaxLength(100)
                .HasColumnName("Subject_Lang_enTW");
            entity
                .Property(e => e.SubjectLangEnUs)
                .HasMaxLength(100)
                .HasColumnName("Subject_Lang_enUS");
            entity
                .Property(e => e.SubjectLangEsEs)
                .HasMaxLength(100)
                .HasColumnName("Subject_Lang_esES");
            entity
                .Property(e => e.SubjectLangEsMx)
                .HasMaxLength(100)
                .HasColumnName("Subject_Lang_esMX");
            entity
                .Property(e => e.SubjectLangFrFr)
                .HasMaxLength(100)
                .HasColumnName("Subject_Lang_frFR");
            entity
                .Property(e => e.SubjectLangItIt)
                .HasMaxLength(100)
                .HasColumnName("Subject_Lang_itIT");
            entity
                .Property(e => e.SubjectLangKoKr)
                .HasMaxLength(100)
                .HasColumnName("Subject_Lang_koKR");
            entity.Property(e => e.SubjectLangMask).HasColumnName("Subject_Lang_Mask");
            entity
                .Property(e => e.SubjectLangPtBr)
                .HasMaxLength(100)
                .HasColumnName("Subject_Lang_ptBR");
            entity
                .Property(e => e.SubjectLangPtPt)
                .HasMaxLength(100)
                .HasColumnName("Subject_Lang_ptPT");
            entity
                .Property(e => e.SubjectLangRuRu)
                .HasMaxLength(100)
                .HasColumnName("Subject_Lang_ruRU");
            entity
                .Property(e => e.SubjectLangUnk)
                .HasMaxLength(100)
                .HasColumnName("Subject_Lang_Unk");
            entity
                .Property(e => e.SubjectLangZhCn)
                .HasMaxLength(100)
                .HasColumnName("Subject_Lang_zhCN");
            entity
                .Property(e => e.SubjectLangZhTw)
                .HasMaxLength(100)
                .HasColumnName("Subject_Lang_zhTW");
        });

        modelBuilder.Entity<MapDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("map_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AreaTableId).HasColumnName("AreaTableID");
            entity.Property(e => e.CorpseMapId).HasColumnName("CorpseMapID");
            entity.Property(e => e.Directory).HasMaxLength(100);
            entity.Property(e => e.ExpansionId).HasColumnName("ExpansionID");
            entity.Property(e => e.LoadingScreenId).HasColumnName("LoadingScreenID");
            entity
                .Property(e => e.MapDescription0LangDeDe)
                .HasColumnType("text")
                .HasColumnName("MapDescription0_Lang_deDE");
            entity
                .Property(e => e.MapDescription0LangEnCn)
                .HasColumnType("text")
                .HasColumnName("MapDescription0_Lang_enCN");
            entity
                .Property(e => e.MapDescription0LangEnGb)
                .HasColumnType("text")
                .HasColumnName("MapDescription0_Lang_enGB");
            entity
                .Property(e => e.MapDescription0LangEnTw)
                .HasColumnType("text")
                .HasColumnName("MapDescription0_Lang_enTW");
            entity
                .Property(e => e.MapDescription0LangEnUs)
                .HasColumnType("text")
                .HasColumnName("MapDescription0_Lang_enUS");
            entity
                .Property(e => e.MapDescription0LangEsEs)
                .HasColumnType("text")
                .HasColumnName("MapDescription0_Lang_esES");
            entity
                .Property(e => e.MapDescription0LangEsMx)
                .HasColumnType("text")
                .HasColumnName("MapDescription0_Lang_esMX");
            entity
                .Property(e => e.MapDescription0LangFrFr)
                .HasColumnType("text")
                .HasColumnName("MapDescription0_Lang_frFR");
            entity
                .Property(e => e.MapDescription0LangItIt)
                .HasColumnType("text")
                .HasColumnName("MapDescription0_Lang_itIT");
            entity
                .Property(e => e.MapDescription0LangKoKr)
                .HasColumnType("text")
                .HasColumnName("MapDescription0_Lang_koKR");
            entity
                .Property(e => e.MapDescription0LangMask)
                .HasColumnName("MapDescription0_Lang_Mask");
            entity
                .Property(e => e.MapDescription0LangPtBr)
                .HasColumnType("text")
                .HasColumnName("MapDescription0_Lang_ptBR");
            entity
                .Property(e => e.MapDescription0LangPtPt)
                .HasColumnType("text")
                .HasColumnName("MapDescription0_Lang_ptPT");
            entity
                .Property(e => e.MapDescription0LangRuRu)
                .HasColumnType("text")
                .HasColumnName("MapDescription0_Lang_ruRU");
            entity
                .Property(e => e.MapDescription0LangUnk)
                .HasMaxLength(100)
                .HasColumnName("MapDescription0_Lang_Unk");
            entity
                .Property(e => e.MapDescription0LangZhCn)
                .HasColumnType("text")
                .HasColumnName("MapDescription0_Lang_zhCN");
            entity
                .Property(e => e.MapDescription0LangZhTw)
                .HasColumnType("text")
                .HasColumnName("MapDescription0_Lang_zhTW");
            entity
                .Property(e => e.MapDescription1LangDeDe)
                .HasColumnType("text")
                .HasColumnName("MapDescription1_Lang_deDE");
            entity
                .Property(e => e.MapDescription1LangEnCn)
                .HasColumnType("text")
                .HasColumnName("MapDescription1_Lang_enCN");
            entity
                .Property(e => e.MapDescription1LangEnGb)
                .HasColumnType("text")
                .HasColumnName("MapDescription1_Lang_enGB");
            entity
                .Property(e => e.MapDescription1LangEnTw)
                .HasColumnType("text")
                .HasColumnName("MapDescription1_Lang_enTW");
            entity
                .Property(e => e.MapDescription1LangEnUs)
                .HasColumnType("text")
                .HasColumnName("MapDescription1_Lang_enUS");
            entity
                .Property(e => e.MapDescription1LangEsEs)
                .HasColumnType("text")
                .HasColumnName("MapDescription1_Lang_esES");
            entity
                .Property(e => e.MapDescription1LangEsMx)
                .HasColumnType("text")
                .HasColumnName("MapDescription1_Lang_esMX");
            entity
                .Property(e => e.MapDescription1LangFrFr)
                .HasColumnType("text")
                .HasColumnName("MapDescription1_Lang_frFR");
            entity
                .Property(e => e.MapDescription1LangItIt)
                .HasColumnType("text")
                .HasColumnName("MapDescription1_Lang_itIT");
            entity
                .Property(e => e.MapDescription1LangKoKr)
                .HasColumnType("text")
                .HasColumnName("MapDescription1_Lang_koKR");
            entity
                .Property(e => e.MapDescription1LangMask)
                .HasColumnName("MapDescription1_Lang_Mask");
            entity
                .Property(e => e.MapDescription1LangPtBr)
                .HasColumnType("text")
                .HasColumnName("MapDescription1_Lang_ptBR");
            entity
                .Property(e => e.MapDescription1LangPtPt)
                .HasColumnType("text")
                .HasColumnName("MapDescription1_Lang_ptPT");
            entity
                .Property(e => e.MapDescription1LangRuRu)
                .HasColumnType("text")
                .HasColumnName("MapDescription1_Lang_ruRU");
            entity
                .Property(e => e.MapDescription1LangUnk)
                .HasMaxLength(100)
                .HasColumnName("MapDescription1_Lang_Unk");
            entity
                .Property(e => e.MapDescription1LangZhCn)
                .HasColumnType("text")
                .HasColumnName("MapDescription1_Lang_zhCN");
            entity
                .Property(e => e.MapDescription1LangZhTw)
                .HasColumnType("text")
                .HasColumnName("MapDescription1_Lang_zhTW");
            entity
                .Property(e => e.MapNameLangDeDe)
                .HasMaxLength(100)
                .HasColumnName("MapName_Lang_deDE");
            entity
                .Property(e => e.MapNameLangEnCn)
                .HasMaxLength(100)
                .HasColumnName("MapName_Lang_enCN");
            entity
                .Property(e => e.MapNameLangEnGb)
                .HasMaxLength(100)
                .HasColumnName("MapName_Lang_enGB");
            entity
                .Property(e => e.MapNameLangEnTw)
                .HasMaxLength(100)
                .HasColumnName("MapName_Lang_enTW");
            entity
                .Property(e => e.MapNameLangEnUs)
                .HasMaxLength(100)
                .HasColumnName("MapName_Lang_enUS");
            entity
                .Property(e => e.MapNameLangEsEs)
                .HasMaxLength(100)
                .HasColumnName("MapName_Lang_esES");
            entity
                .Property(e => e.MapNameLangEsMx)
                .HasMaxLength(100)
                .HasColumnName("MapName_Lang_esMX");
            entity
                .Property(e => e.MapNameLangFrFr)
                .HasMaxLength(100)
                .HasColumnName("MapName_Lang_frFR");
            entity
                .Property(e => e.MapNameLangItIt)
                .HasMaxLength(100)
                .HasColumnName("MapName_Lang_itIT");
            entity
                .Property(e => e.MapNameLangKoKr)
                .HasMaxLength(100)
                .HasColumnName("MapName_Lang_koKR");
            entity.Property(e => e.MapNameLangMask).HasColumnName("MapName_Lang_Mask");
            entity
                .Property(e => e.MapNameLangPtBr)
                .HasMaxLength(100)
                .HasColumnName("MapName_Lang_ptBR");
            entity
                .Property(e => e.MapNameLangPtPt)
                .HasMaxLength(100)
                .HasColumnName("MapName_Lang_ptPT");
            entity
                .Property(e => e.MapNameLangRuRu)
                .HasMaxLength(100)
                .HasColumnName("MapName_Lang_ruRU");
            entity
                .Property(e => e.MapNameLangUnk)
                .HasMaxLength(100)
                .HasColumnName("MapName_Lang_Unk");
            entity
                .Property(e => e.MapNameLangZhCn)
                .HasMaxLength(100)
                .HasColumnName("MapName_Lang_zhCN");
            entity
                .Property(e => e.MapNameLangZhTw)
                .HasMaxLength(100)
                .HasColumnName("MapName_Lang_zhTW");
            entity.Property(e => e.Pvp).HasColumnName("PVP");
        });

        modelBuilder.Entity<MapdifficultyDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mapdifficulty_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Difficultystring).HasMaxLength(100);
            entity.Property(e => e.MapId).HasColumnName("MapID");
            entity
                .Property(e => e.MessageLangDeDe)
                .HasMaxLength(200)
                .HasColumnName("Message_Lang_deDE");
            entity
                .Property(e => e.MessageLangEnCn)
                .HasMaxLength(200)
                .HasColumnName("Message_Lang_enCN");
            entity
                .Property(e => e.MessageLangEnGb)
                .HasMaxLength(200)
                .HasColumnName("Message_Lang_enGB");
            entity
                .Property(e => e.MessageLangEnTw)
                .HasMaxLength(200)
                .HasColumnName("Message_Lang_enTW");
            entity
                .Property(e => e.MessageLangEnUs)
                .HasMaxLength(200)
                .HasColumnName("Message_Lang_enUS");
            entity
                .Property(e => e.MessageLangEsEs)
                .HasMaxLength(200)
                .HasColumnName("Message_Lang_esES");
            entity
                .Property(e => e.MessageLangEsMx)
                .HasMaxLength(200)
                .HasColumnName("Message_Lang_esMX");
            entity
                .Property(e => e.MessageLangFrFr)
                .HasMaxLength(200)
                .HasColumnName("Message_Lang_frFR");
            entity
                .Property(e => e.MessageLangItIt)
                .HasMaxLength(200)
                .HasColumnName("Message_Lang_itIT");
            entity
                .Property(e => e.MessageLangKoKr)
                .HasMaxLength(200)
                .HasColumnName("Message_Lang_koKR");
            entity.Property(e => e.MessageLangMask).HasColumnName("Message_Lang_Mask");
            entity
                .Property(e => e.MessageLangPtBr)
                .HasMaxLength(200)
                .HasColumnName("Message_Lang_ptBR");
            entity
                .Property(e => e.MessageLangPtPt)
                .HasMaxLength(200)
                .HasColumnName("Message_Lang_ptPT");
            entity
                .Property(e => e.MessageLangRuRu)
                .HasMaxLength(200)
                .HasColumnName("Message_Lang_ruRU");
            entity
                .Property(e => e.MessageLangUnk)
                .HasMaxLength(100)
                .HasColumnName("Message_Lang_Unk");
            entity
                .Property(e => e.MessageLangZhCn)
                .HasMaxLength(200)
                .HasColumnName("Message_Lang_zhCN");
            entity
                .Property(e => e.MessageLangZhTw)
                .HasMaxLength(200)
                .HasColumnName("Message_Lang_zhTW");
        });

        modelBuilder.Entity<MillingLootTemplate>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Item }).HasName("PRIMARY");

            entity.ToTable("milling_loot_template", tb => tb.HasComment("Loot System"));

            entity.Property(e => e.Chance).HasDefaultValueSql("'100'");
            entity.Property(e => e.Comment).HasMaxLength(255);
            entity.Property(e => e.LootMode).HasDefaultValueSql("'1'");
            entity.Property(e => e.MaxCount).HasDefaultValueSql("'1'");
            entity.Property(e => e.MinCount).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<MovieDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("movie_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Filename).HasMaxLength(100);
        });

        modelBuilder.Entity<NamesprofanityDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("namesprofanity_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.LanguagueId).HasColumnName("LanguagueID");
            entity.Property(e => e.Pattern).HasColumnType("tinytext");
        });

        modelBuilder.Entity<NamesreservedDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("namesreserved_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.LanguagueId).HasColumnName("LanguagueID");
            entity.Property(e => e.Pattern).HasColumnType("tinytext");
        });

        modelBuilder.Entity<NpcSpellclickSpell>(entity =>
        {
            entity.HasKey(e => new { e.NpcEntry, e.SpellId }).HasName("PRIMARY");

            entity.ToTable("npc_spellclick_spells");

            entity
                .Property(e => e.NpcEntry)
                .HasComment("reference to creature_template")
                .HasColumnName("npc_entry");
            entity
                .Property(e => e.SpellId)
                .HasComment("spell which should be casted ")
                .HasColumnName("spell_id");
            entity
                .Property(e => e.CastFlags)
                .HasComment(
                    "first bit defines caster: 1=player, 0=creature; second bit defines target, same mapping as caster bit"
                )
                .HasColumnName("cast_flags");
            entity
                .Property(e => e.UserType)
                .HasComment(
                    "relation with summoner: 0-no 1-friendly 2-raid 3-party player can click"
                )
                .HasColumnName("user_type");
        });

        modelBuilder.Entity<NpcText>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("npc_text");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BroadcastTextId0).HasColumnName("BroadcastTextID0");
            entity.Property(e => e.BroadcastTextId1).HasColumnName("BroadcastTextID1");
            entity.Property(e => e.BroadcastTextId2).HasColumnName("BroadcastTextID2");
            entity.Property(e => e.BroadcastTextId3).HasColumnName("BroadcastTextID3");
            entity.Property(e => e.BroadcastTextId4).HasColumnName("BroadcastTextID4");
            entity.Property(e => e.BroadcastTextId5).HasColumnName("BroadcastTextID5");
            entity.Property(e => e.BroadcastTextId6).HasColumnName("BroadcastTextID6");
            entity.Property(e => e.BroadcastTextId7).HasColumnName("BroadcastTextID7");
            entity.Property(e => e.Em00).HasColumnName("em0_0");
            entity.Property(e => e.Em01).HasColumnName("em0_1");
            entity.Property(e => e.Em02).HasColumnName("em0_2");
            entity.Property(e => e.Em03).HasColumnName("em0_3");
            entity.Property(e => e.Em04).HasColumnName("em0_4");
            entity.Property(e => e.Em05).HasColumnName("em0_5");
            entity.Property(e => e.Em10).HasColumnName("em1_0");
            entity.Property(e => e.Em11).HasColumnName("em1_1");
            entity.Property(e => e.Em12).HasColumnName("em1_2");
            entity.Property(e => e.Em13).HasColumnName("em1_3");
            entity.Property(e => e.Em14).HasColumnName("em1_4");
            entity.Property(e => e.Em15).HasColumnName("em1_5");
            entity.Property(e => e.Em20).HasColumnName("em2_0");
            entity.Property(e => e.Em21).HasColumnName("em2_1");
            entity.Property(e => e.Em22).HasColumnName("em2_2");
            entity.Property(e => e.Em23).HasColumnName("em2_3");
            entity.Property(e => e.Em24).HasColumnName("em2_4");
            entity.Property(e => e.Em25).HasColumnName("em2_5");
            entity.Property(e => e.Em30).HasColumnName("em3_0");
            entity.Property(e => e.Em31).HasColumnName("em3_1");
            entity.Property(e => e.Em32).HasColumnName("em3_2");
            entity.Property(e => e.Em33).HasColumnName("em3_3");
            entity.Property(e => e.Em34).HasColumnName("em3_4");
            entity.Property(e => e.Em35).HasColumnName("em3_5");
            entity.Property(e => e.Em40).HasColumnName("em4_0");
            entity.Property(e => e.Em41).HasColumnName("em4_1");
            entity.Property(e => e.Em42).HasColumnName("em4_2");
            entity.Property(e => e.Em43).HasColumnName("em4_3");
            entity.Property(e => e.Em44).HasColumnName("em4_4");
            entity.Property(e => e.Em45).HasColumnName("em4_5");
            entity.Property(e => e.Em50).HasColumnName("em5_0");
            entity.Property(e => e.Em51).HasColumnName("em5_1");
            entity.Property(e => e.Em52).HasColumnName("em5_2");
            entity.Property(e => e.Em53).HasColumnName("em5_3");
            entity.Property(e => e.Em54).HasColumnName("em5_4");
            entity.Property(e => e.Em55).HasColumnName("em5_5");
            entity.Property(e => e.Em60).HasColumnName("em6_0");
            entity.Property(e => e.Em61).HasColumnName("em6_1");
            entity.Property(e => e.Em62).HasColumnName("em6_2");
            entity.Property(e => e.Em63).HasColumnName("em6_3");
            entity.Property(e => e.Em64).HasColumnName("em6_4");
            entity.Property(e => e.Em65).HasColumnName("em6_5");
            entity.Property(e => e.Em70).HasColumnName("em7_0");
            entity.Property(e => e.Em71).HasColumnName("em7_1");
            entity.Property(e => e.Em72).HasColumnName("em7_2");
            entity.Property(e => e.Em73).HasColumnName("em7_3");
            entity.Property(e => e.Em74).HasColumnName("em7_4");
            entity.Property(e => e.Em75).HasColumnName("em7_5");
            entity.Property(e => e.Lang0).HasColumnName("lang0");
            entity.Property(e => e.Lang1).HasColumnName("lang1");
            entity.Property(e => e.Lang2).HasColumnName("lang2");
            entity.Property(e => e.Lang3).HasColumnName("lang3");
            entity.Property(e => e.Lang4).HasColumnName("lang4");
            entity.Property(e => e.Lang5).HasColumnName("lang5");
            entity.Property(e => e.Lang6).HasColumnName("lang6");
            entity.Property(e => e.Lang7).HasColumnName("lang7");
            entity.Property(e => e.Text00).HasColumnName("text0_0");
            entity.Property(e => e.Text01).HasColumnName("text0_1");
            entity.Property(e => e.Text10).HasColumnName("text1_0");
            entity.Property(e => e.Text11).HasColumnName("text1_1");
            entity.Property(e => e.Text20).HasColumnName("text2_0");
            entity.Property(e => e.Text21).HasColumnName("text2_1");
            entity.Property(e => e.Text30).HasColumnName("text3_0");
            entity.Property(e => e.Text31).HasColumnName("text3_1");
            entity.Property(e => e.Text40).HasColumnName("text4_0");
            entity.Property(e => e.Text41).HasColumnName("text4_1");
            entity.Property(e => e.Text50).HasColumnName("text5_0");
            entity.Property(e => e.Text51).HasColumnName("text5_1");
            entity.Property(e => e.Text60).HasColumnName("text6_0");
            entity.Property(e => e.Text61).HasColumnName("text6_1");
            entity.Property(e => e.Text70).HasColumnName("text7_0");
            entity.Property(e => e.Text71).HasColumnName("text7_1");
        });

        modelBuilder.Entity<NpcTextLocale>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Locale }).HasName("PRIMARY");

            entity.ToTable("npc_text_locale");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Locale).HasMaxLength(4);
            entity.Property(e => e.Text00).HasColumnName("Text0_0");
            entity.Property(e => e.Text01).HasColumnName("Text0_1");
            entity.Property(e => e.Text10).HasColumnName("Text1_0");
            entity.Property(e => e.Text11).HasColumnName("Text1_1");
            entity.Property(e => e.Text20).HasColumnName("Text2_0");
            entity.Property(e => e.Text21).HasColumnName("Text2_1");
            entity.Property(e => e.Text30).HasColumnName("Text3_0");
            entity.Property(e => e.Text31).HasColumnName("Text3_1");
            entity.Property(e => e.Text40).HasColumnName("Text4_0");
            entity.Property(e => e.Text41).HasColumnName("Text4_1");
            entity.Property(e => e.Text50).HasColumnName("Text5_0");
            entity.Property(e => e.Text51).HasColumnName("Text5_1");
            entity.Property(e => e.Text60).HasColumnName("Text6_0");
            entity.Property(e => e.Text61).HasColumnName("Text6_1");
            entity.Property(e => e.Text70).HasColumnName("Text7_0");
            entity.Property(e => e.Text71).HasColumnName("Text7_1");
        });

        modelBuilder.Entity<NpcTrainer>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.SpellId }).HasName("PRIMARY");

            entity.ToTable("npc_trainer");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.SpellId).HasColumnName("SpellID");
        });

        modelBuilder.Entity<NpcVendor>(entity =>
        {
            entity
                .HasKey(e => new
                {
                    e.Entry,
                    e.Item,
                    e.ExtendedCost
                })
                .HasName("PRIMARY");

            entity.ToTable("npc_vendor", tb => tb.HasComment("Npc System"));

            entity.HasIndex(e => e.Slot, "slot");

            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.Item).HasColumnName("item");
            entity.Property(e => e.Incrtime).HasColumnName("incrtime");
            entity.Property(e => e.Maxcount).HasColumnName("maxcount");
            entity.Property(e => e.Slot).HasColumnName("slot");
        });

        modelBuilder.Entity<OutdoorpvpTemplate>(entity =>
        {
            entity.HasKey(e => e.TypeId).HasName("PRIMARY");

            entity.ToTable("outdoorpvp_template", tb => tb.HasComment("OutdoorPvP Templates"));

            entity.Property(e => e.Comment).HasColumnType("text").HasColumnName("comment");
            entity
                .Property(e => e.ScriptName)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .IsFixedLength();
        });

        modelBuilder.Entity<OverridespelldataDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("overridespelldata_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Spells1).HasColumnName("Spells_1");
            entity.Property(e => e.Spells10).HasColumnName("Spells_10");
            entity.Property(e => e.Spells2).HasColumnName("Spells_2");
            entity.Property(e => e.Spells3).HasColumnName("Spells_3");
            entity.Property(e => e.Spells4).HasColumnName("Spells_4");
            entity.Property(e => e.Spells5).HasColumnName("Spells_5");
            entity.Property(e => e.Spells6).HasColumnName("Spells_6");
            entity.Property(e => e.Spells7).HasColumnName("Spells_7");
            entity.Property(e => e.Spells8).HasColumnName("Spells_8");
            entity.Property(e => e.Spells9).HasColumnName("Spells_9");
        });

        modelBuilder.Entity<PageText>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("page_text", tb => tb.HasComment("Item System"));

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.NextPageId).HasColumnName("NextPageID");
        });

        modelBuilder.Entity<PageTextLocale>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Locale }).HasName("PRIMARY");

            entity.ToTable("page_text_locale");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Locale).HasMaxLength(4).HasColumnName("locale");
            entity.Property(e => e.Text).HasColumnType("text");
        });

        modelBuilder.Entity<PetLevelstat>(entity =>
        {
            entity.HasKey(e => new { e.CreatureEntry, e.Level }).HasName("PRIMARY");

            entity.ToTable("pet_levelstats", tb => tb.HasComment("Stores pet levels stats."));

            entity.Property(e => e.CreatureEntry).HasColumnName("creature_entry");
            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.Agi).HasColumnName("agi");
            entity.Property(e => e.Armor).HasColumnName("armor");
            entity.Property(e => e.Hp).HasColumnName("hp");
            entity.Property(e => e.Inte).HasColumnName("inte");
            entity.Property(e => e.Mana).HasColumnName("mana");
            entity.Property(e => e.MaxDmg).HasColumnName("max_dmg");
            entity.Property(e => e.MinDmg).HasColumnName("min_dmg");
            entity.Property(e => e.Spi).HasColumnName("spi");
            entity.Property(e => e.Sta).HasColumnName("sta");
            entity.Property(e => e.Str).HasColumnName("str");
        });

        modelBuilder.Entity<PetNameGeneration>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("pet_name_generation");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.Half).HasColumnName("half");
            entity.Property(e => e.Word).HasColumnType("tinytext").HasColumnName("word");
        });

        modelBuilder.Entity<PetNameGenerationLocale>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Locale }).HasName("PRIMARY");

            entity.ToTable("pet_name_generation_locale");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Locale).HasMaxLength(4);
            entity.Property(e => e.Word).HasColumnType("tinytext");
        });

        modelBuilder.Entity<PickpocketingLootTemplate>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Item }).HasName("PRIMARY");

            entity.ToTable("pickpocketing_loot_template", tb => tb.HasComment("Loot System"));

            entity.Property(e => e.Chance).HasDefaultValueSql("'100'");
            entity.Property(e => e.Comment).HasMaxLength(255);
            entity.Property(e => e.LootMode).HasDefaultValueSql("'1'");
            entity.Property(e => e.MaxCount).HasDefaultValueSql("'1'");
            entity.Property(e => e.MinCount).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<PlayerClassStat>(entity =>
        {
            entity.HasKey(e => new { e.Class, e.Level }).HasName("PRIMARY");

            entity.ToTable("player_class_stats", tb => tb.HasComment("Stores levels stats."));

            entity.Property(e => e.BaseHp).HasDefaultValueSql("'1'").HasColumnName("BaseHP");
            entity.Property(e => e.BaseMana).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<PlayerClasslevelstat>(entity =>
        {
            entity.HasKey(e => new { e.Class, e.Level }).HasName("PRIMARY");

            entity.ToTable("player_classlevelstats", tb => tb.HasComment("Stores levels stats."));

            entity.Property(e => e.Class).HasColumnName("class");
            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.Basehp).HasDefaultValueSql("'1'").HasColumnName("basehp");
            entity.Property(e => e.Basemana).HasDefaultValueSql("'1'").HasColumnName("basemana");
        });

        modelBuilder.Entity<PlayerFactionchangeAchievement>(entity =>
        {
            entity.HasKey(e => new { e.AllianceId, e.HordeId }).HasName("PRIMARY");

            entity.ToTable("player_factionchange_achievement");

            entity.Property(e => e.AllianceId).HasColumnName("alliance_id");
            entity.Property(e => e.HordeId).HasColumnName("horde_id");
        });

        modelBuilder.Entity<PlayerFactionchangeItem>(entity =>
        {
            entity.HasKey(e => new { e.AllianceId, e.HordeId }).HasName("PRIMARY");

            entity.ToTable("player_factionchange_items");

            entity.Property(e => e.AllianceId).HasColumnName("alliance_id");
            entity.Property(e => e.HordeId).HasColumnName("horde_id");
            entity
                .Property(e => e.AllianceComment)
                .HasColumnType("text")
                .HasColumnName("alliance_comment");
            entity
                .Property(e => e.HordeComment)
                .HasColumnType("text")
                .HasColumnName("horde_comment");
        });

        modelBuilder.Entity<PlayerFactionchangeQuest>(entity =>
        {
            entity.HasKey(e => new { e.AllianceId, e.HordeId }).HasName("PRIMARY");

            entity.ToTable("player_factionchange_quests");

            entity.HasIndex(e => e.AllianceId, "alliance_uniq").IsUnique();

            entity.HasIndex(e => e.HordeId, "horde_uniq").IsUnique();

            entity.Property(e => e.AllianceId).HasColumnName("alliance_id");
            entity.Property(e => e.HordeId).HasColumnName("horde_id");
        });

        modelBuilder.Entity<PlayerFactionchangeReputation>(entity =>
        {
            entity.HasKey(e => new { e.AllianceId, e.HordeId }).HasName("PRIMARY");

            entity.ToTable("player_factionchange_reputations");

            entity.Property(e => e.AllianceId).HasColumnName("alliance_id");
            entity.Property(e => e.HordeId).HasColumnName("horde_id");
        });

        modelBuilder.Entity<PlayerFactionchangeSpell>(entity =>
        {
            entity.HasKey(e => new { e.AllianceId, e.HordeId }).HasName("PRIMARY");

            entity.ToTable("player_factionchange_spells");

            entity.Property(e => e.AllianceId).HasColumnName("alliance_id");
            entity.Property(e => e.HordeId).HasColumnName("horde_id");
            entity
                .Property(e => e.AllianceComment)
                .HasColumnType("text")
                .HasColumnName("alliance_comment");
            entity
                .Property(e => e.HordeComment)
                .HasColumnType("text")
                .HasColumnName("horde_comment");
        });

        modelBuilder.Entity<PlayerFactionchangeTitle>(entity =>
        {
            entity.HasKey(e => new { e.AllianceId, e.HordeId }).HasName("PRIMARY");

            entity.ToTable("player_factionchange_titles");

            entity.Property(e => e.AllianceId).HasColumnName("alliance_id");
            entity.Property(e => e.HordeId).HasColumnName("horde_id");
            entity
                .Property(e => e.AllianceComment)
                .HasColumnType("text")
                .HasColumnName("alliance_comment");
            entity
                .Property(e => e.HordeComment)
                .HasColumnType("text")
                .HasColumnName("horde_comment");
        });

        modelBuilder.Entity<PlayerLootTemplate>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Item }).HasName("PRIMARY");

            entity.ToTable("player_loot_template", tb => tb.HasComment("Loot System"));

            entity.Property(e => e.Chance).HasDefaultValueSql("'100'");
            entity.Property(e => e.Comment).HasColumnType("text");
            entity.Property(e => e.LootMode).HasDefaultValueSql("'1'");
            entity.Property(e => e.MaxCount).HasDefaultValueSql("'1'");
            entity.Property(e => e.MinCount).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<PlayerRaceStat>(entity =>
        {
            entity.HasKey(e => e.Race).HasName("PRIMARY");

            entity.ToTable("player_race_stats", tb => tb.HasComment("Stores race stats."));
        });

        modelBuilder.Entity<PlayerXpForLevel>(entity =>
        {
            entity.HasKey(e => e.Level).HasName("PRIMARY");

            entity.ToTable("player_xp_for_level");
        });

        modelBuilder.Entity<Playercreateinfo>(entity =>
        {
            entity.HasKey(e => new { e.Race, e.Class }).HasName("PRIMARY");

            entity.ToTable("playercreateinfo");

            entity.Property(e => e.Race).HasColumnName("race");
            entity.Property(e => e.Class).HasColumnName("class");
            entity.Property(e => e.Map).HasColumnName("map");
            entity.Property(e => e.Orientation).HasColumnName("orientation");
            entity.Property(e => e.PositionX).HasColumnName("position_x");
            entity.Property(e => e.PositionY).HasColumnName("position_y");
            entity.Property(e => e.PositionZ).HasColumnName("position_z");
            entity.Property(e => e.Zone).HasColumnName("zone");
        });

        modelBuilder.Entity<PlayercreateinfoAction>(entity =>
        {
            entity
                .HasKey(e => new
                {
                    e.Race,
                    e.Class,
                    e.Button
                })
                .HasName("PRIMARY");

            entity.ToTable("playercreateinfo_action");

            entity.HasIndex(e => new { e.Race, e.Class }, "playercreateinfo_race_class_index");

            entity.Property(e => e.Race).HasColumnName("race");
            entity.Property(e => e.Class).HasColumnName("class");
            entity.Property(e => e.Button).HasColumnName("button");
            entity.Property(e => e.Action).HasColumnName("action");
            entity.Property(e => e.Type).HasColumnName("type");
        });

        modelBuilder.Entity<PlayercreateinfoCastSpell>(entity =>
        {
            entity.HasNoKey().ToTable("playercreateinfo_cast_spell");

            entity.Property(e => e.ClassMask).HasColumnName("classMask");
            entity.Property(e => e.Note).HasMaxLength(255).HasColumnName("note");
            entity.Property(e => e.RaceMask).HasColumnName("raceMask");
            entity.Property(e => e.Spell).HasColumnName("spell");
        });

        modelBuilder.Entity<PlayercreateinfoItem>(entity =>
        {
            entity
                .HasKey(e => new
                {
                    e.Race,
                    e.Class,
                    e.Itemid
                })
                .HasName("PRIMARY");

            entity.ToTable("playercreateinfo_item");

            entity.HasIndex(e => new { e.Race, e.Class }, "playercreateinfo_race_class_index");

            entity.Property(e => e.Race).HasColumnName("race");
            entity.Property(e => e.Class).HasColumnName("class");
            entity.Property(e => e.Itemid).HasColumnName("itemid");
            entity.Property(e => e.Amount).HasDefaultValueSql("'1'").HasColumnName("amount");
            entity.Property(e => e.Note).HasMaxLength(255);
        });

        modelBuilder.Entity<PlayercreateinfoSkill>(entity =>
        {
            entity
                .HasKey(e => new
                {
                    e.RaceMask,
                    e.ClassMask,
                    e.Skill
                })
                .HasName("PRIMARY");

            entity.ToTable("playercreateinfo_skills");

            entity.Property(e => e.RaceMask).HasColumnName("raceMask");
            entity.Property(e => e.ClassMask).HasColumnName("classMask");
            entity.Property(e => e.Skill).HasColumnName("skill");
            entity.Property(e => e.Comment).HasMaxLength(255).HasColumnName("comment");
            entity.Property(e => e.Rank).HasColumnName("rank");
        });

        modelBuilder.Entity<PlayercreateinfoSpellCustom>(entity =>
        {
            entity
                .HasKey(e => new
                {
                    e.Racemask,
                    e.Classmask,
                    e.Spell
                })
                .HasName("PRIMARY");

            entity.ToTable("playercreateinfo_spell_custom");

            entity.Property(e => e.Racemask).HasColumnName("racemask");
            entity.Property(e => e.Classmask).HasColumnName("classmask");
            entity.Property(e => e.Note).HasMaxLength(255);
        });

        modelBuilder.Entity<PointsOfInterest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("points_of_interest");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name).HasColumnType("text");
        });

        modelBuilder.Entity<PointsOfInterestLocale>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Locale }).HasName("PRIMARY");

            entity.ToTable("points_of_interest_locale");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Locale).HasMaxLength(4).HasColumnName("locale");
            entity.Property(e => e.Name).HasColumnType("text");
        });

        modelBuilder.Entity<PoolCreature>(entity =>
        {
            entity.HasKey(e => e.Guid).HasName("PRIMARY");

            entity.ToTable("pool_creature");

            entity.HasIndex(e => e.Guid, "idx_guid");

            entity.Property(e => e.Guid).HasColumnName("guid");
            entity.Property(e => e.Chance).HasColumnName("chance");
            entity.Property(e => e.Description).HasMaxLength(255).HasColumnName("description");
            entity.Property(e => e.PoolEntry).HasColumnName("pool_entry");
        });

        modelBuilder.Entity<PoolGameobject>(entity =>
        {
            entity.HasKey(e => e.Guid).HasName("PRIMARY");

            entity.ToTable("pool_gameobject");

            entity.HasIndex(e => e.Guid, "idx_guid");

            entity.Property(e => e.Guid).HasColumnName("guid");
            entity.Property(e => e.Chance).HasColumnName("chance");
            entity.Property(e => e.Description).HasMaxLength(255).HasColumnName("description");
            entity.Property(e => e.PoolEntry).HasColumnName("pool_entry");
        });

        modelBuilder.Entity<PoolPool>(entity =>
        {
            entity.HasKey(e => e.PoolId).HasName("PRIMARY");

            entity.ToTable("pool_pool");

            entity.Property(e => e.PoolId).HasColumnName("pool_id");
            entity.Property(e => e.Chance).HasColumnName("chance");
            entity.Property(e => e.Description).HasMaxLength(255).HasColumnName("description");
            entity.Property(e => e.MotherPool).HasColumnName("mother_pool");
        });

        modelBuilder.Entity<PoolQuest>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity.ToTable("pool_quest");

            entity.HasIndex(e => e.Entry, "idx_guid");

            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.Description).HasMaxLength(255).HasColumnName("description");
            entity.Property(e => e.PoolEntry).HasColumnName("pool_entry");
        });

        modelBuilder.Entity<PoolTemplate>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity.ToTable("pool_template");

            entity.Property(e => e.Entry).HasComment("Pool entry").HasColumnName("entry");
            entity.Property(e => e.Description).HasMaxLength(255).HasColumnName("description");
            entity
                .Property(e => e.MaxLimit)
                .HasComment("Max number of objects (0) is no limit")
                .HasColumnName("max_limit");
        });

        modelBuilder.Entity<PowerdisplayDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("powerdisplay_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GlobalstringBaseTag).HasMaxLength(100);
        });

        modelBuilder.Entity<ProspectingLootTemplate>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Item }).HasName("PRIMARY");

            entity.ToTable("prospecting_loot_template", tb => tb.HasComment("Loot System"));

            entity.Property(e => e.Chance).HasDefaultValueSql("'100'");
            entity.Property(e => e.Comment).HasMaxLength(255);
            entity.Property(e => e.LootMode).HasDefaultValueSql("'1'");
            entity.Property(e => e.MaxCount).HasDefaultValueSql("'1'");
            entity.Property(e => e.MinCount).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<PvpdifficultyDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("pvpdifficulty_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MapId).HasColumnName("MapID");
        });

        modelBuilder.Entity<QuestDetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("quest_details");

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<QuestGreeting>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Type }).HasName("PRIMARY");

            entity.ToTable("quest_greeting");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Greeting).HasColumnType("text");
        });

        modelBuilder.Entity<QuestGreetingLocale>(entity =>
        {
            entity
                .HasKey(e => new
                {
                    e.Id,
                    e.Type,
                    e.Locale
                })
                .HasName("PRIMARY");

            entity.ToTable("quest_greeting_locale");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Locale).HasMaxLength(4).HasColumnName("locale");
            entity.Property(e => e.Greeting).HasColumnType("text");
        });

        modelBuilder.Entity<QuestMailSender>(entity =>
        {
            entity.HasKey(e => e.QuestId).HasName("PRIMARY");

            entity.ToTable("quest_mail_sender");
        });

        modelBuilder.Entity<QuestMoneyReward>(entity =>
        {
            entity.HasKey(e => e.Level).HasName("PRIMARY");

            entity.ToTable("quest_money_reward");
        });

        modelBuilder.Entity<QuestOfferReward>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("quest_offer_reward");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.RewardText).HasColumnType("text");
        });

        modelBuilder.Entity<QuestOfferRewardLocale>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Locale }).HasName("PRIMARY");

            entity.ToTable("quest_offer_reward_locale");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Locale).HasMaxLength(4).HasColumnName("locale");
            entity.Property(e => e.RewardText).HasColumnType("text");
        });

        modelBuilder.Entity<QuestPoi>(entity =>
        {
            entity.HasKey(e => new { e.QuestId, e.Id }).HasName("PRIMARY");

            entity.ToTable("quest_poi");

            entity.HasIndex(e => new { e.QuestId, e.Id }, "idx");

            entity.Property(e => e.QuestId).HasColumnName("QuestID");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.MapId).HasColumnName("MapID");
        });

        modelBuilder.Entity<QuestPoiPoint>(entity =>
        {
            entity
                .HasKey(e => new
                {
                    e.QuestId,
                    e.Idx1,
                    e.Idx2
                })
                .HasName("PRIMARY");

            entity.ToTable("quest_poi_points");

            entity.HasIndex(e => new { e.QuestId, e.Idx1 }, "questId_id");

            entity.Property(e => e.QuestId).HasColumnName("QuestID");
        });

        modelBuilder.Entity<QuestRequestItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("quest_request_items");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CompletionText).HasColumnType("text");
        });

        modelBuilder.Entity<QuestRequestItemsLocale>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Locale }).HasName("PRIMARY");

            entity.ToTable("quest_request_items_locale");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Locale).HasMaxLength(4).HasColumnName("locale");
            entity.Property(e => e.CompletionText).HasColumnType("text");
        });

        modelBuilder.Entity<QuestTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("quest_template", tb => tb.HasComment("Quest System"));

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AreaDescription).HasColumnType("text");
            entity.Property(e => e.LogDescription).HasColumnType("text");
            entity.Property(e => e.LogTitle).HasColumnType("text");
            entity.Property(e => e.ObjectiveText1).HasColumnType("text");
            entity.Property(e => e.ObjectiveText2).HasColumnType("text");
            entity.Property(e => e.ObjectiveText3).HasColumnType("text");
            entity.Property(e => e.ObjectiveText4).HasColumnType("text");
            entity.Property(e => e.Poicontinent).HasColumnName("POIContinent");
            entity.Property(e => e.Poipriority).HasColumnName("POIPriority");
            entity.Property(e => e.Poix).HasColumnName("POIx");
            entity.Property(e => e.Poiy).HasColumnName("POIy");
            entity.Property(e => e.QuestCompletionLog).HasColumnType("text");
            entity.Property(e => e.QuestDescription).HasColumnType("text");
            entity.Property(e => e.QuestInfoId).HasColumnName("QuestInfoID");
            entity.Property(e => e.QuestLevel).HasDefaultValueSql("'1'");
            entity.Property(e => e.QuestSortId).HasColumnName("QuestSortID");
            entity.Property(e => e.QuestType).HasDefaultValueSql("'2'");
            entity.Property(e => e.RewardChoiceItemId1).HasColumnName("RewardChoiceItemID1");
            entity.Property(e => e.RewardChoiceItemId2).HasColumnName("RewardChoiceItemID2");
            entity.Property(e => e.RewardChoiceItemId3).HasColumnName("RewardChoiceItemID3");
            entity.Property(e => e.RewardChoiceItemId4).HasColumnName("RewardChoiceItemID4");
            entity.Property(e => e.RewardChoiceItemId5).HasColumnName("RewardChoiceItemID5");
            entity.Property(e => e.RewardChoiceItemId6).HasColumnName("RewardChoiceItemID6");
            entity
                .Property(e => e.RewardFactionId1)
                .HasComment("faction id from Faction.dbc in this case")
                .HasColumnName("RewardFactionID1");
            entity
                .Property(e => e.RewardFactionId2)
                .HasComment("faction id from Faction.dbc in this case")
                .HasColumnName("RewardFactionID2");
            entity
                .Property(e => e.RewardFactionId3)
                .HasComment("faction id from Faction.dbc in this case")
                .HasColumnName("RewardFactionID3");
            entity
                .Property(e => e.RewardFactionId4)
                .HasComment("faction id from Faction.dbc in this case")
                .HasColumnName("RewardFactionID4");
            entity
                .Property(e => e.RewardFactionId5)
                .HasComment("faction id from Faction.dbc in this case")
                .HasColumnName("RewardFactionID5");
            entity.Property(e => e.RewardXpdifficulty).HasColumnName("RewardXPDifficulty");
        });

        modelBuilder.Entity<QuestTemplateAddon>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("quest_template_addon");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.NextQuestId).HasColumnName("NextQuestID");
            entity.Property(e => e.PrevQuestId).HasColumnName("PrevQuestID");
            entity.Property(e => e.RequiredSkillId).HasColumnName("RequiredSkillID");
            entity.Property(e => e.RewardMailTemplateId).HasColumnName("RewardMailTemplateID");
            entity.Property(e => e.SourceSpellId).HasColumnName("SourceSpellID");
        });

        modelBuilder.Entity<QuestTemplateLocale>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Locale }).HasName("PRIMARY");

            entity.ToTable("quest_template_locale");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Locale).HasMaxLength(4).HasColumnName("locale");
            entity.Property(e => e.CompletedText).HasColumnType("text");
            entity.Property(e => e.Details).HasColumnType("text");
            entity.Property(e => e.EndText).HasColumnType("text");
            entity.Property(e => e.ObjectiveText1).HasColumnType("text");
            entity.Property(e => e.ObjectiveText2).HasColumnType("text");
            entity.Property(e => e.ObjectiveText3).HasColumnType("text");
            entity.Property(e => e.ObjectiveText4).HasColumnType("text");
            entity.Property(e => e.Objectives).HasColumnType("text");
            entity.Property(e => e.Title).HasColumnType("text");
        });

        modelBuilder.Entity<QuestfactionrewardDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("questfactionreward_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Difficulty1).HasColumnName("Difficulty_1");
            entity.Property(e => e.Difficulty10).HasColumnName("Difficulty_10");
            entity.Property(e => e.Difficulty2).HasColumnName("Difficulty_2");
            entity.Property(e => e.Difficulty3).HasColumnName("Difficulty_3");
            entity.Property(e => e.Difficulty4).HasColumnName("Difficulty_4");
            entity.Property(e => e.Difficulty5).HasColumnName("Difficulty_5");
            entity.Property(e => e.Difficulty6).HasColumnName("Difficulty_6");
            entity.Property(e => e.Difficulty7).HasColumnName("Difficulty_7");
            entity.Property(e => e.Difficulty8).HasColumnName("Difficulty_8");
            entity.Property(e => e.Difficulty9).HasColumnName("Difficulty_9");
        });

        modelBuilder.Entity<QuestsortDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("questsort_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity
                .Property(e => e.SortNameLangDeDe)
                .HasMaxLength(100)
                .HasColumnName("SortName_Lang_deDE");
            entity
                .Property(e => e.SortNameLangEnCn)
                .HasMaxLength(100)
                .HasColumnName("SortName_Lang_enCN");
            entity
                .Property(e => e.SortNameLangEnGb)
                .HasMaxLength(100)
                .HasColumnName("SortName_Lang_enGB");
            entity
                .Property(e => e.SortNameLangEnTw)
                .HasMaxLength(100)
                .HasColumnName("SortName_Lang_enTW");
            entity
                .Property(e => e.SortNameLangEnUs)
                .HasMaxLength(100)
                .HasColumnName("SortName_Lang_enUS");
            entity
                .Property(e => e.SortNameLangEsEs)
                .HasMaxLength(100)
                .HasColumnName("SortName_Lang_esES");
            entity
                .Property(e => e.SortNameLangEsMx)
                .HasMaxLength(100)
                .HasColumnName("SortName_Lang_esMX");
            entity
                .Property(e => e.SortNameLangFrFr)
                .HasMaxLength(100)
                .HasColumnName("SortName_Lang_frFR");
            entity
                .Property(e => e.SortNameLangItIt)
                .HasMaxLength(100)
                .HasColumnName("SortName_Lang_itIT");
            entity
                .Property(e => e.SortNameLangKoKr)
                .HasMaxLength(100)
                .HasColumnName("SortName_Lang_koKR");
            entity.Property(e => e.SortNameLangMask).HasColumnName("SortName_Lang_Mask");
            entity
                .Property(e => e.SortNameLangPtBr)
                .HasMaxLength(100)
                .HasColumnName("SortName_Lang_ptBR");
            entity
                .Property(e => e.SortNameLangPtPt)
                .HasMaxLength(100)
                .HasColumnName("SortName_Lang_ptPT");
            entity
                .Property(e => e.SortNameLangRuRu)
                .HasMaxLength(100)
                .HasColumnName("SortName_Lang_ruRU");
            entity
                .Property(e => e.SortNameLangUnk)
                .HasMaxLength(100)
                .HasColumnName("SortName_Lang_Unk");
            entity
                .Property(e => e.SortNameLangZhCn)
                .HasMaxLength(100)
                .HasColumnName("SortName_Lang_zhCN");
            entity
                .Property(e => e.SortNameLangZhTw)
                .HasMaxLength(100)
                .HasColumnName("SortName_Lang_zhTW");
        });

        modelBuilder.Entity<QuestxpDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("questxp_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Difficulty1).HasColumnName("Difficulty_1");
            entity.Property(e => e.Difficulty10).HasColumnName("Difficulty_10");
            entity.Property(e => e.Difficulty2).HasColumnName("Difficulty_2");
            entity.Property(e => e.Difficulty3).HasColumnName("Difficulty_3");
            entity.Property(e => e.Difficulty4).HasColumnName("Difficulty_4");
            entity.Property(e => e.Difficulty5).HasColumnName("Difficulty_5");
            entity.Property(e => e.Difficulty6).HasColumnName("Difficulty_6");
            entity.Property(e => e.Difficulty7).HasColumnName("Difficulty_7");
            entity.Property(e => e.Difficulty8).HasColumnName("Difficulty_8");
            entity.Property(e => e.Difficulty9).HasColumnName("Difficulty_9");
        });

        modelBuilder.Entity<RandproppointsDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("randproppoints_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Epic1).HasColumnName("Epic_1");
            entity.Property(e => e.Epic2).HasColumnName("Epic_2");
            entity.Property(e => e.Epic3).HasColumnName("Epic_3");
            entity.Property(e => e.Epic4).HasColumnName("Epic_4");
            entity.Property(e => e.Epic5).HasColumnName("Epic_5");
            entity.Property(e => e.Good1).HasColumnName("Good_1");
            entity.Property(e => e.Good2).HasColumnName("Good_2");
            entity.Property(e => e.Good3).HasColumnName("Good_3");
            entity.Property(e => e.Good4).HasColumnName("Good_4");
            entity.Property(e => e.Good5).HasColumnName("Good_5");
            entity.Property(e => e.Superior1).HasColumnName("Superior_1");
            entity.Property(e => e.Superior2).HasColumnName("Superior_2");
            entity.Property(e => e.Superior3).HasColumnName("Superior_3");
            entity.Property(e => e.Superior4).HasColumnName("Superior_4");
            entity.Property(e => e.Superior5).HasColumnName("Superior_5");
        });

        modelBuilder.Entity<ReferenceLootTemplate>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Item }).HasName("PRIMARY");

            entity.ToTable("reference_loot_template", tb => tb.HasComment("Loot System"));

            entity.Property(e => e.Chance).HasDefaultValueSql("'100'");
            entity.Property(e => e.Comment).HasMaxLength(255);
            entity.Property(e => e.LootMode).HasDefaultValueSql("'1'");
            entity.Property(e => e.MaxCount).HasDefaultValueSql("'1'");
            entity.Property(e => e.MinCount).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<ReputationRewardRate>(entity =>
        {
            entity.HasKey(e => e.Faction).HasName("PRIMARY");

            entity.ToTable("reputation_reward_rate");

            entity.Property(e => e.Faction).HasColumnName("faction");
            entity
                .Property(e => e.CreatureRate)
                .HasDefaultValueSql("'1'")
                .HasColumnName("creature_rate");
            entity
                .Property(e => e.QuestDailyRate)
                .HasDefaultValueSql("'1'")
                .HasColumnName("quest_daily_rate");
            entity
                .Property(e => e.QuestMonthlyRate)
                .HasDefaultValueSql("'1'")
                .HasColumnName("quest_monthly_rate");
            entity.Property(e => e.QuestRate).HasDefaultValueSql("'1'").HasColumnName("quest_rate");
            entity
                .Property(e => e.QuestRepeatableRate)
                .HasDefaultValueSql("'1'")
                .HasColumnName("quest_repeatable_rate");
            entity
                .Property(e => e.QuestWeeklyRate)
                .HasDefaultValueSql("'1'")
                .HasColumnName("quest_weekly_rate");
            entity.Property(e => e.SpellRate).HasDefaultValueSql("'1'").HasColumnName("spell_rate");
        });

        modelBuilder.Entity<ReputationSpilloverTemplate>(entity =>
        {
            entity.HasKey(e => e.Faction).HasName("PRIMARY");

            entity.ToTable(
                "reputation_spillover_template",
                tb => tb.HasComment("Reputation spillover reputation gain")
            );

            entity.Property(e => e.Faction).HasComment("faction entry").HasColumnName("faction");
            entity
                .Property(e => e.Faction1)
                .HasComment("faction to give spillover for")
                .HasColumnName("faction1");
            entity.Property(e => e.Faction2).HasColumnName("faction2");
            entity.Property(e => e.Faction3).HasColumnName("faction3");
            entity.Property(e => e.Faction4).HasColumnName("faction4");
            entity.Property(e => e.Faction5).HasColumnName("faction5");
            entity.Property(e => e.Faction6).HasColumnName("faction6");
            entity
                .Property(e => e.Rank1)
                .HasComment("max rank,above this will not give any spillover")
                .HasColumnName("rank_1");
            entity.Property(e => e.Rank2).HasColumnName("rank_2");
            entity.Property(e => e.Rank3).HasColumnName("rank_3");
            entity.Property(e => e.Rank4).HasColumnName("rank_4");
            entity.Property(e => e.Rank5).HasColumnName("rank_5");
            entity.Property(e => e.Rank6).HasColumnName("rank_6");
            entity
                .Property(e => e.Rate1)
                .HasComment("the given rep points * rate")
                .HasColumnName("rate_1");
            entity.Property(e => e.Rate2).HasColumnName("rate_2");
            entity.Property(e => e.Rate3).HasColumnName("rate_3");
            entity.Property(e => e.Rate4).HasColumnName("rate_4");
            entity.Property(e => e.Rate5).HasColumnName("rate_5");
            entity.Property(e => e.Rate6).HasColumnName("rate_6");
        });

        modelBuilder.Entity<ScalingstatdistributionDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("scalingstatdistribution_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Bonus1).HasColumnName("Bonus_1");
            entity.Property(e => e.Bonus10).HasColumnName("Bonus_10");
            entity.Property(e => e.Bonus2).HasColumnName("Bonus_2");
            entity.Property(e => e.Bonus3).HasColumnName("Bonus_3");
            entity.Property(e => e.Bonus4).HasColumnName("Bonus_4");
            entity.Property(e => e.Bonus5).HasColumnName("Bonus_5");
            entity.Property(e => e.Bonus6).HasColumnName("Bonus_6");
            entity.Property(e => e.Bonus7).HasColumnName("Bonus_7");
            entity.Property(e => e.Bonus8).HasColumnName("Bonus_8");
            entity.Property(e => e.Bonus9).HasColumnName("Bonus_9");
            entity.Property(e => e.StatId1).HasColumnName("StatID_1");
            entity.Property(e => e.StatId10).HasColumnName("StatID_10");
            entity.Property(e => e.StatId2).HasColumnName("StatID_2");
            entity.Property(e => e.StatId3).HasColumnName("StatID_3");
            entity.Property(e => e.StatId4).HasColumnName("StatID_4");
            entity.Property(e => e.StatId5).HasColumnName("StatID_5");
            entity.Property(e => e.StatId6).HasColumnName("StatID_6");
            entity.Property(e => e.StatId7).HasColumnName("StatID_7");
            entity.Property(e => e.StatId8).HasColumnName("StatID_8");
            entity.Property(e => e.StatId9).HasColumnName("StatID_9");
        });

        modelBuilder.Entity<ScalingstatvaluesDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("scalingstatvalues_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.RangedDps).HasColumnName("RangedDPS");
            entity.Property(e => e.SpellcasterDps1h).HasColumnName("SpellcasterDPS1H");
            entity.Property(e => e.SpellcasterDps2h).HasColumnName("SpellcasterDPS2H");
            entity.Property(e => e.WandDps).HasColumnName("WandDPS");
            entity.Property(e => e.WeaponDps1h).HasColumnName("WeaponDPS1H");
            entity.Property(e => e.WeaponDps2h).HasColumnName("WeaponDPS2H");
        });

        modelBuilder.Entity<ScriptWaypoint>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Pointid }).HasName("PRIMARY");

            entity.ToTable("script_waypoint", tb => tb.HasComment("Script Creature waypoints"));

            entity
                .Property(e => e.Entry)
                .HasComment("creature_template entry")
                .HasColumnName("entry");
            entity.Property(e => e.Pointid).HasColumnName("pointid");
            entity.Property(e => e.LocationX).HasColumnName("location_x");
            entity.Property(e => e.LocationY).HasColumnName("location_y");
            entity.Property(e => e.LocationZ).HasColumnName("location_z");
            entity
                .Property(e => e.PointComment)
                .HasColumnType("text")
                .HasColumnName("point_comment");
            entity
                .Property(e => e.Waittime)
                .HasComment("waittime in millisecs")
                .HasColumnName("waittime");
        });

        modelBuilder.Entity<SkillDiscoveryTemplate>(entity =>
        {
            entity.HasKey(e => new { e.SpellId, e.ReqSpell }).HasName("PRIMARY");

            entity.ToTable(
                "skill_discovery_template",
                tb => tb.HasComment("Skill Discovery System")
            );

            entity
                .Property(e => e.SpellId)
                .HasComment("SpellId of the discoverable spell")
                .HasColumnName("spellId");
            entity
                .Property(e => e.ReqSpell)
                .HasComment("spell requirement")
                .HasColumnName("reqSpell");
            entity.Property(e => e.Chance).HasComment("chance to discover").HasColumnName("chance");
            entity
                .Property(e => e.ReqSkillValue)
                .HasComment("skill points requirement")
                .HasColumnName("reqSkillValue");
        });

        modelBuilder.Entity<SkillExtraItemTemplate>(entity =>
        {
            entity.HasKey(e => e.SpellId).HasName("PRIMARY");

            entity.ToTable(
                "skill_extra_item_template",
                tb => tb.HasComment("Skill Specialization System")
            );

            entity
                .Property(e => e.SpellId)
                .HasComment("SpellId of the item creation spell")
                .HasColumnName("spellId");
            entity
                .Property(e => e.AdditionalCreateChance)
                .HasComment("chance to create add")
                .HasColumnName("additionalCreateChance");
            entity.Property(e => e.AdditionalMaxNum).HasColumnName("additionalMaxNum");
            entity
                .Property(e => e.RequiredSpecialization)
                .HasComment("Specialization spell id")
                .HasColumnName("requiredSpecialization");
        });

        modelBuilder.Entity<SkillFishingBaseLevel>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity.ToTable("skill_fishing_base_level", tb => tb.HasComment("Fishing system"));

            entity.Property(e => e.Entry).HasComment("Area identifier").HasColumnName("entry");
            entity
                .Property(e => e.Skill)
                .HasComment("Base skill level requirement")
                .HasColumnName("skill");
        });

        modelBuilder.Entity<SkillPerfectItemTemplate>(entity =>
        {
            entity.HasKey(e => e.SpellId).HasName("PRIMARY");

            entity.ToTable(
                "skill_perfect_item_template",
                tb => tb.HasComment("Crafting Perfection System")
            );

            entity
                .Property(e => e.SpellId)
                .HasComment("SpellId of the item creation spell")
                .HasColumnName("spellId");
            entity
                .Property(e => e.PerfectCreateChance)
                .HasComment("chance to create the perfect item instead")
                .HasColumnName("perfectCreateChance");
            entity
                .Property(e => e.PerfectItemType)
                .HasComment("perfect item type to create instead")
                .HasColumnName("perfectItemType");
            entity
                .Property(e => e.RequiredSpecialization)
                .HasComment("Specialization spell id")
                .HasColumnName("requiredSpecialization");
        });

        modelBuilder.Entity<SkilllineDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("skillline_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity
                .Property(e => e.AlternateVerbLangDeDe)
                .HasMaxLength(100)
                .HasColumnName("AlternateVerb_Lang_deDE");
            entity
                .Property(e => e.AlternateVerbLangEnCn)
                .HasMaxLength(100)
                .HasColumnName("AlternateVerb_Lang_enCN");
            entity
                .Property(e => e.AlternateVerbLangEnGb)
                .HasMaxLength(100)
                .HasColumnName("AlternateVerb_Lang_enGB");
            entity
                .Property(e => e.AlternateVerbLangEnTw)
                .HasMaxLength(100)
                .HasColumnName("AlternateVerb_Lang_enTW");
            entity
                .Property(e => e.AlternateVerbLangEnUs)
                .HasMaxLength(100)
                .HasColumnName("AlternateVerb_Lang_enUS");
            entity
                .Property(e => e.AlternateVerbLangEsEs)
                .HasMaxLength(100)
                .HasColumnName("AlternateVerb_Lang_esES");
            entity
                .Property(e => e.AlternateVerbLangEsMx)
                .HasMaxLength(100)
                .HasColumnName("AlternateVerb_Lang_esMX");
            entity
                .Property(e => e.AlternateVerbLangFrFr)
                .HasMaxLength(100)
                .HasColumnName("AlternateVerb_Lang_frFR");
            entity
                .Property(e => e.AlternateVerbLangItIt)
                .HasMaxLength(100)
                .HasColumnName("AlternateVerb_Lang_itIT");
            entity
                .Property(e => e.AlternateVerbLangKoKr)
                .HasMaxLength(100)
                .HasColumnName("AlternateVerb_Lang_koKR");
            entity.Property(e => e.AlternateVerbLangMask).HasColumnName("AlternateVerb_Lang_Mask");
            entity
                .Property(e => e.AlternateVerbLangPtBr)
                .HasMaxLength(100)
                .HasColumnName("AlternateVerb_Lang_ptBR");
            entity
                .Property(e => e.AlternateVerbLangPtPt)
                .HasMaxLength(100)
                .HasColumnName("AlternateVerb_Lang_ptPT");
            entity
                .Property(e => e.AlternateVerbLangRuRu)
                .HasMaxLength(100)
                .HasColumnName("AlternateVerb_Lang_ruRU");
            entity
                .Property(e => e.AlternateVerbLangUnk)
                .HasMaxLength(100)
                .HasColumnName("AlternateVerb_Lang_Unk");
            entity
                .Property(e => e.AlternateVerbLangZhCn)
                .HasMaxLength(100)
                .HasColumnName("AlternateVerb_Lang_zhCN");
            entity
                .Property(e => e.AlternateVerbLangZhTw)
                .HasMaxLength(100)
                .HasColumnName("AlternateVerb_Lang_zhTW");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity
                .Property(e => e.DescriptionLangDeDe)
                .HasMaxLength(300)
                .HasColumnName("Description_Lang_deDE");
            entity
                .Property(e => e.DescriptionLangEnCn)
                .HasMaxLength(300)
                .HasColumnName("Description_Lang_enCN");
            entity
                .Property(e => e.DescriptionLangEnGb)
                .HasMaxLength(300)
                .HasColumnName("Description_Lang_enGB");
            entity
                .Property(e => e.DescriptionLangEnTw)
                .HasMaxLength(300)
                .HasColumnName("Description_Lang_enTW");
            entity
                .Property(e => e.DescriptionLangEnUs)
                .HasMaxLength(300)
                .HasColumnName("Description_Lang_enUS");
            entity
                .Property(e => e.DescriptionLangEsEs)
                .HasMaxLength(300)
                .HasColumnName("Description_Lang_esES");
            entity
                .Property(e => e.DescriptionLangEsMx)
                .HasMaxLength(300)
                .HasColumnName("Description_Lang_esMX");
            entity
                .Property(e => e.DescriptionLangFrFr)
                .HasMaxLength(300)
                .HasColumnName("Description_Lang_frFR");
            entity
                .Property(e => e.DescriptionLangItIt)
                .HasMaxLength(300)
                .HasColumnName("Description_Lang_itIT");
            entity
                .Property(e => e.DescriptionLangKoKr)
                .HasMaxLength(300)
                .HasColumnName("Description_Lang_koKR");
            entity.Property(e => e.DescriptionLangMask).HasColumnName("Description_Lang_Mask");
            entity
                .Property(e => e.DescriptionLangPtBr)
                .HasMaxLength(300)
                .HasColumnName("Description_Lang_ptBR");
            entity
                .Property(e => e.DescriptionLangPtPt)
                .HasMaxLength(300)
                .HasColumnName("Description_Lang_ptPT");
            entity
                .Property(e => e.DescriptionLangRuRu)
                .HasMaxLength(300)
                .HasColumnName("Description_Lang_ruRU");
            entity
                .Property(e => e.DescriptionLangUnk)
                .HasMaxLength(100)
                .HasColumnName("Description_Lang_Unk");
            entity
                .Property(e => e.DescriptionLangZhCn)
                .HasMaxLength(300)
                .HasColumnName("Description_Lang_zhCN");
            entity
                .Property(e => e.DescriptionLangZhTw)
                .HasMaxLength(300)
                .HasColumnName("Description_Lang_zhTW");
            entity
                .Property(e => e.DisplayNameLangDeDe)
                .HasMaxLength(100)
                .HasColumnName("DisplayName_Lang_deDE");
            entity
                .Property(e => e.DisplayNameLangEnCn)
                .HasMaxLength(100)
                .HasColumnName("DisplayName_Lang_enCN");
            entity
                .Property(e => e.DisplayNameLangEnGb)
                .HasMaxLength(100)
                .HasColumnName("DisplayName_Lang_enGB");
            entity
                .Property(e => e.DisplayNameLangEnTw)
                .HasMaxLength(100)
                .HasColumnName("DisplayName_Lang_enTW");
            entity
                .Property(e => e.DisplayNameLangEnUs)
                .HasMaxLength(100)
                .HasColumnName("DisplayName_Lang_enUS");
            entity
                .Property(e => e.DisplayNameLangEsEs)
                .HasMaxLength(100)
                .HasColumnName("DisplayName_Lang_esES");
            entity
                .Property(e => e.DisplayNameLangEsMx)
                .HasMaxLength(100)
                .HasColumnName("DisplayName_Lang_esMX");
            entity
                .Property(e => e.DisplayNameLangFrFr)
                .HasMaxLength(100)
                .HasColumnName("DisplayName_Lang_frFR");
            entity
                .Property(e => e.DisplayNameLangItIt)
                .HasMaxLength(100)
                .HasColumnName("DisplayName_Lang_itIT");
            entity
                .Property(e => e.DisplayNameLangKoKr)
                .HasMaxLength(100)
                .HasColumnName("DisplayName_Lang_koKR");
            entity.Property(e => e.DisplayNameLangMask).HasColumnName("DisplayName_Lang_Mask");
            entity
                .Property(e => e.DisplayNameLangPtBr)
                .HasMaxLength(100)
                .HasColumnName("DisplayName_Lang_ptBR");
            entity
                .Property(e => e.DisplayNameLangPtPt)
                .HasMaxLength(100)
                .HasColumnName("DisplayName_Lang_ptPT");
            entity
                .Property(e => e.DisplayNameLangRuRu)
                .HasMaxLength(100)
                .HasColumnName("DisplayName_Lang_ruRU");
            entity
                .Property(e => e.DisplayNameLangUnk)
                .HasMaxLength(100)
                .HasColumnName("DisplayName_Lang_Unk");
            entity
                .Property(e => e.DisplayNameLangZhCn)
                .HasMaxLength(100)
                .HasColumnName("DisplayName_Lang_zhCN");
            entity
                .Property(e => e.DisplayNameLangZhTw)
                .HasMaxLength(100)
                .HasColumnName("DisplayName_Lang_zhTW");
            entity.Property(e => e.SkillCostsId).HasColumnName("SkillCostsID");
            entity.Property(e => e.SpellIconId).HasColumnName("SpellIconID");
        });

        modelBuilder.Entity<SkilllineabilityDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("skilllineability_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CharacterPoints1).HasColumnName("CharacterPoints_1");
            entity.Property(e => e.CharacterPoints2).HasColumnName("CharacterPoints_2");
        });

        modelBuilder.Entity<SkillraceclassinfoDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("skillraceclassinfo_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.SkillId).HasColumnName("SkillID");
            entity.Property(e => e.SkillTierId).HasColumnName("SkillTierID");
        });

        modelBuilder.Entity<SkilltiersDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("skilltiers_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Cost1).HasColumnName("Cost_1");
            entity.Property(e => e.Cost10).HasColumnName("Cost_10");
            entity.Property(e => e.Cost11).HasColumnName("Cost_11");
            entity.Property(e => e.Cost12).HasColumnName("Cost_12");
            entity.Property(e => e.Cost13).HasColumnName("Cost_13");
            entity.Property(e => e.Cost14).HasColumnName("Cost_14");
            entity.Property(e => e.Cost15).HasColumnName("Cost_15");
            entity.Property(e => e.Cost16).HasColumnName("Cost_16");
            entity.Property(e => e.Cost2).HasColumnName("Cost_2");
            entity.Property(e => e.Cost3).HasColumnName("Cost_3");
            entity.Property(e => e.Cost4).HasColumnName("Cost_4");
            entity.Property(e => e.Cost5).HasColumnName("Cost_5");
            entity.Property(e => e.Cost6).HasColumnName("Cost_6");
            entity.Property(e => e.Cost7).HasColumnName("Cost_7");
            entity.Property(e => e.Cost8).HasColumnName("Cost_8");
            entity.Property(e => e.Cost9).HasColumnName("Cost_9");
            entity.Property(e => e.Value1).HasColumnName("Value_1");
            entity.Property(e => e.Value10).HasColumnName("Value_10");
            entity.Property(e => e.Value11).HasColumnName("Value_11");
            entity.Property(e => e.Value12).HasColumnName("Value_12");
            entity.Property(e => e.Value13).HasColumnName("Value_13");
            entity.Property(e => e.Value14).HasColumnName("Value_14");
            entity.Property(e => e.Value15).HasColumnName("Value_15");
            entity.Property(e => e.Value16).HasColumnName("Value_16");
            entity.Property(e => e.Value2).HasColumnName("Value_2");
            entity.Property(e => e.Value3).HasColumnName("Value_3");
            entity.Property(e => e.Value4).HasColumnName("Value_4");
            entity.Property(e => e.Value5).HasColumnName("Value_5");
            entity.Property(e => e.Value6).HasColumnName("Value_6");
            entity.Property(e => e.Value7).HasColumnName("Value_7");
            entity.Property(e => e.Value8).HasColumnName("Value_8");
            entity.Property(e => e.Value9).HasColumnName("Value_9");
        });

        modelBuilder.Entity<SkinningLootTemplate>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Item }).HasName("PRIMARY");

            entity.ToTable("skinning_loot_template", tb => tb.HasComment("Loot System"));

            entity.Property(e => e.Chance).HasDefaultValueSql("'100'");
            entity.Property(e => e.Comment).HasMaxLength(255);
            entity.Property(e => e.LootMode).HasDefaultValueSql("'1'");
            entity.Property(e => e.MaxCount).HasDefaultValueSql("'1'");
            entity.Property(e => e.MinCount).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<SmartScript>(entity =>
        {
            entity
                .HasKey(e => new
                {
                    e.Entryorguid,
                    e.SourceType,
                    e.Id,
                    e.Link
                })
                .HasName("PRIMARY");

            entity.ToTable("smart_scripts");

            entity.Property(e => e.Entryorguid).HasColumnName("entryorguid");
            entity.Property(e => e.SourceType).HasColumnName("source_type");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Link).HasColumnName("link");
            entity.Property(e => e.ActionParam1).HasColumnName("action_param1");
            entity.Property(e => e.ActionParam2).HasColumnName("action_param2");
            entity.Property(e => e.ActionParam3).HasColumnName("action_param3");
            entity.Property(e => e.ActionParam4).HasColumnName("action_param4");
            entity.Property(e => e.ActionParam5).HasColumnName("action_param5");
            entity.Property(e => e.ActionParam6).HasColumnName("action_param6");
            entity.Property(e => e.ActionType).HasColumnName("action_type");
            entity
                .Property(e => e.Comment)
                .HasComment("Event Comment")
                .HasColumnType("text")
                .HasColumnName("comment");
            entity
                .Property(e => e.EventChance)
                .HasDefaultValueSql("'100'")
                .HasColumnName("event_chance");
            entity.Property(e => e.EventFlags).HasColumnName("event_flags");
            entity.Property(e => e.EventParam1).HasColumnName("event_param1");
            entity.Property(e => e.EventParam2).HasColumnName("event_param2");
            entity.Property(e => e.EventParam3).HasColumnName("event_param3");
            entity.Property(e => e.EventParam4).HasColumnName("event_param4");
            entity.Property(e => e.EventParam5).HasColumnName("event_param5");
            entity.Property(e => e.EventParam6).HasColumnName("event_param6");
            entity.Property(e => e.EventPhaseMask).HasColumnName("event_phase_mask");
            entity.Property(e => e.EventType).HasColumnName("event_type");
            entity.Property(e => e.TargetO).HasColumnName("target_o");
            entity.Property(e => e.TargetParam1).HasColumnName("target_param1");
            entity.Property(e => e.TargetParam2).HasColumnName("target_param2");
            entity.Property(e => e.TargetParam3).HasColumnName("target_param3");
            entity.Property(e => e.TargetParam4).HasColumnName("target_param4");
            entity.Property(e => e.TargetType).HasColumnName("target_type");
            entity.Property(e => e.TargetX).HasColumnName("target_x");
            entity.Property(e => e.TargetY).HasColumnName("target_y");
            entity.Property(e => e.TargetZ).HasColumnName("target_z");
        });

        modelBuilder.Entity<SoundentriesDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("soundentries_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DirectoryBase).HasMaxLength(100);
            entity.Property(e => e.Eaxdef).HasColumnName("EAXDef");
            entity.Property(e => e.File1).HasMaxLength(100).HasColumnName("File_1");
            entity.Property(e => e.File10).HasMaxLength(100).HasColumnName("File_10");
            entity.Property(e => e.File2).HasMaxLength(100).HasColumnName("File_2");
            entity.Property(e => e.File3).HasMaxLength(100).HasColumnName("File_3");
            entity.Property(e => e.File4).HasMaxLength(100).HasColumnName("File_4");
            entity.Property(e => e.File5).HasMaxLength(100).HasColumnName("File_5");
            entity.Property(e => e.File6).HasMaxLength(100).HasColumnName("File_6");
            entity.Property(e => e.File7).HasMaxLength(100).HasColumnName("File_7");
            entity.Property(e => e.File8).HasMaxLength(100).HasColumnName("File_8");
            entity.Property(e => e.File9).HasMaxLength(100).HasColumnName("File_9");
            entity.Property(e => e.Freq1).HasColumnName("Freq_1");
            entity.Property(e => e.Freq10).HasColumnName("Freq_10");
            entity.Property(e => e.Freq2).HasColumnName("Freq_2");
            entity.Property(e => e.Freq3).HasColumnName("Freq_3");
            entity.Property(e => e.Freq4).HasColumnName("Freq_4");
            entity.Property(e => e.Freq5).HasColumnName("Freq_5");
            entity.Property(e => e.Freq6).HasColumnName("Freq_6");
            entity.Property(e => e.Freq7).HasColumnName("Freq_7");
            entity.Property(e => e.Freq8).HasColumnName("Freq_8");
            entity.Property(e => e.Freq9).HasColumnName("Freq_9");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.SoundEntriesAdvancedId).HasColumnName("SoundEntriesAdvancedID");
        });

        modelBuilder.Entity<SpellArea>(entity =>
        {
            entity
                .HasKey(e => new
                {
                    e.Spell,
                    e.Area,
                    e.QuestStart,
                    e.AuraSpell,
                    e.Racemask,
                    e.Gender
                })
                .HasName("PRIMARY");

            entity.ToTable("spell_area");

            entity.Property(e => e.Spell).HasColumnName("spell");
            entity.Property(e => e.Area).HasColumnName("area");
            entity.Property(e => e.QuestStart).HasColumnName("quest_start");
            entity.Property(e => e.AuraSpell).HasColumnName("aura_spell");
            entity.Property(e => e.Racemask).HasColumnName("racemask");
            entity.Property(e => e.Gender).HasDefaultValueSql("'2'").HasColumnName("gender");
            entity.Property(e => e.Autocast).HasColumnName("autocast");
            entity.Property(e => e.QuestEnd).HasColumnName("quest_end");
            entity
                .Property(e => e.QuestEndStatus)
                .HasDefaultValueSql("'11'")
                .HasColumnName("quest_end_status");
            entity
                .Property(e => e.QuestStartStatus)
                .HasDefaultValueSql("'64'")
                .HasColumnName("quest_start_status");
        });

        modelBuilder.Entity<SpellBonusDatum>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity.ToTable("spell_bonus_data");

            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.ApBonus).HasColumnName("ap_bonus");
            entity.Property(e => e.ApDotBonus).HasColumnName("ap_dot_bonus");
            entity.Property(e => e.Comments).HasMaxLength(255).HasColumnName("comments");
            entity.Property(e => e.DirectBonus).HasColumnName("direct_bonus");
            entity.Property(e => e.DotBonus).HasColumnName("dot_bonus");
        });

        modelBuilder.Entity<SpellCooldownOverride>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("spell_cooldown_overrides");

            entity.Property(e => e.Comment).HasColumnType("text");
        });

        modelBuilder.Entity<SpellCustomAttr>(entity =>
        {
            entity.HasKey(e => e.SpellId).HasName("PRIMARY");

            entity.ToTable("spell_custom_attr", tb => tb.HasComment("SpellInfo custom attributes"));

            entity.Property(e => e.SpellId).HasComment("spell id").HasColumnName("spell_id");
            entity
                .Property(e => e.Attributes)
                .HasComment("SpellCustomAttributes")
                .HasColumnName("attributes");
        });

        modelBuilder.Entity<SpellDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("spell_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ActiveIconId).HasColumnName("ActiveIconID");
            entity
                .Property(e => e.AuraDescriptionLangDeDe)
                .HasMaxLength(550)
                .HasColumnName("AuraDescription_Lang_deDE");
            entity
                .Property(e => e.AuraDescriptionLangEnCn)
                .HasMaxLength(550)
                .HasColumnName("AuraDescription_Lang_enCN");
            entity
                .Property(e => e.AuraDescriptionLangEnGb)
                .HasMaxLength(550)
                .HasColumnName("AuraDescription_Lang_enGB");
            entity
                .Property(e => e.AuraDescriptionLangEnTw)
                .HasMaxLength(550)
                .HasColumnName("AuraDescription_Lang_enTW");
            entity
                .Property(e => e.AuraDescriptionLangEnUs)
                .HasMaxLength(550)
                .HasColumnName("AuraDescription_Lang_enUS");
            entity
                .Property(e => e.AuraDescriptionLangEsEs)
                .HasMaxLength(550)
                .HasColumnName("AuraDescription_Lang_esES");
            entity
                .Property(e => e.AuraDescriptionLangEsMx)
                .HasMaxLength(550)
                .HasColumnName("AuraDescription_Lang_esMX");
            entity
                .Property(e => e.AuraDescriptionLangFrFr)
                .HasMaxLength(550)
                .HasColumnName("AuraDescription_Lang_frFR");
            entity
                .Property(e => e.AuraDescriptionLangItIt)
                .HasMaxLength(550)
                .HasColumnName("AuraDescription_Lang_itIT");
            entity
                .Property(e => e.AuraDescriptionLangKoKr)
                .HasMaxLength(550)
                .HasColumnName("AuraDescription_Lang_koKR");
            entity
                .Property(e => e.AuraDescriptionLangMask)
                .HasColumnName("AuraDescription_Lang_Mask");
            entity
                .Property(e => e.AuraDescriptionLangPtBr)
                .HasMaxLength(550)
                .HasColumnName("AuraDescription_Lang_ptBR");
            entity
                .Property(e => e.AuraDescriptionLangPtPt)
                .HasMaxLength(550)
                .HasColumnName("AuraDescription_Lang_ptPT");
            entity
                .Property(e => e.AuraDescriptionLangRuRu)
                .HasMaxLength(550)
                .HasColumnName("AuraDescription_Lang_ruRU");
            entity
                .Property(e => e.AuraDescriptionLangUnk)
                .HasMaxLength(100)
                .HasColumnName("AuraDescription_Lang_Unk");
            entity
                .Property(e => e.AuraDescriptionLangZhCn)
                .HasMaxLength(550)
                .HasColumnName("AuraDescription_Lang_zhCN");
            entity
                .Property(e => e.AuraDescriptionLangZhTw)
                .HasMaxLength(550)
                .HasColumnName("AuraDescription_Lang_zhTW");
            entity
                .Property(e => e.DescriptionLangDeDe)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_deDE");
            entity
                .Property(e => e.DescriptionLangEnCn)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_enCN");
            entity
                .Property(e => e.DescriptionLangEnGb)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_enGB");
            entity
                .Property(e => e.DescriptionLangEnTw)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_enTW");
            entity
                .Property(e => e.DescriptionLangEnUs)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_enUS");
            entity
                .Property(e => e.DescriptionLangEsEs)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_esES");
            entity
                .Property(e => e.DescriptionLangEsMx)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_esMX");
            entity
                .Property(e => e.DescriptionLangFrFr)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_frFR");
            entity
                .Property(e => e.DescriptionLangItIt)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_itIT");
            entity
                .Property(e => e.DescriptionLangKoKr)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_koKR");
            entity.Property(e => e.DescriptionLangMask).HasColumnName("Description_Lang_Mask");
            entity
                .Property(e => e.DescriptionLangPtBr)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_ptBR");
            entity
                .Property(e => e.DescriptionLangPtPt)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_ptPT");
            entity
                .Property(e => e.DescriptionLangRuRu)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_ruRU");
            entity
                .Property(e => e.DescriptionLangUnk)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_Unk");
            entity
                .Property(e => e.DescriptionLangZhCn)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_zhCN");
            entity
                .Property(e => e.DescriptionLangZhTw)
                .HasColumnType("text")
                .HasColumnName("Description_Lang_zhTW");
            entity.Property(e => e.Effect1).HasColumnName("Effect_1");
            entity.Property(e => e.Effect2).HasColumnName("Effect_2");
            entity.Property(e => e.Effect3).HasColumnName("Effect_3");
            entity.Property(e => e.EffectAura1).HasColumnName("EffectAura_1");
            entity.Property(e => e.EffectAura2).HasColumnName("EffectAura_2");
            entity.Property(e => e.EffectAura3).HasColumnName("EffectAura_3");
            entity.Property(e => e.EffectAuraPeriod1).HasColumnName("EffectAuraPeriod_1");
            entity.Property(e => e.EffectAuraPeriod2).HasColumnName("EffectAuraPeriod_2");
            entity.Property(e => e.EffectAuraPeriod3).HasColumnName("EffectAuraPeriod_3");
            entity.Property(e => e.EffectBasePoints1).HasColumnName("EffectBasePoints_1");
            entity.Property(e => e.EffectBasePoints2).HasColumnName("EffectBasePoints_2");
            entity.Property(e => e.EffectBasePoints3).HasColumnName("EffectBasePoints_3");
            entity.Property(e => e.EffectBonusMultiplier1).HasColumnName("EffectBonusMultiplier_1");
            entity.Property(e => e.EffectBonusMultiplier2).HasColumnName("EffectBonusMultiplier_2");
            entity.Property(e => e.EffectBonusMultiplier3).HasColumnName("EffectBonusMultiplier_3");
            entity.Property(e => e.EffectChainAmplitude1).HasColumnName("EffectChainAmplitude_1");
            entity.Property(e => e.EffectChainAmplitude2).HasColumnName("EffectChainAmplitude_2");
            entity.Property(e => e.EffectChainAmplitude3).HasColumnName("EffectChainAmplitude_3");
            entity.Property(e => e.EffectChainTargets1).HasColumnName("EffectChainTargets_1");
            entity.Property(e => e.EffectChainTargets2).HasColumnName("EffectChainTargets_2");
            entity.Property(e => e.EffectChainTargets3).HasColumnName("EffectChainTargets_3");
            entity.Property(e => e.EffectDieSides1).HasColumnName("EffectDieSides_1");
            entity.Property(e => e.EffectDieSides2).HasColumnName("EffectDieSides_2");
            entity.Property(e => e.EffectDieSides3).HasColumnName("EffectDieSides_3");
            entity.Property(e => e.EffectItemType1).HasColumnName("EffectItemType_1");
            entity.Property(e => e.EffectItemType2).HasColumnName("EffectItemType_2");
            entity.Property(e => e.EffectItemType3).HasColumnName("EffectItemType_3");
            entity.Property(e => e.EffectMechanic1).HasColumnName("EffectMechanic_1");
            entity.Property(e => e.EffectMechanic2).HasColumnName("EffectMechanic_2");
            entity.Property(e => e.EffectMechanic3).HasColumnName("EffectMechanic_3");
            entity.Property(e => e.EffectMiscValue1).HasColumnName("EffectMiscValue_1");
            entity.Property(e => e.EffectMiscValue2).HasColumnName("EffectMiscValue_2");
            entity.Property(e => e.EffectMiscValue3).HasColumnName("EffectMiscValue_3");
            entity.Property(e => e.EffectMiscValueB1).HasColumnName("EffectMiscValueB_1");
            entity.Property(e => e.EffectMiscValueB2).HasColumnName("EffectMiscValueB_2");
            entity.Property(e => e.EffectMiscValueB3).HasColumnName("EffectMiscValueB_3");
            entity.Property(e => e.EffectMultipleValue1).HasColumnName("EffectMultipleValue_1");
            entity.Property(e => e.EffectMultipleValue2).HasColumnName("EffectMultipleValue_2");
            entity.Property(e => e.EffectMultipleValue3).HasColumnName("EffectMultipleValue_3");
            entity.Property(e => e.EffectPointsPerCombo1).HasColumnName("EffectPointsPerCombo_1");
            entity.Property(e => e.EffectPointsPerCombo2).HasColumnName("EffectPointsPerCombo_2");
            entity.Property(e => e.EffectPointsPerCombo3).HasColumnName("EffectPointsPerCombo_3");
            entity.Property(e => e.EffectRadiusIndex1).HasColumnName("EffectRadiusIndex_1");
            entity.Property(e => e.EffectRadiusIndex2).HasColumnName("EffectRadiusIndex_2");
            entity.Property(e => e.EffectRadiusIndex3).HasColumnName("EffectRadiusIndex_3");
            entity
                .Property(e => e.EffectRealPointsPerLevel1)
                .HasColumnName("EffectRealPointsPerLevel_1");
            entity
                .Property(e => e.EffectRealPointsPerLevel2)
                .HasColumnName("EffectRealPointsPerLevel_2");
            entity
                .Property(e => e.EffectRealPointsPerLevel3)
                .HasColumnName("EffectRealPointsPerLevel_3");
            entity.Property(e => e.EffectSpellClassMaskA1).HasColumnName("EffectSpellClassMaskA_1");
            entity.Property(e => e.EffectSpellClassMaskA2).HasColumnName("EffectSpellClassMaskA_2");
            entity.Property(e => e.EffectSpellClassMaskA3).HasColumnName("EffectSpellClassMaskA_3");
            entity.Property(e => e.EffectSpellClassMaskB1).HasColumnName("EffectSpellClassMaskB_1");
            entity.Property(e => e.EffectSpellClassMaskB2).HasColumnName("EffectSpellClassMaskB_2");
            entity.Property(e => e.EffectSpellClassMaskB3).HasColumnName("EffectSpellClassMaskB_3");
            entity.Property(e => e.EffectSpellClassMaskC1).HasColumnName("EffectSpellClassMaskC_1");
            entity.Property(e => e.EffectSpellClassMaskC2).HasColumnName("EffectSpellClassMaskC_2");
            entity.Property(e => e.EffectSpellClassMaskC3).HasColumnName("EffectSpellClassMaskC_3");
            entity.Property(e => e.EffectTriggerSpell1).HasColumnName("EffectTriggerSpell_1");
            entity.Property(e => e.EffectTriggerSpell2).HasColumnName("EffectTriggerSpell_2");
            entity.Property(e => e.EffectTriggerSpell3).HasColumnName("EffectTriggerSpell_3");
            entity.Property(e => e.ImplicitTargetA1).HasColumnName("ImplicitTargetA_1");
            entity.Property(e => e.ImplicitTargetA2).HasColumnName("ImplicitTargetA_2");
            entity.Property(e => e.ImplicitTargetA3).HasColumnName("ImplicitTargetA_3");
            entity.Property(e => e.ImplicitTargetB1).HasColumnName("ImplicitTargetB_1");
            entity.Property(e => e.ImplicitTargetB2).HasColumnName("ImplicitTargetB_2");
            entity.Property(e => e.ImplicitTargetB3).HasColumnName("ImplicitTargetB_3");
            entity.Property(e => e.MinFactionId).HasColumnName("MinFactionID");
            entity.Property(e => e.NameLangDeDe).HasMaxLength(100).HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn).HasMaxLength(100).HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb).HasMaxLength(100).HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw).HasMaxLength(100).HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs).HasMaxLength(100).HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs).HasMaxLength(100).HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx).HasMaxLength(100).HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr).HasMaxLength(100).HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt).HasMaxLength(100).HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr).HasMaxLength(100).HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr).HasMaxLength(100).HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt).HasMaxLength(100).HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu).HasMaxLength(100).HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk).HasMaxLength(100).HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn).HasMaxLength(100).HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw).HasMaxLength(100).HasColumnName("Name_Lang_zhTW");
            entity
                .Property(e => e.NameSubtextLangDeDe)
                .HasMaxLength(100)
                .HasColumnName("NameSubtext_Lang_deDE");
            entity
                .Property(e => e.NameSubtextLangEnCn)
                .HasMaxLength(100)
                .HasColumnName("NameSubtext_Lang_enCN");
            entity
                .Property(e => e.NameSubtextLangEnGb)
                .HasMaxLength(100)
                .HasColumnName("NameSubtext_Lang_enGB");
            entity
                .Property(e => e.NameSubtextLangEnTw)
                .HasMaxLength(100)
                .HasColumnName("NameSubtext_Lang_enTW");
            entity
                .Property(e => e.NameSubtextLangEnUs)
                .HasMaxLength(100)
                .HasColumnName("NameSubtext_Lang_enUS");
            entity
                .Property(e => e.NameSubtextLangEsEs)
                .HasMaxLength(100)
                .HasColumnName("NameSubtext_Lang_esES");
            entity
                .Property(e => e.NameSubtextLangEsMx)
                .HasMaxLength(100)
                .HasColumnName("NameSubtext_Lang_esMX");
            entity
                .Property(e => e.NameSubtextLangFrFr)
                .HasMaxLength(100)
                .HasColumnName("NameSubtext_Lang_frFR");
            entity
                .Property(e => e.NameSubtextLangItIt)
                .HasMaxLength(100)
                .HasColumnName("NameSubtext_Lang_itIT");
            entity
                .Property(e => e.NameSubtextLangKoKr)
                .HasMaxLength(100)
                .HasColumnName("NameSubtext_Lang_koKR");
            entity.Property(e => e.NameSubtextLangMask).HasColumnName("NameSubtext_Lang_Mask");
            entity
                .Property(e => e.NameSubtextLangPtBr)
                .HasMaxLength(100)
                .HasColumnName("NameSubtext_Lang_ptBR");
            entity
                .Property(e => e.NameSubtextLangPtPt)
                .HasMaxLength(100)
                .HasColumnName("NameSubtext_Lang_ptPT");
            entity
                .Property(e => e.NameSubtextLangRuRu)
                .HasMaxLength(100)
                .HasColumnName("NameSubtext_Lang_ruRU");
            entity
                .Property(e => e.NameSubtextLangUnk)
                .HasMaxLength(100)
                .HasColumnName("NameSubtext_Lang_Unk");
            entity
                .Property(e => e.NameSubtextLangZhCn)
                .HasMaxLength(100)
                .HasColumnName("NameSubtext_Lang_zhCN");
            entity
                .Property(e => e.NameSubtextLangZhTw)
                .HasMaxLength(100)
                .HasColumnName("NameSubtext_Lang_zhTW");
            entity.Property(e => e.PowerDisplayId).HasColumnName("PowerDisplayID");
            entity.Property(e => e.Reagent1).HasColumnName("Reagent_1");
            entity.Property(e => e.Reagent2).HasColumnName("Reagent_2");
            entity.Property(e => e.Reagent3).HasColumnName("Reagent_3");
            entity.Property(e => e.Reagent4).HasColumnName("Reagent_4");
            entity.Property(e => e.Reagent5).HasColumnName("Reagent_5");
            entity.Property(e => e.Reagent6).HasColumnName("Reagent_6");
            entity.Property(e => e.Reagent7).HasColumnName("Reagent_7");
            entity.Property(e => e.Reagent8).HasColumnName("Reagent_8");
            entity.Property(e => e.ReagentCount1).HasColumnName("ReagentCount_1");
            entity.Property(e => e.ReagentCount2).HasColumnName("ReagentCount_2");
            entity.Property(e => e.ReagentCount3).HasColumnName("ReagentCount_3");
            entity.Property(e => e.ReagentCount4).HasColumnName("ReagentCount_4");
            entity.Property(e => e.ReagentCount5).HasColumnName("ReagentCount_5");
            entity.Property(e => e.ReagentCount6).HasColumnName("ReagentCount_6");
            entity.Property(e => e.ReagentCount7).HasColumnName("ReagentCount_7");
            entity.Property(e => e.ReagentCount8).HasColumnName("ReagentCount_8");
            entity.Property(e => e.RequiredAreasId).HasColumnName("RequiredAreasID");
            entity
                .Property(e => e.RequiredTotemCategoryId1)
                .HasColumnName("RequiredTotemCategoryID_1");
            entity
                .Property(e => e.RequiredTotemCategoryId2)
                .HasColumnName("RequiredTotemCategoryID_2");
            entity.Property(e => e.RuneCostId).HasColumnName("RuneCostID");
            entity.Property(e => e.SpellClassMask1).HasColumnName("SpellClassMask_1");
            entity.Property(e => e.SpellClassMask2).HasColumnName("SpellClassMask_2");
            entity.Property(e => e.SpellClassMask3).HasColumnName("SpellClassMask_3");
            entity
                .Property(e => e.SpellDescriptionVariableId)
                .HasColumnName("SpellDescriptionVariableID");
            entity.Property(e => e.SpellDifficultyId).HasColumnName("SpellDifficultyID");
            entity.Property(e => e.SpellIconId).HasColumnName("SpellIconID");
            entity.Property(e => e.SpellMissileId).HasColumnName("SpellMissileID");
            entity.Property(e => e.SpellVisualId1).HasColumnName("SpellVisualID_1");
            entity.Property(e => e.SpellVisualId2).HasColumnName("SpellVisualID_2");
            entity.Property(e => e.Totem1).HasColumnName("Totem_1");
            entity.Property(e => e.Totem2).HasColumnName("Totem_2");
            entity.Property(e => e.Unk3202).HasColumnName("unk_320_2");
            entity.Property(e => e.Unk3203).HasColumnName("unk_320_3");
        });

        modelBuilder.Entity<SpellEnchantProcDatum>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity.ToTable(
                "spell_enchant_proc_data",
                tb => tb.HasComment("Spell enchant proc data")
            );

            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.AttributeMask).HasColumnName("attributeMask");
            entity.Property(e => e.CustomChance).HasColumnName("customChance");
            entity.Property(e => e.Ppmchance).HasColumnName("PPMChance");
            entity.Property(e => e.ProcEx).HasColumnName("procEx");
        });

        modelBuilder.Entity<SpellGroup>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.SpellId }).HasName("PRIMARY");

            entity.ToTable("spell_group", tb => tb.HasComment("Spell System"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.SpellId).HasColumnName("spell_id");
            entity.Property(e => e.SpecialFlag).HasColumnName("special_flag");
        });

        modelBuilder.Entity<SpellGroupStackRule>(entity =>
        {
            entity.HasKey(e => e.GroupId).HasName("PRIMARY");

            entity.ToTable("spell_group_stack_rules");

            entity.Property(e => e.GroupId).HasColumnName("group_id");
            entity
                .Property(e => e.Description)
                .HasMaxLength(150)
                .HasDefaultValueSql("''")
                .HasColumnName("description");
            entity.Property(e => e.StackRule).HasColumnName("stack_rule");
        });

        modelBuilder.Entity<SpellLinkedSpell>(entity =>
        {
            entity.HasNoKey().ToTable("spell_linked_spell", tb => tb.HasComment("Spell System"));

            entity
                .HasIndex(
                    e => new
                    {
                        e.SpellTrigger,
                        e.SpellEffect,
                        e.Type
                    },
                    "trigger_effect_type"
                )
                .IsUnique();

            entity.Property(e => e.Comment).HasColumnType("text").HasColumnName("comment");
            entity.Property(e => e.SpellEffect).HasColumnName("spell_effect");
            entity.Property(e => e.SpellTrigger).HasColumnName("spell_trigger");
            entity.Property(e => e.Type).HasColumnName("type");
        });

        modelBuilder.Entity<SpellLootTemplate>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Item }).HasName("PRIMARY");

            entity.ToTable("spell_loot_template", tb => tb.HasComment("Loot System"));

            entity.Property(e => e.Chance).HasDefaultValueSql("'100'");
            entity.Property(e => e.Comment).HasMaxLength(255);
            entity.Property(e => e.LootMode).HasDefaultValueSql("'1'");
            entity.Property(e => e.MaxCount).HasDefaultValueSql("'1'");
            entity.Property(e => e.MinCount).HasDefaultValueSql("'1'");
        });

        modelBuilder.Entity<SpellMixology>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity.ToTable("spell_mixology");

            entity.Property(e => e.Entry).HasColumnName("entry");
            entity
                .Property(e => e.PctMod)
                .HasDefaultValueSql("'30'")
                .HasComment("bonus multiplier")
                .HasColumnName("pctMod");
        });

        modelBuilder.Entity<SpellPetAura>(entity =>
        {
            entity
                .HasKey(e => new
                {
                    e.Spell,
                    e.EffectId,
                    e.Pet
                })
                .HasName("PRIMARY");

            entity.ToTable("spell_pet_auras");

            entity.Property(e => e.Spell).HasComment("dummy spell id").HasColumnName("spell");
            entity.Property(e => e.EffectId).HasColumnName("effectId");
            entity.Property(e => e.Pet).HasComment("pet id; 0 = all").HasColumnName("pet");
            entity.Property(e => e.Aura).HasComment("pet aura id").HasColumnName("aura");
        });

        modelBuilder.Entity<SpellProc>(entity =>
        {
            entity.HasKey(e => e.SpellId).HasName("PRIMARY");

            entity.ToTable("spell_proc");
        });

        modelBuilder.Entity<SpellProcEvent>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity.ToTable("spell_proc_event");

            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.PpmRate).HasColumnName("ppmRate");
            entity.Property(e => e.ProcEx).HasColumnName("procEx");
            entity.Property(e => e.ProcFlags).HasColumnName("procFlags");
            entity.Property(e => e.ProcPhase).HasColumnName("procPhase");
        });

        modelBuilder.Entity<SpellRank>(entity =>
        {
            entity.HasKey(e => new { e.FirstSpellId, e.Rank }).HasName("PRIMARY");

            entity.ToTable("spell_ranks", tb => tb.HasComment("Spell Rank Data"));

            entity.HasIndex(e => e.SpellId, "spell_id").IsUnique();

            entity.Property(e => e.FirstSpellId).HasColumnName("first_spell_id");
            entity.Property(e => e.Rank).HasColumnName("rank");
            entity.Property(e => e.SpellId).HasColumnName("spell_id");
        });

        modelBuilder.Entity<SpellRequired>(entity =>
        {
            entity.HasKey(e => new { e.SpellId, e.ReqSpell }).HasName("PRIMARY");

            entity.ToTable("spell_required", tb => tb.HasComment("Spell Additinal Data"));

            entity.Property(e => e.SpellId).HasColumnName("spell_id");
            entity.Property(e => e.ReqSpell).HasColumnName("req_spell");
        });

        modelBuilder.Entity<SpellScript>(entity =>
        {
            entity.HasNoKey().ToTable("spell_scripts");

            entity.Property(e => e.Command).HasColumnName("command");
            entity.Property(e => e.Dataint).HasColumnName("dataint");
            entity.Property(e => e.Datalong).HasColumnName("datalong");
            entity.Property(e => e.Datalong2).HasColumnName("datalong2");
            entity.Property(e => e.Delay).HasColumnName("delay");
            entity.Property(e => e.EffIndex).HasColumnName("effIndex");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.O).HasColumnName("o");
            entity.Property(e => e.X).HasColumnName("x");
            entity.Property(e => e.Y).HasColumnName("y");
            entity.Property(e => e.Z).HasColumnName("z");
        });

        modelBuilder.Entity<SpellScriptName>(entity =>
        {
            entity.HasNoKey().ToTable("spell_script_names");

            entity.HasIndex(e => new { e.SpellId, e.ScriptName }, "spell_id").IsUnique();

            entity.Property(e => e.ScriptName).HasMaxLength(64).IsFixedLength();
            entity.Property(e => e.SpellId).HasColumnName("spell_id");
        });

        modelBuilder.Entity<SpellTargetPosition>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.EffectIndex }).HasName("PRIMARY");

            entity.ToTable("spell_target_position", tb => tb.HasComment("Spell System"));

            entity.Property(e => e.Id).HasComment("Identifier").HasColumnName("ID");
            entity.Property(e => e.MapId).HasColumnName("MapID");
        });

        modelBuilder.Entity<SpellThreat>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity.ToTable("spell_threat");

            entity.Property(e => e.Entry).HasColumnName("entry");
            entity
                .Property(e => e.ApPctMod)
                .HasComment("additional threat bonus from attack power")
                .HasColumnName("apPctMod");
            entity.Property(e => e.FlatMod).HasColumnName("flatMod");
            entity
                .Property(e => e.PctMod)
                .HasDefaultValueSql("'1'")
                .HasComment("threat multiplier for damage/healing")
                .HasColumnName("pctMod");
        });

        modelBuilder.Entity<SpellcasttimesDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("spellcasttimes_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<SpellcategoryDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("spellcategory_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<SpelldifficultyDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("spelldifficulty_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DifficultySpellId1).HasColumnName("DifficultySpellID_1");
            entity.Property(e => e.DifficultySpellId2).HasColumnName("DifficultySpellID_2");
            entity.Property(e => e.DifficultySpellId3).HasColumnName("DifficultySpellID_3");
            entity.Property(e => e.DifficultySpellId4).HasColumnName("DifficultySpellID_4");
        });

        modelBuilder.Entity<SpelldurationDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("spellduration_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<SpellfocusobjectDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("spellfocusobject_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.NameLangDeDe).HasMaxLength(100).HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn).HasMaxLength(100).HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb).HasMaxLength(100).HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw).HasMaxLength(100).HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs).HasMaxLength(100).HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs).HasMaxLength(100).HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx).HasMaxLength(100).HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr).HasMaxLength(100).HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt).HasMaxLength(100).HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr).HasMaxLength(100).HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr).HasMaxLength(100).HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt).HasMaxLength(100).HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu).HasMaxLength(100).HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk).HasMaxLength(100).HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn).HasMaxLength(100).HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw).HasMaxLength(100).HasColumnName("Name_Lang_zhTW");
        });

        modelBuilder.Entity<SpellitemenchantmentDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("spellitemenchantment_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ConditionId).HasColumnName("Condition_Id");
            entity.Property(e => e.Effect1).HasColumnName("Effect_1");
            entity.Property(e => e.Effect2).HasColumnName("Effect_2");
            entity.Property(e => e.Effect3).HasColumnName("Effect_3");
            entity.Property(e => e.EffectArg1).HasColumnName("EffectArg_1");
            entity.Property(e => e.EffectArg2).HasColumnName("EffectArg_2");
            entity.Property(e => e.EffectArg3).HasColumnName("EffectArg_3");
            entity.Property(e => e.EffectPointsMax1).HasColumnName("EffectPointsMax_1");
            entity.Property(e => e.EffectPointsMax2).HasColumnName("EffectPointsMax_2");
            entity.Property(e => e.EffectPointsMax3).HasColumnName("EffectPointsMax_3");
            entity.Property(e => e.EffectPointsMin1).HasColumnName("EffectPointsMin_1");
            entity.Property(e => e.EffectPointsMin2).HasColumnName("EffectPointsMin_2");
            entity.Property(e => e.EffectPointsMin3).HasColumnName("EffectPointsMin_3");
            entity.Property(e => e.NameLangDeDe).HasMaxLength(100).HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn).HasMaxLength(100).HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb).HasMaxLength(100).HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw).HasMaxLength(100).HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs).HasMaxLength(100).HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs).HasMaxLength(100).HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx).HasMaxLength(100).HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr).HasMaxLength(100).HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt).HasMaxLength(100).HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr).HasMaxLength(100).HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr).HasMaxLength(100).HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt).HasMaxLength(100).HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu).HasMaxLength(100).HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk).HasMaxLength(100).HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn).HasMaxLength(100).HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw).HasMaxLength(100).HasColumnName("Name_Lang_zhTW");
            entity.Property(e => e.RequiredSkillId).HasColumnName("RequiredSkillID");
            entity.Property(e => e.SrcItemId).HasColumnName("Src_ItemID");
        });

        modelBuilder.Entity<SpellitemenchantmentconditionDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("spellitemenchantmentcondition_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Logic1).HasColumnName("Logic_1");
            entity.Property(e => e.Logic2).HasColumnName("Logic_2");
            entity.Property(e => e.Logic3).HasColumnName("Logic_3");
            entity.Property(e => e.Logic4).HasColumnName("Logic_4");
            entity.Property(e => e.Logic5).HasColumnName("Logic_5");
            entity.Property(e => e.LtOperand1).HasColumnName("Lt_Operand_1");
            entity.Property(e => e.LtOperand2).HasColumnName("Lt_Operand_2");
            entity.Property(e => e.LtOperand3).HasColumnName("Lt_Operand_3");
            entity.Property(e => e.LtOperand4).HasColumnName("Lt_Operand_4");
            entity.Property(e => e.LtOperand5).HasColumnName("Lt_Operand_5");
            entity.Property(e => e.LtOperandType1).HasColumnName("Lt_OperandType_1");
            entity.Property(e => e.LtOperandType2).HasColumnName("Lt_OperandType_2");
            entity.Property(e => e.LtOperandType3).HasColumnName("Lt_OperandType_3");
            entity.Property(e => e.LtOperandType4).HasColumnName("Lt_OperandType_4");
            entity.Property(e => e.LtOperandType5).HasColumnName("Lt_OperandType_5");
            entity.Property(e => e.Operator1).HasColumnName("Operator_1");
            entity.Property(e => e.Operator2).HasColumnName("Operator_2");
            entity.Property(e => e.Operator3).HasColumnName("Operator_3");
            entity.Property(e => e.Operator4).HasColumnName("Operator_4");
            entity.Property(e => e.Operator5).HasColumnName("Operator_5");
            entity.Property(e => e.RtOperand1).HasColumnName("Rt_Operand_1");
            entity.Property(e => e.RtOperand2).HasColumnName("Rt_Operand_2");
            entity.Property(e => e.RtOperand3).HasColumnName("Rt_Operand_3");
            entity.Property(e => e.RtOperand4).HasColumnName("Rt_Operand_4");
            entity.Property(e => e.RtOperand5).HasColumnName("Rt_Operand_5");
            entity.Property(e => e.RtOperandType1).HasColumnName("Rt_OperandType_1");
            entity.Property(e => e.RtOperandType2).HasColumnName("Rt_OperandType_2");
            entity.Property(e => e.RtOperandType3).HasColumnName("Rt_OperandType_3");
            entity.Property(e => e.RtOperandType4).HasColumnName("Rt_OperandType_4");
            entity.Property(e => e.RtOperandType5).HasColumnName("Rt_OperandType_5");
        });

        modelBuilder.Entity<SpellradiusDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("spellradius_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<SpellrangeDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("spellrange_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity
                .Property(e => e.DisplayNameLangDeDe)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_deDE");
            entity
                .Property(e => e.DisplayNameLangEnCn)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_enCN");
            entity
                .Property(e => e.DisplayNameLangEnGb)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_enGB");
            entity
                .Property(e => e.DisplayNameLangEnTw)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_enTW");
            entity
                .Property(e => e.DisplayNameLangEnUs)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_enUS");
            entity
                .Property(e => e.DisplayNameLangEsEs)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_esES");
            entity
                .Property(e => e.DisplayNameLangEsMx)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_esMX");
            entity
                .Property(e => e.DisplayNameLangFrFr)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_frFR");
            entity
                .Property(e => e.DisplayNameLangItIt)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_itIT");
            entity
                .Property(e => e.DisplayNameLangKoKr)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_koKR");
            entity.Property(e => e.DisplayNameLangMask).HasColumnName("DisplayName_Lang_Mask");
            entity
                .Property(e => e.DisplayNameLangPtBr)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_ptBR");
            entity
                .Property(e => e.DisplayNameLangPtPt)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_ptPT");
            entity
                .Property(e => e.DisplayNameLangRuRu)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_ruRU");
            entity
                .Property(e => e.DisplayNameLangUnk)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_Unk");
            entity
                .Property(e => e.DisplayNameLangZhCn)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_zhCN");
            entity
                .Property(e => e.DisplayNameLangZhTw)
                .HasColumnType("text")
                .HasColumnName("DisplayName_Lang_zhTW");
            entity
                .Property(e => e.DisplayNameShortLangDeDe)
                .HasColumnType("text")
                .HasColumnName("DisplayNameShort_Lang_deDE");
            entity
                .Property(e => e.DisplayNameShortLangEnCn)
                .HasColumnType("text")
                .HasColumnName("DisplayNameShort_Lang_enCN");
            entity
                .Property(e => e.DisplayNameShortLangEnGb)
                .HasColumnType("text")
                .HasColumnName("DisplayNameShort_Lang_enGB");
            entity
                .Property(e => e.DisplayNameShortLangEnTw)
                .HasColumnType("text")
                .HasColumnName("DisplayNameShort_Lang_enTW");
            entity
                .Property(e => e.DisplayNameShortLangEnUs)
                .HasColumnType("text")
                .HasColumnName("DisplayNameShort_Lang_enUS");
            entity
                .Property(e => e.DisplayNameShortLangEsEs)
                .HasColumnType("text")
                .HasColumnName("DisplayNameShort_Lang_esES");
            entity
                .Property(e => e.DisplayNameShortLangEsMx)
                .HasColumnType("text")
                .HasColumnName("DisplayNameShort_Lang_esMX");
            entity
                .Property(e => e.DisplayNameShortLangFrFr)
                .HasColumnType("text")
                .HasColumnName("DisplayNameShort_Lang_frFR");
            entity
                .Property(e => e.DisplayNameShortLangItIt)
                .HasColumnType("text")
                .HasColumnName("DisplayNameShort_Lang_itIT");
            entity
                .Property(e => e.DisplayNameShortLangKoKr)
                .HasColumnType("text")
                .HasColumnName("DisplayNameShort_Lang_koKR");
            entity
                .Property(e => e.DisplayNameShortLangMask)
                .HasColumnName("DisplayNameShort_Lang_Mask");
            entity
                .Property(e => e.DisplayNameShortLangPtBr)
                .HasColumnType("text")
                .HasColumnName("DisplayNameShort_Lang_ptBR");
            entity
                .Property(e => e.DisplayNameShortLangPtPt)
                .HasColumnType("text")
                .HasColumnName("DisplayNameShort_Lang_ptPT");
            entity
                .Property(e => e.DisplayNameShortLangRuRu)
                .HasColumnType("text")
                .HasColumnName("DisplayNameShort_Lang_ruRU");
            entity
                .Property(e => e.DisplayNameShortLangUnk)
                .HasColumnType("text")
                .HasColumnName("DisplayNameShort_Lang_Unk");
            entity
                .Property(e => e.DisplayNameShortLangZhCn)
                .HasColumnType("text")
                .HasColumnName("DisplayNameShort_Lang_zhCN");
            entity
                .Property(e => e.DisplayNameShortLangZhTw)
                .HasColumnType("text")
                .HasColumnName("DisplayNameShort_Lang_zhTW");
            entity.Property(e => e.RangeMax1).HasColumnName("RangeMax_1");
            entity.Property(e => e.RangeMax2).HasColumnName("RangeMax_2");
            entity.Property(e => e.RangeMin1).HasColumnName("RangeMin_1");
            entity.Property(e => e.RangeMin2).HasColumnName("RangeMin_2");
        });

        modelBuilder.Entity<SpellrunecostDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("spellrunecost_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<SpellshapeshiftformDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("spellshapeshiftform_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AttackIconId).HasColumnName("AttackIconID");
            entity.Property(e => e.CreatureDisplayId1).HasColumnName("CreatureDisplayID_1");
            entity.Property(e => e.CreatureDisplayId2).HasColumnName("CreatureDisplayID_2");
            entity.Property(e => e.CreatureDisplayId3).HasColumnName("CreatureDisplayID_3");
            entity.Property(e => e.CreatureDisplayId4).HasColumnName("CreatureDisplayID_4");
            entity.Property(e => e.NameLangDeDe).HasMaxLength(100).HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn).HasMaxLength(100).HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb).HasMaxLength(100).HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw).HasMaxLength(100).HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs).HasMaxLength(100).HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs).HasMaxLength(100).HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx).HasMaxLength(100).HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr).HasMaxLength(100).HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt).HasMaxLength(100).HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr).HasMaxLength(100).HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr).HasMaxLength(100).HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt).HasMaxLength(100).HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu).HasMaxLength(100).HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk).HasMaxLength(100).HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn).HasMaxLength(100).HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw).HasMaxLength(100).HasColumnName("Name_Lang_zhTW");
            entity.Property(e => e.PresetSpellId1).HasColumnName("PresetSpellID_1");
            entity.Property(e => e.PresetSpellId2).HasColumnName("PresetSpellID_2");
            entity.Property(e => e.PresetSpellId3).HasColumnName("PresetSpellID_3");
            entity.Property(e => e.PresetSpellId4).HasColumnName("PresetSpellID_4");
            entity.Property(e => e.PresetSpellId5).HasColumnName("PresetSpellID_5");
            entity.Property(e => e.PresetSpellId6).HasColumnName("PresetSpellID_6");
            entity.Property(e => e.PresetSpellId7).HasColumnName("PresetSpellID_7");
            entity.Property(e => e.PresetSpellId8).HasColumnName("PresetSpellID_8");
        });

        modelBuilder.Entity<SpellvisualDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("spellvisual_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AnimEventSoundId).HasColumnName("AnimEventSoundID");
        });

        modelBuilder.Entity<StableslotpricesDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("stableslotprices_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<SummonpropertiesDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("summonproperties_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<TalentDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("talent_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CategoryMask1).HasColumnName("CategoryMask_1");
            entity.Property(e => e.CategoryMask2).HasColumnName("CategoryMask_2");
            entity.Property(e => e.PrereqRank1).HasColumnName("PrereqRank_1");
            entity.Property(e => e.PrereqRank2).HasColumnName("PrereqRank_2");
            entity.Property(e => e.PrereqRank3).HasColumnName("PrereqRank_3");
            entity.Property(e => e.PrereqTalent1).HasColumnName("PrereqTalent_1");
            entity.Property(e => e.PrereqTalent2).HasColumnName("PrereqTalent_2");
            entity.Property(e => e.PrereqTalent3).HasColumnName("PrereqTalent_3");
            entity.Property(e => e.RequiredSpellId).HasColumnName("RequiredSpellID");
            entity.Property(e => e.SpellRank1).HasColumnName("SpellRank_1");
            entity.Property(e => e.SpellRank2).HasColumnName("SpellRank_2");
            entity.Property(e => e.SpellRank3).HasColumnName("SpellRank_3");
            entity.Property(e => e.SpellRank4).HasColumnName("SpellRank_4");
            entity.Property(e => e.SpellRank5).HasColumnName("SpellRank_5");
            entity.Property(e => e.SpellRank6).HasColumnName("SpellRank_6");
            entity.Property(e => e.SpellRank7).HasColumnName("SpellRank_7");
            entity.Property(e => e.SpellRank8).HasColumnName("SpellRank_8");
            entity.Property(e => e.SpellRank9).HasColumnName("SpellRank_9");
            entity.Property(e => e.TabId).HasColumnName("TabID");
            entity.Property(e => e.TierId).HasColumnName("TierID");
        });

        modelBuilder.Entity<TalenttabDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("talenttab_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BackgroundFile).HasMaxLength(100);
            entity.Property(e => e.NameLangDeDe).HasMaxLength(100).HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn).HasMaxLength(100).HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb).HasMaxLength(100).HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw).HasMaxLength(100).HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs).HasMaxLength(100).HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs).HasMaxLength(100).HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx).HasMaxLength(100).HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr).HasMaxLength(100).HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt).HasMaxLength(100).HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr).HasMaxLength(100).HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr).HasMaxLength(100).HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt).HasMaxLength(100).HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu).HasMaxLength(100).HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk).HasMaxLength(100).HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn).HasMaxLength(100).HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw).HasMaxLength(100).HasColumnName("Name_Lang_zhTW");
            entity.Property(e => e.SpellIconId).HasColumnName("SpellIconID");
        });

        modelBuilder.Entity<TaxinodesDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("taxinodes_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ContinentId).HasColumnName("ContinentID");
            entity.Property(e => e.MountCreatureId1).HasColumnName("MountCreatureID_1");
            entity.Property(e => e.MountCreatureId2).HasColumnName("MountCreatureID_2");
            entity.Property(e => e.NameLangDeDe).HasMaxLength(100).HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn).HasMaxLength(100).HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb).HasMaxLength(100).HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw).HasMaxLength(100).HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs).HasMaxLength(100).HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs).HasMaxLength(100).HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx).HasMaxLength(100).HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr).HasMaxLength(100).HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt).HasMaxLength(100).HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr).HasMaxLength(100).HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr).HasMaxLength(100).HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt).HasMaxLength(100).HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu).HasMaxLength(100).HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk).HasMaxLength(100).HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn).HasMaxLength(100).HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw).HasMaxLength(100).HasColumnName("Name_Lang_zhTW");
        });

        modelBuilder.Entity<TaxipathDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("taxipath_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<TaxipathnodeDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("taxipathnode_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ArrivalEventId).HasColumnName("ArrivalEventID");
            entity.Property(e => e.ContinentId).HasColumnName("ContinentID");
            entity.Property(e => e.DepartureEventId).HasColumnName("DepartureEventID");
            entity.Property(e => e.PathId).HasColumnName("PathID");
        });

        modelBuilder.Entity<TeamcontributionpointsDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("teamcontributionpoints_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<TotemcategoryDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("totemcategory_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.NameLangDeDe).HasMaxLength(100).HasColumnName("Name_Lang_deDE");
            entity.Property(e => e.NameLangEnCn).HasMaxLength(100).HasColumnName("Name_Lang_enCN");
            entity.Property(e => e.NameLangEnGb).HasMaxLength(100).HasColumnName("Name_Lang_enGB");
            entity.Property(e => e.NameLangEnTw).HasMaxLength(100).HasColumnName("Name_Lang_enTW");
            entity.Property(e => e.NameLangEnUs).HasMaxLength(100).HasColumnName("Name_Lang_enUS");
            entity.Property(e => e.NameLangEsEs).HasMaxLength(100).HasColumnName("Name_Lang_esES");
            entity.Property(e => e.NameLangEsMx).HasMaxLength(100).HasColumnName("Name_Lang_esMX");
            entity.Property(e => e.NameLangFrFr).HasMaxLength(100).HasColumnName("Name_Lang_frFR");
            entity.Property(e => e.NameLangItIt).HasMaxLength(100).HasColumnName("Name_Lang_itIT");
            entity.Property(e => e.NameLangKoKr).HasMaxLength(100).HasColumnName("Name_Lang_koKR");
            entity.Property(e => e.NameLangMask).HasColumnName("Name_Lang_Mask");
            entity.Property(e => e.NameLangPtBr).HasMaxLength(100).HasColumnName("Name_Lang_ptBR");
            entity.Property(e => e.NameLangPtPt).HasMaxLength(100).HasColumnName("Name_Lang_ptPT");
            entity.Property(e => e.NameLangRuRu).HasMaxLength(100).HasColumnName("Name_Lang_ruRU");
            entity.Property(e => e.NameLangUnk).HasMaxLength(100).HasColumnName("Name_Lang_Unk");
            entity.Property(e => e.NameLangZhCn).HasMaxLength(100).HasColumnName("Name_Lang_zhCN");
            entity.Property(e => e.NameLangZhTw).HasMaxLength(100).HasColumnName("Name_Lang_zhTW");
        });

        modelBuilder.Entity<Transport>(entity =>
        {
            entity.HasKey(e => e.Guid).HasName("PRIMARY");

            entity.ToTable("transports", tb => tb.HasComment("Transports"));

            entity.HasIndex(e => e.Entry, "idx_entry").IsUnique();

            entity.Property(e => e.Guid).HasColumnName("guid");
            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.Name).HasColumnType("text").HasColumnName("name");
            entity
                .Property(e => e.ScriptName)
                .HasMaxLength(64)
                .HasDefaultValueSql("''")
                .IsFixedLength();
        });

        modelBuilder.Entity<TransportanimationDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("transportanimation_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.SequenceId).HasColumnName("SequenceID");
            entity.Property(e => e.TransportId).HasColumnName("TransportID");
        });

        modelBuilder.Entity<TransportrotationDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("transportrotation_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.GameObjectsId).HasColumnName("GameObjectsID");
        });

        modelBuilder.Entity<Update>(entity =>
        {
            entity.HasKey(e => e.Name).HasName("PRIMARY");

            entity.ToTable(
                "updates",
                tb => tb.HasComment("List of all applied updates in this database.")
            );

            entity
                .Property(e => e.Name)
                .HasMaxLength(200)
                .HasComment("filename with extension of the update.")
                .HasColumnName("name");
            entity
                .Property(e => e.Hash)
                .HasMaxLength(40)
                .HasDefaultValueSql("''")
                .IsFixedLength()
                .HasComment("sha1 hash of the sql file.")
                .HasColumnName("hash");
            entity
                .Property(e => e.Speed)
                .HasComment("time the query takes to apply in ms.")
                .HasColumnName("speed");
            entity
                .Property(e => e.State)
                .HasDefaultValueSql("'RELEASED'")
                .HasComment("defines if an update is released or archived.")
                .HasColumnType("enum('RELEASED','CUSTOM','MODULE','ARCHIVED')")
                .HasColumnName("state");
            entity
                .Property(e => e.Timestamp)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasComment("timestamp when the query was applied.")
                .HasColumnType("timestamp")
                .HasColumnName("timestamp");
        });

        modelBuilder.Entity<UpdatesInclude>(entity =>
        {
            entity.HasKey(e => e.Path).HasName("PRIMARY");

            entity.ToTable(
                "updates_include",
                tb => tb.HasComment("List of directories where we want to include sql updates.")
            );

            entity
                .Property(e => e.Path)
                .HasMaxLength(200)
                .HasComment("directory to include. $ means relative to the source directory.")
                .HasColumnName("path");
            entity
                .Property(e => e.State)
                .HasDefaultValueSql("'RELEASED'")
                .HasComment("defines if the directory contains released or archived updates.")
                .HasColumnType("enum('RELEASED','ARCHIVED','CUSTOM')")
                .HasColumnName("state");
        });

        modelBuilder.Entity<VehicleAccessory>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.SeatId }).HasName("PRIMARY");

            entity.ToTable("vehicle_accessory");

            entity.Property(e => e.Guid).HasColumnName("guid");
            entity.Property(e => e.SeatId).HasColumnName("seat_id");
            entity.Property(e => e.AccessoryEntry).HasColumnName("accessory_entry");
            entity.Property(e => e.Description).HasColumnType("text").HasColumnName("description");
            entity.Property(e => e.Minion).HasColumnName("minion");
            entity
                .Property(e => e.Summontimer)
                .HasDefaultValueSql("'30000'")
                .HasComment("timer, only relevant for certain summontypes")
                .HasColumnName("summontimer");
            entity
                .Property(e => e.Summontype)
                .HasDefaultValueSql("'6'")
                .HasComment("see enum TempSummonType")
                .HasColumnName("summontype");
        });

        modelBuilder.Entity<VehicleDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("vehicle_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MsslTrgtArcTexture).HasMaxLength(100);
            entity
                .Property(e => e.MsslTrgtImpactModel1)
                .HasMaxLength(100)
                .HasColumnName("MsslTrgtImpactModel_1");
            entity
                .Property(e => e.MsslTrgtImpactModel2)
                .HasMaxLength(100)
                .HasColumnName("MsslTrgtImpactModel_2");
            entity.Property(e => e.MsslTrgtImpactRadius1).HasColumnName("MsslTrgtImpactRadius_1");
            entity.Property(e => e.MsslTrgtImpactRadius2).HasColumnName("MsslTrgtImpactRadius_2");
            entity.Property(e => e.MsslTrgtImpactTexture).HasMaxLength(100);
            entity.Property(e => e.PowerDisplayId1).HasColumnName("PowerDisplayID_1");
            entity.Property(e => e.PowerDisplayId2).HasColumnName("PowerDisplayID_2");
            entity.Property(e => e.PowerDisplayId3).HasColumnName("PowerDisplayID_3");
            entity.Property(e => e.SeatId1).HasColumnName("SeatID_1");
            entity.Property(e => e.SeatId2).HasColumnName("SeatID_2");
            entity.Property(e => e.SeatId3).HasColumnName("SeatID_3");
            entity.Property(e => e.SeatId4).HasColumnName("SeatID_4");
            entity.Property(e => e.SeatId5).HasColumnName("SeatID_5");
            entity.Property(e => e.SeatId6).HasColumnName("SeatID_6");
            entity.Property(e => e.SeatId7).HasColumnName("SeatID_7");
            entity.Property(e => e.SeatId8).HasColumnName("SeatID_8");
            entity.Property(e => e.VehicleUiindicatorId).HasColumnName("VehicleUIIndicatorID");
        });

        modelBuilder.Entity<VehicleTemplateAccessory>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.SeatId }).HasName("PRIMARY");

            entity.ToTable("vehicle_template_accessory");

            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.SeatId).HasColumnName("seat_id");
            entity.Property(e => e.AccessoryEntry).HasColumnName("accessory_entry");
            entity.Property(e => e.Description).HasColumnType("text").HasColumnName("description");
            entity.Property(e => e.Minion).HasColumnName("minion");
            entity
                .Property(e => e.Summontimer)
                .HasDefaultValueSql("'30000'")
                .HasComment("timer, only relevant for certain summontypes")
                .HasColumnName("summontimer");
            entity
                .Property(e => e.Summontype)
                .HasDefaultValueSql("'6'")
                .HasComment("see enum TempSummonType")
                .HasColumnName("summontype");
        });

        modelBuilder.Entity<VehicleseatDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("vehicleseat_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AttachmentId).HasColumnName("AttachmentID");
            entity.Property(e => e.EnterUisoundId).HasColumnName("EnterUISoundID");
            entity.Property(e => e.ExitUisoundId).HasColumnName("ExitUISoundID");
            entity.Property(e => e.PassengerAttachmentId).HasColumnName("PassengerAttachmentID");
        });

        modelBuilder.Entity<Models.Acore.World.Version>(entity =>
        {
            entity.HasKey(e => e.CoreVersion).HasName("PRIMARY");

            entity.ToTable("version", tb => tb.HasComment("Version Notes"));

            entity
                .Property(e => e.CoreVersion)
                .HasDefaultValueSql("''")
                .HasComment("Core revision dumped at startup.")
                .HasColumnName("core_version");
            entity.Property(e => e.CacheId).HasDefaultValueSql("'0'").HasColumnName("cache_id");
            entity.Property(e => e.CoreRevision).HasMaxLength(120).HasColumnName("core_revision");
            entity
                .Property(e => e.DbVersion)
                .HasMaxLength(120)
                .HasComment("Version of world DB.")
                .HasColumnName("db_version");
        });

        modelBuilder.Entity<WardenCheck>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("warden_checks");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address).HasColumnName("address");
            entity.Property(e => e.Comment).HasMaxLength(50).HasColumnName("comment");
            entity.Property(e => e.Data).HasMaxLength(48).HasColumnName("data");
            entity.Property(e => e.Length).HasColumnName("length");
            entity.Property(e => e.Result).HasMaxLength(24).HasColumnName("result");
            entity.Property(e => e.Str).HasMaxLength(170).HasColumnName("str");
            entity.Property(e => e.Type).HasColumnName("type");
        });

        modelBuilder.Entity<Waypoint>(entity =>
        {
            entity.HasKey(e => new { e.Entry, e.Pointid }).HasName("PRIMARY");

            entity.ToTable("waypoints", tb => tb.HasComment("Creature waypoints"));

            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.Pointid).HasColumnName("pointid");
            entity.Property(e => e.Delay).HasColumnName("delay");
            entity.Property(e => e.Orientation).HasColumnName("orientation");
            entity
                .Property(e => e.PointComment)
                .HasColumnType("text")
                .HasColumnName("point_comment");
            entity.Property(e => e.PositionX).HasColumnName("position_x");
            entity.Property(e => e.PositionY).HasColumnName("position_y");
            entity.Property(e => e.PositionZ).HasColumnName("position_z");
        });

        modelBuilder.Entity<WaypointDatum>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Point }).HasName("PRIMARY");

            entity.ToTable("waypoint_data");

            entity.Property(e => e.Id).HasComment("Creature GUID").HasColumnName("id");
            entity.Property(e => e.Point).HasColumnName("point");
            entity.Property(e => e.Action).HasColumnName("action");
            entity
                .Property(e => e.ActionChance)
                .HasDefaultValueSql("'100'")
                .HasColumnName("action_chance");
            entity.Property(e => e.Delay).HasColumnName("delay");
            entity.Property(e => e.MoveType).HasColumnName("move_type");
            entity.Property(e => e.Orientation).HasColumnName("orientation");
            entity.Property(e => e.PositionX).HasColumnName("position_x");
            entity.Property(e => e.PositionY).HasColumnName("position_y");
            entity.Property(e => e.PositionZ).HasColumnName("position_z");
            entity.Property(e => e.Wpguid).HasColumnName("wpguid");
        });

        modelBuilder.Entity<WaypointScript>(entity =>
        {
            entity.HasKey(e => e.Guid).HasName("PRIMARY");

            entity.ToTable("waypoint_scripts");

            entity.Property(e => e.Guid).HasColumnName("guid");
            entity.Property(e => e.Command).HasColumnName("command");
            entity.Property(e => e.Dataint).HasColumnName("dataint");
            entity.Property(e => e.Datalong).HasColumnName("datalong");
            entity.Property(e => e.Datalong2).HasColumnName("datalong2");
            entity.Property(e => e.Delay).HasColumnName("delay");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.O).HasColumnName("o");
            entity.Property(e => e.X).HasColumnName("x");
            entity.Property(e => e.Y).HasColumnName("y");
            entity.Property(e => e.Z).HasColumnName("z");
        });

        modelBuilder.Entity<WmoareatableDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("wmoareatable_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AmbienceId).HasColumnName("AmbienceID");
            entity
                .Property(e => e.AreaNameLangDeDe)
                .HasMaxLength(100)
                .HasColumnName("AreaName_Lang_deDE");
            entity
                .Property(e => e.AreaNameLangEnCn)
                .HasMaxLength(100)
                .HasColumnName("AreaName_Lang_enCN");
            entity
                .Property(e => e.AreaNameLangEnGb)
                .HasMaxLength(100)
                .HasColumnName("AreaName_Lang_enGB");
            entity
                .Property(e => e.AreaNameLangEnTw)
                .HasMaxLength(100)
                .HasColumnName("AreaName_Lang_enTW");
            entity
                .Property(e => e.AreaNameLangEnUs)
                .HasMaxLength(100)
                .HasColumnName("AreaName_Lang_enUS");
            entity
                .Property(e => e.AreaNameLangEsEs)
                .HasMaxLength(100)
                .HasColumnName("AreaName_Lang_esES");
            entity
                .Property(e => e.AreaNameLangEsMx)
                .HasMaxLength(100)
                .HasColumnName("AreaName_Lang_esMX");
            entity
                .Property(e => e.AreaNameLangFrFr)
                .HasMaxLength(100)
                .HasColumnName("AreaName_Lang_frFR");
            entity
                .Property(e => e.AreaNameLangItIt)
                .HasMaxLength(100)
                .HasColumnName("AreaName_Lang_itIT");
            entity
                .Property(e => e.AreaNameLangKoKr)
                .HasMaxLength(100)
                .HasColumnName("AreaName_Lang_koKR");
            entity.Property(e => e.AreaNameLangMask).HasColumnName("AreaName_Lang_Mask");
            entity
                .Property(e => e.AreaNameLangPtBr)
                .HasMaxLength(100)
                .HasColumnName("AreaName_Lang_ptBR");
            entity
                .Property(e => e.AreaNameLangPtPt)
                .HasMaxLength(100)
                .HasColumnName("AreaName_Lang_ptPT");
            entity
                .Property(e => e.AreaNameLangRuRu)
                .HasMaxLength(100)
                .HasColumnName("AreaName_Lang_ruRU");
            entity
                .Property(e => e.AreaNameLangUnk)
                .HasMaxLength(100)
                .HasColumnName("AreaName_Lang_Unk");
            entity
                .Property(e => e.AreaNameLangZhCn)
                .HasMaxLength(100)
                .HasColumnName("AreaName_Lang_zhCN");
            entity
                .Property(e => e.AreaNameLangZhTw)
                .HasMaxLength(100)
                .HasColumnName("AreaName_Lang_zhTW");
            entity.Property(e => e.AreaTableId).HasColumnName("AreaTableID");
            entity.Property(e => e.NameSetId).HasColumnName("NameSetID");
            entity.Property(e => e.WmogroupId).HasColumnName("WMOGroupID");
            entity.Property(e => e.Wmoid).HasColumnName("WMOID");
        });

        modelBuilder.Entity<WorldmapareaDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("worldmaparea_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AreaId).HasColumnName("AreaID");
            entity.Property(e => e.AreaName).HasMaxLength(100);
            entity.Property(e => e.DisplayMapId).HasColumnName("DisplayMapID");
            entity.Property(e => e.MapId).HasColumnName("MapID");
            entity.Property(e => e.ParentWorldMapId).HasColumnName("ParentWorldMapID");
        });

        modelBuilder.Entity<WorldmapoverlayDbc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("worldmapoverlay_dbc");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AreaId1).HasColumnName("AreaID_1");
            entity.Property(e => e.AreaId2).HasColumnName("AreaID_2");
            entity.Property(e => e.AreaId3).HasColumnName("AreaID_3");
            entity.Property(e => e.AreaId4).HasColumnName("AreaID_4");
            entity.Property(e => e.MapAreaId).HasColumnName("MapAreaID");
            entity.Property(e => e.TextureName).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
