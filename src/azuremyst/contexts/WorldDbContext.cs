using azuremyst.models.mangosd;
using Microsoft.EntityFrameworkCore;

namespace azuremyst.contexts
{
    public partial class WorldDbContext : DbContext
    {
        public WorldDbContext(DbContextOptions<WorldDbContext> options)
            : base(options) { }

        public virtual DbSet<AreatriggerInvolvedrelation>? AreatriggerInvolvedrelations { get; set; } = null!;
        public virtual DbSet<AreatriggerTavern>? AreatriggerTaverns { get; set; } = null!;
        public virtual DbSet<AreatriggerTeleport>? AreatriggerTeleports { get; set; } = null!;
        public virtual DbSet<BattlegroundEvent>? BattlegroundEvents { get; set; } = null!;
        public virtual DbSet<BattlegroundTemplate>? BattlegroundTemplates { get; set; } = null!;
        public virtual DbSet<BattlemasterEntry>? BattlemasterEntries { get; set; } = null!;
        public virtual DbSet<Command>? Commands { get; set; } = null!;
        public virtual DbSet<Condition>? Conditions { get; set; } = null!;
        public virtual DbSet<Creature>? Creatures { get; set; } = null!;
        public virtual DbSet<CreatureAddon>? CreatureAddons { get; set; } = null!;
        public virtual DbSet<CreatureAiScript>? CreatureAiScripts { get; set; } = null!;
        public virtual DbSet<CreatureAiSummon>? CreatureAiSummons { get; set; } = null!;
        public virtual DbSet<CreatureAiText>? CreatureAiTexts { get; set; } = null!;
        public virtual DbSet<CreatureBattleground>? CreatureBattlegrounds { get; set; } = null!;
        public virtual DbSet<CreatureConditionalSpawn>? CreatureConditionalSpawns { get; set; } = null!;
        public virtual DbSet<CreatureCooldown>? CreatureCooldowns { get; set; } = null!;
        public virtual DbSet<CreatureEquipTemplate>? CreatureEquipTemplates { get; set; } = null!;
        public virtual DbSet<CreatureEquipTemplateRaw>? CreatureEquipTemplateRaws { get; set; } = null!;
        public virtual DbSet<CreatureImmunity>? CreatureImmunities { get; set; } = null!;
        public virtual DbSet<CreatureInvolvedrelation>? CreatureInvolvedrelations { get; set; } = null!;
        public virtual DbSet<CreatureLinking>? CreatureLinkings { get; set; } = null!;
        public virtual DbSet<CreatureLinkingTemplate>? CreatureLinkingTemplates { get; set; } = null!;
        public virtual DbSet<CreatureLootTemplate>? CreatureLootTemplates { get; set; } = null!;
        public virtual DbSet<CreatureModelInfo>? CreatureModelInfos { get; set; } = null!;
        public virtual DbSet<CreatureModelRace>? CreatureModelRaces { get; set; } = null!;
        public virtual DbSet<CreatureMovement>? CreatureMovements { get; set; } = null!;
        public virtual DbSet<CreatureMovementTemplate>? CreatureMovementTemplates { get; set; } = null!;
        public virtual DbSet<CreatureOnkillReputation>? CreatureOnkillReputations { get; set; } = null!;
        public virtual DbSet<CreatureQuestrelation>? CreatureQuestrelations { get; set; } = null!;
        public virtual DbSet<CreatureSpawnDataTemplate>? CreatureSpawnDataTemplates { get; set; } = null!;
        public virtual DbSet<CreatureSpawnDatum>? CreatureSpawnData { get; set; } = null!;
        public virtual DbSet<CreatureSpawnEntry>? CreatureSpawnEntries { get; set; } = null!;
        public virtual DbSet<CreatureSpellList>? CreatureSpellLists { get; set; } = null!;
        public virtual DbSet<CreatureSpellListEntry>? CreatureSpellListEntries { get; set; } = null!;
        public virtual DbSet<CreatureSpellTargeting>? CreatureSpellTargetings { get; set; } = null!;
        public virtual DbSet<CreatureTemplate>? CreatureTemplates { get; set; } = null!;
        public virtual DbSet<CreatureTemplateAddon>? CreatureTemplateAddons { get; set; } = null!;
        public virtual DbSet<CreatureTemplateSpell>? CreatureTemplateSpells { get; set; } = null!;
        public virtual DbSet<CustomText>? CustomTexts { get; set; } = null!;
        public virtual DbSet<DbVersion>? DbVersions { get; set; } = null!;
        public virtual DbSet<DbscriptRandomTemplate>? DbscriptRandomTemplates { get; set; } = null!;
        public virtual DbSet<DbscriptString>? DbscriptStrings { get; set; } = null!;
        public virtual DbSet<DbscriptStringTemplate>? DbscriptStringTemplates { get; set; } = null!;
        public virtual DbSet<DbscriptsOnCreatureDeath>? DbscriptsOnCreatureDeaths { get; set; } = null!;
        public virtual DbSet<DbscriptsOnCreatureMovement>? DbscriptsOnCreatureMovements { get; set; } = null!;
        public virtual DbSet<DbscriptsOnEvent>? DbscriptsOnEvents { get; set; } = null!;
        public virtual DbSet<DbscriptsOnGoTemplateUse>? DbscriptsOnGoTemplateUses { get; set; } = null!;
        public virtual DbSet<DbscriptsOnGoUse>? DbscriptsOnGoUses { get; set; } = null!;
        public virtual DbSet<DbscriptsOnGossip>? DbscriptsOnGossips { get; set; } = null!;
        public virtual DbSet<DbscriptsOnQuestEnd>? DbscriptsOnQuestEnds { get; set; } = null!;
        public virtual DbSet<DbscriptsOnQuestStart>? DbscriptsOnQuestStarts { get; set; } = null!;
        public virtual DbSet<DbscriptsOnSpell>? DbscriptsOnSpells { get; set; } = null!;
        public virtual DbSet<DisenchantLootTemplate>? DisenchantLootTemplates { get; set; } = null!;
        public virtual DbSet<ExplorationBasexp>? ExplorationBasexps { get; set; } = null!;
        public virtual DbSet<FishingLootTemplate>? FishingLootTemplates { get; set; } = null!;
        public virtual DbSet<GameEvent>? GameEvents { get; set; } = null!;
        public virtual DbSet<GameEventCreature>? GameEventCreatures { get; set; } = null!;
        public virtual DbSet<GameEventCreatureDatum>? GameEventCreatureData { get; set; } = null!;
        public virtual DbSet<GameEventGameobject>? GameEventGameobjects { get; set; } = null!;
        public virtual DbSet<GameEventMail>? GameEventMails { get; set; } = null!;
        public virtual DbSet<GameEventQuest>? GameEventQuests { get; set; } = null!;
        public virtual DbSet<GameEventTime>? GameEventTimes { get; set; } = null!;
        public virtual DbSet<GameGraveyardZone>? GameGraveyardZones { get; set; } = null!;
        public virtual DbSet<GameTele>? GameTeles { get; set; } = null!;
        public virtual DbSet<GameWeather>? GameWeathers { get; set; } = null!;
        public virtual DbSet<Gameobject>? Gameobjects { get; set; } = null!;
        public virtual DbSet<GameobjectBattleground>? GameobjectBattlegrounds { get; set; } = null!;
        public virtual DbSet<GameobjectInvolvedrelation>? GameobjectInvolvedrelations { get; set; } = null!;
        public virtual DbSet<GameobjectLootTemplate>? GameobjectLootTemplates { get; set; } = null!;
        public virtual DbSet<GameobjectQuestrelation>? GameobjectQuestrelations { get; set; } = null!;
        public virtual DbSet<GameobjectSpawnEntry>? GameobjectSpawnEntries { get; set; } = null!;
        public virtual DbSet<GameobjectTemplate>? GameobjectTemplates { get; set; } = null!;
        public virtual DbSet<GameobjectTemplateAddon>? GameobjectTemplateAddons { get; set; } = null!;
        public virtual DbSet<GossipMenu>? GossipMenus { get; set; } = null!;
        public virtual DbSet<GossipMenuOption>? GossipMenuOptions { get; set; } = null!;
        public virtual DbSet<GossipText>? GossipTexts { get; set; } = null!;
        public virtual DbSet<InstanceEncounter>? InstanceEncounters { get; set; } = null!;
        public virtual DbSet<InstanceTemplate>? InstanceTemplates { get; set; } = null!;
        public virtual DbSet<ItemEnchantmentTemplate>? ItemEnchantmentTemplates { get; set; } = null!;
        public virtual DbSet<ItemLootTemplate>? ItemLootTemplates { get; set; } = null!;
        public virtual DbSet<ItemRequiredTarget>? ItemRequiredTargets { get; set; } = null!;
        public virtual DbSet<ItemTemplate>? ItemTemplates { get; set; } = null!;
        public virtual DbSet<LocalesAreatriggerTeleport>? LocalesAreatriggerTeleports { get; set; } = null!;
        public virtual DbSet<LocalesCreature>? LocalesCreatures { get; set; } = null!;
        public virtual DbSet<LocalesGameobject>? LocalesGameobjects { get; set; } = null!;
        public virtual DbSet<LocalesGossipMenuOption>? LocalesGossipMenuOptions { get; set; } = null!;
        public virtual DbSet<LocalesItem>? LocalesItems { get; set; } = null!;
        public virtual DbSet<LocalesNpcText>? LocalesNpcTexts { get; set; } = null!;
        public virtual DbSet<LocalesPageText>? LocalesPageTexts { get; set; } = null!;
        public virtual DbSet<LocalesPointsOfInterest>? LocalesPointsOfInterests { get; set; } = null!;
        public virtual DbSet<LocalesQuest>? LocalesQuests { get; set; } = null!;
        public virtual DbSet<LocalesQuestgiverGreeting>? LocalesQuestgiverGreetings { get; set; } = null!;
        public virtual DbSet<LocalesTrainerGreeting>? LocalesTrainerGreetings { get; set; } = null!;
        public virtual DbSet<MailLevelReward>? MailLevelRewards { get; set; } = null!;
        public virtual DbSet<MailLootTemplate>? MailLootTemplates { get; set; } = null!;
        public virtual DbSet<MangosString>? MangosStrings { get; set; } = null!;
        public virtual DbSet<NpcGossip>? NpcGossips { get; set; } = null!;
        public virtual DbSet<NpcText>? NpcTexts { get; set; } = null!;
        public virtual DbSet<NpcTextBroadcastText>? NpcTextBroadcastTexts { get; set; } = null!;
        public virtual DbSet<NpcTrainer>? NpcTrainers { get; set; } = null!;
        public virtual DbSet<NpcTrainerTemplate>? NpcTrainerTemplates { get; set; } = null!;
        public virtual DbSet<NpcVendor>? NpcVendors { get; set; } = null!;
        public virtual DbSet<NpcVendorTemplate>? NpcVendorTemplates { get; set; } = null!;
        public virtual DbSet<PageText>? PageTexts { get; set; } = null!;
        public virtual DbSet<PetLevelstat>? PetLevelstats { get; set; } = null!;
        public virtual DbSet<PetNameGeneration>? PetNameGenerations { get; set; } = null!;
        public virtual DbSet<PetcreateinfoSpell>? PetcreateinfoSpells { get; set; } = null!;
        public virtual DbSet<PickpocketingLootTemplate>? PickpocketingLootTemplates { get; set; } = null!;
        public virtual DbSet<PlayerClasslevelstat>? PlayerClasslevelstats { get; set; } = null!;
        public virtual DbSet<PlayerLevelstat>? PlayerLevelstats { get; set; } = null!;
        public virtual DbSet<PlayerXpForLevel>? PlayerXpForLevels { get; set; } = null!;
        public virtual DbSet<Playercreateinfo>? Playercreateinfos { get; set; } = null!;
        public virtual DbSet<PlayercreateinfoAction>? PlayercreateinfoActions { get; set; } = null!;
        public virtual DbSet<PlayercreateinfoItem>? PlayercreateinfoItems { get; set; } = null!;
        public virtual DbSet<PlayercreateinfoSkill>? PlayercreateinfoSkills { get; set; } = null!;
        public virtual DbSet<PlayercreateinfoSpell>? PlayercreateinfoSpells { get; set; } = null!;
        public virtual DbSet<PointsOfInterest>? PointsOfInterests { get; set; } = null!;
        public virtual DbSet<PoolCreature>? PoolCreatures { get; set; } = null!;
        public virtual DbSet<PoolCreatureTemplate>? PoolCreatureTemplates { get; set; } = null!;
        public virtual DbSet<PoolGameobject>? PoolGameobjects { get; set; } = null!;
        public virtual DbSet<PoolGameobjectTemplate>? PoolGameobjectTemplates { get; set; } = null!;
        public virtual DbSet<PoolPool>? PoolPools { get; set; } = null!;
        public virtual DbSet<PoolTemplate>? PoolTemplates { get; set; } = null!;
        public virtual DbSet<ProspectingLootTemplate>? ProspectingLootTemplates { get; set; } = null!;
        public virtual DbSet<QuestTemplate>? QuestTemplates { get; set; } = null!;
        public virtual DbSet<QuestgiverGreeting>? QuestgiverGreetings { get; set; } = null!;
        public virtual DbSet<ReferenceLootTemplate>? ReferenceLootTemplates { get; set; } = null!;
        public virtual DbSet<ReputationRewardRate>? ReputationRewardRates { get; set; } = null!;
        public virtual DbSet<ReputationSpilloverTemplate>? ReputationSpilloverTemplates { get; set; } = null!;
        public virtual DbSet<ReservedName>? ReservedNames { get; set; } = null!;
        public virtual DbSet<ScriptText>? ScriptTexts { get; set; } = null!;
        public virtual DbSet<ScriptWaypoint>? ScriptWaypoints { get; set; } = null!;
        public virtual DbSet<ScriptedAreatrigger>? ScriptedAreatriggers { get; set; } = null!;
        public virtual DbSet<ScriptedEventId>? ScriptedEventIds { get; set; } = null!;
        public virtual DbSet<SkillDiscoveryTemplate>? SkillDiscoveryTemplates { get; set; } = null!;
        public virtual DbSet<SkillExtraItemTemplate>? SkillExtraItemTemplates { get; set; } = null!;
        public virtual DbSet<SkillFishingBaseLevel>? SkillFishingBaseLevels { get; set; } = null!;
        public virtual DbSet<SkinningLootTemplate>? SkinningLootTemplates { get; set; } = null!;
        public virtual DbSet<SpamRecord>? SpamRecords { get; set; } = null!;
        public virtual DbSet<SpawnGroup>? SpawnGroups { get; set; } = null!;
        public virtual DbSet<SpawnGroupEntry>? SpawnGroupEntries { get; set; } = null!;
        public virtual DbSet<SpawnGroupFormation>? SpawnGroupFormations { get; set; } = null!;
        public virtual DbSet<SpawnGroupLinkedGroup>? SpawnGroupLinkedGroups { get; set; } = null!;
        public virtual DbSet<SpawnGroupSpawn>? SpawnGroupSpawns { get; set; } = null!;
        public virtual DbSet<SpellAffect>? SpellAffects { get; set; } = null!;
        public virtual DbSet<SpellArea>? SpellAreas { get; set; } = null!;
        public virtual DbSet<SpellBonusDatum>? SpellBonusData { get; set; } = null!;
        public virtual DbSet<SpellChain>? SpellChains { get; set; } = null!;
        public virtual DbSet<SpellElixir>? SpellElixirs { get; set; } = null!;
        public virtual DbSet<SpellLearnSpell>? SpellLearnSpells { get; set; } = null!;
        public virtual DbSet<SpellPetAura>? SpellPetAuras { get; set; } = null!;
        public virtual DbSet<SpellProcEvent>? SpellProcEvents { get; set; } = null!;
        public virtual DbSet<SpellProcItemEnchant>? SpellProcItemEnchants { get; set; } = null!;
        public virtual DbSet<SpellScriptTarget>? SpellScriptTargets { get; set; } = null!;
        public virtual DbSet<SpellTargetPosition>? SpellTargetPositions { get; set; } = null!;
        public virtual DbSet<SpellTemplate>? SpellTemplates { get; set; } = null!;
        public virtual DbSet<SpellThreat>? SpellThreats { get; set; } = null!;
        public virtual DbSet<TaxiShortcut>? TaxiShortcuts { get; set; } = null!;
        public virtual DbSet<TrainerGreeting>? TrainerGreetings { get; set; } = null!;
        public virtual DbSet<Transport>? Transports { get; set; } = null!;
        public virtual DbSet<WardenScan>? WardenScans { get; set; } = null!;
        public virtual DbSet<WaypointPath>? WaypointPaths { get; set; } = null!;
        public virtual DbSet<WorldSafeLoc>? WorldSafeLocs { get; set; } = null!;
        public virtual DbSet<WorldTemplate>? WorldTemplates { get; set; } = null!;
        public virtual DbSet<WorldstateName>? WorldstateNames { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<AreatriggerInvolvedrelation>(entity =>
            {
                entity.ToTable("areatrigger_involvedrelation");

                entity.HasComment("Trigger System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("id")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Identifier");

                entity.Property(e => e.Quest)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("quest")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Quest Identifier");
            });

            modelBuilder.Entity<AreatriggerTavern>(entity =>
            {
                entity.ToTable("areatrigger_tavern");

                entity.HasComment("Trigger System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("id")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Identifier");

                entity.Property(e => e.Name)
                    .HasColumnType("text")
                    .HasColumnName("name");
            });

            modelBuilder.Entity<AreatriggerTeleport>(entity =>
            {
                entity.ToTable("areatrigger_teleport");

                entity.HasComment("Trigger System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("id")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Identifier");

                entity.Property(e => e.ConditionId)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("condition_id");

                entity.Property(e => e.HeroicKey)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("heroic_key")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.HeroicKey2)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("heroic_key2")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Name)
                    .HasColumnType("text")
                    .HasColumnName("name");

                entity.Property(e => e.RequiredItem)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("required_item")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RequiredItem2)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("required_item2")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RequiredLevel)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("required_level");

                entity.Property(e => e.RequiredQuestDone)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("required_quest_done");

                entity.Property(e => e.RequiredQuestDoneHeroic)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("required_quest_done_heroic");

                entity.Property(e => e.StatusFailedText)
                    .HasColumnType("text")
                    .HasColumnName("status_failed_text");

                entity.Property(e => e.TargetMap)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("target_map");

                entity.Property(e => e.TargetOrientation).HasColumnName("target_orientation");

                entity.Property(e => e.TargetPositionX).HasColumnName("target_position_x");

                entity.Property(e => e.TargetPositionY).HasColumnName("target_position_y");

