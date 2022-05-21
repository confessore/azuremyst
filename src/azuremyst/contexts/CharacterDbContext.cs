using azuremyst.models.characters;
using Microsoft.EntityFrameworkCore;

namespace azuremyst.contexts
{
    public partial class CharacterDbContext : DbContext
    {
        public CharacterDbContext(DbContextOptions<CharacterDbContext> options)
            : base(options) { }

        public virtual DbSet<AccountDatum>? AccountData { get; set; } = null!;
        public virtual DbSet<AccountInstancesEntered>? AccountInstancesEntereds { get; set; } = null!;
        public virtual DbSet<AhbotItem>? AhbotItems { get; set; } = null!;
        public virtual DbSet<ArenaTeam>? ArenaTeams { get; set; } = null!;
        public virtual DbSet<ArenaTeamMember>? ArenaTeamMembers { get; set; } = null!;
        public virtual DbSet<ArenaTeamStat>? ArenaTeamStats { get; set; } = null!;
        public virtual DbSet<Auction>? Auctions { get; set; } = null!;
        public virtual DbSet<Bugreport>? Bugreports { get; set; } = null!;
        public virtual DbSet<Character>? Characters { get; set; } = null!;
        public virtual DbSet<CharacterAccountDatum>? CharacterAccountData { get; set; } = null!;
        public virtual DbSet<CharacterAction>? CharacterActions { get; set; } = null!;
        public virtual DbSet<CharacterAura>? CharacterAuras { get; set; } = null!;
        public virtual DbSet<CharacterBattlegroundDatum>? CharacterBattlegroundData { get; set; } = null!;
        public virtual DbSet<CharacterDbVersion>? CharacterDbVersions { get; set; } = null!;
        public virtual DbSet<CharacterDeclinedname>? CharacterDeclinednames { get; set; } = null!;
        public virtual DbSet<CharacterGift>? CharacterGifts { get; set; } = null!;
        public virtual DbSet<CharacterHomebind>? CharacterHomebinds { get; set; } = null!;
        public virtual DbSet<CharacterInstance>? CharacterInstances { get; set; } = null!;
        public virtual DbSet<CharacterInventory>? CharacterInventories { get; set; } = null!;
        public virtual DbSet<CharacterPet>? CharacterPets { get; set; } = null!;
        public virtual DbSet<CharacterPetDeclinedname>? CharacterPetDeclinednames { get; set; } = null!;
        public virtual DbSet<CharacterQueststatus>? CharacterQueststatuses { get; set; } = null!;
        public virtual DbSet<CharacterQueststatusDaily>? CharacterQueststatusDailies { get; set; } = null!;
        public virtual DbSet<CharacterQueststatusMonthly>? CharacterQueststatusMonthlies { get; set; } = null!;
        public virtual DbSet<CharacterQueststatusWeekly>? CharacterQueststatusWeeklies { get; set; } = null!;
        public virtual DbSet<CharacterReputation>? CharacterReputations { get; set; } = null!;
        public virtual DbSet<CharacterSkill>? CharacterSkills { get; set; } = null!;
        public virtual DbSet<CharacterSocial>? CharacterSocials { get; set; } = null!;
        public virtual DbSet<CharacterSpell>? CharacterSpells { get; set; } = null!;
        public virtual DbSet<CharacterSpellCooldown>? CharacterSpellCooldowns { get; set; } = null!;
        public virtual DbSet<CharacterStat>? CharacterStats { get; set; } = null!;
        public virtual DbSet<CharacterTutorial>? CharacterTutorials { get; set; } = null!;
        public virtual DbSet<Corpse>? Corpses { get; set; } = null!;
        public virtual DbSet<CreatureRespawn>? CreatureRespawns { get; set; } = null!;
        public virtual DbSet<EventGroupChosen>? EventGroupChosens { get; set; } = null!;
        public virtual DbSet<GameEventStatus>? GameEventStatuses { get; set; } = null!;
        public virtual DbSet<GameobjectRespawn>? GameobjectRespawns { get; set; } = null!;
        public virtual DbSet<GmSurvey>? GmSurveys { get; set; } = null!;
        public virtual DbSet<GmTicket>? GmTickets { get; set; } = null!;
        public virtual DbSet<Group>? Groups { get; set; } = null!;
        public virtual DbSet<GroupInstance>? GroupInstances { get; set; } = null!;
        public virtual DbSet<GroupMember>? GroupMembers { get; set; } = null!;
        public virtual DbSet<Guild>? Guilds { get; set; } = null!;
        public virtual DbSet<GuildBankEventlog>? GuildBankEventlogs { get; set; } = null!;
        public virtual DbSet<GuildBankItem>? GuildBankItems { get; set; } = null!;
        public virtual DbSet<GuildBankRight>? GuildBankRights { get; set; } = null!;
        public virtual DbSet<GuildBankTab>? GuildBankTabs { get; set; } = null!;
        public virtual DbSet<GuildEventlog>? GuildEventlogs { get; set; } = null!;
        public virtual DbSet<GuildMember>? GuildMembers { get; set; } = null!;
        public virtual DbSet<GuildRank>? GuildRanks { get; set; } = null!;
        public virtual DbSet<Instance>? Instances { get; set; } = null!;
        public virtual DbSet<InstanceReset>? InstanceResets { get; set; } = null!;
        public virtual DbSet<ItemInstance>? ItemInstances { get; set; } = null!;
        public virtual DbSet<ItemLoot>? ItemLoots { get; set; } = null!;
        public virtual DbSet<ItemText>? ItemTexts { get; set; } = null!;
        public virtual DbSet<Mail>? Mail { get; set; } = null!;
        public virtual DbSet<MailItem>? MailItems { get; set; } = null!;
        public virtual DbSet<PetAura>? PetAuras { get; set; } = null!;
        public virtual DbSet<PetSpell>? PetSpells { get; set; } = null!;
        public virtual DbSet<PetSpellCooldown>? PetSpellCooldowns { get; set; } = null!;
        public virtual DbSet<Petition>? Petitions { get; set; } = null!;
        public virtual DbSet<PetitionSign>? PetitionSigns { get; set; } = null!;
        public virtual DbSet<PlayerbotSavedDatum>? PlayerbotSavedData { get; set; } = null!;
        public virtual DbSet<PvpstatsBattleground>? PvpstatsBattlegrounds { get; set; } = null!;
        public virtual DbSet<PvpstatsPlayer>? PvpstatsPlayers { get; set; } = null!;
        public virtual DbSet<SavedVariable>? SavedVariables { get; set; } = null!;
        public virtual DbSet<World>? Worlds { get; set; } = null!;
        public virtual DbSet<WorldState>? WorldStates { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_general_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<AccountDatum>(entity =>
            {
                entity.HasKey(e => new { e.Account, e.Type })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("account_data");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Account)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("account");

                entity.Property(e => e.Type)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("type");

                entity.Property(e => e.Data).HasColumnName("data");

                entity.Property(e => e.Time)
                    .HasColumnType("bigint(11) unsigned")
                    .HasColumnName("time");
            });

            modelBuilder.Entity<AccountInstancesEntered>(entity =>
            {
                entity.HasKey(e => new { e.AccountId, e.InstanceId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("account_instances_entered");

                entity.HasComment("Instance reset limit system")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.AccountId)
                    .HasColumnType("int(11) unsigned")
                    .HasComment("Player account");

                entity.Property(e => e.InstanceId)
                    .HasColumnType("int(11) unsigned")
                    .HasComment("ID of instance entered");

                entity.Property(e => e.ExpireTime)
                    .HasColumnType("bigint(40)")
                    .HasComment("Time when instance was entered");
            });

            modelBuilder.Entity<AhbotItem>(entity =>
            {
                entity.HasKey(e => e.Item)
                    .HasName("PRIMARY");

                entity.ToTable("ahbot_items");

                entity.HasComment("AuctionHouseBot overridden item settings")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Item)
                    .HasColumnType("int(11) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("item")
                    .HasComment("Item Identifier");

                entity.Property(e => e.AddChance)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("add_chance")
                    .HasComment("Chance item is added to AH upon bot visit, 0 for normal loot sources");

                entity.Property(e => e.MaxAmount)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("max_amount")
                    .HasComment("Max amount added, not used when add_chance is 0");

                entity.Property(e => e.MinAmount)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("min_amount")
                    .HasComment("Min amount added, not used when add_chance is 0");

                entity.Property(e => e.Value)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("value")
                    .HasComment("Item value, a value of 0 bans item from being sold/bought by AHBot");
            });

            modelBuilder.Entity<ArenaTeam>(entity =>
            {
                entity.ToTable("arena_team");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Arenateamid)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("arenateamid");

                entity.Property(e => e.BackgroundColor).HasColumnType("int(10) unsigned");

                entity.Property(e => e.BorderColor).HasColumnType("int(10) unsigned");

                entity.Property(e => e.BorderStyle).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Captainguid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("captainguid");

                entity.Property(e => e.EmblemColor).HasColumnType("int(10) unsigned");

                entity.Property(e => e.EmblemStyle).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name")
                    .IsFixedLength();

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("type");
            });

            modelBuilder.Entity<ArenaTeamMember>(entity =>
            {
                entity.HasKey(e => new { e.Arenateamid, e.Guid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("arena_team_member");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Arenateamid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("arenateamid");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guid");

                entity.Property(e => e.PersonalRating)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("personal_rating");

                entity.Property(e => e.PlayedSeason)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("played_season");

                entity.Property(e => e.PlayedWeek)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("played_week");

                entity.Property(e => e.WonsSeason)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("wons_season");

                entity.Property(e => e.WonsWeek)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("wons_week");
            });

            modelBuilder.Entity<ArenaTeamStat>(entity =>
            {
                entity.HasKey(e => e.Arenateamid)
                    .HasName("PRIMARY");

                entity.ToTable("arena_team_stats");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Arenateamid)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("arenateamid");

                entity.Property(e => e.GamesSeason)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("games_season");

                entity.Property(e => e.GamesWeek)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("games_week");

                entity.Property(e => e.Rank)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("rank");

                entity.Property(e => e.Rating)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("rating");

                entity.Property(e => e.WinsSeason)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("wins_season");

                entity.Property(e => e.WinsWeek)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("wins_week");
            });

            modelBuilder.Entity<Auction>(entity =>
            {
                entity.ToTable("auction");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Buyguid)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("buyguid");

                entity.Property(e => e.Buyoutprice)
                    .HasColumnType("int(11)")
                    .HasColumnName("buyoutprice");

                entity.Property(e => e.Deposit)
                    .HasColumnType("int(11)")
                    .HasColumnName("deposit");

                entity.Property(e => e.Houseid)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("houseid");

                entity.Property(e => e.ItemCount)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("item_count");

                entity.Property(e => e.ItemRandompropertyid)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_randompropertyid");

                entity.Property(e => e.ItemTemplate)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("item_template")
                    .HasComment("Item Identifier");

                entity.Property(e => e.Itemguid)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("itemguid");

                entity.Property(e => e.Itemowner)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("itemowner");

                entity.Property(e => e.Lastbid)
                    .HasColumnType("int(11)")
                    .HasColumnName("lastbid");

                entity.Property(e => e.Startbid)
                    .HasColumnType("int(11)")
                    .HasColumnName("startbid");

                entity.Property(e => e.Time)
                    .HasColumnType("bigint(40) unsigned")
                    .HasColumnName("time");
            });

            modelBuilder.Entity<Bugreport>(entity =>
            {
                entity.ToTable("bugreport");

                entity.HasComment("Debug System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id")
                    .HasComment("Identifier");

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<Character>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PRIMARY");

                entity.ToTable("characters");

                entity.HasComment("Player System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasIndex(e => e.Account, "idx_account");

                entity.HasIndex(e => e.Name, "idx_name");

                entity.HasIndex(e => e.Online, "idx_online");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(11) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("guid")
                    .HasComment("Global Unique Identifier");

                entity.Property(e => e.Account)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("account")
                    .HasComment("Account Identifier");

                entity.Property(e => e.ActionBars)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("actionBars");

                entity.Property(e => e.AmmoId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("ammoId");

                entity.Property(e => e.ArenaPoints)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("arenaPoints");

                entity.Property(e => e.AtLogin)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("at_login");

                entity.Property(e => e.ChosenTitle)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("chosenTitle");

                entity.Property(e => e.Cinematic)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("cinematic");

                entity.Property(e => e.Class)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("class");

                entity.Property(e => e.DeathExpireTime)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("death_expire_time");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("deleteDate");

                entity.Property(e => e.DeleteInfosAccount)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("deleteInfos_Account");

                entity.Property(e => e.DeleteInfosName)
                    .HasMaxLength(12)
                    .HasColumnName("deleteInfos_Name");

                entity.Property(e => e.Drunk)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("drunk");

                entity.Property(e => e.DungeonDifficulty)
                    .HasColumnType("tinyint(1) unsigned")
                    .HasColumnName("dungeon_difficulty");

                entity.Property(e => e.EquipmentCache).HasColumnName("equipmentCache");

                entity.Property(e => e.ExploredZones).HasColumnName("exploredZones");

                entity.Property(e => e.ExtraFlags)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("extra_flags");

                entity.Property(e => e.Gender)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("gender");

                entity.Property(e => e.GrantableLevels)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("grantableLevels")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Health)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("health");

                entity.Property(e => e.IsLogoutResting)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("is_logout_resting");

                entity.Property(e => e.KnownTitles).HasColumnName("knownTitles");

                entity.Property(e => e.Level)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("level");

                entity.Property(e => e.Leveltime)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("leveltime");

                entity.Property(e => e.LogoutTime)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("logout_time");

                entity.Property(e => e.Map)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("map")
                    .HasComment("Map Identifier");

                entity.Property(e => e.Money)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("money");

                entity.Property(e => e.Name)
                    .HasMaxLength(12)
                    .HasColumnName("name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Online)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("online");

                entity.Property(e => e.Orientation).HasColumnName("orientation");

                entity.Property(e => e.PlayerBytes)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("playerBytes");

                entity.Property(e => e.PlayerBytes2)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("playerBytes2");

                entity.Property(e => e.PlayerFlags)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("playerFlags");

                entity.Property(e => e.PositionX).HasColumnName("position_x");

                entity.Property(e => e.PositionY).HasColumnName("position_y");

                entity.Property(e => e.PositionZ).HasColumnName("position_z");

                entity.Property(e => e.Power1)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("power1");

                entity.Property(e => e.Power2)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("power2");

                entity.Property(e => e.Power3)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("power3");

                entity.Property(e => e.Power4)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("power4");

                entity.Property(e => e.Power5)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("power5");

                entity.Property(e => e.Race)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("race");

                entity.Property(e => e.ResettalentsCost)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("resettalents_cost");

                entity.Property(e => e.ResettalentsTime)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("resettalents_time");

                entity.Property(e => e.RestBonus).HasColumnName("rest_bonus");

                entity.Property(e => e.StableSlots)
                    .HasColumnType("tinyint(1) unsigned")
                    .HasColumnName("stable_slots");

                entity.Property(e => e.TaxiPath)
                    .HasColumnType("text")
                    .HasColumnName("taxi_path");

                entity.Property(e => e.Taximask).HasColumnName("taximask");

                entity.Property(e => e.TodayHonorPoints)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("todayHonorPoints");

                entity.Property(e => e.TodayKills)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("todayKills");

                entity.Property(e => e.TotalHonorPoints)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("totalHonorPoints");

                entity.Property(e => e.TotalKills)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("totalKills");

                entity.Property(e => e.Totaltime)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("totaltime");

                entity.Property(e => e.TransO).HasColumnName("trans_o");

                entity.Property(e => e.TransX).HasColumnName("trans_x");

                entity.Property(e => e.TransY).HasColumnName("trans_y");

                entity.Property(e => e.TransZ).HasColumnName("trans_z");

                entity.Property(e => e.Transguid)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("transguid");

                entity.Property(e => e.WatchedFaction)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("watchedFaction");

                entity.Property(e => e.Xp)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("xp");

                entity.Property(e => e.YesterdayHonorPoints)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("yesterdayHonorPoints");

                entity.Property(e => e.YesterdayKills)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("yesterdayKills");

                entity.Property(e => e.Zone)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("zone");
            });

            modelBuilder.Entity<CharacterAccountDatum>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Type })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("character_account_data");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("guid");