                entity.Property(e => e.TargetPositionZ).HasColumnName("target_position_z");
            });

            modelBuilder.Entity<BattlegroundEvent>(entity =>
            {
                entity.HasKey(e => new { e.Map, e.Event1, e.Event2 })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("battleground_events");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Map)
                    .HasColumnType("smallint(5)")
                    .HasColumnName("map");

                entity.Property(e => e.Event1)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("event1");

                entity.Property(e => e.Event2)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("event2");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");
            });

            modelBuilder.Entity<BattlegroundTemplate>(entity =>
            {
                entity.ToTable("battleground_template");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.AllianceStartLoc).HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.HordeStartLoc).HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.MaxLvl).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.MaxPlayersPerTeam).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.MinLvl).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.MinPlayersPerTeam).HasColumnType("smallint(5) unsigned");
            });

            modelBuilder.Entity<BattlemasterEntry>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("battlemaster_entry");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Entry of a creature");

                entity.Property(e => e.BgTemplate)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("bg_template")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Battleground template id");
            });

            modelBuilder.Entity<Command>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("PRIMARY");

                entity.ToTable("command");

                entity.HasComment("Chat System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Help).HasColumnName("help");

                entity.Property(e => e.Security)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("security");
            });

            modelBuilder.Entity<Condition>(entity =>
            {
                entity.HasKey(e => e.ConditionEntry)
                    .HasName("PRIMARY");

                entity.ToTable("conditions");

                entity.HasComment("Condition System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasIndex(e => new { e.Type, e.Value1, e.Value2, e.Value3, e.Value4, e.Flags }, "unique_conditions")
                    .IsUnique();

                entity.Property(e => e.ConditionEntry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("condition_entry")
                    .HasComment("Identifier");

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .HasColumnName("comments")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Flags)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("flags");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(3)")
                    .HasColumnName("type")
                    .HasComment("Type of the condition");

                entity.Property(e => e.Value1)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("value1")
                    .HasDefaultValueSql("'0'")
                    .HasComment("data field one for the condition");

                entity.Property(e => e.Value2)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("value2")
                    .HasDefaultValueSql("'0'")
                    .HasComment("data field two for the condition");

                entity.Property(e => e.Value3)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("value3")
                    .HasDefaultValueSql("'0'")
                    .HasComment("data field three for the condition");

                entity.Property(e => e.Value4)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("value4")
                    .HasDefaultValueSql("'0'")
                    .HasComment("data field four for the condition");
            });

            modelBuilder.Entity<Creature>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PRIMARY");

                entity.ToTable("creature");

                entity.HasComment("Creature System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasIndex(e => e.Map, "idx_map");

                entity.HasIndex(e => e.Id, "index_id");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guid")
                    .HasComment("Global Unique Identifier");

                entity.Property(e => e.Curhealth)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("curhealth")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Curmana)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("curmana");

                entity.Property(e => e.Currentwaypoint)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("currentwaypoint")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DeathState).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.EquipmentId)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("equipment_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("id")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Creature Identifier");

                entity.Property(e => e.Map)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("map")
                    .HasComment("Map Identifier");

                entity.Property(e => e.Modelid)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("modelid")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MovementType).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Orientation).HasColumnName("orientation");

                entity.Property(e => e.PositionX).HasColumnName("position_x");

                entity.Property(e => e.PositionY).HasColumnName("position_y");

                entity.Property(e => e.PositionZ).HasColumnName("position_z");

                entity.Property(e => e.SpawnMask)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("spawnMask")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Spawndist)
                    .HasColumnName("spawndist")
                    .HasDefaultValueSql("'5'");

                entity.Property(e => e.Spawntimesecsmax)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("spawntimesecsmax")
                    .HasDefaultValueSql("'120'")
                    .HasComment("Creature respawn time maximum");

                entity.Property(e => e.Spawntimesecsmin)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("spawntimesecsmin")
                    .HasDefaultValueSql("'120'")
                    .HasComment("Creature respawn time minimum");
            });

            modelBuilder.Entity<CreatureAddon>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PRIMARY");

                entity.ToTable("creature_addon");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("guid");

                entity.Property(e => e.Auras)
                    .HasColumnType("text")
                    .HasColumnName("auras");

                entity.Property(e => e.B20Sheath)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("b2_0_sheath");

                entity.Property(e => e.B21Flags)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("b2_1_flags");

                entity.Property(e => e.Bytes1)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("bytes1");

                entity.Property(e => e.Emote)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("emote");

                entity.Property(e => e.Mount)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("mount")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Moveflags)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("moveflags");
            });

            modelBuilder.Entity<CreatureAiScript>(entity =>
            {
                entity.ToTable("creature_ai_scripts");

                entity.HasComment("EventAI Scripts")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("id")
                    .HasComment("Identifier");

                entity.Property(e => e.Action1Param1)
                    .HasColumnType("int(11)")
                    .HasColumnName("action1_param1");

                entity.Property(e => e.Action1Param2)
                    .HasColumnType("int(11)")
                    .HasColumnName("action1_param2");

                entity.Property(e => e.Action1Param3)
                    .HasColumnType("int(11)")
                    .HasColumnName("action1_param3");

                entity.Property(e => e.Action1Type)
                    .HasColumnType("tinyint(5) unsigned")
                    .HasColumnName("action1_type")
                    .HasComment("Action Type");

                entity.Property(e => e.Action2Param1)
                    .HasColumnType("int(11)")
                    .HasColumnName("action2_param1");

                entity.Property(e => e.Action2Param2)
                    .HasColumnType("int(11)")
                    .HasColumnName("action2_param2");

                entity.Property(e => e.Action2Param3)
                    .HasColumnType("int(11)")
                    .HasColumnName("action2_param3");

                entity.Property(e => e.Action2Type)
                    .HasColumnType("tinyint(5) unsigned")
                    .HasColumnName("action2_type")
                    .HasComment("Action Type");

                entity.Property(e => e.Action3Param1)
                    .HasColumnType("int(11)")
                    .HasColumnName("action3_param1");

                entity.Property(e => e.Action3Param2)
                    .HasColumnType("int(11)")
                    .HasColumnName("action3_param2");

                entity.Property(e => e.Action3Param3)
                    .HasColumnType("int(11)")
                    .HasColumnName("action3_param3");

                entity.Property(e => e.Action3Type)
                    .HasColumnType("tinyint(5) unsigned")
                    .HasColumnName("action3_type")
                    .HasComment("Action Type");

                entity.Property(e => e.Comment)
                    .HasMaxLength(255)
                    .HasColumnName("comment")
                    .HasDefaultValueSql("''")
                    .HasComment("Event Comment");

                entity.Property(e => e.CreatureId)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("creature_id")
                    .HasComment("Creature Template Identifier");

                entity.Property(e => e.EventChance)
                    .HasColumnType("int(3) unsigned")
                    .HasColumnName("event_chance")
                    .HasDefaultValueSql("'100'");

                entity.Property(e => e.EventFlags)
                    .HasColumnType("int(3) unsigned")
                    .HasColumnName("event_flags");

                entity.Property(e => e.EventInversePhaseMask)
                    .HasColumnType("int(11)")
                    .HasColumnName("event_inverse_phase_mask")
                    .HasComment("Mask which phases this event will not trigger in");

                entity.Property(e => e.EventParam1)
                    .HasColumnType("int(11)")
                    .HasColumnName("event_param1");

                entity.Property(e => e.EventParam2)
                    .HasColumnType("int(11)")
                    .HasColumnName("event_param2");

                entity.Property(e => e.EventParam3)
                    .HasColumnType("int(11)")
                    .HasColumnName("event_param3");

                entity.Property(e => e.EventParam4)
                    .HasColumnType("int(11)")
                    .HasColumnName("event_param4");

                entity.Property(e => e.EventParam5)
                    .HasColumnType("int(11)")
                    .HasColumnName("event_param5");

                entity.Property(e => e.EventParam6)
                    .HasColumnType("int(11)")
                    .HasColumnName("event_param6");

                entity.Property(e => e.EventType)
                    .HasColumnType("tinyint(5) unsigned")
                    .HasColumnName("event_type")
                    .HasComment("Event Type");
            });

            modelBuilder.Entity<CreatureAiSummon>(entity =>
            {
                entity.ToTable("creature_ai_summons");

                entity.HasComment("EventAI Summoning Locations")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("id")
                    .HasComment("Location Identifier");

                entity.Property(e => e.Comment)
                    .HasMaxLength(255)
                    .HasColumnName("comment")
                    .HasDefaultValueSql("''")
                    .HasComment("Summon Comment");

                entity.Property(e => e.Orientation).HasColumnName("orientation");

                entity.Property(e => e.PositionX).HasColumnName("position_x");

                entity.Property(e => e.PositionY).HasColumnName("position_y");

                entity.Property(e => e.PositionZ).HasColumnName("position_z");

                entity.Property(e => e.Spawntimesecs)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("spawntimesecs")
                    .HasDefaultValueSql("'120'");
            });

            modelBuilder.Entity<CreatureAiText>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("creature_ai_texts");

                entity.HasComment("Script Texts")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8)")
                    .ValueGeneratedNever()
                    .HasColumnName("entry");

                entity.Property(e => e.BroadcastTextId)
                    .HasColumnType("int(11)")
                    .HasColumnName("broadcast_text_id");

                entity.Property(e => e.Comment)
                    .HasColumnType("text")
                    .HasColumnName("comment");

                entity.Property(e => e.ContentDefault)
                    .HasColumnType("text")
                    .HasColumnName("content_default");

                entity.Property(e => e.ContentLoc1)
                    .HasColumnType("text")
                    .HasColumnName("content_loc1");

                entity.Property(e => e.ContentLoc2)
                    .HasColumnType("text")
                    .HasColumnName("content_loc2");

                entity.Property(e => e.ContentLoc3)
                    .HasColumnType("text")
                    .HasColumnName("content_loc3");

                entity.Property(e => e.ContentLoc4)
                    .HasColumnType("text")
                    .HasColumnName("content_loc4");

                entity.Property(e => e.ContentLoc5)
                    .HasColumnType("text")
                    .HasColumnName("content_loc5");

                entity.Property(e => e.ContentLoc6)
                    .HasColumnType("text")
                    .HasColumnName("content_loc6");

                entity.Property(e => e.ContentLoc7)
                    .HasColumnType("text")
                    .HasColumnName("content_loc7");

                entity.Property(e => e.ContentLoc8)
                    .HasColumnType("text")
                    .HasColumnName("content_loc8");

                entity.Property(e => e.Emote)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("emote");

                entity.Property(e => e.Language)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("language");

                entity.Property(e => e.Sound)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("sound")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("type");
            });

            modelBuilder.Entity<CreatureBattleground>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PRIMARY");

                entity.ToTable("creature_battleground");

                entity.HasComment("Creature battleground indexing system")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("guid")
                    .HasComment("Creature's GUID");

                entity.Property(e => e.Event1)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("event1")
                    .HasComment("main event");

                entity.Property(e => e.Event2)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("event2")
                    .HasComment("sub event");
            });

            modelBuilder.Entity<CreatureConditionalSpawn>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PRIMARY");

                entity.ToTable("creature_conditional_spawn");

                entity.HasComment("Creature System (Conditional Spawn)")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .HasComment("Global Unique Identifier");

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.EntryAlliance)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Alliance Creature Identifier");

                entity.Property(e => e.EntryHorde)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Horde Creature Identifier");
            });

            modelBuilder.Entity<CreatureCooldown>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.SpellId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("creature_cooldowns");

                entity.Property(e => e.Entry).HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.SpellId).HasColumnType("int(11) unsigned");

                entity.Property(e => e.CooldownMax).HasColumnType("int(10) unsigned");

                entity.Property(e => e.CooldownMin).HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<CreatureEquipTemplate>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("creature_equip_template");

                entity.HasComment("Creature System (Equipment)")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Unique entry");

                entity.Property(e => e.Equipentry1)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("equipentry1")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Equipentry2)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("equipentry2")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Equipentry3)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("equipentry3")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<CreatureEquipTemplateRaw>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("creature_equip_template_raw");

                entity.HasComment("Creature System (Equipment)")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Unique entry");

                entity.Property(e => e.Equipinfo1)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("equipinfo1");

                entity.Property(e => e.Equipinfo2)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("equipinfo2");

                entity.Property(e => e.Equipinfo3)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("equipinfo3");

                entity.Property(e => e.Equipmodel1)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("equipmodel1")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Equipmodel2)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("equipmodel2")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Equipmodel3)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("equipmodel3")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Equipslot1)
                    .HasColumnType("int(11)")
                    .HasColumnName("equipslot1");

                entity.Property(e => e.Equipslot2)
                    .HasColumnType("int(11)")
                    .HasColumnName("equipslot2");

                entity.Property(e => e.Equipslot3)
                    .HasColumnType("int(11)")
                    .HasColumnName("equipslot3");
            });

            modelBuilder.Entity<CreatureImmunity>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.SetId, e.Type, e.Value })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

                entity.ToTable("creature_immunities");

                entity.Property(e => e.Entry)
                    .HasColumnType("int(10) unsigned")
                    .HasComment("creature_template entry");

                entity.Property(e => e.SetId)
                    .HasColumnType("int(10) unsigned")
                    .HasComment("immunity set ID");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasComment("enum SpellImmunity");

                entity.Property(e => e.Value)
                    .HasColumnType("int(10) unsigned")
                    .HasComment("value depending on type");
            });

            modelBuilder.Entity<CreatureInvolvedrelation>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Quest })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("creature_involvedrelation");

                entity.HasComment("Creature System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("id")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Identifier");

                entity.Property(e => e.Quest)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("quest")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Quest Identifier");
            });

            modelBuilder.Entity<CreatureLinking>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PRIMARY");

                entity.ToTable("creature_linking");

                entity.HasComment("Creature Linking System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("guid")
                    .HasComment("creature.guid of the slave mob that is linked");

                entity.Property(e => e.Flag)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("flag")
                    .HasComment("flag - describing what should happen when");

                entity.Property(e => e.MasterGuid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("master_guid")
                    .HasComment("master to trigger events");
            });

            modelBuilder.Entity<CreatureLinkingTemplate>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.Map })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("creature_linking_template");

                entity.HasComment("Creature Linking System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'")
                    .HasComment("creature_template.entry of the slave mob that is linked");

                entity.Property(e => e.Map)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("map")
                    .HasComment("Id of map of the mobs");

                entity.Property(e => e.Flag)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("flag")
                    .HasDefaultValueSql("'0'")
                    .HasComment("flag - describing what should happen when");

                entity.Property(e => e.MasterEntry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("master_entry")
                    .HasDefaultValueSql("'0'")
                    .HasComment("master to trigger events");

                entity.Property(e => e.SearchRange)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("search_range")
                    .HasDefaultValueSql("'0'")
                    .HasComment("search_range - describing in which range (spawn-coords) master and slave are linked together");
            });

            modelBuilder.Entity<CreatureLootTemplate>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.Item })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("creature_loot_template");

                entity.HasComment("Loot System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'")
                    .HasComment("entry 0 used for player insignia loot");

                entity.Property(e => e.Item)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("item")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ChanceOrQuestChance).HasDefaultValueSql("'100'");

                entity.Property(e => e.Comments)
                    .HasMaxLength(300)
                    .HasColumnName("comments")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ConditionId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("condition_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Groupid)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("groupid");

                entity.Property(e => e.Maxcount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("maxcount")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MincountOrRef)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("mincountOrRef")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<CreatureModelInfo>(entity =>
            {
                entity.HasKey(e => e.Modelid)
                    .HasName("PRIMARY");

                entity.ToTable("creature_model_info");

                entity.HasComment("Creature System (Model related info)")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Modelid)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("modelid")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.BoundingRadius).HasColumnName("bounding_radius");

                entity.Property(e => e.CombatReach).HasColumnName("combat_reach");

                entity.Property(e => e.Gender)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("gender")
                    .HasDefaultValueSql("'2'");

                entity.Property(e => e.ModelidAlternative)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("modelid_alternative")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ModelidOtherGender)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("modelid_other_gender")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SpeedRun)
                    .HasDefaultValueSql("'1.14286'")
                    .HasComment("Default running speed for any creature with model");

                entity.Property(e => e.SpeedWalk)
                    .HasDefaultValueSql("'1'")
                    .HasComment("Default walking speed for any creature with model");
            });

            modelBuilder.Entity<CreatureModelRace>(entity =>
            {
                entity.HasKey(e => new { e.Modelid, e.Racemask })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("creature_model_race");

                entity.HasComment("Model system")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Modelid)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("modelid")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Racemask)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("racemask")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CreatureEntry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("creature_entry")
                    .HasDefaultValueSql("'0'")
                    .HasComment("option 1, modelid_N from creature_template");

                entity.Property(e => e.ModelidRacial)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("modelid_racial")
                    .HasDefaultValueSql("'0'")
                    .HasComment("option 2, explicit modelid");
            });

            modelBuilder.Entity<CreatureMovement>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Point })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("creature_movement");

                entity.HasComment("Creature System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasComment("Creature GUID");

                entity.Property(e => e.Point)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Comment).HasColumnType("text");

                entity.Property(e => e.ScriptId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.WaitTime).HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<CreatureMovementTemplate>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.PathId, e.Point })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("creature_movement_template");

                entity.HasComment("Creature waypoint system")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasComment("Creature entry");

                entity.Property(e => e.PathId)
                    .HasColumnType("int(11) unsigned")
                    .HasComment("Path ID for entry");

                entity.Property(e => e.Point)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Comment).HasColumnType("text");

                entity.Property(e => e.ScriptId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.WaitTime).HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<CreatureOnkillReputation>(entity =>
            {
                entity.HasKey(e => e.CreatureId)
                    .HasName("PRIMARY");

                entity.ToTable("creature_onkill_reputation");

                entity.HasComment("Creature OnKill Reputation gain")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.CreatureId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("creature_id")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Creature Identifier");

                entity.Property(e => e.IsTeamAward1).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsTeamAward2).HasColumnType("tinyint(4)");

                entity.Property(e => e.MaxStanding1).HasColumnType("tinyint(4)");

                entity.Property(e => e.MaxStanding2).HasColumnType("tinyint(4)");

                entity.Property(e => e.RewOnKillRepFaction1).HasColumnType("smallint(6)");

                entity.Property(e => e.RewOnKillRepFaction2).HasColumnType("smallint(6)");

                entity.Property(e => e.RewOnKillRepValue1)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RewOnKillRepValue2)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TeamDependent).HasColumnType("tinyint(3) unsigned");
            });

            modelBuilder.Entity<CreatureQuestrelation>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Quest })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("creature_questrelation");

                entity.HasComment("Creature System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("id")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Identifier");

                entity.Property(e => e.Quest)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("quest")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Quest Identifier");
            });

            modelBuilder.Entity<CreatureSpawnDataTemplate>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.UnitFlags, e.ModelId, e.EquipmentId, e.CurHealth, e.CurMana, e.SpawnFlags })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0, 0 });

                entity.ToTable("creature_spawn_data_template");

                entity.HasComment("Creature System (Spawn Data Template)")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("int(10) unsigned")
                    .HasComment("ID of template");

                entity.Property(e => e.UnitFlags)
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.ModelId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EquipmentId)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CurHealth).HasColumnType("int(10) unsigned");

                entity.Property(e => e.CurMana).HasColumnType("int(10) unsigned");

                entity.Property(e => e.SpawnFlags).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Faction).HasColumnType("int(10) unsigned");

                entity.Property(e => e.NpcFlags)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.RelayId).HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<CreatureSpawnDatum>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PRIMARY");

                entity.ToTable("creature_spawn_data");

                entity.HasComment("Creature System (Spawn Data)")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasComment("guid of creature");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasComment("ID of template");
            });

            modelBuilder.Entity<CreatureSpawnEntry>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Entry })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("creature_spawn_entry");

                entity.HasComment("Creature System (Spawn Entry)")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guid")
                    .HasComment("Global Unique Identifier");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<CreatureSpellList>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Position })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("creature_spell_list");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasComment("List ID");

                entity.Property(e => e.Position)
                    .HasColumnType("int(11)")
                    .HasComment("Position on list");

                entity.Property(e => e.Availability)
                    .HasColumnType("int(11)")
                    .HasComment("Chance on spawn for spell to be included");

                entity.Property(e => e.Comments)
                    .HasMaxLength(255)
                    .HasComment("Description of spell use");

                entity.Property(e => e.Flags)
                    .HasColumnType("int(11)")
                    .HasComment("Spell Flags");

                entity.Property(e => e.InitialMax)
                    .HasColumnType("int(11)")
                    .HasComment("Initial delay maximum");

                entity.Property(e => e.InitialMin)
                    .HasColumnType("int(11)")
                    .HasComment("Initial delay minimum");

                entity.Property(e => e.Probability)
                    .HasColumnType("int(11)")
                    .HasComment("Weight of spell when multiple are available");

                entity.Property(e => e.RepeatMax)
                    .HasColumnType("int(11)")
                    .HasComment("Repeated delay maximum");

                entity.Property(e => e.RepeatMin)
                    .HasColumnType("int(11)")
                    .HasComment("Repeated delay minimum");

                entity.Property(e => e.ScriptId)
                    .HasColumnType("int(11)")
                    .HasComment("Dbscript to be launched on success");

                entity.Property(e => e.SpellId)
                    .HasColumnType("int(11)")
                    .HasComment("Spell ID");

                entity.Property(e => e.TargetId)
                    .HasColumnType("int(11)")
                    .HasComment("Targeting ID");
            });

            modelBuilder.Entity<CreatureSpellListEntry>(entity =>
            {
                entity.ToTable("creature_spell_list_entry");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasComment("List ID");

                entity.Property(e => e.ChanceRangedAttack)
                    .HasColumnType("int(11)")
                    .HasComment("Chance of ranged attack per tick");

                entity.Property(e => e.ChanceSupportAction)
                    .HasColumnType("int(11)")
                    .HasComment("Chance of support action per tick");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .HasComment("Description of usage");
            });

            modelBuilder.Entity<CreatureSpellTargeting>(entity =>
            {
                entity.ToTable("creature_spell_targeting");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasComment("Targeting ID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(255)
                    .HasComment("Description of target");

                entity.Property(e => e.Param1)
                    .HasColumnType("int(11)")
                    .HasComment("First parameter");

                entity.Property(e => e.Param2)
                    .HasColumnType("int(11)")
                    .HasComment("Second parameter");

                entity.Property(e => e.Param3)
                    .HasColumnType("int(11)")
                    .HasComment("Third parameter");

                entity.Property(e => e.Type)
                    .HasColumnType("int(11)")
                    .HasComment("Type of targeting ID");
            });

            modelBuilder.Entity<CreatureTemplate>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("creature_template");

                entity.HasComment("Creature System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Ainame)
                    .HasMaxLength(64)
                    .HasColumnName("AIName")
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.Armor)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ArmorMultiplier).HasDefaultValueSql("'1'");

                entity.Property(e => e.CallForHelp)
                    .HasColumnType("int(10) unsigned")
                    .HasComment("Range in which creature calls for help?");

                entity.Property(e => e.CorpseDecay)
                    .HasColumnType("int(10) unsigned")
                    .HasComment("Time before corpse despawns");

                entity.Property(e => e.CreatureType).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.CreatureTypeFlags).HasColumnType("int(10) unsigned");

                entity.Property(e => e.DamageMultiplier).HasDefaultValueSql("'1'");

                entity.Property(e => e.DamageSchool).HasColumnType("tinyint(4)");

                entity.Property(e => e.DamageVariance).HasDefaultValueSql("'1'");

                entity.Property(e => e.Detection)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'20'")
                    .HasComment("Detection range for proximity");

                entity.Property(e => e.DynamicFlags).HasColumnType("int(10) unsigned");

                entity.Property(e => e.EquipmentTemplateId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Expansion)
                    .HasColumnType("tinyint(3)")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.ExperienceMultiplier).HasDefaultValueSql("'1'");

                entity.Property(e => e.ExtraFlags).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Faction).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Family).HasColumnType("tinyint(4)");

                entity.Property(e => e.GossipMenuId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.HealthMultiplier).HasDefaultValueSql("'1'");

                entity.Property(e => e.HeroicEntry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IconName)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.InhabitType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'3'");

                entity.Property(e => e.InteractionPauseTimer)
                    .HasColumnType("int(10)")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.KillCredit1).HasColumnType("int(11) unsigned");

                entity.Property(e => e.KillCredit2).HasColumnType("int(11) unsigned");

                entity.Property(e => e.Leash)
                    .HasColumnType("int(10) unsigned")
                    .HasComment("Leash range from combat start position");

                entity.Property(e => e.LootId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MaxLevel)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MaxLevelHealth).HasColumnType("int(10) unsigned");

                entity.Property(e => e.MaxLevelMana).HasColumnType("int(10) unsigned");

                entity.Property(e => e.MaxLootGold)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MechanicImmuneMask).HasColumnType("int(10) unsigned");

                entity.Property(e => e.MeleeAttackPower).HasColumnType("int(10) unsigned");

                entity.Property(e => e.MeleeBaseAttackTime)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'2000'");

                entity.Property(e => e.MinLevel)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MinLevelHealth).HasColumnType("int(10) unsigned");

                entity.Property(e => e.MinLevelMana).HasColumnType("int(10) unsigned");

                entity.Property(e => e.MinLootGold)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ModelId1)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ModelId2)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ModelId3)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ModelId4)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MovementType).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.NpcFlags).HasColumnType("int(10) unsigned");

                entity.Property(e => e.PetSpellDataId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PickpocketLootId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PowerMultiplier).HasDefaultValueSql("'1'");

                entity.Property(e => e.Pursuit)
                    .HasColumnType("int(10) unsigned")
                    .HasComment("When exceeded during pursuit creature evades?");

                entity.Property(e => e.RacialLeader).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.RangedAttackPower).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RangedBaseAttackTime)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'2000'");

                entity.Property(e => e.Rank).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.RegenerateStats)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'3'");

                entity.Property(e => e.ResistanceArcane).HasColumnType("smallint(5)");

                entity.Property(e => e.ResistanceFire).HasColumnType("smallint(5)");

                entity.Property(e => e.ResistanceFrost).HasColumnType("smallint(5)");

                entity.Property(e => e.ResistanceHoly).HasColumnType("smallint(5)");

                entity.Property(e => e.ResistanceNature).HasColumnType("smallint(5)");

                entity.Property(e => e.ResistanceShadow).HasColumnType("smallint(5)");

                entity.Property(e => e.Scale).HasDefaultValueSql("'1'");

                entity.Property(e => e.SchoolImmuneMask).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ScriptName)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.SkinningLootId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SpellList)
                    .HasColumnType("int(11)")
                    .HasComment("creature_spell_list_entry");

                entity.Property(e => e.SubName)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.Timeout)
                    .HasColumnType("int(10) unsigned")
                    .HasComment("Time for refreshing leashing before evade?");

                entity.Property(e => e.TrainerClass).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.TrainerRace).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.TrainerSpell)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TrainerTemplateId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TrainerType).HasColumnType("tinyint(4)");

                entity.Property(e => e.UnitClass).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.UnitFlags).HasColumnType("int(10) unsigned");

                entity.Property(e => e.VendorTemplateId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.VisibilityDistanceType).HasColumnType("tinyint(4)");
            });

            modelBuilder.Entity<CreatureTemplateAddon>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("creature_template_addon");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Auras)
                    .HasColumnType("text")
                    .HasColumnName("auras");

                entity.Property(e => e.B20Sheath)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("b2_0_sheath");

                entity.Property(e => e.B21Flags)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("b2_1_flags");

                entity.Property(e => e.Bytes1)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("bytes1");

                entity.Property(e => e.Emote)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("emote")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Mount)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("mount")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Moveflags)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("moveflags");
            });

            modelBuilder.Entity<CreatureTemplateSpell>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.SetId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("creature_template_spells");

                entity.HasComment("Creature System (Spells used by creature)")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry");

                entity.Property(e => e.SetId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("setId")
                    .HasComment("Id of set of spells");

                entity.Property(e => e.Spell1)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("spell1");

                entity.Property(e => e.Spell10)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("spell10")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Spell2)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("spell2")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Spell3)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("spell3")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Spell4)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("spell4")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Spell5)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("spell5")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Spell6)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("spell6")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Spell7)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("spell7")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Spell8)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("spell8")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Spell9)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("spell9")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<CustomText>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("custom_texts");

                entity.HasComment("Custom Texts")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8)")
                    .ValueGeneratedNever()
                    .HasColumnName("entry");

                entity.Property(e => e.Comment)
                    .HasColumnType("text")
                    .HasColumnName("comment");

                entity.Property(e => e.ContentDefault)
                    .HasColumnType("text")
                    .HasColumnName("content_default");

                entity.Property(e => e.ContentLoc1)
                    .HasColumnType("text")
                    .HasColumnName("content_loc1");

                entity.Property(e => e.ContentLoc2)
                    .HasColumnType("text")
                    .HasColumnName("content_loc2");

                entity.Property(e => e.ContentLoc3)
                    .HasColumnType("text")
                    .HasColumnName("content_loc3");

                entity.Property(e => e.ContentLoc4)
                    .HasColumnType("text")
                    .HasColumnName("content_loc4");

                entity.Property(e => e.ContentLoc5)
                    .HasColumnType("text")
                    .HasColumnName("content_loc5");

                entity.Property(e => e.ContentLoc6)
                    .HasColumnType("text")
                    .HasColumnName("content_loc6");

                entity.Property(e => e.ContentLoc7)
                    .HasColumnType("text")
                    .HasColumnName("content_loc7");

                entity.Property(e => e.ContentLoc8)
                    .HasColumnType("text")
                    .HasColumnName("content_loc8");

                entity.Property(e => e.Emote)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("emote");

                entity.Property(e => e.Language)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("language");

                entity.Property(e => e.Sound)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("sound")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("type");
            });

            modelBuilder.Entity<DbVersion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("db_version");

                entity.HasComment("Used DB version notes")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.CreatureAiVersion)
                    .HasMaxLength(120)
                    .HasColumnName("creature_ai_version");

                entity.Property(e => e.RequiredS245001MangosQuestMaxlevel)
                    .HasColumnType("bit(1)")
                    .HasColumnName("required_s2450_01_mangos_quest_maxlevel");

                entity.Property(e => e.Version)
                    .HasMaxLength(120)
                    .HasColumnName("version");
            });

            modelBuilder.Entity<DbscriptRandomTemplate>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Type, e.TargetId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("dbscript_random_templates");

                entity.HasComment("DBScript system")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("id")
                    .HasComment("Id of template");

                entity.Property(e => e.Type)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("type")
                    .HasComment("Type of template");

                entity.Property(e => e.TargetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("target_id")
                    .HasComment("Id of chanced element");

                entity.Property(e => e.Chance)
                    .HasColumnType("int(11)")
                    .HasColumnName("chance")
                    .HasComment("Chance for element to occur in %");

                entity.Property(e => e.Comments)
                    .HasMaxLength(500)
                    .HasColumnName("comments")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<DbscriptString>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("dbscript_string");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("int(11) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("entry");

                entity.Property(e => e.BroadcastTextId)
                    .HasColumnType("int(11)")
                    .HasColumnName("broadcast_text_id");

                entity.Property(e => e.Comment)
                    .HasColumnType("text")
                    .HasColumnName("comment");

                entity.Property(e => e.ContentDefault)
                    .HasColumnType("text")
                    .HasColumnName("content_default");

                entity.Property(e => e.ContentLoc1)
                    .HasColumnType("text")
                    .HasColumnName("content_loc1");

                entity.Property(e => e.ContentLoc2)
                    .HasColumnType("text")
                    .HasColumnName("content_loc2");

                entity.Property(e => e.ContentLoc3)
                    .HasColumnType("text")
                    .HasColumnName("content_loc3");

                entity.Property(e => e.ContentLoc4)
                    .HasColumnType("text")
                    .HasColumnName("content_loc4");

                entity.Property(e => e.ContentLoc5)
                    .HasColumnType("text")
                    .HasColumnName("content_loc5");

                entity.Property(e => e.ContentLoc6)
                    .HasColumnType("text")
                    .HasColumnName("content_loc6");

                entity.Property(e => e.ContentLoc7)
                    .HasColumnType("text")
                    .HasColumnName("content_loc7");

                entity.Property(e => e.ContentLoc8)
                    .HasColumnType("text")
                    .HasColumnName("content_loc8");

                entity.Property(e => e.Emote)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("emote");

                entity.Property(e => e.Language)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("language");

                entity.Property(e => e.Sound)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("sound")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("type");
            });

            modelBuilder.Entity<DbscriptStringTemplate>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.StringId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("dbscript_string_template");

                entity.HasComment("DBScript system")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11) unsigned")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id")
                    .HasComment("Id of template");

                entity.Property(e => e.StringId)
                    .HasColumnType("int(11)")
                    .HasColumnName("string_id")
                    .HasComment("dbscript_string id");
            });

            modelBuilder.Entity<DbscriptsOnCreatureDeath>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dbscripts_on_creature_death");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.BuddyEntry)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("buddy_entry");

                entity.Property(e => e.Command)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("command")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Comments)
                    .HasMaxLength(255)
                    .HasColumnName("comments");

                entity.Property(e => e.ConditionId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("condition_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DataFlags)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("data_flags");

                entity.Property(e => e.Datafloat).HasColumnName("datafloat");

                entity.Property(e => e.Dataint)
                    .HasColumnType("int(11)")
                    .HasColumnName("dataint");

                entity.Property(e => e.Dataint2)
                    .HasColumnType("int(11)")
                    .HasColumnName("dataint2");

                entity.Property(e => e.Dataint3)
                    .HasColumnType("int(11)")
                    .HasColumnName("dataint3");

                entity.Property(e => e.Dataint4)
                    .HasColumnType("int(11)")
                    .HasColumnName("dataint4");

                entity.Property(e => e.Datalong)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("datalong");

                entity.Property(e => e.Datalong2)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("datalong2");

                entity.Property(e => e.Datalong3)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("datalong3");

                entity.Property(e => e.Delay)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("delay");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.O).HasColumnName("o");

                entity.Property(e => e.Priority)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("priority");

                entity.Property(e => e.SearchRadius)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("search_radius");

                entity.Property(e => e.Speed).HasColumnName("speed");

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.Y).HasColumnName("y");

                entity.Property(e => e.Z).HasColumnName("z");
            });

            modelBuilder.Entity<DbscriptsOnCreatureMovement>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dbscripts_on_creature_movement");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.BuddyEntry)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("buddy_entry");

                entity.Property(e => e.Command)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("command")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Comments)
                    .HasMaxLength(255)
                    .HasColumnName("comments");

                entity.Property(e => e.ConditionId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("condition_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DataFlags)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("data_flags");

                entity.Property(e => e.Datafloat).HasColumnName("datafloat");

                entity.Property(e => e.Dataint)
                    .HasColumnType("int(11)")
                    .HasColumnName("dataint");

                entity.Property(e => e.Dataint2)
                    .HasColumnType("int(11)")
                    .HasColumnName("dataint2");

                entity.Property(e => e.Dataint3)
                    .HasColumnType("int(11)")
                    .HasColumnName("dataint3");

                entity.Property(e => e.Dataint4)
                    .HasColumnType("int(11)")
                    .HasColumnName("dataint4");

                entity.Property(e => e.Datalong)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("datalong");

                entity.Property(e => e.Datalong2)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("datalong2");

                entity.Property(e => e.Datalong3)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("datalong3");

                entity.Property(e => e.Delay)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("delay");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.O).HasColumnName("o");

                entity.Property(e => e.Priority)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("priority");

                entity.Property(e => e.SearchRadius)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("search_radius");

                entity.Property(e => e.Speed).HasColumnName("speed");

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.Y).HasColumnName("y");

                entity.Property(e => e.Z).HasColumnName("z");
            });

            modelBuilder.Entity<DbscriptsOnEvent>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dbscripts_on_event");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.BuddyEntry)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("buddy_entry");

                entity.Property(e => e.Command)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("command")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Comments)
                    .HasMaxLength(255)
                    .HasColumnName("comments");

                entity.Property(e => e.ConditionId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("condition_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DataFlags)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("data_flags");

                entity.Property(e => e.Datafloat).HasColumnName("datafloat");

                entity.Property(e => e.Dataint)
                    .HasColumnType("int(11)")
                    .HasColumnName("dataint");

                entity.Property(e => e.Dataint2)
                    .HasColumnType("int(11)")
                    .HasColumnName("dataint2");

                entity.Property(e => e.Dataint3)
                    .HasColumnType("int(11)")
                    .HasColumnName("dataint3");

                entity.Property(e => e.Dataint4)
                    .HasColumnType("int(11)")
                    .HasColumnName("dataint4");

                entity.Property(e => e.Datalong)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("datalong");

                entity.Property(e => e.Datalong2)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("datalong2");

                entity.Property(e => e.Datalong3)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("datalong3");

                entity.Property(e => e.Delay)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("delay");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.O).HasColumnName("o");

                entity.Property(e => e.Priority)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("priority");

                entity.Property(e => e.SearchRadius)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("search_radius");

                entity.Property(e => e.Speed).HasColumnName("speed");

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.Y).HasColumnName("y");

                entity.Property(e => e.Z).HasColumnName("z");
            });

            modelBuilder.Entity<DbscriptsOnGoTemplateUse>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dbscripts_on_go_template_use");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.BuddyEntry)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("buddy_entry");

                entity.Property(e => e.Command)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("command")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Comments)
                    .HasMaxLength(255)
                    .HasColumnName("comments");

                entity.Property(e => e.ConditionId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("condition_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DataFlags)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("data_flags");

                entity.Property(e => e.Datafloat).HasColumnName("datafloat");

                entity.Property(e => e.Dataint)
                    .HasColumnType("int(11)")
                    .HasColumnName("dataint");

                entity.Property(e => e.Dataint2)
                    .HasColumnType("int(11)")
                    .HasColumnName("dataint2");

                entity.Property(e => e.Dataint3)
                    .HasColumnType("int(11)")
                    .HasColumnName("dataint3");

                entity.Property(e => e.Dataint4)
                    .HasColumnType("int(11)")
                    .HasColumnName("dataint4");

                entity.Property(e => e.Datalong)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("datalong");

                entity.Property(e => e.Datalong2)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("datalong2");

                entity.Property(e => e.Datalong3)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("datalong3");

                entity.Property(e => e.Delay)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("delay");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.O).HasColumnName("o");

                entity.Property(e => e.Priority)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("priority");

                entity.Property(e => e.SearchRadius)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("search_radius");

                entity.Property(e => e.Speed).HasColumnName("speed");

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.Y).HasColumnName("y");

                entity.Property(e => e.Z).HasColumnName("z");
            });

            modelBuilder.Entity<DbscriptsOnGoUse>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dbscripts_on_go_use");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.BuddyEntry)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("buddy_entry");

                entity.Property(e => e.Command)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("command")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Comments)
                    .HasMaxLength(255)
                    .HasColumnName("comments");

                entity.Property(e => e.ConditionId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("condition_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DataFlags)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("data_flags");

                entity.Property(e => e.Datafloat).HasColumnName("datafloat");

                entity.Property(e => e.Dataint)
                    .HasColumnType("int(11)")
                    .HasColumnName("dataint");

                entity.Property(e => e.Dataint2)
                    .HasColumnType("int(11)")
                    .HasColumnName("dataint2");

                entity.Property(e => e.Dataint3)
                    .HasColumnType("int(11)")
                    .HasColumnName("dataint3");

                entity.Property(e => e.Dataint4)
                    .HasColumnType("int(11)")
                    .HasColumnName("dataint4");

                entity.Property(e => e.Datalong)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("datalong");

                entity.Property(e => e.Datalong2)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("datalong2");

                entity.Property(e => e.Datalong3)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("datalong3");

                entity.Property(e => e.Delay)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("delay");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.O).HasColumnName("o");

                entity.Property(e => e.Priority)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("priority");

                entity.Property(e => e.SearchRadius)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("search_radius");

                entity.Property(e => e.Speed).HasColumnName("speed");

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.Y).HasColumnName("y");

                entity.Property(e => e.Z).HasColumnName("z");
            });

            modelBuilder.Entity<DbscriptsOnGossip>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dbscripts_on_gossip");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.BuddyEntry)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("buddy_entry");

                entity.Property(e => e.Command)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("command")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Comments)
                    .HasMaxLength(255)
                    .HasColumnName("comments");

                entity.Property(e => e.ConditionId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("condition_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DataFlags)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("data_flags");

                entity.Property(e => e.Datafloat).HasColumnName("datafloat");

                entity.Property(e => e.Dataint)
                    .HasColumnType("int(11)")
                    .HasColumnName("dataint");

                entity.Property(e => e.Dataint2)
                    .HasColumnType("int(11)")
                    .HasColumnName("dataint2");

                entity.Property(e => e.Dataint3)
                    .HasColumnType("int(11)")
                    .HasColumnName("dataint3");

                entity.Property(e => e.Dataint4)
                    .HasColumnType("int(11)")
                    .HasColumnName("dataint4");

                entity.Property(e => e.Datalong)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("datalong");

                entity.Property(e => e.Datalong2)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("datalong2");

                entity.Property(e => e.Datalong3)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("datalong3");

                entity.Property(e => e.Delay)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("delay");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.O).HasColumnName("o");

                entity.Property(e => e.Priority)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("priority");

                entity.Property(e => e.SearchRadius)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("search_radius");

                entity.Property(e => e.Speed).HasColumnName("speed");

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.Y).HasColumnName("y");

                entity.Property(e => e.Z).HasColumnName("z");
            });

            modelBuilder.Entity<DbscriptsOnQuestEnd>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dbscripts_on_quest_end");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.BuddyEntry)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("buddy_entry");

                entity.Property(e => e.Command)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("command")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Comments)
                    .HasMaxLength(255)
                    .HasColumnName("comments");

                entity.Property(e => e.ConditionId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("condition_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DataFlags)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("data_flags");

                entity.Property(e => e.Datafloat).HasColumnName("datafloat");

                entity.Property(e => e.Dataint)
                    .HasColumnType("int(11)")
                    .HasColumnName("dataint");

                entity.Property(e => e.Dataint2)
                    .HasColumnType("int(11)")
                    .HasColumnName("dataint2");

                entity.Property(e => e.Dataint3)
                    .HasColumnType("int(11)")
                    .HasColumnName("dataint3");

                entity.Property(e => e.Dataint4)
                    .HasColumnType("int(11)")
                    .HasColumnName("dataint4");

                entity.Property(e => e.Datalong)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("datalong");

                entity.Property(e => e.Datalong2)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("datalong2");

                entity.Property(e => e.Datalong3)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("datalong3");

                entity.Property(e => e.Delay)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("delay");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.O).HasColumnName("o");

                entity.Property(e => e.Priority)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("priority");

                entity.Property(e => e.SearchRadius)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("search_radius");

                entity.Property(e => e.Speed).HasColumnName("speed");

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.Y).HasColumnName("y");

                entity.Property(e => e.Z).HasColumnName("z");
            });

            modelBuilder.Entity<DbscriptsOnQuestStart>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dbscripts_on_quest_start");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.BuddyEntry)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("buddy_entry");

                entity.Property(e => e.Command)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("command")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Comments)
                    .HasMaxLength(255)
                    .HasColumnName("comments");

                entity.Property(e => e.ConditionId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("condition_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DataFlags)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("data_flags");

                entity.Property(e => e.Datafloat).HasColumnName("datafloat");

                entity.Property(e => e.Dataint)
                    .HasColumnType("int(11)")
                    .HasColumnName("dataint");

                entity.Property(e => e.Dataint2)
                    .HasColumnType("int(11)")
                    .HasColumnName("dataint2");

                entity.Property(e => e.Dataint3)
                    .HasColumnType("int(11)")
                    .HasColumnName("dataint3");

                entity.Property(e => e.Dataint4)
                    .HasColumnType("int(11)")
                    .HasColumnName("dataint4");

                entity.Property(e => e.Datalong)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("datalong");

                entity.Property(e => e.Datalong2)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("datalong2");

                entity.Property(e => e.Datalong3)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("datalong3");

                entity.Property(e => e.Delay)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("delay");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.O).HasColumnName("o");

                entity.Property(e => e.Priority)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("priority");

                entity.Property(e => e.SearchRadius)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("search_radius");

                entity.Property(e => e.Speed).HasColumnName("speed");

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.Y).HasColumnName("y");

                entity.Property(e => e.Z).HasColumnName("z");
            });

            modelBuilder.Entity<DbscriptsOnSpell>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dbscripts_on_spell");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.BuddyEntry)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("buddy_entry");

                entity.Property(e => e.Command)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("command")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Comments)
                    .HasMaxLength(255)
                    .HasColumnName("comments");

                entity.Property(e => e.ConditionId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("condition_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DataFlags)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("data_flags");

                entity.Property(e => e.Datafloat).HasColumnName("datafloat");

                entity.Property(e => e.Dataint)
                    .HasColumnType("int(11)")
                    .HasColumnName("dataint");

                entity.Property(e => e.Dataint2)
                    .HasColumnType("int(11)")
                    .HasColumnName("dataint2");

                entity.Property(e => e.Dataint3)
                    .HasColumnType("int(11)")
                    .HasColumnName("dataint3");

                entity.Property(e => e.Dataint4)
                    .HasColumnType("int(11)")
                    .HasColumnName("dataint4");

                entity.Property(e => e.Datalong)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("datalong");

                entity.Property(e => e.Datalong2)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("datalong2");

                entity.Property(e => e.Datalong3)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("datalong3");

                entity.Property(e => e.Delay)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("delay");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.O).HasColumnName("o");

                entity.Property(e => e.Priority)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("priority");

                entity.Property(e => e.SearchRadius)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("search_radius");

                entity.Property(e => e.Speed).HasColumnName("speed");

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.Y).HasColumnName("y");

                entity.Property(e => e.Z).HasColumnName("z");
            });

            modelBuilder.Entity<DisenchantLootTemplate>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.Item })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("disenchant_loot_template");

                entity.HasComment("Loot System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Recommended id selection: item_level*100 + item_quality");

                entity.Property(e => e.Item)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("item")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ChanceOrQuestChance).HasDefaultValueSql("'100'");

                entity.Property(e => e.Comments)
                    .HasMaxLength(300)
                    .HasColumnName("comments")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ConditionId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("condition_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Groupid)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("groupid");

                entity.Property(e => e.Maxcount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("maxcount")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MincountOrRef)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("mincountOrRef")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<ExplorationBasexp>(entity =>
            {
                entity.HasKey(e => e.Level)
                    .HasName("PRIMARY");

                entity.ToTable("exploration_basexp");

                entity.HasComment("Exploration System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Level)
                    .HasColumnType("tinyint(4)")
                    .ValueGeneratedNever()
                    .HasColumnName("level");

                entity.Property(e => e.Basexp)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("basexp")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<FishingLootTemplate>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.Item })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("fishing_loot_template");

                entity.HasComment("Loot System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'")
                    .HasComment("entry 0 used for junk loot at fishing fail (if allowed by config option)");

                entity.Property(e => e.Item)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("item")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ChanceOrQuestChance).HasDefaultValueSql("'100'");

                entity.Property(e => e.Comments)
                    .HasMaxLength(300)
                    .HasColumnName("comments")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ConditionId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("condition_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Groupid)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("groupid");

                entity.Property(e => e.Maxcount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("maxcount")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MincountOrRef)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("mincountOrRef")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<GameEvent>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("game_event");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("entry")
                    .HasComment("Entry of the game event");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description")
                    .HasComment("Description of the event displayed in console");

                entity.Property(e => e.EventGroup)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Used for events that are randomized daily/weekly");

                entity.Property(e => e.Holiday)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("holiday")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Client side holiday id");

                entity.Property(e => e.Length)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("length")
                    .HasDefaultValueSql("'43200'")
                    .HasComment("Length in minutes of the event");

                entity.Property(e => e.LinkedTo)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("linkedTo")
                    .HasDefaultValueSql("'0'")
                    .HasComment("This event starts only if defined LinkedTo event is started");

                entity.Property(e => e.Occurence)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("occurence")
                    .HasDefaultValueSql("'86400'")
                    .HasComment("Delay in minutes between occurences of the event");
            });

            modelBuilder.Entity<GameEventCreature>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Event })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("game_event_creature");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guid");

                entity.Property(e => e.Event)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("event")
                    .HasComment("Negatives value to remove during event and ignore pool grouping, positive value for spawn during event and if guid is part of pool then al pool memebers must be listed as part of event spawn.");
            });

            modelBuilder.Entity<GameEventCreatureDatum>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Event })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("game_event_creature_data");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guid");

                entity.Property(e => e.Event)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("event");

                entity.Property(e => e.EntryId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EquipmentId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("equipment_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Modelid)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("modelid")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SpellEnd)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("spell_end")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SpellStart)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("spell_start")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.VendorId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("vendor_id")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<GameEventGameobject>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Event })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("game_event_gameobject");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guid");

                entity.Property(e => e.Event)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("event")
                    .HasComment("Negatives value to remove during event and ignore pool grouping, positive value for spawn during event and if guid is part of pool then al pool memebers must be listed as part of event spawn.");
            });

            modelBuilder.Entity<GameEventMail>(entity =>
            {
                entity.HasKey(e => new { e.Event, e.RaceMask, e.Quest })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("game_event_mail");

                entity.HasComment("Game event system")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Event)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("event")
                    .HasComment("Negatives value to send at event stop, positive value for send at event start.");

                entity.Property(e => e.RaceMask)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("raceMask")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Quest)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("quest")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MailTemplateId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("mailTemplateId")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SenderEntry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("senderEntry")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<GameEventQuest>(entity =>
            {
                entity.HasKey(e => new { e.Quest, e.Event })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("game_event_quest");

                entity.HasComment("Game event system")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Quest)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("quest")
                    .HasDefaultValueSql("'0'")
                    .HasComment("entry from quest_template");

                entity.Property(e => e.Event)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("event")
                    .HasComment("entry from game_event");
            });

            modelBuilder.Entity<GameEventTime>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("game_event_time");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("entry")
                    .HasComment("Entry of the game event");

                entity.Property(e => e.EndTime)
                    .HasColumnType("datetime")
                    .HasColumnName("end_time")
                    .HasDefaultValueSql("'1970-01-01 00:00:00'")
                    .HasComment("Absolute end date, the event will never start after");

                entity.Property(e => e.StartTime)
                    .HasColumnType("datetime")
                    .HasColumnName("start_time")
                    .HasDefaultValueSql("'1970-01-01 00:00:00'")
                    .HasComment("Absolute start date, the event will never start before");
            });

            modelBuilder.Entity<GameGraveyardZone>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.GhostLoc, e.LinkKind })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("game_graveyard_zone");

                entity.HasComment("Graveyard link definitions")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GhostLoc)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("ghost_loc")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.LinkKind)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("link_kind");

                entity.Property(e => e.Faction)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("faction");
            });

            modelBuilder.Entity<GameTele>(entity =>
            {
                entity.ToTable("game_tele");

                entity.HasComment("Tele Command")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Map)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("map");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Orientation).HasColumnName("orientation");

                entity.Property(e => e.PositionX).HasColumnName("position_x");

                entity.Property(e => e.PositionY).HasColumnName("position_y");

                entity.Property(e => e.PositionZ).HasColumnName("position_z");
            });

            modelBuilder.Entity<GameWeather>(entity =>
            {
                entity.HasKey(e => e.Zone)
                    .HasName("PRIMARY");

                entity.ToTable("game_weather");

                entity.HasComment("Weather System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Zone)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("zone")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FallRainChance)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("fall_rain_chance")
                    .HasDefaultValueSql("'25'");

                entity.Property(e => e.FallSnowChance)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("fall_snow_chance")
                    .HasDefaultValueSql("'25'");

                entity.Property(e => e.FallStormChance)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("fall_storm_chance")
                    .HasDefaultValueSql("'25'");

                entity.Property(e => e.SpringRainChance)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("spring_rain_chance")
                    .HasDefaultValueSql("'25'");

                entity.Property(e => e.SpringSnowChance)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("spring_snow_chance")
                    .HasDefaultValueSql("'25'");

                entity.Property(e => e.SpringStormChance)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("spring_storm_chance")
                    .HasDefaultValueSql("'25'");

                entity.Property(e => e.SummerRainChance)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("summer_rain_chance")
                    .HasDefaultValueSql("'25'");

                entity.Property(e => e.SummerSnowChance)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("summer_snow_chance")
                    .HasDefaultValueSql("'25'");

                entity.Property(e => e.SummerStormChance)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("summer_storm_chance")
                    .HasDefaultValueSql("'25'");

                entity.Property(e => e.WinterRainChance)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("winter_rain_chance")
                    .HasDefaultValueSql("'25'");

                entity.Property(e => e.WinterSnowChance)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("winter_snow_chance")
                    .HasDefaultValueSql("'25'");

                entity.Property(e => e.WinterStormChance)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("winter_storm_chance")
                    .HasDefaultValueSql("'25'");
            });

            modelBuilder.Entity<Gameobject>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PRIMARY");

                entity.ToTable("gameobject");

                entity.HasComment("Gameobject System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasIndex(e => e.Id, "idx_id");

                entity.HasIndex(e => e.Map, "idx_map");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guid")
                    .HasComment("Global Unique Identifier");

                entity.Property(e => e.Animprogress)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("animprogress");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("id")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Gameobject Identifier");

                entity.Property(e => e.Map)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("map")
                    .HasComment("Map Identifier");

                entity.Property(e => e.Orientation).HasColumnName("orientation");

                entity.Property(e => e.PositionX).HasColumnName("position_x");

                entity.Property(e => e.PositionY).HasColumnName("position_y");

                entity.Property(e => e.PositionZ).HasColumnName("position_z");

                entity.Property(e => e.Rotation0).HasColumnName("rotation0");

                entity.Property(e => e.Rotation1).HasColumnName("rotation1");

                entity.Property(e => e.Rotation2).HasColumnName("rotation2");

                entity.Property(e => e.Rotation3).HasColumnName("rotation3");

                entity.Property(e => e.SpawnMask)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("spawnMask")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Spawntimesecsmax)
                    .HasColumnType("int(11)")
                    .HasColumnName("spawntimesecsmax")
                    .HasComment("Gameobject respawn time maximum");

                entity.Property(e => e.Spawntimesecsmin)
                    .HasColumnType("int(11)")
                    .HasColumnName("spawntimesecsmin")
                    .HasComment("GameObject respawn time minimum");

                entity.Property(e => e.State)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("state");
            });

            modelBuilder.Entity<GameobjectBattleground>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PRIMARY");

                entity.ToTable("gameobject_battleground");

                entity.HasComment("GameObject battleground indexing system")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("guid")
                    .HasComment("GameObject's GUID");

                entity.Property(e => e.Event1)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("event1")
                    .HasComment("main event");

                entity.Property(e => e.Event2)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("event2")
                    .HasComment("sub event");
            });

            modelBuilder.Entity<GameobjectInvolvedrelation>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Quest })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("gameobject_involvedrelation");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Quest)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("quest")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Quest Identifier");
            });

            modelBuilder.Entity<GameobjectLootTemplate>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.Item })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("gameobject_loot_template");

                entity.HasComment("Loot System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Item)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("item")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ChanceOrQuestChance).HasDefaultValueSql("'100'");

                entity.Property(e => e.Comments)
                    .HasMaxLength(300)
                    .HasColumnName("comments")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ConditionId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("condition_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Groupid)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("groupid");

                entity.Property(e => e.Maxcount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("maxcount")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MincountOrRef)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("mincountOrRef")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<GameobjectQuestrelation>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Quest })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("gameobject_questrelation");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Quest)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("quest")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Quest Identifier");
            });

            modelBuilder.Entity<GameobjectSpawnEntry>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Entry })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("gameobject_spawn_entry");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guid")
                    .HasComment("Gameobject table guid");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasComment("Gameobject Template entry");
            });

            modelBuilder.Entity<GameobjectTemplate>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("gameobject_template");

                entity.HasComment("Gameobject System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CastBarCaption)
                    .HasMaxLength(100)
                    .HasColumnName("castBarCaption")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CustomData1).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Data0)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("data0");

                entity.Property(e => e.Data1)
                    .HasColumnType("int(10)")
                    .HasColumnName("data1");

                entity.Property(e => e.Data10)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("data10");

                entity.Property(e => e.Data11)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("data11");

                entity.Property(e => e.Data12)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("data12");

                entity.Property(e => e.Data13)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("data13");

                entity.Property(e => e.Data14)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("data14");

                entity.Property(e => e.Data15)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("data15");

                entity.Property(e => e.Data16)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("data16");

                entity.Property(e => e.Data17)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("data17");

                entity.Property(e => e.Data18)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("data18");

                entity.Property(e => e.Data19)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("data19");

                entity.Property(e => e.Data2)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("data2");

                entity.Property(e => e.Data20)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("data20");

                entity.Property(e => e.Data21)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("data21");

                entity.Property(e => e.Data22)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("data22");

                entity.Property(e => e.Data23)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("data23");

                entity.Property(e => e.Data3)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("data3");

                entity.Property(e => e.Data4)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("data4");

                entity.Property(e => e.Data5)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("data5");

                entity.Property(e => e.Data6)
                    .HasColumnType("int(10)")
                    .HasColumnName("data6");

                entity.Property(e => e.Data7)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("data7");

                entity.Property(e => e.Data8)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("data8");

                entity.Property(e => e.Data9)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("data9");

                entity.Property(e => e.DisplayId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("displayId")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ExtraFlags).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Faction)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("faction");

                entity.Property(e => e.Flags)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("flags");

                entity.Property(e => e.IconName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Maxgold)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("maxgold")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Mingold)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("mingold")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ScriptName)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Size)
                    .HasColumnName("size")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("type");
            });

            modelBuilder.Entity<GameobjectTemplateAddon>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("gameobject_template_addon");

                entity.Property(e => e.Entry)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasComment("gameobject_template");

                entity.Property(e => e.Artkit0).HasColumnType("int(11)");

                entity.Property(e => e.Artkit1).HasColumnType("int(11)");

                entity.Property(e => e.Artkit2).HasColumnType("int(11)");

                entity.Property(e => e.Artkit3).HasColumnType("int(11)");
            });

            modelBuilder.Entity<GossipMenu>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.TextId, e.ScriptId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("gossip_menu");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("smallint(6) unsigned")
                    .HasColumnName("entry");

                entity.Property(e => e.TextId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("text_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ScriptId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("script_id")
                    .HasDefaultValueSql("'0'")
                    .HasComment("script in `dbscripts_on_gossip` - will be executed on GossipHello");

                entity.Property(e => e.ConditionId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("condition_id")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<GossipMenuOption>(entity =>
            {
                entity.HasKey(e => new { e.MenuId, e.Id })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("gossip_menu_option");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.MenuId)
                    .HasColumnType("smallint(6) unsigned")
                    .HasColumnName("menu_id");

                entity.Property(e => e.Id)
                    .HasColumnType("smallint(6) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.ActionMenuId)
                    .HasColumnType("mediumint(8)")
                    .HasColumnName("action_menu_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ActionPoiId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("action_poi_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ActionScriptId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("action_script_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.BoxBroadcastText)
                    .HasColumnType("int(11)")
                    .HasColumnName("box_broadcast_text");

                entity.Property(e => e.BoxCoded)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("box_coded");

                entity.Property(e => e.BoxMoney)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("box_money");

                entity.Property(e => e.BoxText)
                    .HasColumnType("text")
                    .HasColumnName("box_text");

                entity.Property(e => e.ConditionId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("condition_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.NpcOptionNpcflag)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("npc_option_npcflag");

                entity.Property(e => e.OptionBroadcastText)
                    .HasColumnType("int(11)")
                    .HasColumnName("option_broadcast_text");

                entity.Property(e => e.OptionIcon)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("option_icon")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.OptionId)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("option_id");

                entity.Property(e => e.OptionText)
                    .HasColumnType("text")
                    .HasColumnName("option_text");
            });

            modelBuilder.Entity<GossipText>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("gossip_texts");

                entity.HasComment("Gossip Texts")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8)")
                    .ValueGeneratedNever()
                    .HasColumnName("entry");

                entity.Property(e => e.Comment)
                    .HasColumnType("text")
                    .HasColumnName("comment");

                entity.Property(e => e.ContentDefault)
                    .HasColumnType("text")
                    .HasColumnName("content_default");

                entity.Property(e => e.ContentLoc1)
                    .HasColumnType("text")
                    .HasColumnName("content_loc1");

                entity.Property(e => e.ContentLoc2)
                    .HasColumnType("text")
                    .HasColumnName("content_loc2");

                entity.Property(e => e.ContentLoc3)
                    .HasColumnType("text")
                    .HasColumnName("content_loc3");

                entity.Property(e => e.ContentLoc4)
                    .HasColumnType("text")
                    .HasColumnName("content_loc4");

                entity.Property(e => e.ContentLoc5)
                    .HasColumnType("text")
                    .HasColumnName("content_loc5");

                entity.Property(e => e.ContentLoc6)
                    .HasColumnType("text")
                    .HasColumnName("content_loc6");

                entity.Property(e => e.ContentLoc7)
                    .HasColumnType("text")
                    .HasColumnName("content_loc7");

                entity.Property(e => e.ContentLoc8)
                    .HasColumnType("text")
                    .HasColumnName("content_loc8");
            });

            modelBuilder.Entity<InstanceEncounter>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("instance_encounters");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("entry")
                    .HasComment("Unique entry from DungeonEncounter.dbc");

                entity.Property(e => e.CreditEntry)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("creditEntry");

                entity.Property(e => e.CreditType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("creditType");

                entity.Property(e => e.LastEncounterDungeon)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("lastEncounterDungeon")
                    .HasComment("If not 0, LfgDungeon.dbc entry for the instance it is last encounter in");
            });

            modelBuilder.Entity<InstanceTemplate>(entity =>
            {
                entity.HasKey(e => e.Map)
                    .HasName("PRIMARY");

                entity.ToTable("instance_template");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Map)
                    .HasColumnType("smallint(5) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("map");

                entity.Property(e => e.LevelMax)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("levelMax");

                entity.Property(e => e.LevelMin)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("levelMin");

                entity.Property(e => e.MaxPlayers)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("maxPlayers");

                entity.Property(e => e.MountAllowed)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("mountAllowed");

                entity.Property(e => e.Parent)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("parent");

                entity.Property(e => e.ResetDelay)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("reset_delay")
                    .HasComment("Reset time in days");

                entity.Property(e => e.ScriptName)
                    .HasMaxLength(128)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ItemEnchantmentTemplate>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.Ench })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("item_enchantment_template");

                entity.HasComment("Item Random Enchantment System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Ench)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("ench")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Chance)
                    .HasColumnType("float unsigned")
                    .HasColumnName("chance");
            });

            modelBuilder.Entity<ItemLootTemplate>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.Item })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("item_loot_template");

                entity.HasComment("Loot System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Item)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("item")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ChanceOrQuestChance).HasDefaultValueSql("'100'");

                entity.Property(e => e.Comments)
                    .HasMaxLength(300)
                    .HasColumnName("comments")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ConditionId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("condition_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Groupid)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("groupid");

                entity.Property(e => e.Maxcount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("maxcount")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MincountOrRef)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("mincountOrRef")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<ItemRequiredTarget>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("item_required_target");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasIndex(e => new { e.Entry, e.Type, e.TargetEntry }, "entry_type_target")
                    .IsUnique();

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry");

                entity.Property(e => e.TargetEntry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("targetEntry")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("type");
            });

            modelBuilder.Entity<ItemTemplate>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("item_template");

                entity.HasComment("Item System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasIndex(e => e.Class, "items_index");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AllowableClass)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.AllowableRace)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.AmmoType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("ammo_type");

                entity.Property(e => e.ArcaneRes)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("arcane_res");

                entity.Property(e => e.Area)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("area")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Armor)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("armor");

                entity.Property(e => e.BagFamily)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Block)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("block")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Bonding)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("bonding");

                entity.Property(e => e.BuyCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.BuyPrice).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Class)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("class");

                entity.Property(e => e.ContainerSlots).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Delay)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("delay")
                    .HasDefaultValueSql("'1000'");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DisenchantId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("DisenchantID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Displayid)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("displayid")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DmgMax1).HasColumnName("dmg_max1");

                entity.Property(e => e.DmgMax2).HasColumnName("dmg_max2");

                entity.Property(e => e.DmgMax3).HasColumnName("dmg_max3");

                entity.Property(e => e.DmgMax4).HasColumnName("dmg_max4");

                entity.Property(e => e.DmgMax5).HasColumnName("dmg_max5");

                entity.Property(e => e.DmgMin1).HasColumnName("dmg_min1");

                entity.Property(e => e.DmgMin2).HasColumnName("dmg_min2");

                entity.Property(e => e.DmgMin3).HasColumnName("dmg_min3");

                entity.Property(e => e.DmgMin4).HasColumnName("dmg_min4");

                entity.Property(e => e.DmgMin5).HasColumnName("dmg_min5");

                entity.Property(e => e.DmgType1)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("dmg_type1");

                entity.Property(e => e.DmgType2)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("dmg_type2");

                entity.Property(e => e.DmgType3)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("dmg_type3");

                entity.Property(e => e.DmgType4)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("dmg_type4");

                entity.Property(e => e.DmgType5)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("dmg_type5");

                entity.Property(e => e.Duration)
                    .HasColumnType("int(11) unsigned")
                    .HasComment("Duration in seconds");

                entity.Property(e => e.ExtraFlags).HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.FireRes)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("fire_res");

                entity.Property(e => e.Flags).HasColumnType("int(10) unsigned");

                entity.Property(e => e.FoodType).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.FrostRes)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("frost_res");

                entity.Property(e => e.GemProperties)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.HolyRes)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("holy_res");

                entity.Property(e => e.InventoryType).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.ItemLevel).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Itemset)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("itemset")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.LanguageId)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("LanguageID");

                entity.Property(e => e.Lockid)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("lockid")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Map).HasColumnType("smallint(6)");

                entity.Property(e => e.Material).HasColumnType("tinyint(4)");

                entity.Property(e => e.MaxDurability).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.MaxMoneyLoot)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("maxMoneyLoot");

                entity.Property(e => e.Maxcount)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("maxcount");

                entity.Property(e => e.MinMoneyLoot)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("minMoneyLoot");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NatureRes)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("nature_res");

                entity.Property(e => e.PageMaterial).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.PageText)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Quality).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.RandomProperty)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RandomSuffix)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RequiredCityRank)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RequiredDisenchantSkill)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.RequiredLevel).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.RequiredReputationFaction).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RequiredReputationRank).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RequiredSkill).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RequiredSkillRank).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Requiredhonorrank)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("requiredhonorrank")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Requiredspell)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("requiredspell")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ScriptName)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SellPrice).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ShadowRes)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("shadow_res");

                entity.Property(e => e.Sheath)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("sheath");

                entity.Property(e => e.SocketBonus)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("socketBonus")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SocketColor1)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("socketColor_1");

                entity.Property(e => e.SocketColor2)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("socketColor_2");

                entity.Property(e => e.SocketColor3)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("socketColor_3");

                entity.Property(e => e.SocketContent1)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("socketContent_1")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SocketContent2)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("socketContent_2")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SocketContent3)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("socketContent_3")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Spellcategory1)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("spellcategory_1");

                entity.Property(e => e.Spellcategory2)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("spellcategory_2");

                entity.Property(e => e.Spellcategory3)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("spellcategory_3");

                entity.Property(e => e.Spellcategory4)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("spellcategory_4");

                entity.Property(e => e.Spellcategory5)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("spellcategory_5");

                entity.Property(e => e.Spellcategorycooldown1)
                    .HasColumnType("int(11)")
                    .HasColumnName("spellcategorycooldown_1")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.Spellcategorycooldown2)
                    .HasColumnType("int(11)")
                    .HasColumnName("spellcategorycooldown_2")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.Spellcategorycooldown3)
                    .HasColumnType("int(11)")
                    .HasColumnName("spellcategorycooldown_3")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.Spellcategorycooldown4)
                    .HasColumnType("int(11)")
                    .HasColumnName("spellcategorycooldown_4")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.Spellcategorycooldown5)
                    .HasColumnType("int(11)")
                    .HasColumnName("spellcategorycooldown_5")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.Spellcharges1)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("spellcharges_1");

                entity.Property(e => e.Spellcharges2)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("spellcharges_2");

                entity.Property(e => e.Spellcharges3)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("spellcharges_3");

                entity.Property(e => e.Spellcharges4)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("spellcharges_4");

                entity.Property(e => e.Spellcharges5)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("spellcharges_5");

                entity.Property(e => e.Spellcooldown1)
                    .HasColumnType("int(11)")
                    .HasColumnName("spellcooldown_1")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.Spellcooldown2)
                    .HasColumnType("int(11)")
                    .HasColumnName("spellcooldown_2")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.Spellcooldown3)
                    .HasColumnType("int(11)")
                    .HasColumnName("spellcooldown_3")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.Spellcooldown4)
                    .HasColumnType("int(11)")
                    .HasColumnName("spellcooldown_4")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.Spellcooldown5)
                    .HasColumnType("int(11)")
                    .HasColumnName("spellcooldown_5")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.Spellid1)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("spellid_1")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Spellid2)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("spellid_2")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Spellid3)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("spellid_3")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Spellid4)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("spellid_4")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Spellid5)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("spellid_5")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SpellppmRate1).HasColumnName("spellppmRate_1");

                entity.Property(e => e.SpellppmRate2).HasColumnName("spellppmRate_2");

                entity.Property(e => e.SpellppmRate3).HasColumnName("spellppmRate_3");

                entity.Property(e => e.SpellppmRate4).HasColumnName("spellppmRate_4");

                entity.Property(e => e.SpellppmRate5).HasColumnName("spellppmRate_5");

                entity.Property(e => e.Spelltrigger1)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("spelltrigger_1");

                entity.Property(e => e.Spelltrigger2)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("spelltrigger_2");

                entity.Property(e => e.Spelltrigger3)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("spelltrigger_3");

                entity.Property(e => e.Spelltrigger4)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("spelltrigger_4");

                entity.Property(e => e.Spelltrigger5)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("spelltrigger_5");

                entity.Property(e => e.Stackable)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("stackable")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Startquest)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("startquest")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.StatType1)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("stat_type1");

                entity.Property(e => e.StatType10)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("stat_type10");

                entity.Property(e => e.StatType2)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("stat_type2");

                entity.Property(e => e.StatType3)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("stat_type3");

                entity.Property(e => e.StatType4)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("stat_type4");

                entity.Property(e => e.StatType5)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("stat_type5");

                entity.Property(e => e.StatType6)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("stat_type6");

                entity.Property(e => e.StatType7)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("stat_type7");

                entity.Property(e => e.StatType8)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("stat_type8");

                entity.Property(e => e.StatType9)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("stat_type9");

                entity.Property(e => e.StatValue1)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("stat_value1");

                entity.Property(e => e.StatValue10)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("stat_value10");

                entity.Property(e => e.StatValue2)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("stat_value2");

                entity.Property(e => e.StatValue3)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("stat_value3");

                entity.Property(e => e.StatValue4)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("stat_value4");

                entity.Property(e => e.StatValue5)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("stat_value5");

                entity.Property(e => e.StatValue6)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("stat_value6");

                entity.Property(e => e.StatValue7)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("stat_value7");

                entity.Property(e => e.StatValue8)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("stat_value8");

                entity.Property(e => e.StatValue9)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("stat_value9");

                entity.Property(e => e.Subclass)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("subclass");

                entity.Property(e => e.TotemCategory).HasColumnType("tinyint(4)");

                entity.Property(e => e.Unk0)
                    .HasColumnType("int(11)")
                    .HasColumnName("unk0")
                    .HasDefaultValueSql("-1");
            });

            modelBuilder.Entity<LocalesAreatriggerTeleport>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("locales_areatrigger_teleport");

                entity.HasComment("Areatrigger System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("int(11) unsigned")
                    .ValueGeneratedNever()
                    .HasComment("Entry of Areatrigger Teleport");

                entity.Property(e => e.TextLoc1)
                    .HasColumnName("Text_loc1")
                    .HasComment("Text of the status_failed locale 1");

                entity.Property(e => e.TextLoc2)
                    .HasColumnName("Text_loc2")
                    .HasComment("Text of the status_failed locale 2");

                entity.Property(e => e.TextLoc3)
                    .HasColumnName("Text_loc3")
                    .HasComment("Text of the status_failed locale 3");

                entity.Property(e => e.TextLoc4)
                    .HasColumnName("Text_loc4")
                    .HasComment("Text of the status_failed locale 4");

                entity.Property(e => e.TextLoc5)
                    .HasColumnName("Text_loc5")
                    .HasComment("Text of the status_failed locale 5");

                entity.Property(e => e.TextLoc6)
                    .HasColumnName("Text_loc6")
                    .HasComment("Text of the status_failed locale 6");

                entity.Property(e => e.TextLoc7)
                    .HasColumnName("Text_loc7")
                    .HasComment("Text of the status_failed locale 7");

                entity.Property(e => e.TextLoc8)
                    .HasColumnName("Text_loc8")
                    .HasComment("Text of the status_failed locale 8");
            });

            modelBuilder.Entity<LocalesCreature>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("locales_creature");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.NameLoc1)
                    .HasMaxLength(100)
                    .HasColumnName("name_loc1")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NameLoc2)
                    .HasMaxLength(100)
                    .HasColumnName("name_loc2")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NameLoc3)
                    .HasMaxLength(100)
                    .HasColumnName("name_loc3")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NameLoc4)
                    .HasMaxLength(100)
                    .HasColumnName("name_loc4")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NameLoc5)
                    .HasMaxLength(100)
                    .HasColumnName("name_loc5")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NameLoc6)
                    .HasMaxLength(100)
                    .HasColumnName("name_loc6")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NameLoc7)
                    .HasMaxLength(100)
                    .HasColumnName("name_loc7")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NameLoc8)
                    .HasMaxLength(100)
                    .HasColumnName("name_loc8")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SubnameLoc1)
                    .HasMaxLength(100)
                    .HasColumnName("subname_loc1");

                entity.Property(e => e.SubnameLoc2)
                    .HasMaxLength(100)
                    .HasColumnName("subname_loc2");

                entity.Property(e => e.SubnameLoc3)
                    .HasMaxLength(100)
                    .HasColumnName("subname_loc3");

                entity.Property(e => e.SubnameLoc4)
                    .HasMaxLength(100)
                    .HasColumnName("subname_loc4");

                entity.Property(e => e.SubnameLoc5)
                    .HasMaxLength(100)
                    .HasColumnName("subname_loc5");

                entity.Property(e => e.SubnameLoc6)
                    .HasMaxLength(100)
                    .HasColumnName("subname_loc6");

                entity.Property(e => e.SubnameLoc7)
                    .HasMaxLength(100)
                    .HasColumnName("subname_loc7");

                entity.Property(e => e.SubnameLoc8)
                    .HasMaxLength(100)
                    .HasColumnName("subname_loc8");
            });

            modelBuilder.Entity<LocalesGameobject>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("locales_gameobject");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CastbarcaptionLoc1)
                    .HasMaxLength(100)
                    .HasColumnName("castbarcaption_loc1")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CastbarcaptionLoc2)
                    .HasMaxLength(100)
                    .HasColumnName("castbarcaption_loc2")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CastbarcaptionLoc3)
                    .HasMaxLength(100)
                    .HasColumnName("castbarcaption_loc3")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CastbarcaptionLoc4)
                    .HasMaxLength(100)
                    .HasColumnName("castbarcaption_loc4")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CastbarcaptionLoc5)
                    .HasMaxLength(100)
                    .HasColumnName("castbarcaption_loc5")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CastbarcaptionLoc6)
                    .HasMaxLength(100)
                    .HasColumnName("castbarcaption_loc6")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CastbarcaptionLoc7)
                    .HasMaxLength(100)
                    .HasColumnName("castbarcaption_loc7")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CastbarcaptionLoc8)
                    .HasMaxLength(100)
                    .HasColumnName("castbarcaption_loc8")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NameLoc1)
                    .HasMaxLength(100)
                    .HasColumnName("name_loc1")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NameLoc2)
                    .HasMaxLength(100)
                    .HasColumnName("name_loc2")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NameLoc3)
                    .HasMaxLength(100)
                    .HasColumnName("name_loc3")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NameLoc4)
                    .HasMaxLength(100)
                    .HasColumnName("name_loc4")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NameLoc5)
                    .HasMaxLength(100)
                    .HasColumnName("name_loc5")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NameLoc6)
                    .HasMaxLength(100)
                    .HasColumnName("name_loc6")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NameLoc7)
                    .HasMaxLength(100)
                    .HasColumnName("name_loc7")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NameLoc8)
                    .HasMaxLength(100)
                    .HasColumnName("name_loc8")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<LocalesGossipMenuOption>(entity =>
            {
                entity.HasKey(e => new { e.MenuId, e.Id })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("locales_gossip_menu_option");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.MenuId)
                    .HasColumnType("smallint(6) unsigned")
                    .HasColumnName("menu_id");

                entity.Property(e => e.Id)
                    .HasColumnType("smallint(6) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.BoxTextLoc1)
                    .HasColumnType("text")
                    .HasColumnName("box_text_loc1");

                entity.Property(e => e.BoxTextLoc2)
                    .HasColumnType("text")
                    .HasColumnName("box_text_loc2");

                entity.Property(e => e.BoxTextLoc3)
                    .HasColumnType("text")
                    .HasColumnName("box_text_loc3");

                entity.Property(e => e.BoxTextLoc4)
                    .HasColumnType("text")
                    .HasColumnName("box_text_loc4");

                entity.Property(e => e.BoxTextLoc5)
                    .HasColumnType("text")
                    .HasColumnName("box_text_loc5");

                entity.Property(e => e.BoxTextLoc6)
                    .HasColumnType("text")
                    .HasColumnName("box_text_loc6");

                entity.Property(e => e.BoxTextLoc7)
                    .HasColumnType("text")
                    .HasColumnName("box_text_loc7");

                entity.Property(e => e.BoxTextLoc8)
                    .HasColumnType("text")
                    .HasColumnName("box_text_loc8");

                entity.Property(e => e.OptionTextLoc1)
                    .HasColumnType("text")
                    .HasColumnName("option_text_loc1");

                entity.Property(e => e.OptionTextLoc2)
                    .HasColumnType("text")
                    .HasColumnName("option_text_loc2");

                entity.Property(e => e.OptionTextLoc3)
                    .HasColumnType("text")
                    .HasColumnName("option_text_loc3");

                entity.Property(e => e.OptionTextLoc4)
                    .HasColumnType("text")
                    .HasColumnName("option_text_loc4");

                entity.Property(e => e.OptionTextLoc5)
                    .HasColumnType("text")
                    .HasColumnName("option_text_loc5");

                entity.Property(e => e.OptionTextLoc6)
                    .HasColumnType("text")
                    .HasColumnName("option_text_loc6");

                entity.Property(e => e.OptionTextLoc7)
                    .HasColumnType("text")
                    .HasColumnName("option_text_loc7");

                entity.Property(e => e.OptionTextLoc8)
                    .HasColumnType("text")
                    .HasColumnName("option_text_loc8");
            });

            modelBuilder.Entity<LocalesItem>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("locales_item");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DescriptionLoc1)
                    .HasMaxLength(255)
                    .HasColumnName("description_loc1");

                entity.Property(e => e.DescriptionLoc2)
                    .HasMaxLength(255)
                    .HasColumnName("description_loc2");

                entity.Property(e => e.DescriptionLoc3)
                    .HasMaxLength(255)
                    .HasColumnName("description_loc3");

                entity.Property(e => e.DescriptionLoc4)
                    .HasMaxLength(255)
                    .HasColumnName("description_loc4");

                entity.Property(e => e.DescriptionLoc5)
                    .HasMaxLength(255)
                    .HasColumnName("description_loc5");

                entity.Property(e => e.DescriptionLoc6)
                    .HasMaxLength(255)
                    .HasColumnName("description_loc6");

                entity.Property(e => e.DescriptionLoc7)
                    .HasMaxLength(255)
                    .HasColumnName("description_loc7");

                entity.Property(e => e.DescriptionLoc8)
                    .HasMaxLength(255)
                    .HasColumnName("description_loc8");

                entity.Property(e => e.NameLoc1)
                    .HasMaxLength(100)
                    .HasColumnName("name_loc1")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NameLoc2)
                    .HasMaxLength(100)
                    .HasColumnName("name_loc2")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NameLoc3)
                    .HasMaxLength(100)
                    .HasColumnName("name_loc3")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NameLoc4)
                    .HasMaxLength(100)
                    .HasColumnName("name_loc4")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NameLoc5)
                    .HasMaxLength(100)
                    .HasColumnName("name_loc5")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NameLoc6)
                    .HasMaxLength(100)
                    .HasColumnName("name_loc6")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NameLoc7)
                    .HasMaxLength(100)
                    .HasColumnName("name_loc7")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NameLoc8)
                    .HasMaxLength(100)
                    .HasColumnName("name_loc8")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<LocalesNpcText>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("locales_npc_text");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Text00Loc1).HasColumnName("Text0_0_loc1");

                entity.Property(e => e.Text00Loc2).HasColumnName("Text0_0_loc2");

                entity.Property(e => e.Text00Loc3).HasColumnName("Text0_0_loc3");

                entity.Property(e => e.Text00Loc4).HasColumnName("Text0_0_loc4");

                entity.Property(e => e.Text00Loc5).HasColumnName("Text0_0_loc5");

                entity.Property(e => e.Text00Loc6).HasColumnName("Text0_0_loc6");

                entity.Property(e => e.Text00Loc7).HasColumnName("Text0_0_loc7");

                entity.Property(e => e.Text00Loc8).HasColumnName("Text0_0_loc8");

                entity.Property(e => e.Text01Loc1).HasColumnName("Text0_1_loc1");

                entity.Property(e => e.Text01Loc2).HasColumnName("Text0_1_loc2");

                entity.Property(e => e.Text01Loc3).HasColumnName("Text0_1_loc3");

                entity.Property(e => e.Text01Loc4).HasColumnName("Text0_1_loc4");

                entity.Property(e => e.Text01Loc5).HasColumnName("Text0_1_loc5");

                entity.Property(e => e.Text01Loc6).HasColumnName("Text0_1_loc6");

                entity.Property(e => e.Text01Loc7).HasColumnName("Text0_1_loc7");

                entity.Property(e => e.Text01Loc8).HasColumnName("Text0_1_loc8");

                entity.Property(e => e.Text10Loc1).HasColumnName("Text1_0_loc1");

                entity.Property(e => e.Text10Loc2).HasColumnName("Text1_0_loc2");

                entity.Property(e => e.Text10Loc3).HasColumnName("Text1_0_loc3");

                entity.Property(e => e.Text10Loc4).HasColumnName("Text1_0_loc4");

                entity.Property(e => e.Text10Loc5).HasColumnName("Text1_0_loc5");

                entity.Property(e => e.Text10Loc6).HasColumnName("Text1_0_loc6");

                entity.Property(e => e.Text10Loc7).HasColumnName("Text1_0_loc7");

                entity.Property(e => e.Text10Loc8).HasColumnName("Text1_0_loc8");

                entity.Property(e => e.Text11Loc1).HasColumnName("Text1_1_loc1");

                entity.Property(e => e.Text11Loc2).HasColumnName("Text1_1_loc2");

                entity.Property(e => e.Text11Loc3).HasColumnName("Text1_1_loc3");

                entity.Property(e => e.Text11Loc4).HasColumnName("Text1_1_loc4");

                entity.Property(e => e.Text11Loc5).HasColumnName("Text1_1_loc5");

                entity.Property(e => e.Text11Loc6).HasColumnName("Text1_1_loc6");

                entity.Property(e => e.Text11Loc7).HasColumnName("Text1_1_loc7");

                entity.Property(e => e.Text11Loc8).HasColumnName("Text1_1_loc8");

                entity.Property(e => e.Text20Loc1).HasColumnName("Text2_0_loc1");

                entity.Property(e => e.Text20Loc2).HasColumnName("Text2_0_loc2");

                entity.Property(e => e.Text20Loc3).HasColumnName("Text2_0_loc3");

                entity.Property(e => e.Text20Loc4).HasColumnName("Text2_0_loc4");

                entity.Property(e => e.Text20Loc5).HasColumnName("Text2_0_loc5");

                entity.Property(e => e.Text20Loc6).HasColumnName("Text2_0_loc6");

                entity.Property(e => e.Text20Loc7).HasColumnName("Text2_0_loc7");

                entity.Property(e => e.Text20Loc8).HasColumnName("Text2_0_loc8");

                entity.Property(e => e.Text21Loc1).HasColumnName("Text2_1_loc1");

                entity.Property(e => e.Text21Loc2).HasColumnName("Text2_1_loc2");

                entity.Property(e => e.Text21Loc3).HasColumnName("Text2_1_loc3");

                entity.Property(e => e.Text21Loc4).HasColumnName("Text2_1_loc4");

                entity.Property(e => e.Text21Loc5).HasColumnName("Text2_1_loc5");

                entity.Property(e => e.Text21Loc6).HasColumnName("Text2_1_loc6");

                entity.Property(e => e.Text21Loc7).HasColumnName("Text2_1_loc7");

                entity.Property(e => e.Text21Loc8).HasColumnName("Text2_1_loc8");

                entity.Property(e => e.Text30Loc1).HasColumnName("Text3_0_loc1");

                entity.Property(e => e.Text30Loc2).HasColumnName("Text3_0_loc2");

                entity.Property(e => e.Text30Loc3).HasColumnName("Text3_0_loc3");

                entity.Property(e => e.Text30Loc4).HasColumnName("Text3_0_loc4");

                entity.Property(e => e.Text30Loc5).HasColumnName("Text3_0_loc5");

                entity.Property(e => e.Text30Loc6).HasColumnName("Text3_0_loc6");

                entity.Property(e => e.Text30Loc7).HasColumnName("Text3_0_loc7");

                entity.Property(e => e.Text30Loc8).HasColumnName("Text3_0_loc8");

                entity.Property(e => e.Text31Loc1).HasColumnName("Text3_1_loc1");

                entity.Property(e => e.Text31Loc2).HasColumnName("Text3_1_loc2");

                entity.Property(e => e.Text31Loc3).HasColumnName("Text3_1_loc3");

                entity.Property(e => e.Text31Loc4).HasColumnName("Text3_1_loc4");

                entity.Property(e => e.Text31Loc5).HasColumnName("Text3_1_loc5");

                entity.Property(e => e.Text31Loc6).HasColumnName("Text3_1_loc6");

                entity.Property(e => e.Text31Loc7).HasColumnName("Text3_1_loc7");

                entity.Property(e => e.Text31Loc8).HasColumnName("Text3_1_loc8");

                entity.Property(e => e.Text40Loc1).HasColumnName("Text4_0_loc1");

                entity.Property(e => e.Text40Loc2).HasColumnName("Text4_0_loc2");

                entity.Property(e => e.Text40Loc3).HasColumnName("Text4_0_loc3");

                entity.Property(e => e.Text40Loc4).HasColumnName("Text4_0_loc4");

                entity.Property(e => e.Text40Loc5).HasColumnName("Text4_0_loc5");

                entity.Property(e => e.Text40Loc6).HasColumnName("Text4_0_loc6");

                entity.Property(e => e.Text40Loc7).HasColumnName("Text4_0_loc7");

                entity.Property(e => e.Text40Loc8).HasColumnName("Text4_0_loc8");

                entity.Property(e => e.Text41Loc1).HasColumnName("Text4_1_loc1");

                entity.Property(e => e.Text41Loc2).HasColumnName("Text4_1_loc2");

                entity.Property(e => e.Text41Loc3).HasColumnName("Text4_1_loc3");

                entity.Property(e => e.Text41Loc4).HasColumnName("Text4_1_loc4");

                entity.Property(e => e.Text41Loc5).HasColumnName("Text4_1_loc5");

                entity.Property(e => e.Text41Loc6).HasColumnName("Text4_1_loc6");

                entity.Property(e => e.Text41Loc7).HasColumnName("Text4_1_loc7");

                entity.Property(e => e.Text41Loc8).HasColumnName("Text4_1_loc8");

                entity.Property(e => e.Text50Loc1).HasColumnName("Text5_0_loc1");

                entity.Property(e => e.Text50Loc2).HasColumnName("Text5_0_loc2");

                entity.Property(e => e.Text50Loc3).HasColumnName("Text5_0_loc3");

                entity.Property(e => e.Text50Loc4).HasColumnName("Text5_0_loc4");

                entity.Property(e => e.Text50Loc5).HasColumnName("Text5_0_loc5");

                entity.Property(e => e.Text50Loc6).HasColumnName("Text5_0_loc6");

                entity.Property(e => e.Text50Loc7).HasColumnName("Text5_0_loc7");

                entity.Property(e => e.Text50Loc8).HasColumnName("Text5_0_loc8");

                entity.Property(e => e.Text51Loc1).HasColumnName("Text5_1_loc1");

                entity.Property(e => e.Text51Loc2).HasColumnName("Text5_1_loc2");

                entity.Property(e => e.Text51Loc3).HasColumnName("Text5_1_loc3");

                entity.Property(e => e.Text51Loc4).HasColumnName("Text5_1_loc4");

                entity.Property(e => e.Text51Loc5).HasColumnName("Text5_1_loc5");

                entity.Property(e => e.Text51Loc6).HasColumnName("Text5_1_loc6");

                entity.Property(e => e.Text51Loc7).HasColumnName("Text5_1_loc7");

                entity.Property(e => e.Text51Loc8).HasColumnName("Text5_1_loc8");

                entity.Property(e => e.Text60Loc1).HasColumnName("Text6_0_loc1");

                entity.Property(e => e.Text60Loc2).HasColumnName("Text6_0_loc2");

                entity.Property(e => e.Text60Loc3).HasColumnName("Text6_0_loc3");

                entity.Property(e => e.Text60Loc4).HasColumnName("Text6_0_loc4");

                entity.Property(e => e.Text60Loc5).HasColumnName("Text6_0_loc5");

                entity.Property(e => e.Text60Loc6).HasColumnName("Text6_0_loc6");

                entity.Property(e => e.Text60Loc7).HasColumnName("Text6_0_loc7");

                entity.Property(e => e.Text60Loc8).HasColumnName("Text6_0_loc8");

                entity.Property(e => e.Text61Loc1).HasColumnName("Text6_1_loc1");

                entity.Property(e => e.Text61Loc2).HasColumnName("Text6_1_loc2");

                entity.Property(e => e.Text61Loc3).HasColumnName("Text6_1_loc3");

                entity.Property(e => e.Text61Loc4).HasColumnName("Text6_1_loc4");

                entity.Property(e => e.Text61Loc5).HasColumnName("Text6_1_loc5");

                entity.Property(e => e.Text61Loc6).HasColumnName("Text6_1_loc6");

                entity.Property(e => e.Text61Loc7).HasColumnName("Text6_1_loc7");

                entity.Property(e => e.Text61Loc8).HasColumnName("Text6_1_loc8");

                entity.Property(e => e.Text70Loc1).HasColumnName("Text7_0_loc1");

                entity.Property(e => e.Text70Loc2).HasColumnName("Text7_0_loc2");

                entity.Property(e => e.Text70Loc3).HasColumnName("Text7_0_loc3");

                entity.Property(e => e.Text70Loc4).HasColumnName("Text7_0_loc4");

                entity.Property(e => e.Text70Loc5).HasColumnName("Text7_0_loc5");

                entity.Property(e => e.Text70Loc6).HasColumnName("Text7_0_loc6");

                entity.Property(e => e.Text70Loc7).HasColumnName("Text7_0_loc7");

                entity.Property(e => e.Text70Loc8).HasColumnName("Text7_0_loc8");

                entity.Property(e => e.Text71Loc1).HasColumnName("Text7_1_loc1");

                entity.Property(e => e.Text71Loc2).HasColumnName("Text7_1_loc2");

                entity.Property(e => e.Text71Loc3).HasColumnName("Text7_1_loc3");

                entity.Property(e => e.Text71Loc4).HasColumnName("Text7_1_loc4");

                entity.Property(e => e.Text71Loc5).HasColumnName("Text7_1_loc5");

                entity.Property(e => e.Text71Loc6).HasColumnName("Text7_1_loc6");

                entity.Property(e => e.Text71Loc7).HasColumnName("Text7_1_loc7");

                entity.Property(e => e.Text71Loc8).HasColumnName("Text7_1_loc8");
            });

            modelBuilder.Entity<LocalesPageText>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("locales_page_text");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TextLoc1).HasColumnName("Text_loc1");

                entity.Property(e => e.TextLoc2).HasColumnName("Text_loc2");

                entity.Property(e => e.TextLoc3).HasColumnName("Text_loc3");

                entity.Property(e => e.TextLoc4).HasColumnName("Text_loc4");

                entity.Property(e => e.TextLoc5).HasColumnName("Text_loc5");

                entity.Property(e => e.TextLoc6).HasColumnName("Text_loc6");

                entity.Property(e => e.TextLoc7).HasColumnName("Text_loc7");

                entity.Property(e => e.TextLoc8).HasColumnName("Text_loc8");
            });

            modelBuilder.Entity<LocalesPointsOfInterest>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("locales_points_of_interest");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IconNameLoc1)
                    .HasColumnType("text")
                    .HasColumnName("icon_name_loc1");

                entity.Property(e => e.IconNameLoc2)
                    .HasColumnType("text")
                    .HasColumnName("icon_name_loc2");

                entity.Property(e => e.IconNameLoc3)
                    .HasColumnType("text")
                    .HasColumnName("icon_name_loc3");

                entity.Property(e => e.IconNameLoc4)
                    .HasColumnType("text")
                    .HasColumnName("icon_name_loc4");

                entity.Property(e => e.IconNameLoc5)
                    .HasColumnType("text")
                    .HasColumnName("icon_name_loc5");

                entity.Property(e => e.IconNameLoc6)
                    .HasColumnType("text")
                    .HasColumnName("icon_name_loc6");

                entity.Property(e => e.IconNameLoc7)
                    .HasColumnType("text")
                    .HasColumnName("icon_name_loc7");

                entity.Property(e => e.IconNameLoc8)
                    .HasColumnType("text")
                    .HasColumnName("icon_name_loc8");
            });

            modelBuilder.Entity<LocalesQuest>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("locales_quest");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DetailsLoc1)
                    .HasColumnType("text")
                    .HasColumnName("Details_loc1");

                entity.Property(e => e.DetailsLoc2)
                    .HasColumnType("text")
                    .HasColumnName("Details_loc2");

                entity.Property(e => e.DetailsLoc3)
                    .HasColumnType("text")
                    .HasColumnName("Details_loc3");

                entity.Property(e => e.DetailsLoc4)
                    .HasColumnType("text")
                    .HasColumnName("Details_loc4");

                entity.Property(e => e.DetailsLoc5)
                    .HasColumnType("text")
                    .HasColumnName("Details_loc5");

                entity.Property(e => e.DetailsLoc6)
                    .HasColumnType("text")
                    .HasColumnName("Details_loc6");

                entity.Property(e => e.DetailsLoc7)
                    .HasColumnType("text")
                    .HasColumnName("Details_loc7");

                entity.Property(e => e.DetailsLoc8)
                    .HasColumnType("text")
                    .HasColumnName("Details_loc8");

                entity.Property(e => e.EndTextLoc1)
                    .HasColumnType("text")
                    .HasColumnName("EndText_loc1");

                entity.Property(e => e.EndTextLoc2)
                    .HasColumnType("text")
                    .HasColumnName("EndText_loc2");

                entity.Property(e => e.EndTextLoc3)
                    .HasColumnType("text")
                    .HasColumnName("EndText_loc3");

                entity.Property(e => e.EndTextLoc4)
                    .HasColumnType("text")
                    .HasColumnName("EndText_loc4");

                entity.Property(e => e.EndTextLoc5)
                    .HasColumnType("text")
                    .HasColumnName("EndText_loc5");

                entity.Property(e => e.EndTextLoc6)
                    .HasColumnType("text")
                    .HasColumnName("EndText_loc6");

                entity.Property(e => e.EndTextLoc7)
                    .HasColumnType("text")
                    .HasColumnName("EndText_loc7");

                entity.Property(e => e.EndTextLoc8)
                    .HasColumnType("text")
                    .HasColumnName("EndText_loc8");

                entity.Property(e => e.ObjectiveText1Loc1)
                    .HasColumnType("text")
                    .HasColumnName("ObjectiveText1_loc1");

                entity.Property(e => e.ObjectiveText1Loc2)
                    .HasColumnType("text")
                    .HasColumnName("ObjectiveText1_loc2");

                entity.Property(e => e.ObjectiveText1Loc3)
                    .HasColumnType("text")
                    .HasColumnName("ObjectiveText1_loc3");

                entity.Property(e => e.ObjectiveText1Loc4)
                    .HasColumnType("text")
                    .HasColumnName("ObjectiveText1_loc4");

                entity.Property(e => e.ObjectiveText1Loc5)
                    .HasColumnType("text")
                    .HasColumnName("ObjectiveText1_loc5");

                entity.Property(e => e.ObjectiveText1Loc6)
                    .HasColumnType("text")
                    .HasColumnName("ObjectiveText1_loc6");

                entity.Property(e => e.ObjectiveText1Loc7)
                    .HasColumnType("text")
                    .HasColumnName("ObjectiveText1_loc7");

                entity.Property(e => e.ObjectiveText1Loc8)
                    .HasColumnType("text")
                    .HasColumnName("ObjectiveText1_loc8");

                entity.Property(e => e.ObjectiveText2Loc1)
                    .HasColumnType("text")
                    .HasColumnName("ObjectiveText2_loc1");

                entity.Property(e => e.ObjectiveText2Loc2)
                    .HasColumnType("text")
                    .HasColumnName("ObjectiveText2_loc2");

                entity.Property(e => e.ObjectiveText2Loc3)
                    .HasColumnType("text")
                    .HasColumnName("ObjectiveText2_loc3");

                entity.Property(e => e.ObjectiveText2Loc4)
                    .HasColumnType("text")
                    .HasColumnName("ObjectiveText2_loc4");

                entity.Property(e => e.ObjectiveText2Loc5)
                    .HasColumnType("text")
                    .HasColumnName("ObjectiveText2_loc5");

                entity.Property(e => e.ObjectiveText2Loc6)
                    .HasColumnType("text")
                    .HasColumnName("ObjectiveText2_loc6");

                entity.Property(e => e.ObjectiveText2Loc7)
                    .HasColumnType("text")
                    .HasColumnName("ObjectiveText2_loc7");

                entity.Property(e => e.ObjectiveText2Loc8)
                    .HasColumnType("text")
                    .HasColumnName("ObjectiveText2_loc8");

                entity.Property(e => e.ObjectiveText3Loc1)
                    .HasColumnType("text")
                    .HasColumnName("ObjectiveText3_loc1");

                entity.Property(e => e.ObjectiveText3Loc2)
                    .HasColumnType("text")
                    .HasColumnName("ObjectiveText3_loc2");

                entity.Property(e => e.ObjectiveText3Loc3)
                    .HasColumnType("text")
                    .HasColumnName("ObjectiveText3_loc3");

                entity.Property(e => e.ObjectiveText3Loc4)
                    .HasColumnType("text")
                    .HasColumnName("ObjectiveText3_loc4");

                entity.Property(e => e.ObjectiveText3Loc5)
                    .HasColumnType("text")
                    .HasColumnName("ObjectiveText3_loc5");

                entity.Property(e => e.ObjectiveText3Loc6)
                    .HasColumnType("text")
                    .HasColumnName("ObjectiveText3_loc6");

                entity.Property(e => e.ObjectiveText3Loc7)
                    .HasColumnType("text")
                    .HasColumnName("ObjectiveText3_loc7");

                entity.Property(e => e.ObjectiveText3Loc8)
                    .HasColumnType("text")
                    .HasColumnName("ObjectiveText3_loc8");

                entity.Property(e => e.ObjectiveText4Loc1)
                    .HasColumnType("text")
                    .HasColumnName("ObjectiveText4_loc1");

                entity.Property(e => e.ObjectiveText4Loc2)
                    .HasColumnType("text")
                    .HasColumnName("ObjectiveText4_loc2");

                entity.Property(e => e.ObjectiveText4Loc3)
                    .HasColumnType("text")
                    .HasColumnName("ObjectiveText4_loc3");

                entity.Property(e => e.ObjectiveText4Loc4)
                    .HasColumnType("text")
                    .HasColumnName("ObjectiveText4_loc4");

                entity.Property(e => e.ObjectiveText4Loc5)
                    .HasColumnType("text")
                    .HasColumnName("ObjectiveText4_loc5");

                entity.Property(e => e.ObjectiveText4Loc6)
                    .HasColumnType("text")
                    .HasColumnName("ObjectiveText4_loc6");

                entity.Property(e => e.ObjectiveText4Loc7)
                    .HasColumnType("text")
                    .HasColumnName("ObjectiveText4_loc7");

                entity.Property(e => e.ObjectiveText4Loc8)
                    .HasColumnType("text")
                    .HasColumnName("ObjectiveText4_loc8");

                entity.Property(e => e.ObjectivesLoc1)
                    .HasColumnType("text")
                    .HasColumnName("Objectives_loc1");

                entity.Property(e => e.ObjectivesLoc2)
                    .HasColumnType("text")
                    .HasColumnName("Objectives_loc2");

                entity.Property(e => e.ObjectivesLoc3)
                    .HasColumnType("text")
                    .HasColumnName("Objectives_loc3");

                entity.Property(e => e.ObjectivesLoc4)
                    .HasColumnType("text")
                    .HasColumnName("Objectives_loc4");

                entity.Property(e => e.ObjectivesLoc5)
                    .HasColumnType("text")
                    .HasColumnName("Objectives_loc5");

                entity.Property(e => e.ObjectivesLoc6)
                    .HasColumnType("text")
                    .HasColumnName("Objectives_loc6");

                entity.Property(e => e.ObjectivesLoc7)
                    .HasColumnType("text")
                    .HasColumnName("Objectives_loc7");

                entity.Property(e => e.ObjectivesLoc8)
                    .HasColumnType("text")
                    .HasColumnName("Objectives_loc8");

                entity.Property(e => e.OfferRewardTextLoc1)
                    .HasColumnType("text")
                    .HasColumnName("OfferRewardText_loc1");

                entity.Property(e => e.OfferRewardTextLoc2)
                    .HasColumnType("text")
                    .HasColumnName("OfferRewardText_loc2");

                entity.Property(e => e.OfferRewardTextLoc3)
                    .HasColumnType("text")
                    .HasColumnName("OfferRewardText_loc3");

                entity.Property(e => e.OfferRewardTextLoc4)
                    .HasColumnType("text")
                    .HasColumnName("OfferRewardText_loc4");

                entity.Property(e => e.OfferRewardTextLoc5)
                    .HasColumnType("text")
                    .HasColumnName("OfferRewardText_loc5");

                entity.Property(e => e.OfferRewardTextLoc6)
                    .HasColumnType("text")
                    .HasColumnName("OfferRewardText_loc6");

                entity.Property(e => e.OfferRewardTextLoc7)
                    .HasColumnType("text")
                    .HasColumnName("OfferRewardText_loc7");

                entity.Property(e => e.OfferRewardTextLoc8)
                    .HasColumnType("text")
                    .HasColumnName("OfferRewardText_loc8");

                entity.Property(e => e.RequestItemsTextLoc1)
                    .HasColumnType("text")
                    .HasColumnName("RequestItemsText_loc1");

                entity.Property(e => e.RequestItemsTextLoc2)
                    .HasColumnType("text")
                    .HasColumnName("RequestItemsText_loc2");

                entity.Property(e => e.RequestItemsTextLoc3)
                    .HasColumnType("text")
                    .HasColumnName("RequestItemsText_loc3");

                entity.Property(e => e.RequestItemsTextLoc4)
                    .HasColumnType("text")
                    .HasColumnName("RequestItemsText_loc4");

                entity.Property(e => e.RequestItemsTextLoc5)
                    .HasColumnType("text")
                    .HasColumnName("RequestItemsText_loc5");

                entity.Property(e => e.RequestItemsTextLoc6)
                    .HasColumnType("text")
                    .HasColumnName("RequestItemsText_loc6");

                entity.Property(e => e.RequestItemsTextLoc7)
                    .HasColumnType("text")
                    .HasColumnName("RequestItemsText_loc7");

                entity.Property(e => e.RequestItemsTextLoc8)
                    .HasColumnType("text")
                    .HasColumnName("RequestItemsText_loc8");

                entity.Property(e => e.TitleLoc1)
                    .HasColumnType("text")
                    .HasColumnName("Title_loc1");

                entity.Property(e => e.TitleLoc2)
                    .HasColumnType("text")
                    .HasColumnName("Title_loc2");

                entity.Property(e => e.TitleLoc3)
                    .HasColumnType("text")
                    .HasColumnName("Title_loc3");

                entity.Property(e => e.TitleLoc4)
                    .HasColumnType("text")
                    .HasColumnName("Title_loc4");

                entity.Property(e => e.TitleLoc5)
                    .HasColumnType("text")
                    .HasColumnName("Title_loc5");

                entity.Property(e => e.TitleLoc6)
                    .HasColumnType("text")
                    .HasColumnName("Title_loc6");

                entity.Property(e => e.TitleLoc7)
                    .HasColumnType("text")
                    .HasColumnName("Title_loc7");

                entity.Property(e => e.TitleLoc8)
                    .HasColumnType("text")
                    .HasColumnName("Title_loc8");
            });

            modelBuilder.Entity<LocalesQuestgiverGreeting>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.Type })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("locales_questgiver_greeting");

                entity.HasComment("Quest and Gossip system")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("int(11) unsigned")
                    .HasComment("Entry of Questgiver");

                entity.Property(e => e.Type)
                    .HasColumnType("int(11) unsigned")
                    .HasComment("Type of entry");

                entity.Property(e => e.TextLoc1)
                    .HasColumnName("Text_loc1")
                    .HasComment("Text of the greeting locale 1");

                entity.Property(e => e.TextLoc2)
                    .HasColumnName("Text_loc2")
                    .HasComment("Text of the greeting locale 2");

                entity.Property(e => e.TextLoc3)
                    .HasColumnName("Text_loc3")
                    .HasComment("Text of the greeting locale 3");

                entity.Property(e => e.TextLoc4)
                    .HasColumnName("Text_loc4")
                    .HasComment("Text of the greeting locale 4");

                entity.Property(e => e.TextLoc5)
                    .HasColumnName("Text_loc5")
                    .HasComment("Text of the greeting locale 5");

                entity.Property(e => e.TextLoc6)
                    .HasColumnName("Text_loc6")
                    .HasComment("Text of the greeting locale 6");

                entity.Property(e => e.TextLoc7)
                    .HasColumnName("Text_loc7")
                    .HasComment("Text of the greeting locale 7");

                entity.Property(e => e.TextLoc8)
                    .HasColumnName("Text_loc8")
                    .HasComment("Text of the greeting locale 8");
            });

            modelBuilder.Entity<LocalesTrainerGreeting>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("locales_trainer_greeting");

                entity.HasComment("Trainer system")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("int(11) unsigned")
                    .ValueGeneratedNever()
                    .HasComment("Entry of Trainer");

                entity.Property(e => e.TextLoc1)
                    .HasColumnName("Text_loc1")
                    .HasComment("Text of the greeting locale 1");

                entity.Property(e => e.TextLoc2)
                    .HasColumnName("Text_loc2")
                    .HasComment("Text of the greeting locale 2");

                entity.Property(e => e.TextLoc3)
                    .HasColumnName("Text_loc3")
                    .HasComment("Text of the greeting locale 3");

                entity.Property(e => e.TextLoc4)
                    .HasColumnName("Text_loc4")
                    .HasComment("Text of the greeting locale 4");

                entity.Property(e => e.TextLoc5)
                    .HasColumnName("Text_loc5")
                    .HasComment("Text of the greeting locale 5");

                entity.Property(e => e.TextLoc6)
                    .HasColumnName("Text_loc6")
                    .HasComment("Text of the greeting locale 6");

                entity.Property(e => e.TextLoc7)
                    .HasColumnName("Text_loc7")
                    .HasComment("Text of the greeting locale 7");

                entity.Property(e => e.TextLoc8)
                    .HasColumnName("Text_loc8")
                    .HasComment("Text of the greeting locale 8");
            });

            modelBuilder.Entity<MailLevelReward>(entity =>
            {
                entity.HasKey(e => new { e.Level, e.RaceMask })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("mail_level_reward");

                entity.HasComment("Mail System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Level)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("level")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RaceMask)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("raceMask")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MailTemplateId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("mailTemplateId")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SenderEntry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("senderEntry")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<MailLootTemplate>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.Item })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("mail_loot_template");

                entity.HasComment("Loot System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Item)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("item")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ChanceOrQuestChance).HasDefaultValueSql("'100'");

                entity.Property(e => e.Comments)
                    .HasMaxLength(300)
                    .HasColumnName("comments")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ConditionId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("condition_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Groupid)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("groupid");

                entity.Property(e => e.Maxcount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("maxcount")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MincountOrRef)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("mincountOrRef")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<MangosString>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("mangos_string");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ContentDefault)
                    .HasColumnType("text")
                    .HasColumnName("content_default");

                entity.Property(e => e.ContentLoc1)
                    .HasColumnType("text")
                    .HasColumnName("content_loc1");

                entity.Property(e => e.ContentLoc2)
                    .HasColumnType("text")
                    .HasColumnName("content_loc2");

                entity.Property(e => e.ContentLoc3)
                    .HasColumnType("text")
                    .HasColumnName("content_loc3");

                entity.Property(e => e.ContentLoc4)
                    .HasColumnType("text")
                    .HasColumnName("content_loc4");

                entity.Property(e => e.ContentLoc5)
                    .HasColumnType("text")
                    .HasColumnName("content_loc5");

                entity.Property(e => e.ContentLoc6)
                    .HasColumnType("text")
                    .HasColumnName("content_loc6");

                entity.Property(e => e.ContentLoc7)
                    .HasColumnType("text")
                    .HasColumnName("content_loc7");

                entity.Property(e => e.ContentLoc8)
                    .HasColumnType("text")
                    .HasColumnName("content_loc8");
            });

            modelBuilder.Entity<NpcGossip>(entity =>
            {
                entity.HasKey(e => e.NpcGuid)
                    .HasName("PRIMARY");

                entity.ToTable("npc_gossip");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.NpcGuid)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("npc_guid");

                entity.Property(e => e.Textid)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("textid")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<NpcText>(entity =>
            {
                entity.ToTable("npc_text");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("ID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Em00)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em0_0");

                entity.Property(e => e.Em01)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em0_1");

                entity.Property(e => e.Em02)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em0_2");

                entity.Property(e => e.Em03)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em0_3");

                entity.Property(e => e.Em04)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em0_4");

                entity.Property(e => e.Em05)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em0_5");

                entity.Property(e => e.Em10)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em1_0");

                entity.Property(e => e.Em11)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em1_1");

                entity.Property(e => e.Em12)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em1_2");

                entity.Property(e => e.Em13)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em1_3");

                entity.Property(e => e.Em14)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em1_4");

                entity.Property(e => e.Em15)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em1_5");

                entity.Property(e => e.Em20)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em2_0");

                entity.Property(e => e.Em21)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em2_1");

                entity.Property(e => e.Em22)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em2_2");

                entity.Property(e => e.Em23)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em2_3");

                entity.Property(e => e.Em24)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em2_4");

                entity.Property(e => e.Em25)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em2_5");

                entity.Property(e => e.Em30)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em3_0");

                entity.Property(e => e.Em31)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em3_1");

                entity.Property(e => e.Em32)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em3_2");

                entity.Property(e => e.Em33)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em3_3");

                entity.Property(e => e.Em34)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em3_4");

                entity.Property(e => e.Em35)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em3_5");

                entity.Property(e => e.Em40)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em4_0");

                entity.Property(e => e.Em41)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em4_1");

                entity.Property(e => e.Em42)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em4_2");

                entity.Property(e => e.Em43)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em4_3");

                entity.Property(e => e.Em44)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em4_4");

                entity.Property(e => e.Em45)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em4_5");

                entity.Property(e => e.Em50)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em5_0");

                entity.Property(e => e.Em51)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em5_1");

                entity.Property(e => e.Em52)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em5_2");

                entity.Property(e => e.Em53)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em5_3");

                entity.Property(e => e.Em54)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em5_4");

                entity.Property(e => e.Em55)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em5_5");

                entity.Property(e => e.Em60)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em6_0");

                entity.Property(e => e.Em61)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em6_1");

                entity.Property(e => e.Em62)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em6_2");

                entity.Property(e => e.Em63)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em6_3");

                entity.Property(e => e.Em64)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em6_4");

                entity.Property(e => e.Em65)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em6_5");

                entity.Property(e => e.Em70)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em7_0");

                entity.Property(e => e.Em71)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em7_1");

                entity.Property(e => e.Em72)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em7_2");

                entity.Property(e => e.Em73)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em7_3");

                entity.Property(e => e.Em74)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em7_4");

                entity.Property(e => e.Em75)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em7_5");

                entity.Property(e => e.Lang0)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("lang0");

                entity.Property(e => e.Lang1)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("lang1");

                entity.Property(e => e.Lang2)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("lang2");

                entity.Property(e => e.Lang3)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("lang3");

                entity.Property(e => e.Lang4)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("lang4");

                entity.Property(e => e.Lang5)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("lang5");

                entity.Property(e => e.Lang6)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("lang6");

                entity.Property(e => e.Lang7)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("lang7");

                entity.Property(e => e.Prob0).HasColumnName("prob0");

                entity.Property(e => e.Prob1).HasColumnName("prob1");

                entity.Property(e => e.Prob2).HasColumnName("prob2");

                entity.Property(e => e.Prob3).HasColumnName("prob3");

                entity.Property(e => e.Prob4).HasColumnName("prob4");

                entity.Property(e => e.Prob5).HasColumnName("prob5");

                entity.Property(e => e.Prob6).HasColumnName("prob6");

                entity.Property(e => e.Prob7).HasColumnName("prob7");

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

            modelBuilder.Entity<NpcTextBroadcastText>(entity =>
            {
                entity.ToTable("npc_text_broadcast_text");

                entity.HasComment("Broadcast Text npc_text equivalent")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .ValueGeneratedNever()
                    .HasComment("Identifier");

                entity.Property(e => e.BroadcastTextId0).HasColumnType("int(11)");

                entity.Property(e => e.BroadcastTextId1).HasColumnType("int(11)");

                entity.Property(e => e.BroadcastTextId2).HasColumnType("int(11)");

                entity.Property(e => e.BroadcastTextId3).HasColumnType("int(11)");

                entity.Property(e => e.BroadcastTextId4).HasColumnType("int(11)");

                entity.Property(e => e.BroadcastTextId5).HasColumnType("int(11)");

                entity.Property(e => e.BroadcastTextId6).HasColumnType("int(11)");

                entity.Property(e => e.BroadcastTextId7).HasColumnType("int(11)");
            });

            modelBuilder.Entity<NpcTrainer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("npc_trainer");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasIndex(e => new { e.Entry, e.Spell }, "entry_spell")
                    .IsUnique();

                entity.Property(e => e.ConditionId)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("condition_id");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Reqlevel)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("reqlevel");

                entity.Property(e => e.Reqskill)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("reqskill");

                entity.Property(e => e.Reqskillvalue)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("reqskillvalue");

                entity.Property(e => e.Spell)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("spell")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Spellcost)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("spellcost");
            });

            modelBuilder.Entity<NpcTrainerTemplate>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("npc_trainer_template");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasIndex(e => new { e.Entry, e.Spell }, "entry_spell")
                    .IsUnique();

                entity.Property(e => e.ConditionId)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("condition_id");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Reqlevel)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("reqlevel");

                entity.Property(e => e.Reqskill)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("reqskill");

                entity.Property(e => e.Reqskillvalue)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("reqskillvalue");

                entity.Property(e => e.Spell)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("spell")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Spellcost)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("spellcost");
            });

            modelBuilder.Entity<NpcVendor>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.Item })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("npc_vendor");

                entity.HasComment("Npc System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Item)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("item")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ConditionId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("condition_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ExtendedCost)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Incrtime)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incrtime");

                entity.Property(e => e.Maxcount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("maxcount");

                entity.Property(e => e.Slot)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("slot");
            });

            modelBuilder.Entity<NpcVendorTemplate>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.Item })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("npc_vendor_template");

                entity.HasComment("Npc System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Item)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("item")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ConditionId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("condition_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ExtendedCost)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Incrtime)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incrtime");

                entity.Property(e => e.Maxcount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("maxcount");

                entity.Property(e => e.Slot)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("slot");
            });

            modelBuilder.Entity<PageText>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("page_text");

                entity.HasComment("Item System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.NextPage)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("next_page")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Text).HasColumnName("text");
            });

            modelBuilder.Entity<PetLevelstat>(entity =>
            {
                entity.HasKey(e => new { e.CreatureEntry, e.Level })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("pet_levelstats");

                entity.HasComment("Stores pet levels stats.")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.CreatureEntry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("creature_entry");

                entity.Property(e => e.Level)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("level");

                entity.Property(e => e.Agi)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("agi");

                entity.Property(e => e.Armor)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("armor");

                entity.Property(e => e.Hp)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("hp");

                entity.Property(e => e.Inte)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("inte");

                entity.Property(e => e.Mana)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("mana");

                entity.Property(e => e.Spi)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("spi");

                entity.Property(e => e.Sta)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("sta");

                entity.Property(e => e.Str)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("str");
            });

            modelBuilder.Entity<PetNameGeneration>(entity =>
            {
                entity.ToTable("pet_name_generation");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Half)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("half");

                entity.Property(e => e.Word)
                    .HasColumnType("tinytext")
                    .HasColumnName("word");
            });

            modelBuilder.Entity<PetcreateinfoSpell>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("petcreateinfo_spell");

                entity.HasComment("Pet Create Spells")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Spell1)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Spell2)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Spell3)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Spell4)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PickpocketingLootTemplate>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.Item })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("pickpocketing_loot_template");

                entity.HasComment("Loot System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Item)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("item")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ChanceOrQuestChance).HasDefaultValueSql("'100'");

                entity.Property(e => e.Comments)
                    .HasMaxLength(300)
                    .HasColumnName("comments")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ConditionId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("condition_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Groupid)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("groupid");

                entity.Property(e => e.Maxcount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("maxcount")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MincountOrRef)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("mincountOrRef")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<PlayerClasslevelstat>(entity =>
            {
                entity.HasKey(e => new { e.Class, e.Level })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("player_classlevelstats");

                entity.HasComment("Stores levels stats.")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Class)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("class");

                entity.Property(e => e.Level)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("level");

                entity.Property(e => e.Basehp)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("basehp");

                entity.Property(e => e.Basemana)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("basemana");
            });

            modelBuilder.Entity<PlayerLevelstat>(entity =>
            {
                entity.HasKey(e => new { e.Race, e.Class, e.Level })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("player_levelstats");

                entity.HasComment("Stores levels stats.")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Race)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("race");

                entity.Property(e => e.Class)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("class");

                entity.Property(e => e.Level)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("level");

                entity.Property(e => e.Agi)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("agi");

                entity.Property(e => e.Inte)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("inte");

                entity.Property(e => e.Spi)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("spi");

                entity.Property(e => e.Sta)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("sta");

                entity.Property(e => e.Str)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("str");
            });

            modelBuilder.Entity<PlayerXpForLevel>(entity =>
            {
                entity.HasKey(e => e.Lvl)
                    .HasName("PRIMARY");

                entity.ToTable("player_xp_for_level");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Lvl)
                    .HasColumnType("int(3) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("lvl");

                entity.Property(e => e.XpForNextLevel)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("xp_for_next_level");
            });

            modelBuilder.Entity<Playercreateinfo>(entity =>
            {
                entity.HasKey(e => new { e.Race, e.Class })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("playercreateinfo");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Race)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("race");

                entity.Property(e => e.Class)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("class");

                entity.Property(e => e.Map)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("map");

                entity.Property(e => e.Orientation).HasColumnName("orientation");

                entity.Property(e => e.PositionX).HasColumnName("position_x");

                entity.Property(e => e.PositionY).HasColumnName("position_y");

                entity.Property(e => e.PositionZ).HasColumnName("position_z");

                entity.Property(e => e.Zone)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("zone")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PlayercreateinfoAction>(entity =>
            {
                entity.HasKey(e => new { e.Race, e.Class, e.Button })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("playercreateinfo_action");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Race)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("race");

                entity.Property(e => e.Class)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("class");

                entity.Property(e => e.Button)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("button");

                entity.Property(e => e.Action)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("action");

                entity.Property(e => e.Type)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("type");
            });

            modelBuilder.Entity<PlayercreateinfoItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("playercreateinfo_item");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasIndex(e => new { e.Race, e.Class }, "playercreateinfo_race_class_index");

                entity.Property(e => e.Amount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("amount")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Class)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("class");

                entity.Property(e => e.Itemid)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("itemid")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Race)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("race");
            });

            modelBuilder.Entity<PlayercreateinfoSkill>(entity =>
            {
                entity.HasKey(e => new { e.RaceMask, e.ClassMask, e.Skill })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("playercreateinfo_skills");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.RaceMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("raceMask");

                entity.Property(e => e.ClassMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("classMask");

                entity.Property(e => e.Skill)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("skill");

                entity.Property(e => e.Note)
                    .HasMaxLength(255)
                    .HasColumnName("note");

                entity.Property(e => e.Step)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("step");
            });

            modelBuilder.Entity<PlayercreateinfoSpell>(entity =>
            {
                entity.HasKey(e => new { e.Race, e.Class, e.Spell })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("playercreateinfo_spell");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Race)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("race");

                entity.Property(e => e.Class)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("class");

                entity.Property(e => e.Spell)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Note).HasMaxLength(255);
            });

            modelBuilder.Entity<PointsOfInterest>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("points_of_interest");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Data)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("data")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Flags)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("flags")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Icon)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("icon")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IconName)
                    .HasColumnType("text")
                    .HasColumnName("icon_name");

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.Y).HasColumnName("y");
            });

            modelBuilder.Entity<PoolCreature>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PRIMARY");

                entity.ToTable("pool_creature");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasIndex(e => e.PoolEntry, "pool_idx");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("guid");

                entity.Property(e => e.Chance)
                    .HasColumnType("float unsigned")
                    .HasColumnName("chance");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.PoolEntry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("pool_entry")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PoolCreatureTemplate>(entity =>
            {
                entity.ToTable("pool_creature_template");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasIndex(e => e.PoolEntry, "pool_idx");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Chance)
                    .HasColumnType("float unsigned")
                    .HasColumnName("chance");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.PoolEntry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("pool_entry")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PoolGameobject>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PRIMARY");

                entity.ToTable("pool_gameobject");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasIndex(e => e.PoolEntry, "pool_idx");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("guid");

                entity.Property(e => e.Chance)
                    .HasColumnType("float unsigned")
                    .HasColumnName("chance");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.PoolEntry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("pool_entry")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PoolGameobjectTemplate>(entity =>
            {
                entity.ToTable("pool_gameobject_template");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasIndex(e => e.PoolEntry, "pool_idx");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Chance)
                    .HasColumnType("float unsigned")
                    .HasColumnName("chance");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.PoolEntry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("pool_entry")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PoolPool>(entity =>
            {
                entity.HasKey(e => e.PoolId)
                    .HasName("PRIMARY");

                entity.ToTable("pool_pool");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasIndex(e => e.MotherPool, "pool_idx");

                entity.Property(e => e.PoolId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("pool_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Chance).HasColumnName("chance");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.MotherPool)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("mother_pool")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PoolTemplate>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("pool_template");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Pool entry");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.MaxLimit)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("max_limit")
                    .HasComment("Max number of objects (0) is no limit");
            });

            modelBuilder.Entity<ProspectingLootTemplate>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.Item })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("prospecting_loot_template");

                entity.HasComment("Loot System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Item)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("item")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ChanceOrQuestChance).HasDefaultValueSql("'100'");

                entity.Property(e => e.Comments)
                    .HasMaxLength(300)
                    .HasColumnName("comments")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ConditionId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("condition_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Groupid)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("groupid");

                entity.Property(e => e.Maxcount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("maxcount")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MincountOrRef)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("mincountOrRef")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<QuestTemplate>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("quest_template");

                entity.HasComment("Quest System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.BreadcrumbForQuestId)
                    .HasColumnType("mediumint(9) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CharTitleId).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.CompleteEmote).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.CompleteScript)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Details).HasColumnType("text");

                entity.Property(e => e.DetailsEmote1).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.DetailsEmote2).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.DetailsEmote3).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.DetailsEmote4).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.DetailsEmoteDelay1).HasColumnType("int(11) unsigned");

                entity.Property(e => e.DetailsEmoteDelay2).HasColumnType("int(11) unsigned");

                entity.Property(e => e.DetailsEmoteDelay3).HasColumnType("int(11) unsigned");

                entity.Property(e => e.DetailsEmoteDelay4).HasColumnType("int(11) unsigned");

                entity.Property(e => e.EndText).HasColumnType("text");

                entity.Property(e => e.ExclusiveGroup)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IncompleteEmote).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.LimitTime).HasColumnType("int(10) unsigned");

                entity.Property(e => e.MaxLevel)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'255'");

                entity.Property(e => e.Method)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'2'");

                entity.Property(e => e.MinLevel).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.NextQuestId)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.NextQuestInChain)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ObjectiveText1).HasColumnType("text");

                entity.Property(e => e.ObjectiveText2).HasColumnType("text");

                entity.Property(e => e.ObjectiveText3).HasColumnType("text");

                entity.Property(e => e.ObjectiveText4).HasColumnType("text");

                entity.Property(e => e.Objectives).HasColumnType("text");

                entity.Property(e => e.OfferRewardEmote1).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.OfferRewardEmote2).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.OfferRewardEmote3).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.OfferRewardEmote4).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.OfferRewardEmoteDelay1).HasColumnType("int(11) unsigned");

                entity.Property(e => e.OfferRewardEmoteDelay2).HasColumnType("int(11) unsigned");

                entity.Property(e => e.OfferRewardEmoteDelay3).HasColumnType("int(11) unsigned");

                entity.Property(e => e.OfferRewardEmoteDelay4).HasColumnType("int(11) unsigned");

                entity.Property(e => e.OfferRewardText).HasColumnType("text");

                entity.Property(e => e.PointMapId).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.PointOpt)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PrevQuestId)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.QuestFlags).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.QuestLevel).HasColumnType("smallint(6)");

                entity.Property(e => e.RepObjectiveFaction).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RepObjectiveValue)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ReqCreatureOrGocount1)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("ReqCreatureOrGOCount1");

                entity.Property(e => e.ReqCreatureOrGocount2)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("ReqCreatureOrGOCount2");

                entity.Property(e => e.ReqCreatureOrGocount3)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("ReqCreatureOrGOCount3");

                entity.Property(e => e.ReqCreatureOrGocount4)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("ReqCreatureOrGOCount4");

                entity.Property(e => e.ReqCreatureOrGoid1)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("ReqCreatureOrGOId1")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ReqCreatureOrGoid2)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("ReqCreatureOrGOId2")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ReqCreatureOrGoid3)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("ReqCreatureOrGOId3")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ReqCreatureOrGoid4)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("ReqCreatureOrGOId4")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ReqItemCount1).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.ReqItemCount2).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.ReqItemCount3).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.ReqItemCount4).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.ReqItemId1)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ReqItemId2)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ReqItemId3)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ReqItemId4)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ReqSourceCount1).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.ReqSourceCount2).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.ReqSourceCount3).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.ReqSourceCount4).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.ReqSourceId1)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ReqSourceId2)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ReqSourceId3)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ReqSourceId4)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ReqSpellCast1)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ReqSpellCast2)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ReqSpellCast3)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ReqSpellCast4)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RequestItemsText).HasColumnType("text");

                entity.Property(e => e.RequiredClasses).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RequiredCondition).HasColumnType("int(11) unsigned");

                entity.Property(e => e.RequiredMaxRepFaction).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RequiredMaxRepValue)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RequiredMinRepFaction).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RequiredMinRepValue)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RequiredRaces).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RequiredSkill).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RequiredSkillValue).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RewChoiceItemCount1).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RewChoiceItemCount2).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RewChoiceItemCount3).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RewChoiceItemCount4).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RewChoiceItemCount5).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RewChoiceItemCount6).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RewChoiceItemId1)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RewChoiceItemId2)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RewChoiceItemId3)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RewChoiceItemId4)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RewChoiceItemId5)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RewChoiceItemId6)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RewHonorableKills).HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewItemCount1).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RewItemCount2).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RewItemCount3).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RewItemCount4).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RewItemId1)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RewItemId2)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RewItemId3)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RewItemId4)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RewMailDelaySecs).HasColumnType("int(11) unsigned");

                entity.Property(e => e.RewMailTemplateId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RewMaxRepValue1)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'42999'");

                entity.Property(e => e.RewMaxRepValue2)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'42999'");

                entity.Property(e => e.RewMaxRepValue3)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'42999'");

                entity.Property(e => e.RewMaxRepValue4)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'42999'");

                entity.Property(e => e.RewMaxRepValue5)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'42999'");

                entity.Property(e => e.RewMoneyMaxLevel).HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewOrReqMoney).HasColumnType("int(11)");

                entity.Property(e => e.RewRepFaction1)
                    .HasColumnType("smallint(5) unsigned")
                    .HasComment("faction id from Faction.dbc in this case");

                entity.Property(e => e.RewRepFaction2)
                    .HasColumnType("smallint(5) unsigned")
                    .HasComment("faction id from Faction.dbc in this case");

                entity.Property(e => e.RewRepFaction3)
                    .HasColumnType("smallint(5) unsigned")
                    .HasComment("faction id from Faction.dbc in this case");

                entity.Property(e => e.RewRepFaction4)
                    .HasColumnType("smallint(5) unsigned")
                    .HasComment("faction id from Faction.dbc in this case");

                entity.Property(e => e.RewRepFaction5)
                    .HasColumnType("smallint(5) unsigned")
                    .HasComment("faction id from Faction.dbc in this case");

                entity.Property(e => e.RewRepValue1)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RewRepValue2)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RewRepValue3)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RewRepValue4)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RewRepValue5)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RewSpell)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RewSpellCast)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SpecialFlags).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.SrcItemCount).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.SrcItemId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SrcSpell)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.StartScript)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SuggestedPlayers).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Title).HasColumnType("text");

                entity.Property(e => e.Type).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.ZoneOrSort).HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<QuestgiverGreeting>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.Type })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("questgiver_greeting");

                entity.HasComment("Quest and Gossip system")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("int(11) unsigned")
                    .HasComment("Entry of Questgiver");

                entity.Property(e => e.Type)
                    .HasColumnType("int(11) unsigned")
                    .HasComment("Type of entry");

                entity.Property(e => e.EmoteDelay)
                    .HasColumnType("int(11) unsigned")
                    .HasComment("Emote delay of the greeting");

                entity.Property(e => e.EmoteId)
                    .HasColumnType("int(11) unsigned")
                    .HasComment("Emote ID of greeting");

                entity.Property(e => e.Text).HasComment("Text of the greeting");
            });

            modelBuilder.Entity<ReferenceLootTemplate>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.Item })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("reference_loot_template");

                entity.HasComment("Loot System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Item)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("item")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ChanceOrQuestChance).HasDefaultValueSql("'100'");

                entity.Property(e => e.Comments)
                    .HasMaxLength(300)
                    .HasColumnName("comments")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ConditionId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("condition_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Groupid)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("groupid");

                entity.Property(e => e.Maxcount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("maxcount")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MincountOrRef)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("mincountOrRef")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<ReputationRewardRate>(entity =>
            {
                entity.HasKey(e => e.Faction)
                    .HasName("PRIMARY");

                entity.ToTable("reputation_reward_rate");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Faction)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("faction")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CreatureRate)
                    .HasColumnName("creature_rate")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.QuestRate)
                    .HasColumnName("quest_rate")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SpellRate)
                    .HasColumnName("spell_rate")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<ReputationSpilloverTemplate>(entity =>
            {
                entity.HasKey(e => e.Faction)
                    .HasName("PRIMARY");

                entity.ToTable("reputation_spillover_template");

                entity.HasComment("Reputation spillover reputation gain")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Faction)
                    .HasColumnType("smallint(6) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("faction")
                    .HasComment("faction entry");

                entity.Property(e => e.Faction1)
                    .HasColumnType("smallint(6) unsigned")
                    .HasColumnName("faction1")
                    .HasComment("faction to give spillover for");

                entity.Property(e => e.Faction2)
                    .HasColumnType("smallint(6) unsigned")
                    .HasColumnName("faction2");

                entity.Property(e => e.Faction3)
                    .HasColumnType("smallint(6) unsigned")
                    .HasColumnName("faction3");

                entity.Property(e => e.Faction4)
                    .HasColumnType("smallint(6) unsigned")
                    .HasColumnName("faction4");

                entity.Property(e => e.Rank1)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("rank_1")
                    .HasComment("max rank, above this will not give any spillover");

                entity.Property(e => e.Rank2)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("rank_2");

                entity.Property(e => e.Rank3)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("rank_3");

                entity.Property(e => e.Rank4)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("rank_4");

                entity.Property(e => e.Rate1)
                    .HasColumnName("rate_1")
                    .HasComment("the given rep points * rate");

                entity.Property(e => e.Rate2).HasColumnName("rate_2");

                entity.Property(e => e.Rate3).HasColumnName("rate_3");

                entity.Property(e => e.Rate4).HasColumnName("rate_4");
            });

            modelBuilder.Entity<ReservedName>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("PRIMARY");

                entity.ToTable("reserved_name");

                entity.HasComment("Player Reserved Names")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Name)
                    .HasMaxLength(12)
                    .HasColumnName("name")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ScriptText>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("script_texts");

                entity.HasComment("Script Texts")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8)")
                    .ValueGeneratedNever()
                    .HasColumnName("entry");

                entity.Property(e => e.BroadcastTextId)
                    .HasColumnType("int(11)")
                    .HasColumnName("broadcast_text_id");

                entity.Property(e => e.Comment)
                    .HasColumnType("text")
                    .HasColumnName("comment");

                entity.Property(e => e.ContentDefault)
                    .HasColumnType("text")
                    .HasColumnName("content_default");

                entity.Property(e => e.ContentLoc1)
                    .HasColumnType("text")
                    .HasColumnName("content_loc1");

                entity.Property(e => e.ContentLoc2)
                    .HasColumnType("text")
                    .HasColumnName("content_loc2");

                entity.Property(e => e.ContentLoc3)
                    .HasColumnType("text")
                    .HasColumnName("content_loc3");

                entity.Property(e => e.ContentLoc4)
                    .HasColumnType("text")
                    .HasColumnName("content_loc4");

                entity.Property(e => e.ContentLoc5)
                    .HasColumnType("text")
                    .HasColumnName("content_loc5");

                entity.Property(e => e.ContentLoc6)
                    .HasColumnType("text")
                    .HasColumnName("content_loc6");

                entity.Property(e => e.ContentLoc7)
                    .HasColumnType("text")
                    .HasColumnName("content_loc7");

                entity.Property(e => e.ContentLoc8)
                    .HasColumnType("text")
                    .HasColumnName("content_loc8");

                entity.Property(e => e.Emote)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("emote");

                entity.Property(e => e.Language)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("language");

                entity.Property(e => e.Sound)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("sound")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("type");
            });

            modelBuilder.Entity<ScriptWaypoint>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.PathId, e.Point })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("script_waypoint");

                entity.HasComment("Script Creature waypoints")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'")
                    .HasComment("creature_template entry");

                entity.Property(e => e.PathId).HasColumnType("int(11) unsigned");

                entity.Property(e => e.Point)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Comment).HasColumnType("text");

                entity.Property(e => e.ScriptId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.WaitTime)
                    .HasColumnType("int(10) unsigned")
                    .HasComment("waittime in millisecs");
            });

            modelBuilder.Entity<ScriptedAreatrigger>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("scripted_areatrigger");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8)")
                    .ValueGeneratedNever()
                    .HasColumnName("entry");

                entity.Property(e => e.ScriptName)
                    .HasMaxLength(64)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ScriptedEventId>(entity =>
            {
                entity.ToTable("scripted_event_id");

                entity.HasComment("Script library scripted events")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8)")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.ScriptName)
                    .HasMaxLength(64)
                    .IsFixedLength();
            });

            modelBuilder.Entity<SkillDiscoveryTemplate>(entity =>
            {
                entity.HasKey(e => e.SpellId)
                    .HasName("PRIMARY");

                entity.ToTable("skill_discovery_template");

                entity.HasComment("Skill Discovery System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.SpellId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("spellId")
                    .HasDefaultValueSql("'0'")
                    .HasComment("SpellId of the discoverable spell");

                entity.Property(e => e.Chance)
                    .HasColumnName("chance")
                    .HasComment("chance to discover");

                entity.Property(e => e.ReqSpell)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("reqSpell")
                    .HasDefaultValueSql("'0'")
                    .HasComment("spell requirement");
            });

            modelBuilder.Entity<SkillExtraItemTemplate>(entity =>
            {
                entity.HasKey(e => e.SpellId)
                    .HasName("PRIMARY");

                entity.ToTable("skill_extra_item_template");

                entity.HasComment("Skill Specialization System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.SpellId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("spellId")
                    .HasDefaultValueSql("'0'")
                    .HasComment("SpellId of the item creation spell");

                entity.Property(e => e.AdditionalCreateChance)
                    .HasColumnName("additionalCreateChance")
                    .HasComment("chance to create add");

                entity.Property(e => e.AdditionalMaxNum)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("additionalMaxNum")
                    .HasComment("max num of adds");

                entity.Property(e => e.RequiredSpecialization)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("requiredSpecialization")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Specialization spell id");
            });

            modelBuilder.Entity<SkillFishingBaseLevel>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("skill_fishing_base_level");

                entity.HasComment("Fishing system")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Area identifier");

                entity.Property(e => e.Skill)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("skill")
                    .HasComment("Base skill level requirement");
            });

            modelBuilder.Entity<SkinningLootTemplate>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.Item })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("skinning_loot_template");

                entity.HasComment("Loot System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Item)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("item")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ChanceOrQuestChance).HasDefaultValueSql("'100'");

                entity.Property(e => e.Comments)
                    .HasMaxLength(300)
                    .HasColumnName("comments")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ConditionId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("condition_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Groupid)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("groupid");

                entity.Property(e => e.Maxcount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("maxcount")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MincountOrRef)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("mincountOrRef")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<SpamRecord>(entity =>
            {
                entity.ToTable("spam_records");

                entity.HasComment("REGEX Spam records")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Record)
                    .HasMaxLength(512)
                    .HasColumnName("record");
            });

            modelBuilder.Entity<SpawnGroup>(entity =>
            {
                entity.ToTable("spawn_group");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasComment("Spawn Group ID");

                entity.Property(e => e.Flags)
                    .HasColumnType("int(10) unsigned")
                    .HasComment("Flags for various behaviour");

                entity.Property(e => e.MaxCount)
                    .HasColumnType("int(11)")
                    .HasComment("Maximum total count of all spawns in a group");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .HasComment("Description of usage")
                    .UseCollation("utf8mb3_general_ci")
                    .HasCharSet("utf8mb3");

                entity.Property(e => e.Type)
                    .HasColumnType("int(11)")
                    .HasComment("Creature or GO spawn group");

                entity.Property(e => e.WorldState)
                    .HasColumnType("int(11)")
                    .HasComment("Worldstate which enables spawning of given group");
            });

            modelBuilder.Entity<SpawnGroupEntry>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Entry })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("spawn_group_entry");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasComment("Spawn Group ID");

                entity.Property(e => e.Entry)
                    .HasColumnType("int(11)")
                    .HasComment("Entry of creature or GO");

                entity.Property(e => e.Chance)
                    .HasColumnType("int(11)")
                    .HasComment("Chance for entry to be selected");

                entity.Property(e => e.MaxCount)
                    .HasColumnType("int(11)")
                    .HasComment("Maximum total count of entry in a group");

                entity.Property(e => e.MinCount)
                    .HasColumnType("int(11)")
                    .HasComment("Minimum count of entry in a group before random");
            });

            modelBuilder.Entity<SpawnGroupFormation>(entity =>
            {
                entity.ToTable("spawn_group_formation");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasComment("Spawn group id");

                entity.Property(e => e.Comment).HasMaxLength(255);

                entity.Property(e => e.FormationOptions)
                    .HasColumnType("int(11)")
                    .HasComment("Keep formation compact (bit 1)");

                entity.Property(e => e.FormationSpread)
                    .HasColumnType("float(11,0)")
                    .HasComment("Distance between formation members");

                entity.Property(e => e.FormationType)
                    .HasColumnType("tinyint(11)")
                    .HasComment("Formation shape 0..6");

                entity.Property(e => e.MovementType)
                    .HasColumnType("tinyint(11)")
                    .HasComment("Same as creature table");

                entity.Property(e => e.PathId)
                    .HasColumnType("int(11)")
                    .HasComment("PathId from waypoint_path path");
            });

            modelBuilder.Entity<SpawnGroupLinkedGroup>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.LinkedId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("spawn_group_linked_group");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasComment("Spawn Group ID");

                entity.Property(e => e.LinkedId)
                    .HasColumnType("int(11)")
                    .HasComment("Linked Spawn Group ID");
            });

            modelBuilder.Entity<SpawnGroupSpawn>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Guid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("spawn_group_spawn");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasComment("Spawn Group ID");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(11)")
                    .HasComment("Guid of creature or GO");

                entity.Property(e => e.Chance)
                    .HasColumnType("int(10) unsigned")
                    .HasComment("Chance for a spawn to occur");

                entity.Property(e => e.SlotId)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("-1")
                    .HasComment("0 is the leader, -1 not part of the formation");
            });

            modelBuilder.Entity<SpellAffect>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.EffectId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("spell_affect");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("entry");

                entity.Property(e => e.EffectId)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("effectId");

                entity.Property(e => e.SpellFamilyMask).HasColumnType("bigint(20) unsigned");
            });

            modelBuilder.Entity<SpellArea>(entity =>
            {
                entity.HasKey(e => new { e.Spell, e.Area, e.QuestStart, e.QuestStartActive, e.AuraSpell, e.Racemask, e.Gender })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0, 0 });

                entity.ToTable("spell_area");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Spell)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("spell")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Area)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("area")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.QuestStart)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("quest_start")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.QuestStartActive)
                    .HasColumnType("tinyint(1) unsigned")
                    .HasColumnName("quest_start_active");

                entity.Property(e => e.AuraSpell)
                    .HasColumnType("mediumint(8)")
                    .HasColumnName("aura_spell")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Racemask)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("racemask")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Gender)
                    .HasColumnType("tinyint(1) unsigned")
                    .HasColumnName("gender")
                    .HasDefaultValueSql("'2'");

                entity.Property(e => e.Autocast)
                    .HasColumnType("tinyint(1) unsigned")
                    .HasColumnName("autocast");

                entity.Property(e => e.ConditionId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("condition_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.QuestEnd)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("quest_end")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<SpellBonusDatum>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("spell_bonus_data");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("smallint(5) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("entry");

                entity.Property(e => e.ApBonus).HasColumnName("ap_bonus");

                entity.Property(e => e.ApDotBonus).HasColumnName("ap_dot_bonus");

                entity.Property(e => e.Comments)
                    .HasMaxLength(255)
                    .HasColumnName("comments");

                entity.Property(e => e.DirectBonus).HasColumnName("direct_bonus");

                entity.Property(e => e.DotBonus).HasColumnName("dot_bonus");
            });

            modelBuilder.Entity<SpellChain>(entity =>
            {
                entity.HasKey(e => e.SpellId)
                    .HasName("PRIMARY");

                entity.ToTable("spell_chain");

                entity.HasComment("Spell Additinal Data")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.SpellId)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("spell_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FirstSpell)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("first_spell")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PrevSpell)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("prev_spell")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Rank)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("rank");

                entity.Property(e => e.ReqSpell)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("req_spell")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<SpellElixir>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("spell_elixir");

                entity.HasComment("Spell System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("int(11) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("entry")
                    .HasComment("SpellId of potion");

                entity.Property(e => e.Mask)
                    .HasColumnType("tinyint(1) unsigned")
                    .HasColumnName("mask")
                    .HasComment("Mask 0x1 battle 0x2 guardian 0x3 flask 0x7 unstable flasks 0xB shattrath flasks");
            });

            modelBuilder.Entity<SpellLearnSpell>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.SpellId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("spell_learn_spell");

                entity.HasComment("Item System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("entry");

                entity.Property(e => e.SpellId)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("SpellID");

                entity.Property(e => e.Active)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<SpellPetAura>(entity =>
            {
                entity.HasKey(e => new { e.Spell, e.Pet })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("spell_pet_auras");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Spell)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("spell")
                    .HasComment("dummy spell id");

                entity.Property(e => e.Pet)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("pet")
                    .HasDefaultValueSql("'0'")
                    .HasComment("pet id; 0 = all");

                entity.Property(e => e.Aura)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("aura")
                    .HasComment("pet aura id");
            });

            modelBuilder.Entity<SpellProcEvent>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("spell_proc_event");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Cooldown).HasColumnType("int(10) unsigned");

                entity.Property(e => e.PpmRate).HasColumnName("ppmRate");

                entity.Property(e => e.ProcEx)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("procEx");

                entity.Property(e => e.ProcFlags)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("procFlags");

                entity.Property(e => e.SchoolMask).HasColumnType("tinyint(4) unsigned");

                entity.Property(e => e.SpellFamilyMask0).HasColumnType("bigint(40) unsigned");

                entity.Property(e => e.SpellFamilyMask1).HasColumnType("bigint(40) unsigned");

                entity.Property(e => e.SpellFamilyMask2).HasColumnType("bigint(40) unsigned");

                entity.Property(e => e.SpellFamilyName).HasColumnType("smallint(5) unsigned");
            });

            modelBuilder.Entity<SpellProcItemEnchant>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("spell_proc_item_enchant");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("entry");

                entity.Property(e => e.PpmRate).HasColumnName("ppmRate");
            });

            modelBuilder.Entity<SpellScriptTarget>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("spell_script_target");

                entity.HasComment("Spell System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasIndex(e => new { e.Entry, e.Type, e.TargetEntry }, "entry_type_target")
                    .IsUnique();

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry");

                entity.Property(e => e.InverseEffectMask)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("inverseEffectMask")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TargetEntry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("targetEntry")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("type");
            });

            modelBuilder.Entity<SpellTargetPosition>(entity =>
            {
                entity.ToTable("spell_target_position");

                entity.HasComment("Spell System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("id")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Identifier");

                entity.Property(e => e.TargetMap)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("target_map");

                entity.Property(e => e.TargetOrientation).HasColumnName("target_orientation");

                entity.Property(e => e.TargetPositionX).HasColumnName("target_position_x");

                entity.Property(e => e.TargetPositionY).HasColumnName("target_position_y");

                entity.Property(e => e.TargetPositionZ).HasColumnName("target_position_z");
            });

            modelBuilder.Entity<SpellTemplate>(entity =>
            {
                entity.ToTable("spell_template");

                entity.HasComment("MaNGOS server side spells")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Comments)
                    .HasMaxLength(255)
                    .HasColumnName("comments");

                entity.Property(e => e.DurationIndex)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("duration_index");

                entity.Property(e => e.Effect0)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("effect0");

                entity.Property(e => e.Effect0ApplyAuraName)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("effect0_apply_aura_name");

                entity.Property(e => e.Effect0ImplicitTargetA)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("effect0_implicit_target_a");

                entity.Property(e => e.Effect0MiscValue)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("effect0_misc_value");

                entity.Property(e => e.Effect0MiscValueB)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("effect0_misc_value_b");

                entity.Property(e => e.Effect0RadiusIdx)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("effect0_radius_idx");

                entity.Property(e => e.Effect0TriggerSpell)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("effect0_trigger_spell");

                entity.Property(e => e.ProcChance)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("proc_chance");

                entity.Property(e => e.ProcFlags)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("proc_flags");
            });

            modelBuilder.Entity<SpellThreat>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("spell_threat");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("entry");

                entity.Property(e => e.ApBonus)
                    .HasColumnName("ap_bonus")
                    .HasComment("additional threat bonus from attack power");

                entity.Property(e => e.Multiplier)
                    .HasColumnName("multiplier")
                    .HasDefaultValueSql("'1'")
                    .HasComment("threat multiplier for damage/healing");

                entity.Property(e => e.Threat).HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<TaxiShortcut>(entity =>
            {
                entity.HasKey(e => e.Pathid)
                    .HasName("PRIMARY");

                entity.ToTable("taxi_shortcuts");

                entity.HasComment("Taxi System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Pathid)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("pathid")
                    .HasComment("Flight path entry id");

                entity.Property(e => e.Comments)
                    .HasMaxLength(255)
                    .HasColumnName("comments")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Landing)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("landing")
                    .HasComment("Amount of waypoints to skip at the end of the flight");

                entity.Property(e => e.Takeoff)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("takeoff")
                    .HasComment("Amount of waypoints to skip in the beginning of the flight");
            });

            modelBuilder.Entity<TrainerGreeting>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("trainer_greeting");

                entity.HasComment("Trainer system")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("int(11) unsigned")
                    .ValueGeneratedNever()
                    .HasComment("Entry of Trainer");

                entity.Property(e => e.Text).HasComment("Text of the greeting");
            });

            modelBuilder.Entity<Transport>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("transports");

                entity.HasComment("Transports")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Name)
                    .HasColumnType("text")
                    .HasColumnName("name");

                entity.Property(e => e.Period)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("period")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<WardenScan>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PRIMARY");

                entity.ToTable("warden_scans");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasIndex(e => e.Id, "id")
                    .IsUnique();

                entity.Property(e => e.Address)
                    .HasColumnType("int(8)")
                    .HasColumnName("address")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Comment)
                    .HasColumnType("tinytext")
                    .HasColumnName("comment");

                entity.Property(e => e.Data)
                    .HasColumnType("text")
                    .HasColumnName("data");

                entity.Property(e => e.Flags)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("flags");

                entity.Property(e => e.Id)
                    .HasColumnType("smallint(5) unsigned")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Length)
                    .HasColumnType("int(2)")
                    .HasColumnName("length")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Result)
                    .HasColumnType("tinytext")
                    .HasColumnName("result");

                entity.Property(e => e.Str)
                    .HasColumnType("text")
                    .HasColumnName("str");

                entity.Property(e => e.Type)
                    .HasColumnType("int(2)")
                    .HasColumnName("type")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<WaypointPath>(entity =>
            {
                entity.HasKey(e => new { e.PathId, e.Point })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("waypoint_path");

                entity.Property(e => e.PathId)
                    .HasColumnType("int(10) unsigned")
                    .HasComment("Unique path id");

                entity.Property(e => e.Point)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Comment).HasColumnType("text");

                entity.Property(e => e.ScriptId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.WaitTime).HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<WorldSafeLoc>(entity =>
            {
                entity.ToTable("world_safe_locs");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Map)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("map");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.O).HasColumnName("o");

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.Y).HasColumnName("y");

                entity.Property(e => e.Z).HasColumnName("z");
            });

            modelBuilder.Entity<WorldTemplate>(entity =>
            {
                entity.HasKey(e => e.Map)
                    .HasName("PRIMARY");

                entity.ToTable("world_template");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Map)
                    .HasColumnType("smallint(5) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("map");

                entity.Property(e => e.ScriptName)
                    .HasMaxLength(128)
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<WorldstateName>(entity =>
            {
                entity.ToTable("worldstate_name");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasComment("Worldstate variable Id");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .HasComment("Name and use of variable");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