                entity.Property(e => e.Type)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("type");

                entity.Property(e => e.Data).HasColumnName("data");

                entity.Property(e => e.Time)
                    .HasColumnType("bigint(11) unsigned")
                    .HasColumnName("time");
            });

            modelBuilder.Entity<CharacterAction>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Button })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("character_action");

                entity.HasComment("Player System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("guid")
                    .HasComment("Global Unique Identifier");

                entity.Property(e => e.Button)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("button");

                entity.Property(e => e.Action)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("action");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("type");
            });

            modelBuilder.Entity<CharacterAura>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.CasterGuid, e.ItemGuid, e.Spell })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

                entity.ToTable("character_aura");

                entity.HasComment("Player System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("guid")
                    .HasComment("Global Unique Identifier");

                entity.Property(e => e.CasterGuid)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("caster_guid")
                    .HasComment("Full Global Unique Identifier");

                entity.Property(e => e.ItemGuid)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("item_guid");

                entity.Property(e => e.Spell)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("spell");

                entity.Property(e => e.Basepoints0)
                    .HasColumnType("int(11)")
                    .HasColumnName("basepoints0");

                entity.Property(e => e.Basepoints1)
                    .HasColumnType("int(11)")
                    .HasColumnName("basepoints1");

                entity.Property(e => e.Basepoints2)
                    .HasColumnType("int(11)")
                    .HasColumnName("basepoints2");

                entity.Property(e => e.EffIndexMask)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("effIndexMask");

                entity.Property(e => e.Maxduration)
                    .HasColumnType("int(11)")
                    .HasColumnName("maxduration");

                entity.Property(e => e.Periodictime0)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("periodictime0");

                entity.Property(e => e.Periodictime1)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("periodictime1");

                entity.Property(e => e.Periodictime2)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("periodictime2");

                entity.Property(e => e.Remaincharges)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("remaincharges");

                entity.Property(e => e.Remaintime)
                    .HasColumnType("int(11)")
                    .HasColumnName("remaintime");

                entity.Property(e => e.Stackcount)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("stackcount")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<CharacterBattlegroundDatum>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PRIMARY");

                entity.ToTable("character_battleground_data");

                entity.HasComment("Player System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(11) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("guid")
                    .HasComment("Global Unique Identifier");

                entity.Property(e => e.InstanceId)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("instance_id");

                entity.Property(e => e.JoinMap)
                    .HasColumnType("int(11)")
                    .HasColumnName("join_map");

                entity.Property(e => e.JoinO).HasColumnName("join_o");

                entity.Property(e => e.JoinX).HasColumnName("join_x");

                entity.Property(e => e.JoinY).HasColumnName("join_y");

                entity.Property(e => e.JoinZ).HasColumnName("join_z");

                entity.Property(e => e.Team)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("team");
            });

            modelBuilder.Entity<CharacterDbVersion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("character_db_version");

                entity.HasComment("Last applied sql update to DB")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.RequiredS242901CharactersRaf)
                    .HasColumnType("bit(1)")
                    .HasColumnName("required_s2429_01_characters_raf");
            });

            modelBuilder.Entity<CharacterDeclinedname>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PRIMARY");

                entity.ToTable("character_declinedname");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(11) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("guid")
                    .HasComment("Global Unique Identifier");

                entity.Property(e => e.Accusative)
                    .HasMaxLength(15)
                    .HasColumnName("accusative")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dative)
                    .HasMaxLength(15)
                    .HasColumnName("dative")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Genitive)
                    .HasMaxLength(15)
                    .HasColumnName("genitive")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Instrumental)
                    .HasMaxLength(15)
                    .HasColumnName("instrumental")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Prepositional)
                    .HasMaxLength(15)
                    .HasColumnName("prepositional")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<CharacterGift>(entity =>
            {
                entity.HasKey(e => e.ItemGuid)
                    .HasName("PRIMARY");

                entity.ToTable("character_gifts");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasIndex(e => e.Guid, "idx_guid");

                entity.Property(e => e.ItemGuid)
                    .HasColumnType("int(11) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("item_guid");

                entity.Property(e => e.Entry)
                    .HasColumnType("int(20) unsigned")
                    .HasColumnName("entry");

                entity.Property(e => e.Flags)
                    .HasColumnType("int(20) unsigned")
                    .HasColumnName("flags");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(20) unsigned")
                    .HasColumnName("guid");
            });

            modelBuilder.Entity<CharacterHomebind>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PRIMARY");

                entity.ToTable("character_homebind");

                entity.HasComment("Player System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(11) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("guid")
                    .HasComment("Global Unique Identifier");

                entity.Property(e => e.Map)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("map")
                    .HasComment("Map Identifier");

                entity.Property(e => e.PositionX).HasColumnName("position_x");

                entity.Property(e => e.PositionY).HasColumnName("position_y");

                entity.Property(e => e.PositionZ).HasColumnName("position_z");

                entity.Property(e => e.Zone)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("zone")
                    .HasComment("Zone Identifier");
            });

            modelBuilder.Entity<CharacterInstance>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Instance })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("character_instance");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasIndex(e => e.Instance, "instance");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("guid");

                entity.Property(e => e.Instance)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("instance");

                entity.Property(e => e.Permanent)
                    .HasColumnType("tinyint(1) unsigned")
                    .HasColumnName("permanent");
            });

            modelBuilder.Entity<CharacterInventory>(entity =>
            {
                entity.HasKey(e => e.Item)
                    .HasName("PRIMARY");

                entity.ToTable("character_inventory");

                entity.HasComment("Player System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasIndex(e => e.Guid, "idx_guid");

                entity.Property(e => e.Item)
                    .HasColumnType("int(11) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("item")
                    .HasComment("Item Global Unique Identifier");

                entity.Property(e => e.Bag)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("bag");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("guid")
                    .HasComment("Global Unique Identifier");

                entity.Property(e => e.ItemTemplate)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("item_template")
                    .HasComment("Item Identifier");

                entity.Property(e => e.Slot)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("slot");
            });

            modelBuilder.Entity<CharacterPet>(entity =>
            {
                entity.ToTable("character_pet");

                entity.HasComment("Pet System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasIndex(e => e.Owner, "owner");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Abdata).HasColumnName("abdata");

                entity.Property(e => e.CreatedBySpell).HasColumnType("int(11) unsigned");

                entity.Property(e => e.Curhappiness)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("curhappiness");

                entity.Property(e => e.Curhealth)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("curhealth")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Curmana)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("curmana");

                entity.Property(e => e.Entry)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("entry");

                entity.Property(e => e.Exp)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("exp");

                entity.Property(e => e.Level)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("level")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Loyalty)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("loyalty");

                entity.Property(e => e.Loyaltypoints)
                    .HasColumnType("int(11)")
                    .HasColumnName("loyaltypoints");

                entity.Property(e => e.Modelid)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("modelid")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name")
                    .HasDefaultValueSql("'Pet'");

                entity.Property(e => e.Owner)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("owner");

                entity.Property(e => e.PetType).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Reactstate).HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.Renamed)
                    .HasColumnType("tinyint(1) unsigned")
                    .HasColumnName("renamed");

                entity.Property(e => e.ResettalentsCost)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("resettalents_cost");

                entity.Property(e => e.ResettalentsTime)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("resettalents_time");

                entity.Property(e => e.Savetime)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("savetime");

                entity.Property(e => e.Slot)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("slot");

                entity.Property(e => e.Teachspelldata).HasColumnName("teachspelldata");

                entity.Property(e => e.Trainpoint)
                    .HasColumnType("int(11)")
                    .HasColumnName("trainpoint");

                entity.Property(e => e.XpForNextLoyalty)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("xpForNextLoyalty");
            });

            modelBuilder.Entity<CharacterPetDeclinedname>(entity =>
            {
                entity.ToTable("character_pet_declinedname");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasIndex(e => e.Owner, "owner_key");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Accusative)
                    .HasMaxLength(12)
                    .HasColumnName("accusative")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dative)
                    .HasMaxLength(12)
                    .HasColumnName("dative")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Genitive)
                    .HasMaxLength(12)
                    .HasColumnName("genitive")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Instrumental)
                    .HasMaxLength(12)
                    .HasColumnName("instrumental")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Owner)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("owner");

                entity.Property(e => e.Prepositional)
                    .HasMaxLength(12)
                    .HasColumnName("prepositional")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<CharacterQueststatus>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Quest })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("character_queststatus");

                entity.HasComment("Player System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("guid")
                    .HasComment("Global Unique Identifier");

                entity.Property(e => e.Quest)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("quest")
                    .HasComment("Quest Identifier");

                entity.Property(e => e.Explored)
                    .HasColumnType("tinyint(1) unsigned")
                    .HasColumnName("explored");

                entity.Property(e => e.Itemcount1)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("itemcount1");

                entity.Property(e => e.Itemcount2)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("itemcount2");

                entity.Property(e => e.Itemcount3)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("itemcount3");

                entity.Property(e => e.Itemcount4)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("itemcount4");

                entity.Property(e => e.Mobcount1)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("mobcount1");

                entity.Property(e => e.Mobcount2)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("mobcount2");

                entity.Property(e => e.Mobcount3)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("mobcount3");

                entity.Property(e => e.Mobcount4)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("mobcount4");

                entity.Property(e => e.Rewarded)
                    .HasColumnType("tinyint(1) unsigned")
                    .HasColumnName("rewarded");

                entity.Property(e => e.Status)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("status");

                entity.Property(e => e.Timer)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("timer");
            });

            modelBuilder.Entity<CharacterQueststatusDaily>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Quest })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("character_queststatus_daily");

                entity.HasComment("Player System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("guid")
                    .HasComment("Global Unique Identifier");

                entity.Property(e => e.Quest)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("quest")
                    .HasComment("Quest Identifier");
            });

            modelBuilder.Entity<CharacterQueststatusMonthly>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Quest })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("character_queststatus_monthly");

                entity.HasComment("Player System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("guid")
                    .HasComment("Global Unique Identifier");

                entity.Property(e => e.Quest)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("quest")
                    .HasComment("Quest Identifier");
            });

            modelBuilder.Entity<CharacterQueststatusWeekly>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Quest })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("character_queststatus_weekly");

                entity.HasComment("Player System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("guid")
                    .HasComment("Global Unique Identifier");

                entity.Property(e => e.Quest)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("quest")
                    .HasComment("Quest Identifier");
            });

            modelBuilder.Entity<CharacterReputation>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Faction })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("character_reputation");

                entity.HasComment("Player System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("guid")
                    .HasComment("Global Unique Identifier");

                entity.Property(e => e.Faction)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("faction");

                entity.Property(e => e.Flags)
                    .HasColumnType("int(11)")
                    .HasColumnName("flags");

                entity.Property(e => e.Standing)
                    .HasColumnType("int(11)")
                    .HasColumnName("standing");
            });

            modelBuilder.Entity<CharacterSkill>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Skill })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("character_skills");

                entity.HasComment("Player System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("guid")
                    .HasComment("Global Unique Identifier");

                entity.Property(e => e.Skill)
                    .HasColumnType("mediumint(9) unsigned")
                    .HasColumnName("skill");

                entity.Property(e => e.Max)
                    .HasColumnType("mediumint(9) unsigned")
                    .HasColumnName("max");

                entity.Property(e => e.Value)
                    .HasColumnType("mediumint(9) unsigned")
                    .HasColumnName("value");
            });

            modelBuilder.Entity<CharacterSocial>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Friend, e.Flags })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("character_social");

                entity.HasComment("Player System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasIndex(e => new { e.Friend, e.Flags }, "friend_flags");

                entity.HasIndex(e => new { e.Guid, e.Flags }, "guid_flags");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("guid")
                    .HasComment("Character Global Unique Identifier");

                entity.Property(e => e.Friend)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("friend")
                    .HasComment("Friend Global Unique Identifier");

                entity.Property(e => e.Flags)
                    .HasColumnType("tinyint(1) unsigned")
                    .HasColumnName("flags")
                    .HasComment("Friend Flags");

                entity.Property(e => e.Note)
                    .HasMaxLength(48)
                    .HasColumnName("note")
                    .HasDefaultValueSql("''")
                    .HasComment("Friend Note");
            });

            modelBuilder.Entity<CharacterSpell>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Spell })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("character_spell");

                entity.HasComment("Player System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasIndex(e => e.Spell, "Idx_spell");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("guid")
                    .HasComment("Global Unique Identifier");

                entity.Property(e => e.Spell)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("spell")
                    .HasComment("Spell Identifier");

                entity.Property(e => e.Active)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("active")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Disabled)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("disabled");
            });

            modelBuilder.Entity<CharacterSpellCooldown>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.SpellId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("character_spell_cooldown");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("guid")
                    .HasComment("Global Unique Identifier, Low part");

                entity.Property(e => e.SpellId)
                    .HasColumnType("int(11) unsigned")
                    .HasComment("Spell Identifier");

                entity.Property(e => e.Category)
                    .HasColumnType("int(11) unsigned")
                    .HasComment("Spell category");

                entity.Property(e => e.CategoryExpireTime)
                    .HasColumnType("bigint(20) unsigned")
                    .HasComment("Spell category cooldown expire time");

                entity.Property(e => e.ItemId)
                    .HasColumnType("int(11) unsigned")
                    .HasComment("Item Identifier");

                entity.Property(e => e.SpellExpireTime)
                    .HasColumnType("bigint(20) unsigned")
                    .HasComment("Spell cooldown expire time");
            });

            modelBuilder.Entity<CharacterStat>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PRIMARY");

                entity.ToTable("character_stats");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(11) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("guid")
                    .HasComment("Global Unique Identifier, Low part");

                entity.Property(e => e.Agility)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("agility");

                entity.Property(e => e.Armor)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("armor");

                entity.Property(e => e.AttackPower)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("attackPower");

                entity.Property(e => e.BlockPct)
                    .HasColumnType("float unsigned")
                    .HasColumnName("blockPct");

                entity.Property(e => e.CritPct)
                    .HasColumnType("float unsigned")
                    .HasColumnName("critPct");

                entity.Property(e => e.DodgePct)
                    .HasColumnType("float unsigned")
                    .HasColumnName("dodgePct");

                entity.Property(e => e.Intellect)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("intellect");

                entity.Property(e => e.Maxhealth)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("maxhealth");

                entity.Property(e => e.Maxpower1)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("maxpower1");

                entity.Property(e => e.Maxpower2)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("maxpower2");

                entity.Property(e => e.Maxpower3)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("maxpower3");

                entity.Property(e => e.Maxpower4)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("maxpower4");

                entity.Property(e => e.Maxpower5)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("maxpower5");

                entity.Property(e => e.Maxpower6)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("maxpower6");

                entity.Property(e => e.Maxpower7)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("maxpower7");

                entity.Property(e => e.ParryPct)
                    .HasColumnType("float unsigned")
                    .HasColumnName("parryPct");

                entity.Property(e => e.RangedAttackPower)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("rangedAttackPower");

                entity.Property(e => e.RangedCritPct)
                    .HasColumnType("float unsigned")
                    .HasColumnName("rangedCritPct");

                entity.Property(e => e.ResArcane)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("resArcane");

                entity.Property(e => e.ResFire)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("resFire");

                entity.Property(e => e.ResFrost)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("resFrost");

                entity.Property(e => e.ResHoly)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("resHoly");

                entity.Property(e => e.ResNature)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("resNature");

                entity.Property(e => e.ResShadow)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("resShadow");

                entity.Property(e => e.SpellCritPct)
                    .HasColumnType("float unsigned")
                    .HasColumnName("spellCritPct");

                entity.Property(e => e.SpellPower)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("spellPower");

                entity.Property(e => e.Spirit)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("spirit");

                entity.Property(e => e.Stamina)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("stamina");

                entity.Property(e => e.Strength)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("strength");
            });

            modelBuilder.Entity<CharacterTutorial>(entity =>
            {
                entity.HasKey(e => e.Account)
                    .HasName("PRIMARY");

                entity.ToTable("character_tutorial");

                entity.HasComment("Player System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Account)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("account")
                    .HasComment("Account Identifier");

                entity.Property(e => e.Tut0)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("tut0");

                entity.Property(e => e.Tut1)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("tut1");

                entity.Property(e => e.Tut2)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("tut2");

                entity.Property(e => e.Tut3)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("tut3");

                entity.Property(e => e.Tut4)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("tut4");

                entity.Property(e => e.Tut5)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("tut5");

                entity.Property(e => e.Tut6)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("tut6");

                entity.Property(e => e.Tut7)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("tut7");
            });

            modelBuilder.Entity<Corpse>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PRIMARY");

                entity.ToTable("corpse");

                entity.HasComment("Death System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasIndex(e => e.Player, "Idx_player");

                entity.HasIndex(e => e.Time, "Idx_time");

                entity.HasIndex(e => e.CorpseType, "idx_type");

                entity.HasIndex(e => e.Instance, "instance");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(11) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("guid")
                    .HasComment("Global Unique Identifier");

                entity.Property(e => e.CorpseType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("corpse_type");

                entity.Property(e => e.Instance)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("instance");

                entity.Property(e => e.Map)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("map")
                    .HasComment("Map Identifier");

                entity.Property(e => e.Orientation).HasColumnName("orientation");

                entity.Property(e => e.Player)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("player")
                    .HasComment("Character Global Unique Identifier");

                entity.Property(e => e.PositionX).HasColumnName("position_x");

                entity.Property(e => e.PositionY).HasColumnName("position_y");

                entity.Property(e => e.PositionZ).HasColumnName("position_z");

                entity.Property(e => e.Time)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("time");
            });

            modelBuilder.Entity<CreatureRespawn>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Instance })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("creature_respawn");

                entity.HasComment("Grid Loading System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasIndex(e => e.Instance, "instance");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guid")
                    .HasComment("Global Unique Identifier");

                entity.Property(e => e.Instance)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("instance")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Respawntime)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("respawntime");
            });

            modelBuilder.Entity<EventGroupChosen>(entity =>
            {
                entity.HasKey(e => new { e.EventGroup, e.Entry })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("event_group_chosen");

                entity.HasComment("Quest Group picked")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.EventGroup)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("eventGroup")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<GameEventStatus>(entity =>
            {
                entity.HasKey(e => e.Event)
                    .HasName("PRIMARY");

                entity.ToTable("game_event_status");

                entity.HasComment("Game event system")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Event)
                    .HasColumnType("smallint(6) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("event");
            });

            modelBuilder.Entity<GameobjectRespawn>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Instance })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("gameobject_respawn");

                entity.HasComment("Grid Loading System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasIndex(e => e.Instance, "instance");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guid")
                    .HasComment("Global Unique Identifier");

                entity.Property(e => e.Instance)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("instance")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Respawntime)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("respawntime");
            });

            modelBuilder.Entity<GmSurvey>(entity =>
            {
                entity.HasKey(e => e.Ticketid)
                    .HasName("PRIMARY");

                entity.ToTable("gm_surveys");

                entity.HasComment("GM Tickets System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Ticketid)
                    .HasColumnType("int(11) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("ticketid")
                    .HasComment("GM Ticket's unique identifier");

                entity.Property(e => e.Answer1)
                    .HasColumnType("tinyint(2) unsigned")
                    .HasColumnName("answer1");

                entity.Property(e => e.Answer10)
                    .HasColumnType("tinyint(2) unsigned")
                    .HasColumnName("answer10");

                entity.Property(e => e.Answer2)
                    .HasColumnType("tinyint(2) unsigned")
                    .HasColumnName("answer2");

                entity.Property(e => e.Answer3)
                    .HasColumnType("tinyint(2) unsigned")
                    .HasColumnName("answer3");

                entity.Property(e => e.Answer4)
                    .HasColumnType("tinyint(2) unsigned")
                    .HasColumnName("answer4");

                entity.Property(e => e.Answer5)
                    .HasColumnType("tinyint(2) unsigned")
                    .HasColumnName("answer5");

                entity.Property(e => e.Answer6)
                    .HasColumnType("tinyint(2) unsigned")
                    .HasColumnName("answer6");

                entity.Property(e => e.Answer7)
                    .HasColumnType("tinyint(2) unsigned")
                    .HasColumnName("answer7");

                entity.Property(e => e.Answer8)
                    .HasColumnType("tinyint(2) unsigned")
                    .HasColumnName("answer8");

                entity.Property(e => e.Answer9)
                    .HasColumnType("tinyint(2) unsigned")
                    .HasColumnName("answer9");

                entity.Property(e => e.Comment)
                    .HasColumnType("text")
                    .HasColumnName("comment")
                    .HasComment("Player's feedback");

                entity.Property(e => e.Surveyid)
                    .HasColumnType("int(2) unsigned")
                    .HasColumnName("surveyid")
                    .HasComment("Survey DBC entry's identifier");
            });

            modelBuilder.Entity<GmTicket>(entity =>
            {
                entity.ToTable("gm_tickets");

                entity.HasComment("GM Tickets System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("id")
                    .HasComment("GM Ticket's unique identifier");

                entity.Property(e => e.Answered)
                    .HasColumnType("bigint(40) unsigned")
                    .HasColumnName("answered")
                    .HasComment("Timestamp: ticket's last time answered by a GM");

                entity.Property(e => e.AssigneeGuid)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("assignee_guid")
                    .HasComment("Assignee's character's Global Unique Identifier");

                entity.Property(e => e.AssigneeName)
                    .HasMaxLength(12)
                    .HasColumnName("assignee_name")
                    .HasDefaultValueSql("''")
                    .HasComment("Assignee's character's name");

                entity.Property(e => e.AuthorGuid)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("author_guid")
                    .HasComment("Player's character Global Unique Identifier");

                entity.Property(e => e.AuthorName)
                    .HasMaxLength(12)
                    .HasColumnName("author_name")
                    .HasComment("Player's character name");

                entity.Property(e => e.Category)
                    .HasColumnType("tinyint(2) unsigned")
                    .HasColumnName("category")
                    .HasComment("GM Ticket Category DBC entry's identifier");

                entity.Property(e => e.Closed)
                    .HasColumnType("bigint(40) unsigned")
                    .HasColumnName("closed")
                    .HasComment("Timestamp: ticket closed by a GM");

                entity.Property(e => e.Conclusion)
                    .HasMaxLength(255)
                    .HasColumnName("conclusion")
                    .HasDefaultValueSql("''")
                    .HasComment("Assignee's final conclusion on this ticket");

                entity.Property(e => e.Created)
                    .HasColumnType("bigint(40) unsigned")
                    .HasColumnName("created")
                    .HasComment("Timestamp: ticket created by a player");

                entity.Property(e => e.Level)
                    .HasColumnType("tinyint(1) unsigned")
                    .HasColumnName("level")
                    .HasComment("Ticket's security level");

                entity.Property(e => e.Locale)
                    .HasMaxLength(4)
                    .HasColumnName("locale")
                    .HasDefaultValueSql("'enUS'")
                    .HasComment("Player's client locale name");

                entity.Property(e => e.Mapid)
                    .HasColumnType("int(4) unsigned")
                    .HasColumnName("mapid")
                    .HasComment("Character's map identifier on submission");

                entity.Property(e => e.Notes)
                    .HasMaxLength(10000)
                    .HasColumnName("notes")
                    .HasDefaultValueSql("''")
                    .HasComment("Additional notes for GMs");

                entity.Property(e => e.O)
                    .HasColumnName("o")
                    .HasComment("Character's orientation angle on submission");

                entity.Property(e => e.Seen)
                    .HasColumnType("bigint(40) unsigned")
                    .HasColumnName("seen")
                    .HasComment("Timestamp: ticket's last time opened by a GM");

                entity.Property(e => e.State)
                    .HasColumnType("tinyint(1) unsigned")
                    .HasColumnName("state")
                    .HasComment("Ticket's current state");

                entity.Property(e => e.Status)
                    .HasColumnType("tinyint(1) unsigned")
                    .HasColumnName("status")
                    .HasComment("Ticket's current status");

                entity.Property(e => e.Text)
                    .HasColumnType("text")
                    .HasColumnName("text")
                    .HasComment("Ticket's message");

                entity.Property(e => e.Updated)
                    .HasColumnType("bigint(40) unsigned")
                    .HasColumnName("updated")
                    .HasComment("Timestamp: ticket text's last update");

                entity.Property(e => e.X)
                    .HasColumnName("x")
                    .HasComment("Character's x coordinate on submission");

                entity.Property(e => e.Y)
                    .HasColumnName("y")
                    .HasComment("Character's y coordinate on submission");

                entity.Property(e => e.Z)
                    .HasColumnName("z")
                    .HasComment("Character's z coordinate on submission");
            });

            modelBuilder.Entity<Group>(entity =>
            {
                entity.ToTable("groups");

                entity.HasComment("Groups")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasIndex(e => e.LeaderGuid, "leaderGuid")
                    .IsUnique();

                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("groupId");

                entity.Property(e => e.Difficulty)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("difficulty");

                entity.Property(e => e.Icon1)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("icon1");

                entity.Property(e => e.Icon2)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("icon2");

                entity.Property(e => e.Icon3)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("icon3");

                entity.Property(e => e.Icon4)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("icon4");

                entity.Property(e => e.Icon5)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("icon5");

                entity.Property(e => e.Icon6)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("icon6");

                entity.Property(e => e.Icon7)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("icon7");

                entity.Property(e => e.Icon8)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("icon8");

                entity.Property(e => e.IsRaid)
                    .HasColumnType("tinyint(1) unsigned")
                    .HasColumnName("isRaid");

                entity.Property(e => e.LeaderGuid)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("leaderGuid");

                entity.Property(e => e.LootMethod)
                    .HasColumnType("tinyint(4) unsigned")
                    .HasColumnName("lootMethod");

                entity.Property(e => e.LootThreshold)
                    .HasColumnType("tinyint(4) unsigned")
                    .HasColumnName("lootThreshold");

                entity.Property(e => e.LooterGuid)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("looterGuid");

                entity.Property(e => e.MainAssistant)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("mainAssistant");

                entity.Property(e => e.MainTank)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("mainTank");
            });

            modelBuilder.Entity<GroupInstance>(entity =>
            {
                entity.HasKey(e => new { e.LeaderGuid, e.Instance })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("group_instance");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasIndex(e => e.Instance, "instance");

                entity.Property(e => e.LeaderGuid)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("leaderGuid");

                entity.Property(e => e.Instance)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("instance");

                entity.Property(e => e.Permanent)
                    .HasColumnType("tinyint(1) unsigned")
                    .HasColumnName("permanent");
            });

            modelBuilder.Entity<GroupMember>(entity =>
            {
                entity.HasKey(e => new { e.GroupId, e.MemberGuid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("group_member");

                entity.HasComment("Groups")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasIndex(e => e.MemberGuid, "Idx_memberGuid");

                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("groupId");

                entity.Property(e => e.MemberGuid)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("memberGuid");

                entity.Property(e => e.Assistant)
                    .HasColumnType("tinyint(1) unsigned")
                    .HasColumnName("assistant");

                entity.Property(e => e.Subgroup)
                    .HasColumnType("smallint(6) unsigned")
                    .HasColumnName("subgroup");
            });

            modelBuilder.Entity<Guild>(entity =>
            {
                entity.ToTable("guild");

                entity.HasComment("Guild System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Guildid)
                    .HasColumnType("int(6) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("guildid");

                entity.Property(e => e.BackgroundColor).HasColumnType("int(5)");

                entity.Property(e => e.BankMoney).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.BorderColor).HasColumnType("int(5)");

                entity.Property(e => e.BorderStyle).HasColumnType("int(5)");

                entity.Property(e => e.Createdate)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("createdate");

                entity.Property(e => e.EmblemColor).HasColumnType("int(5)");

                entity.Property(e => e.EmblemStyle).HasColumnType("int(5)");

                entity.Property(e => e.Info)
                    .HasMaxLength(500)
                    .HasColumnName("info")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Leaderguid)
                    .HasColumnType("int(6) unsigned")
                    .HasColumnName("leaderguid");

                entity.Property(e => e.Motd)
                    .HasMaxLength(128)
                    .HasColumnName("motd")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<GuildBankEventlog>(entity =>
            {
                entity.HasKey(e => new { e.Guildid, e.LogGuid, e.TabId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("guild_bank_eventlog");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasIndex(e => e.LogGuid, "Idx_LogGuid");

                entity.HasIndex(e => e.PlayerGuid, "Idx_PlayerGuid");

                entity.Property(e => e.Guildid)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("guildid")
                    .HasComment("Guild Identificator");

                entity.Property(e => e.LogGuid)
                    .HasColumnType("int(11) unsigned")
                    .HasComment("Log record identificator - auxiliary column");

                entity.Property(e => e.TabId)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasComment("Guild bank TabId");

                entity.Property(e => e.DestTabId)
                    .HasColumnType("tinyint(1) unsigned")
                    .HasComment("Destination Tab Id");

                entity.Property(e => e.EventType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasComment("Event type");

                entity.Property(e => e.ItemOrMoney).HasColumnType("int(11) unsigned");

                entity.Property(e => e.ItemStackCount).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.PlayerGuid).HasColumnType("int(11) unsigned");

                entity.Property(e => e.TimeStamp)
                    .HasColumnType("bigint(20) unsigned")
                    .HasComment("Event UNIX time");
            });

            modelBuilder.Entity<GuildBankItem>(entity =>
            {
                entity.HasKey(e => new { e.Guildid, e.TabId, e.SlotId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("guild_bank_item");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasIndex(e => e.ItemGuid, "Idx_item_guid");

                entity.Property(e => e.Guildid)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("guildid");

                entity.Property(e => e.TabId).HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.SlotId).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.ItemEntry)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("item_entry");

                entity.Property(e => e.ItemGuid)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("item_guid");
            });

            modelBuilder.Entity<GuildBankRight>(entity =>
            {
                entity.HasKey(e => new { e.Guildid, e.TabId, e.Rid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("guild_bank_right");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Guildid)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("guildid");

                entity.Property(e => e.TabId).HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.Rid)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("rid");

                entity.Property(e => e.Gbright)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("gbright");

                entity.Property(e => e.SlotPerDay).HasColumnType("int(11) unsigned");
            });

            modelBuilder.Entity<GuildBankTab>(entity =>
            {
                entity.HasKey(e => new { e.Guildid, e.TabId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("guild_bank_tab");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Guildid)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("guildid");

                entity.Property(e => e.TabId).HasColumnType("tinyint(1) unsigned");

                entity.Property(e => e.TabIcon)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TabName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TabText).HasMaxLength(500);
            });

            modelBuilder.Entity<GuildEventlog>(entity =>
            {
                entity.HasKey(e => new { e.Guildid, e.LogGuid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("guild_eventlog");

                entity.HasComment("Guild Eventlog")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasIndex(e => e.LogGuid, "Idx_LogGuid");

                entity.HasIndex(e => e.PlayerGuid1, "Idx_PlayerGuid1");

                entity.HasIndex(e => e.PlayerGuid2, "Idx_PlayerGuid2");

                entity.Property(e => e.Guildid)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("guildid")
                    .HasComment("Guild Identificator");

                entity.Property(e => e.LogGuid)
                    .HasColumnType("int(11) unsigned")
                    .HasComment("Log record identificator - auxiliary column");

                entity.Property(e => e.EventType)
                    .HasColumnType("tinyint(1) unsigned")
                    .HasComment("Event type");

                entity.Property(e => e.NewRank)
                    .HasColumnType("tinyint(2) unsigned")
                    .HasComment("New rank(in case promotion/demotion)");

                entity.Property(e => e.PlayerGuid1)
                    .HasColumnType("int(11) unsigned")
                    .HasComment("Player 1");

                entity.Property(e => e.PlayerGuid2)
                    .HasColumnType("int(11) unsigned")
                    .HasComment("Player 2");

                entity.Property(e => e.TimeStamp)
                    .HasColumnType("bigint(20) unsigned")
                    .HasComment("Event UNIX time");
            });

            modelBuilder.Entity<GuildMember>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("guild_member");

                entity.HasComment("Guild System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasIndex(e => e.Guid, "guid_key")
                    .IsUnique();

                entity.HasIndex(e => new { e.Guildid, e.Rank }, "guildid_rank_key");

                entity.Property(e => e.BankRemMoney).HasColumnType("int(11) unsigned");

                entity.Property(e => e.BankRemSlotsTab0).HasColumnType("int(11) unsigned");

                entity.Property(e => e.BankRemSlotsTab1).HasColumnType("int(11) unsigned");

                entity.Property(e => e.BankRemSlotsTab2).HasColumnType("int(11) unsigned");

                entity.Property(e => e.BankRemSlotsTab3).HasColumnType("int(11) unsigned");

                entity.Property(e => e.BankRemSlotsTab4).HasColumnType("int(11) unsigned");

                entity.Property(e => e.BankRemSlotsTab5).HasColumnType("int(11) unsigned");

                entity.Property(e => e.BankResetTimeMoney).HasColumnType("int(11) unsigned");

                entity.Property(e => e.BankResetTimeTab0).HasColumnType("int(11) unsigned");

                entity.Property(e => e.BankResetTimeTab1).HasColumnType("int(11) unsigned");

                entity.Property(e => e.BankResetTimeTab2).HasColumnType("int(11) unsigned");

                entity.Property(e => e.BankResetTimeTab3).HasColumnType("int(11) unsigned");

                entity.Property(e => e.BankResetTimeTab4).HasColumnType("int(11) unsigned");

                entity.Property(e => e.BankResetTimeTab5).HasColumnType("int(11) unsigned");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("guid");

                entity.Property(e => e.Guildid)
                    .HasColumnType("int(6) unsigned")
                    .HasColumnName("guildid");

                entity.Property(e => e.Offnote)
                    .HasMaxLength(31)
                    .HasColumnName("offnote")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Pnote)
                    .HasMaxLength(31)
                    .HasColumnName("pnote")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Rank)
                    .HasColumnType("tinyint(2) unsigned")
                    .HasColumnName("rank");
            });

            modelBuilder.Entity<GuildRank>(entity =>
            {
                entity.HasKey(e => new { e.Guildid, e.Rid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("guild_rank");

                entity.HasComment("Guild System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasIndex(e => e.Rid, "Idx_rid");

                entity.Property(e => e.Guildid)
                    .HasColumnType("int(6) unsigned")
                    .HasColumnName("guildid");

                entity.Property(e => e.Rid)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("rid");

                entity.Property(e => e.BankMoneyPerDay).HasColumnType("int(11) unsigned");

                entity.Property(e => e.Rights)
                    .HasColumnType("int(3) unsigned")
                    .HasColumnName("rights");

                entity.Property(e => e.Rname)
                    .HasMaxLength(255)
                    .HasColumnName("rname")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Instance>(entity =>
            {
                entity.ToTable("instance");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasIndex(e => e.Map, "map");

                entity.HasIndex(e => e.Resettime, "resettime");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Data).HasColumnName("data");

                entity.Property(e => e.Difficulty)
                    .HasColumnType("tinyint(1) unsigned")
                    .HasColumnName("difficulty");

                entity.Property(e => e.EncountersMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("encountersMask");

                entity.Property(e => e.Map)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("map");

                entity.Property(e => e.Resettime)
                    .HasColumnType("bigint(40) unsigned")
                    .HasColumnName("resettime");
            });

            modelBuilder.Entity<InstanceReset>(entity =>
            {
                entity.HasKey(e => e.Mapid)
                    .HasName("PRIMARY");

                entity.ToTable("instance_reset");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Mapid)
                    .HasColumnType("int(11) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("mapid");

                entity.Property(e => e.Resettime)
                    .HasColumnType("bigint(40) unsigned")
                    .HasColumnName("resettime");
            });

            modelBuilder.Entity<ItemInstance>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PRIMARY");

                entity.ToTable("item_instance");

                entity.HasComment("Item System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasIndex(e => e.OwnerGuid, "idx_owner_guid");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(11) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("guid");

                entity.Property(e => e.Charges)
                    .HasColumnType("text")
                    .HasColumnName("charges");

                entity.Property(e => e.Count)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("count")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.CreatorGuid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("creatorGuid");

                entity.Property(e => e.Durability)
                    .HasColumnType("int(5) unsigned")
                    .HasColumnName("durability");

                entity.Property(e => e.Duration)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("duration");

                entity.Property(e => e.Enchantments)
                    .HasColumnType("text")
                    .HasColumnName("enchantments");

                entity.Property(e => e.Flags)
                    .HasColumnType("int(8) unsigned")
                    .HasColumnName("flags");

                entity.Property(e => e.GiftCreatorGuid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("giftCreatorGuid");

                entity.Property(e => e.ItemEntry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("itemEntry")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ItemTextId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("itemTextId")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.OwnerGuid)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("owner_guid");

                entity.Property(e => e.RandomPropertyId)
                    .HasColumnType("smallint(5)")
                    .HasColumnName("randomPropertyId");
            });

            modelBuilder.Entity<ItemLoot>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Itemid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("item_loot");

                entity.HasComment("Item System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasIndex(e => e.OwnerGuid, "idx_owner_guid");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("guid");

                entity.Property(e => e.Itemid)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("itemid");

                entity.Property(e => e.Amount)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("amount");

                entity.Property(e => e.OwnerGuid)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("owner_guid");

                entity.Property(e => e.Property)
                    .HasColumnType("int(11)")
                    .HasColumnName("property");

                entity.Property(e => e.Suffix)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("suffix");
            });

            modelBuilder.Entity<ItemText>(entity =>
            {
                entity.ToTable("item_text");

                entity.HasComment("Item System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Text).HasColumnName("text");
            });

            modelBuilder.Entity<Mail>(entity =>
            {
                entity.ToTable("mail");

                entity.HasComment("Mail System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasIndex(e => e.Receiver, "idx_receiver");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("id")
                    .HasComment("Identifier");

                entity.Property(e => e.Checked)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("checked");

                entity.Property(e => e.Cod)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("cod");

                entity.Property(e => e.DeliverTime)
                    .HasColumnType("bigint(40) unsigned")
                    .HasColumnName("deliver_time");

                entity.Property(e => e.ExpireTime)
                    .HasColumnType("bigint(40) unsigned")
                    .HasColumnName("expire_time");

                entity.Property(e => e.HasItems)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("has_items");

                entity.Property(e => e.ItemTextId)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("itemTextId");

                entity.Property(e => e.MailTemplateId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("mailTemplateId")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MessageType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("messageType");

                entity.Property(e => e.Money)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("money");

                entity.Property(e => e.Receiver)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("receiver")
                    .HasComment("Character Global Unique Identifier");

                entity.Property(e => e.Sender)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("sender")
                    .HasComment("Character Global Unique Identifier");

                entity.Property(e => e.Stationery)
                    .HasColumnType("tinyint(3)")
                    .HasColumnName("stationery")
                    .HasDefaultValueSql("'41'");

                entity.Property(e => e.Subject).HasColumnName("subject");
            });

            modelBuilder.Entity<MailItem>(entity =>
            {
                entity.HasKey(e => new { e.MailId, e.ItemGuid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("mail_items");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasIndex(e => e.Receiver, "idx_receiver");

                entity.Property(e => e.MailId)
                    .HasColumnType("int(11)")
                    .HasColumnName("mail_id");

                entity.Property(e => e.ItemGuid)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_guid");

                entity.Property(e => e.ItemTemplate)
                    .HasColumnType("int(11)")
                    .HasColumnName("item_template");

                entity.Property(e => e.Receiver)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("receiver")
                    .HasComment("Character Global Unique Identifier");
            });

            modelBuilder.Entity<PetAura>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.CasterGuid, e.ItemGuid, e.Spell })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

                entity.ToTable("pet_aura");

                entity.HasComment("Pet System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("guid")
                    .HasComment("Global Unique Identifier");

                entity.Property(e => e.CasterGuid)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("caster_guid")
                    .HasComment("Full Global Unique Identifier");

                entity.Property(e => e.ItemGuid)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("item_guid");

                entity.Property(e => e.Spell)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("spell");

                entity.Property(e => e.Basepoints0)
                    .HasColumnType("int(11)")
                    .HasColumnName("basepoints0");

                entity.Property(e => e.Basepoints1)
                    .HasColumnType("int(11)")
                    .HasColumnName("basepoints1");

                entity.Property(e => e.Basepoints2)
                    .HasColumnType("int(11)")
                    .HasColumnName("basepoints2");

                entity.Property(e => e.EffIndexMask)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("effIndexMask");

                entity.Property(e => e.Maxduration)
                    .HasColumnType("int(11)")
                    .HasColumnName("maxduration");

                entity.Property(e => e.Periodictime0)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("periodictime0");

                entity.Property(e => e.Periodictime1)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("periodictime1");

                entity.Property(e => e.Periodictime2)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("periodictime2");

                entity.Property(e => e.Remaincharges)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("remaincharges");

                entity.Property(e => e.Remaintime)
                    .HasColumnType("int(11)")
                    .HasColumnName("remaintime");

                entity.Property(e => e.Stackcount)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("stackcount")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<PetSpell>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Spell })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("pet_spell");

                entity.HasComment("Pet System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("guid")
                    .HasComment("Global Unique Identifier");

                entity.Property(e => e.Spell)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("spell")
                    .HasComment("Spell Identifier");

                entity.Property(e => e.Active)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("active");
            });

            modelBuilder.Entity<PetSpellCooldown>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Spell })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("pet_spell_cooldown");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("guid")
                    .HasComment("Global Unique Identifier, Low part");

                entity.Property(e => e.Spell)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("spell")
                    .HasComment("Spell Identifier");

                entity.Property(e => e.Time)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("time");
            });

            modelBuilder.Entity<Petition>(entity =>
            {
                entity.HasKey(e => new { e.Ownerguid, e.Type })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("petition");

                entity.HasComment("Guild System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasIndex(e => new { e.Ownerguid, e.Petitionguid }, "index_ownerguid_petitionguid")
                    .IsUnique();

                entity.Property(e => e.Ownerguid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("ownerguid");

                entity.Property(e => e.Type)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("type");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Petitionguid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("petitionguid")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PetitionSign>(entity =>
            {
                entity.HasKey(e => new { e.Petitionguid, e.Playerguid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("petition_sign");

                entity.HasComment("Guild System")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.HasIndex(e => e.Ownerguid, "Idx_ownerguid");

                entity.HasIndex(e => e.Playerguid, "Idx_playerguid");

                entity.Property(e => e.Petitionguid)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("petitionguid");

                entity.Property(e => e.Playerguid)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("playerguid");

                entity.Property(e => e.Ownerguid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("ownerguid");

                entity.Property(e => e.PlayerAccount)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("player_account");

                entity.Property(e => e.Type)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("type");
            });

            modelBuilder.Entity<PlayerbotSavedDatum>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PRIMARY");

                entity.ToTable("playerbot_saved_data");

                entity.HasComment("Persistent Playerbot settings per alt")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(11) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("guid");

                entity.Property(e => e.AutoFollow)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("auto_follow")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Autoequip).HasColumnName("autoequip");

                entity.Property(e => e.CombatDelay)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("combat_delay");

                entity.Property(e => e.CombatOrder)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("combat_order");

                entity.Property(e => e.Pname)
                    .HasMaxLength(12)
                    .HasColumnName("pname")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PrimaryTarget)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("primary_target");

                entity.Property(e => e.SecondaryTarget)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("secondary_target");

                entity.Property(e => e.Sname)
                    .HasMaxLength(12)
                    .HasColumnName("sname")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<PvpstatsBattleground>(entity =>
            {
                entity.ToTable("pvpstats_battlegrounds");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.BracketId)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("bracket_id");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("type");

                entity.Property(e => e.WinnerTeam)
                    .HasColumnType("tinyint(3)")
                    .HasColumnName("winner_team");
            });

            modelBuilder.Entity<PvpstatsPlayer>(entity =>
            {
                entity.HasKey(e => new { e.BattlegroundId, e.CharacterGuid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("pvpstats_players");

                entity.Property(e => e.BattlegroundId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("battleground_id");

                entity.Property(e => e.CharacterGuid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("character_guid");

                entity.Property(e => e.Attr1)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("attr_1")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Attr2)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("attr_2")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Attr3)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("attr_3")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Attr4)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("attr_4")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Attr5)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("attr_5")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ScoreBonusHonor)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("score_bonus_honor");

                entity.Property(e => e.ScoreDamageDone)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("score_damage_done");

                entity.Property(e => e.ScoreDeaths)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("score_deaths");

                entity.Property(e => e.ScoreHealingDone)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("score_healing_done");

                entity.Property(e => e.ScoreHonorableKills)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("score_honorable_kills");

                entity.Property(e => e.ScoreKillingBlows)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("score_killing_blows");
            });

            modelBuilder.Entity<SavedVariable>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("saved_variables");

                entity.HasComment("Variable Saves")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.CleaningFlags)
                    .HasColumnType("int(11) unsigned")
                    .HasColumnName("cleaning_flags");

                entity.Property(e => e.NextArenaPointDistributionTime).HasColumnType("bigint(40) unsigned");

                entity.Property(e => e.NextDailyQuestResetTime).HasColumnType("bigint(40) unsigned");

                entity.Property(e => e.NextMonthlyQuestResetTime).HasColumnType("bigint(40) unsigned");

                entity.Property(e => e.NextWeeklyQuestResetTime).HasColumnType("bigint(40) unsigned");
            });

            modelBuilder.Entity<World>(entity =>
            {
                entity.HasKey(e => e.Map)
                    .HasName("PRIMARY");

                entity.ToTable("world");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Map)
                    .HasColumnType("int(11) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("map");

                entity.Property(e => e.Data).HasColumnName("data");
            });

            modelBuilder.Entity<WorldState>(entity =>
            {
                entity.ToTable("world_state");

                entity.HasComment("WorldState save system")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11) unsigned")
                    .ValueGeneratedNever()
                    .HasComment("Internal save ID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
