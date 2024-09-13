using Azuremyst.Models.Acore.Characters;
using Microsoft.EntityFrameworkCore;

namespace Azuremyst.Contexts;

public partial class AcoreCharactersContext : DbContext
{
    public AcoreCharactersContext() { }

    public AcoreCharactersContext(DbContextOptions<AcoreCharactersContext> options)
        : base(options) { }

    public virtual DbSet<AccountDatum> AccountData { get; set; }

    public virtual DbSet<AccountInstanceTime> AccountInstanceTimes { get; set; }

    public virtual DbSet<AccountTutorial> AccountTutorials { get; set; }

    public virtual DbSet<Addon> Addons { get; set; }

    public virtual DbSet<ArenaTeam> ArenaTeams { get; set; }

    public virtual DbSet<ArenaTeamMember> ArenaTeamMembers { get; set; }

    public virtual DbSet<Auctionhouse> Auctionhouses { get; set; }

    public virtual DbSet<BannedAddon> BannedAddons { get; set; }

    public virtual DbSet<BattlegroundDeserter> BattlegroundDeserters { get; set; }

    public virtual DbSet<Bugreport> Bugreports { get; set; }

    public virtual DbSet<CalendarEvent> CalendarEvents { get; set; }

    public virtual DbSet<CalendarInvite> CalendarInvites { get; set; }

    public virtual DbSet<Channel> Channels { get; set; }

    public virtual DbSet<ChannelsBan> ChannelsBans { get; set; }

    public virtual DbSet<ChannelsRight> ChannelsRights { get; set; }

    public virtual DbSet<Character> Characters { get; set; }

    public virtual DbSet<CharacterAccountDatum> CharacterAccountData { get; set; }

    public virtual DbSet<CharacterAchievement> CharacterAchievements { get; set; }

    public virtual DbSet<CharacterAchievementProgress> CharacterAchievementProgresses { get; set; }

    public virtual DbSet<CharacterAction> CharacterActions { get; set; }

    public virtual DbSet<CharacterArenaStat> CharacterArenaStats { get; set; }

    public virtual DbSet<CharacterAura> CharacterAuras { get; set; }

    public virtual DbSet<CharacterBanned> CharacterBanneds { get; set; }

    public virtual DbSet<CharacterBattlegroundRandom> CharacterBattlegroundRandoms { get; set; }

    public virtual DbSet<CharacterBrewOfTheMonth> CharacterBrewOfTheMonths { get; set; }

    public virtual DbSet<CharacterDeclinedname> CharacterDeclinednames { get; set; }

    public virtual DbSet<CharacterEntryPoint> CharacterEntryPoints { get; set; }

    public virtual DbSet<CharacterEquipmentset> CharacterEquipmentsets { get; set; }

    public virtual DbSet<CharacterGift> CharacterGifts { get; set; }

    public virtual DbSet<CharacterGlyph> CharacterGlyphs { get; set; }

    public virtual DbSet<CharacterHomebind> CharacterHomebinds { get; set; }

    public virtual DbSet<CharacterInstance> CharacterInstances { get; set; }

    public virtual DbSet<CharacterInventory> CharacterInventories { get; set; }

    public virtual DbSet<CharacterPet> CharacterPets { get; set; }

    public virtual DbSet<CharacterPetDeclinedname> CharacterPetDeclinednames { get; set; }

    public virtual DbSet<CharacterQueststatus> CharacterQueststatuses { get; set; }

    public virtual DbSet<CharacterQueststatusDaily> CharacterQueststatusDailies { get; set; }

    public virtual DbSet<CharacterQueststatusMonthly> CharacterQueststatusMonthlies { get; set; }

    public virtual DbSet<CharacterQueststatusRewarded> CharacterQueststatusRewardeds { get; set; }

    public virtual DbSet<CharacterQueststatusSeasonal> CharacterQueststatusSeasonals { get; set; }

    public virtual DbSet<CharacterQueststatusWeekly> CharacterQueststatusWeeklies { get; set; }

    public virtual DbSet<CharacterReputation> CharacterReputations { get; set; }

    public virtual DbSet<CharacterSetting> CharacterSettings { get; set; }

    public virtual DbSet<CharacterSkill> CharacterSkills { get; set; }

    public virtual DbSet<CharacterSocial> CharacterSocials { get; set; }

    public virtual DbSet<CharacterSpell> CharacterSpells { get; set; }

    public virtual DbSet<CharacterSpellCooldown> CharacterSpellCooldowns { get; set; }

    public virtual DbSet<CharacterStat> CharacterStats { get; set; }

    public virtual DbSet<CharacterTalent> CharacterTalents { get; set; }

    public virtual DbSet<Corpse> Corpses { get; set; }

    public virtual DbSet<CreatureRespawn> CreatureRespawns { get; set; }

    public virtual DbSet<GameEventConditionSave> GameEventConditionSaves { get; set; }

    public virtual DbSet<GameEventSave> GameEventSaves { get; set; }

    public virtual DbSet<GameobjectRespawn> GameobjectRespawns { get; set; }

    public virtual DbSet<GmSubsurvey> GmSubsurveys { get; set; }

    public virtual DbSet<GmSurvey> GmSurveys { get; set; }

    public virtual DbSet<GmTicket> GmTickets { get; set; }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<GroupMember> GroupMembers { get; set; }

    public virtual DbSet<Guild> Guilds { get; set; }

    public virtual DbSet<GuildBankEventlog> GuildBankEventlogs { get; set; }

    public virtual DbSet<GuildBankItem> GuildBankItems { get; set; }

    public virtual DbSet<GuildBankRight> GuildBankRights { get; set; }

    public virtual DbSet<GuildBankTab> GuildBankTabs { get; set; }

    public virtual DbSet<GuildEventlog> GuildEventlogs { get; set; }

    public virtual DbSet<GuildMember> GuildMembers { get; set; }

    public virtual DbSet<GuildMemberWithdraw> GuildMemberWithdraws { get; set; }

    public virtual DbSet<GuildRank> GuildRanks { get; set; }

    public virtual DbSet<Instance> Instances { get; set; }

    public virtual DbSet<InstanceReset> InstanceResets { get; set; }

    public virtual DbSet<InstanceSavedGoStateDatum> InstanceSavedGoStateData { get; set; }

    public virtual DbSet<ItemInstance> ItemInstances { get; set; }

    public virtual DbSet<ItemLootStorage> ItemLootStorages { get; set; }

    public virtual DbSet<ItemRefundInstance> ItemRefundInstances { get; set; }

    public virtual DbSet<ItemSoulboundTradeDatum> ItemSoulboundTradeData { get; set; }

    public virtual DbSet<LagReport> LagReports { get; set; }

    public virtual DbSet<LfgDatum> LfgData { get; set; }

    public virtual DbSet<LogArenaFight> LogArenaFights { get; set; }

    public virtual DbSet<LogArenaMemberstat> LogArenaMemberstats { get; set; }

    public virtual DbSet<LogEncounter> LogEncounters { get; set; }

    public virtual DbSet<LogMoney> LogMoneys { get; set; }

    public virtual DbSet<Mail> Mail { get; set; }

    public virtual DbSet<MailItem> MailItems { get; set; }

    public virtual DbSet<MailServerCharacter> MailServerCharacters { get; set; }

    public virtual DbSet<MailServerTemplate> MailServerTemplates { get; set; }

    public virtual DbSet<PetAura> PetAuras { get; set; }

    public virtual DbSet<PetSpell> PetSpells { get; set; }

    public virtual DbSet<PetSpellCooldown> PetSpellCooldowns { get; set; }

    public virtual DbSet<Petition> Petitions { get; set; }

    public virtual DbSet<PetitionSign> PetitionSigns { get; set; }

    public virtual DbSet<PoolQuestSave> PoolQuestSaves { get; set; }

    public virtual DbSet<ProfanityName> ProfanityNames { get; set; }

    public virtual DbSet<PvpstatsBattleground> PvpstatsBattlegrounds { get; set; }

    public virtual DbSet<PvpstatsPlayer> PvpstatsPlayers { get; set; }

    public virtual DbSet<QuestTracker> QuestTrackers { get; set; }

    public virtual DbSet<RecoveryItem> RecoveryItems { get; set; }

    public virtual DbSet<ReservedName> ReservedNames { get; set; }

    public virtual DbSet<Update> Updates { get; set; }

    public virtual DbSet<UpdatesInclude> UpdatesIncludes { get; set; }

    public virtual DbSet<WardenAction> WardenActions { get; set; }

    public virtual DbSet<Worldstate> Worldstates { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AccountDatum>(entity =>
        {
            entity.HasKey(e => new { e.AccountId, e.Type }).HasName("PRIMARY");

            entity.ToTable("account_data");

            entity
                .Property(e => e.AccountId)
                .HasComment("Account Identifier")
                .HasColumnName("accountId");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Data).HasColumnType("blob").HasColumnName("data");
            entity.Property(e => e.Time).HasColumnName("time");
        });

        modelBuilder.Entity<AccountInstanceTime>(entity =>
        {
            entity.HasKey(e => new { e.AccountId, e.InstanceId }).HasName("PRIMARY");

            entity.ToTable("account_instance_times");

            entity.Property(e => e.AccountId).HasColumnName("accountId");
            entity.Property(e => e.InstanceId).HasColumnName("instanceId");
            entity.Property(e => e.ReleaseTime).HasColumnName("releaseTime");
        });

        modelBuilder.Entity<AccountTutorial>(entity =>
        {
            entity.HasKey(e => e.AccountId).HasName("PRIMARY");

            entity.ToTable("account_tutorial", tb => tb.HasComment("Player System"));

            entity
                .Property(e => e.AccountId)
                .HasComment("Account Identifier")
                .HasColumnName("accountId");
            entity.Property(e => e.Tut0).HasColumnName("tut0");
            entity.Property(e => e.Tut1).HasColumnName("tut1");
            entity.Property(e => e.Tut2).HasColumnName("tut2");
            entity.Property(e => e.Tut3).HasColumnName("tut3");
            entity.Property(e => e.Tut4).HasColumnName("tut4");
            entity.Property(e => e.Tut5).HasColumnName("tut5");
            entity.Property(e => e.Tut6).HasColumnName("tut6");
            entity.Property(e => e.Tut7).HasColumnName("tut7");
        });

        modelBuilder.Entity<Addon>(entity =>
        {
            entity.HasKey(e => e.Name).HasName("PRIMARY");

            entity.ToTable("addons", tb => tb.HasComment("Addons"));

            entity
                .Property(e => e.Name)
                .HasMaxLength(120)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
            entity.Property(e => e.Crc).HasColumnName("crc");
        });

        modelBuilder.Entity<ArenaTeam>(entity =>
        {
            entity.HasKey(e => e.ArenaTeamId).HasName("PRIMARY");

            entity.ToTable("arena_team");

            entity.Property(e => e.ArenaTeamId).HasColumnName("arenaTeamId");
            entity.Property(e => e.BackgroundColor).HasColumnName("backgroundColor");
            entity.Property(e => e.BorderColor).HasColumnName("borderColor");
            entity.Property(e => e.BorderStyle).HasColumnName("borderStyle");
            entity.Property(e => e.CaptainGuid).HasColumnName("captainGuid");
            entity.Property(e => e.EmblemColor).HasColumnName("emblemColor");
            entity.Property(e => e.EmblemStyle).HasColumnName("emblemStyle");
            entity.Property(e => e.Name).HasMaxLength(24).HasColumnName("name");
            entity.Property(e => e.Rank).HasColumnName("rank");
            entity.Property(e => e.Rating).HasColumnName("rating");
            entity.Property(e => e.SeasonGames).HasColumnName("seasonGames");
            entity.Property(e => e.SeasonWins).HasColumnName("seasonWins");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.WeekGames).HasColumnName("weekGames");
            entity.Property(e => e.WeekWins).HasColumnName("weekWins");
        });

        modelBuilder.Entity<ArenaTeamMember>(entity =>
        {
            entity.HasKey(e => new { e.ArenaTeamId, e.Guid }).HasName("PRIMARY");

            entity.ToTable("arena_team_member");

            entity.Property(e => e.ArenaTeamId).HasColumnName("arenaTeamId");
            entity.Property(e => e.Guid).HasColumnName("guid");
            entity.Property(e => e.PersonalRating).HasColumnName("personalRating");
            entity.Property(e => e.SeasonGames).HasColumnName("seasonGames");
            entity.Property(e => e.SeasonWins).HasColumnName("seasonWins");
            entity.Property(e => e.WeekGames).HasColumnName("weekGames");
            entity.Property(e => e.WeekWins).HasColumnName("weekWins");
        });

        modelBuilder.Entity<Auctionhouse>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("auctionhouse");

            entity.HasIndex(e => e.Itemguid, "item_guid").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Buyguid).HasColumnName("buyguid");
            entity.Property(e => e.Buyoutprice).HasColumnName("buyoutprice");
            entity.Property(e => e.Deposit).HasColumnName("deposit");
            entity.Property(e => e.Houseid).HasDefaultValueSql("'7'").HasColumnName("houseid");
            entity.Property(e => e.Itemguid).HasColumnName("itemguid");
            entity.Property(e => e.Itemowner).HasColumnName("itemowner");
            entity.Property(e => e.Lastbid).HasColumnName("lastbid");
            entity.Property(e => e.Startbid).HasColumnName("startbid");
            entity.Property(e => e.Time).HasColumnName("time");
        });

        modelBuilder.Entity<BannedAddon>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("banned_addons");

            entity.HasIndex(e => new { e.Name, e.Version }, "idx_name_ver").IsUnique();

            entity
                .Property(e => e.Timestamp)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp");
            entity.Property(e => e.Version).HasDefaultValueSql("''");
        });

        modelBuilder.Entity<BattlegroundDeserter>(entity =>
        {
            entity.HasNoKey().ToTable("battleground_deserters");

            entity
                .Property(e => e.Datetime)
                .HasComment("datetime of the desertion")
                .HasColumnType("datetime")
                .HasColumnName("datetime");
            entity.Property(e => e.Guid).HasComment("characters.guid").HasColumnName("guid");
            entity.Property(e => e.Type).HasComment("type of the desertion").HasColumnName("type");
        });

        modelBuilder.Entity<Bugreport>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("bugreport", tb => tb.HasComment("Debug System"));

            entity.Property(e => e.Id).HasComment("Identifier").HasColumnName("id");
            entity.Property(e => e.Content).HasColumnName("content");
            entity.Property(e => e.Type).HasColumnName("type");
        });

        modelBuilder.Entity<CalendarEvent>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("calendar_events");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Creator).HasColumnName("creator");
            entity
                .Property(e => e.Description)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("description");
            entity.Property(e => e.Dungeon).HasDefaultValueSql("'-1'").HasColumnName("dungeon");
            entity.Property(e => e.Eventtime).HasColumnName("eventtime");
            entity.Property(e => e.Flags).HasColumnName("flags");
            entity.Property(e => e.Time2).HasColumnName("time2");
            entity
                .Property(e => e.Title)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("title");
            entity.Property(e => e.Type).HasDefaultValueSql("'4'").HasColumnName("type");
        });

        modelBuilder.Entity<CalendarInvite>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("calendar_invites");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Event).HasColumnName("event");
            entity.Property(e => e.Invitee).HasColumnName("invitee");
            entity.Property(e => e.Rank).HasColumnName("rank");
            entity.Property(e => e.Sender).HasColumnName("sender");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Statustime).HasColumnName("statustime");
            entity
                .Property(e => e.Text)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("text");
        });

        modelBuilder.Entity<Channel>(entity =>
        {
            entity.HasKey(e => e.ChannelId).HasName("PRIMARY");

            entity.ToTable("channels", tb => tb.HasComment("Channel System"));

            entity.Property(e => e.ChannelId).HasColumnName("channelId");
            entity.Property(e => e.Announce).HasDefaultValueSql("'1'").HasColumnName("announce");
            entity.Property(e => e.LastUsed).HasColumnName("lastUsed");
            entity.Property(e => e.Name).HasMaxLength(128).HasColumnName("name");
            entity.Property(e => e.Ownership).HasDefaultValueSql("'1'").HasColumnName("ownership");
            entity.Property(e => e.Password).HasMaxLength(32).HasColumnName("password");
            entity.Property(e => e.Team).HasColumnName("team");
        });

        modelBuilder.Entity<ChannelsBan>(entity =>
        {
            entity.HasKey(e => new { e.ChannelId, e.PlayerGuid }).HasName("PRIMARY");

            entity.ToTable("channels_bans");

            entity.Property(e => e.ChannelId).HasColumnName("channelId");
            entity.Property(e => e.PlayerGuid).HasColumnName("playerGUID");
            entity.Property(e => e.BanTime).HasColumnName("banTime");
        });

        modelBuilder.Entity<ChannelsRight>(entity =>
        {
            entity.HasKey(e => e.Name).HasName("PRIMARY");

            entity.ToTable("channels_rights");

            entity.Property(e => e.Name).HasMaxLength(128).HasColumnName("name");
            entity
                .Property(e => e.Delaymessage)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("delaymessage");
            entity.Property(e => e.Flags).HasColumnName("flags");
            entity
                .Property(e => e.Joinmessage)
                .HasMaxLength(255)
                .HasDefaultValueSql("''")
                .HasColumnName("joinmessage");
            entity.Property(e => e.Moderators).HasColumnType("text").HasColumnName("moderators");
            entity.Property(e => e.Speakdelay).HasColumnName("speakdelay");
        });

        modelBuilder.Entity<Character>(entity =>
        {
            entity.HasKey(e => e.Guid).HasName("PRIMARY");

            entity.ToTable("characters", tb => tb.HasComment("Player System"));

            entity.HasIndex(e => e.Account, "idx_account");

            entity.HasIndex(e => e.Name, "idx_name");

            entity.HasIndex(e => e.Online, "idx_online");

            entity
                .Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            entity
                .Property(e => e.Account)
                .HasComment("Account Identifier")
                .HasColumnName("account");
            entity.Property(e => e.ActionBars).HasColumnName("actionBars");
            entity.Property(e => e.ActiveTalentGroup).HasColumnName("activeTalentGroup");
            entity.Property(e => e.AmmoId).HasColumnName("ammoId");
            entity.Property(e => e.ArenaPoints).HasColumnName("arenaPoints");
            entity.Property(e => e.AtLogin).HasColumnName("at_login");
            entity.Property(e => e.BankSlots).HasColumnName("bankSlots");
            entity.Property(e => e.ChosenTitle).HasColumnName("chosenTitle");
            entity.Property(e => e.Cinematic).HasColumnName("cinematic");
            entity.Property(e => e.Class).HasColumnName("class");
            entity
                .Property(e => e.CreationDate)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp")
                .HasColumnName("creation_date");
            entity.Property(e => e.DeathExpireTime).HasColumnName("death_expire_time");
            entity.Property(e => e.DeleteDate).HasColumnName("deleteDate");
            entity.Property(e => e.DeleteInfosAccount).HasColumnName("deleteInfos_Account");
            entity
                .Property(e => e.DeleteInfosName)
                .HasMaxLength(12)
                .HasColumnName("deleteInfos_Name");
            entity.Property(e => e.Drunk).HasColumnName("drunk");
            entity.Property(e => e.EquipmentCache).HasColumnName("equipmentCache");
            entity.Property(e => e.ExploredZones).HasColumnName("exploredZones");
            entity.Property(e => e.ExtraBonusTalentCount).HasColumnName("extraBonusTalentCount");
            entity.Property(e => e.ExtraFlags).HasColumnName("extra_flags");
            entity.Property(e => e.Face).HasColumnName("face");
            entity.Property(e => e.FacialStyle).HasColumnName("facialStyle");
            entity.Property(e => e.Gender).HasColumnName("gender");
            entity.Property(e => e.GrantableLevels).HasColumnName("grantableLevels");
            entity.Property(e => e.HairColor).HasColumnName("hairColor");
            entity.Property(e => e.HairStyle).HasColumnName("hairStyle");
            entity.Property(e => e.Health).HasColumnName("health");
            entity.Property(e => e.InnTriggerId).HasColumnName("innTriggerId");
            entity.Property(e => e.InstanceId).HasColumnName("instance_id");
            entity.Property(e => e.InstanceModeMask).HasColumnName("instance_mode_mask");
            entity.Property(e => e.IsLogoutResting).HasColumnName("is_logout_resting");
            entity.Property(e => e.KnownCurrencies).HasColumnName("knownCurrencies");
            entity.Property(e => e.KnownTitles).HasColumnName("knownTitles");
            entity.Property(e => e.Latency).HasDefaultValueSql("'0'").HasColumnName("latency");
            entity.Property(e => e.Level).HasColumnName("level");
            entity.Property(e => e.Leveltime).HasColumnName("leveltime");
            entity.Property(e => e.LogoutTime).HasColumnName("logout_time");
            entity.Property(e => e.Map).HasComment("Map Identifier").HasColumnName("map");
            entity.Property(e => e.Money).HasColumnName("money");
            entity.Property(e => e.Name).HasMaxLength(12).HasColumnName("name");
            entity.Property(e => e.Online).HasColumnName("online");
            entity.Property(e => e.Order).HasColumnName("order");
            entity.Property(e => e.Orientation).HasColumnName("orientation");
            entity.Property(e => e.PlayerFlags).HasColumnName("playerFlags");
            entity.Property(e => e.PositionX).HasColumnName("position_x");
            entity.Property(e => e.PositionY).HasColumnName("position_y");
            entity.Property(e => e.PositionZ).HasColumnName("position_z");
            entity.Property(e => e.Power1).HasColumnName("power1");
            entity.Property(e => e.Power2).HasColumnName("power2");
            entity.Property(e => e.Power3).HasColumnName("power3");
            entity.Property(e => e.Power4).HasColumnName("power4");
            entity.Property(e => e.Power5).HasColumnName("power5");
            entity.Property(e => e.Power6).HasColumnName("power6");
            entity.Property(e => e.Power7).HasColumnName("power7");
            entity.Property(e => e.Race).HasColumnName("race");
            entity.Property(e => e.ResettalentsCost).HasColumnName("resettalents_cost");
            entity.Property(e => e.ResettalentsTime).HasColumnName("resettalents_time");
            entity.Property(e => e.RestBonus).HasColumnName("rest_bonus");
            entity.Property(e => e.RestState).HasColumnName("restState");
            entity.Property(e => e.Skin).HasColumnName("skin");
            entity.Property(e => e.StableSlots).HasColumnName("stable_slots");
            entity
                .Property(e => e.TalentGroupsCount)
                .HasDefaultValueSql("'1'")
                .HasColumnName("talentGroupsCount");
            entity.Property(e => e.TaxiPath).HasColumnType("text").HasColumnName("taxi_path");
            entity.Property(e => e.Taximask).HasColumnType("text").HasColumnName("taximask");
            entity.Property(e => e.TodayHonorPoints).HasColumnName("todayHonorPoints");
            entity.Property(e => e.TodayKills).HasColumnName("todayKills");
            entity.Property(e => e.TotalHonorPoints).HasColumnName("totalHonorPoints");
            entity.Property(e => e.TotalKills).HasColumnName("totalKills");
            entity.Property(e => e.Totaltime).HasColumnName("totaltime");
            entity.Property(e => e.TransO).HasColumnName("trans_o");
            entity.Property(e => e.TransX).HasColumnName("trans_x");
            entity.Property(e => e.TransY).HasColumnName("trans_y");
            entity.Property(e => e.TransZ).HasColumnName("trans_z");
            entity.Property(e => e.Transguid).HasDefaultValueSql("'0'").HasColumnName("transguid");
            entity.Property(e => e.WatchedFaction).HasColumnName("watchedFaction");
            entity.Property(e => e.Xp).HasColumnName("xp");
            entity.Property(e => e.YesterdayHonorPoints).HasColumnName("yesterdayHonorPoints");
            entity.Property(e => e.YesterdayKills).HasColumnName("yesterdayKills");
            entity.Property(e => e.Zone).HasColumnName("zone");
        });

        modelBuilder.Entity<CharacterAccountDatum>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.Type }).HasName("PRIMARY");

            entity.ToTable("character_account_data");

            entity.Property(e => e.Guid).HasColumnName("guid");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Data).HasColumnType("blob").HasColumnName("data");
            entity.Property(e => e.Time).HasColumnName("time");
        });

        modelBuilder.Entity<CharacterAchievement>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.Achievement }).HasName("PRIMARY");

            entity.ToTable("character_achievement");

            entity.Property(e => e.Guid).HasColumnName("guid");
            entity.Property(e => e.Achievement).HasColumnName("achievement");
            entity.Property(e => e.Date).HasColumnName("date");
        });

        modelBuilder.Entity<CharacterAchievementProgress>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.Criteria }).HasName("PRIMARY");

            entity.ToTable("character_achievement_progress");

            entity.Property(e => e.Guid).HasColumnName("guid");
            entity.Property(e => e.Criteria).HasColumnName("criteria");
            entity.Property(e => e.Counter).HasColumnName("counter");
            entity.Property(e => e.Date).HasColumnName("date");
        });

        modelBuilder.Entity<CharacterAction>(entity =>
        {
            entity
                .HasKey(e => new
                {
                    e.Guid,
                    e.Spec,
                    e.Button
                })
                .HasName("PRIMARY");

            entity.ToTable("character_action");

            entity.Property(e => e.Guid).HasColumnName("guid");
            entity.Property(e => e.Spec).HasColumnName("spec");
            entity.Property(e => e.Button).HasColumnName("button");
            entity.Property(e => e.Action).HasColumnName("action");
            entity.Property(e => e.Type).HasColumnName("type");
        });

        modelBuilder.Entity<CharacterArenaStat>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.Slot }).HasName("PRIMARY");

            entity.ToTable("character_arena_stats");

            entity.Property(e => e.Guid).HasColumnName("guid");
            entity.Property(e => e.Slot).HasColumnName("slot");
            entity.Property(e => e.MatchMakerRating).HasColumnName("matchMakerRating");
            entity.Property(e => e.MaxMmr).HasColumnName("maxMMR");
        });

        modelBuilder.Entity<CharacterAura>(entity =>
        {
            entity
                .HasKey(e => new
                {
                    e.Guid,
                    e.CasterGuid,
                    e.ItemGuid,
                    e.Spell,
                    e.EffectMask
                })
                .HasName("PRIMARY");

            entity.ToTable("character_aura", tb => tb.HasComment("Player System"));

            entity
                .Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            entity
                .Property(e => e.CasterGuid)
                .HasComment("Full Global Unique Identifier")
                .HasColumnName("casterGuid");
            entity.Property(e => e.ItemGuid).HasColumnName("itemGuid");
            entity.Property(e => e.Spell).HasColumnName("spell");
            entity.Property(e => e.EffectMask).HasColumnName("effectMask");
            entity.Property(e => e.Amount0).HasColumnName("amount0");
            entity.Property(e => e.Amount1).HasColumnName("amount1");
            entity.Property(e => e.Amount2).HasColumnName("amount2");
            entity.Property(e => e.BaseAmount0).HasColumnName("base_amount0");
            entity.Property(e => e.BaseAmount1).HasColumnName("base_amount1");
            entity.Property(e => e.BaseAmount2).HasColumnName("base_amount2");
            entity.Property(e => e.MaxDuration).HasColumnName("maxDuration");
            entity.Property(e => e.RecalculateMask).HasColumnName("recalculateMask");
            entity.Property(e => e.RemainCharges).HasColumnName("remainCharges");
            entity.Property(e => e.RemainTime).HasColumnName("remainTime");
            entity
                .Property(e => e.StackCount)
                .HasDefaultValueSql("'1'")
                .HasColumnName("stackCount");
        });

        modelBuilder.Entity<CharacterBanned>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.Bandate }).HasName("PRIMARY");

            entity.ToTable("character_banned", tb => tb.HasComment("Ban List"));

            entity
                .Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            entity.Property(e => e.Bandate).HasColumnName("bandate");
            entity.Property(e => e.Active).HasDefaultValueSql("'1'").HasColumnName("active");
            entity.Property(e => e.Bannedby).HasMaxLength(50).HasColumnName("bannedby");
            entity.Property(e => e.Banreason).HasMaxLength(255).HasColumnName("banreason");
            entity.Property(e => e.Unbandate).HasColumnName("unbandate");
        });

        modelBuilder.Entity<CharacterBattlegroundRandom>(entity =>
        {
            entity.HasKey(e => e.Guid).HasName("PRIMARY");

            entity.ToTable("character_battleground_random");

            entity.Property(e => e.Guid).HasColumnName("guid");
        });

        modelBuilder.Entity<CharacterBrewOfTheMonth>(entity =>
        {
            entity.HasKey(e => e.Guid).HasName("PRIMARY");

            entity.ToTable("character_brew_of_the_month");

            entity.Property(e => e.Guid).HasColumnName("guid");
            entity.Property(e => e.LastEventId).HasColumnName("lastEventId");
        });

        modelBuilder.Entity<CharacterDeclinedname>(entity =>
        {
            entity.HasKey(e => e.Guid).HasName("PRIMARY");

            entity.ToTable("character_declinedname");

            entity
                .Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            entity
                .Property(e => e.Accusative)
                .HasMaxLength(15)
                .HasDefaultValueSql("''")
                .HasColumnName("accusative");
            entity
                .Property(e => e.Dative)
                .HasMaxLength(15)
                .HasDefaultValueSql("''")
                .HasColumnName("dative");
            entity
                .Property(e => e.Genitive)
                .HasMaxLength(15)
                .HasDefaultValueSql("''")
                .HasColumnName("genitive");
            entity
                .Property(e => e.Instrumental)
                .HasMaxLength(15)
                .HasDefaultValueSql("''")
                .HasColumnName("instrumental");
            entity
                .Property(e => e.Prepositional)
                .HasMaxLength(15)
                .HasDefaultValueSql("''")
                .HasColumnName("prepositional");
        });

        modelBuilder.Entity<CharacterEntryPoint>(entity =>
        {
            entity.HasKey(e => e.Guid).HasName("PRIMARY");

            entity.ToTable("character_entry_point", tb => tb.HasComment("Player System"));

            entity
                .Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            entity
                .Property(e => e.JoinMapId)
                .HasComment("Map Identifier")
                .HasColumnName("joinMapId");
            entity.Property(e => e.JoinO).HasColumnName("joinO");
            entity.Property(e => e.JoinX).HasColumnName("joinX");
            entity.Property(e => e.JoinY).HasColumnName("joinY");
            entity.Property(e => e.JoinZ).HasColumnName("joinZ");
            entity.Property(e => e.MountSpell).HasColumnName("mountSpell");
            entity.Property(e => e.TaxiPath0).HasColumnName("taxiPath0");
            entity.Property(e => e.TaxiPath1).HasColumnName("taxiPath1");
        });

        modelBuilder.Entity<CharacterEquipmentset>(entity =>
        {
            entity.HasKey(e => e.Setguid).HasName("PRIMARY");

            entity.ToTable("character_equipmentsets");

            entity.HasIndex(e => e.Setindex, "Idx_setindex");

            entity
                .HasIndex(
                    e => new
                    {
                        e.Guid,
                        e.Setguid,
                        e.Setindex
                    },
                    "idx_set"
                )
                .IsUnique();

            entity.Property(e => e.Setguid).HasColumnName("setguid");
            entity.Property(e => e.Guid).HasColumnName("guid");
            entity.Property(e => e.Iconname).HasMaxLength(100).HasColumnName("iconname");
            entity.Property(e => e.IgnoreMask).HasColumnName("ignore_mask");
            entity.Property(e => e.Item0).HasColumnName("item0");
            entity.Property(e => e.Item1).HasColumnName("item1");
            entity.Property(e => e.Item10).HasColumnName("item10");
            entity.Property(e => e.Item11).HasColumnName("item11");
            entity.Property(e => e.Item12).HasColumnName("item12");
            entity.Property(e => e.Item13).HasColumnName("item13");
            entity.Property(e => e.Item14).HasColumnName("item14");
            entity.Property(e => e.Item15).HasColumnName("item15");
            entity.Property(e => e.Item16).HasColumnName("item16");
            entity.Property(e => e.Item17).HasColumnName("item17");
            entity.Property(e => e.Item18).HasColumnName("item18");
            entity.Property(e => e.Item2).HasColumnName("item2");
            entity.Property(e => e.Item3).HasColumnName("item3");
            entity.Property(e => e.Item4).HasColumnName("item4");
            entity.Property(e => e.Item5).HasColumnName("item5");
            entity.Property(e => e.Item6).HasColumnName("item6");
            entity.Property(e => e.Item7).HasColumnName("item7");
            entity.Property(e => e.Item8).HasColumnName("item8");
            entity.Property(e => e.Item9).HasColumnName("item9");
            entity.Property(e => e.Name).HasMaxLength(31).HasColumnName("name");
            entity.Property(e => e.Setindex).HasColumnName("setindex");
        });

        modelBuilder.Entity<CharacterGift>(entity =>
        {
            entity.HasKey(e => e.ItemGuid).HasName("PRIMARY");

            entity.ToTable("character_gifts");

            entity.HasIndex(e => e.Guid, "idx_guid");

            entity.Property(e => e.ItemGuid).HasColumnName("item_guid");
            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.Flags).HasColumnName("flags");
            entity.Property(e => e.Guid).HasColumnName("guid");
        });

        modelBuilder.Entity<CharacterGlyph>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.TalentGroup }).HasName("PRIMARY");

            entity.ToTable("character_glyphs");

            entity.Property(e => e.Guid).HasColumnName("guid");
            entity.Property(e => e.TalentGroup).HasColumnName("talentGroup");
            entity.Property(e => e.Glyph1).HasDefaultValueSql("'0'").HasColumnName("glyph1");
            entity.Property(e => e.Glyph2).HasDefaultValueSql("'0'").HasColumnName("glyph2");
            entity.Property(e => e.Glyph3).HasDefaultValueSql("'0'").HasColumnName("glyph3");
            entity.Property(e => e.Glyph4).HasDefaultValueSql("'0'").HasColumnName("glyph4");
            entity.Property(e => e.Glyph5).HasDefaultValueSql("'0'").HasColumnName("glyph5");
            entity.Property(e => e.Glyph6).HasDefaultValueSql("'0'").HasColumnName("glyph6");
        });

        modelBuilder.Entity<CharacterHomebind>(entity =>
        {
            entity.HasKey(e => e.Guid).HasName("PRIMARY");

            entity.ToTable("character_homebind", tb => tb.HasComment("Player System"));

            entity
                .Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            entity.Property(e => e.MapId).HasComment("Map Identifier").HasColumnName("mapId");
            entity.Property(e => e.PosO).HasColumnName("posO");
            entity.Property(e => e.PosX).HasColumnName("posX");
            entity.Property(e => e.PosY).HasColumnName("posY");
            entity.Property(e => e.PosZ).HasColumnName("posZ");
            entity.Property(e => e.ZoneId).HasComment("Zone Identifier").HasColumnName("zoneId");
        });

        modelBuilder.Entity<CharacterInstance>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.Instance }).HasName("PRIMARY");

            entity.ToTable("character_instance");

            entity.HasIndex(e => e.Instance, "instance");

            entity.Property(e => e.Guid).HasColumnName("guid");
            entity.Property(e => e.Instance).HasColumnName("instance");
            entity.Property(e => e.Extended).HasColumnName("extended");
            entity.Property(e => e.Permanent).HasColumnName("permanent");
        });

        modelBuilder.Entity<CharacterInventory>(entity =>
        {
            entity.HasKey(e => e.Item).HasName("PRIMARY");

            entity.ToTable("character_inventory", tb => tb.HasComment("Player System"));

            entity
                .HasIndex(
                    e => new
                    {
                        e.Guid,
                        e.Bag,
                        e.Slot
                    },
                    "guid"
                )
                .IsUnique();

            entity.HasIndex(e => e.Guid, "idx_guid");

            entity
                .Property(e => e.Item)
                .HasComment("Item Global Unique Identifier")
                .HasColumnName("item");
            entity.Property(e => e.Bag).HasColumnName("bag");
            entity
                .Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            entity.Property(e => e.Slot).HasColumnName("slot");
        });

        modelBuilder.Entity<CharacterPet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("character_pet", tb => tb.HasComment("Pet System"));

            entity.HasIndex(e => e.Slot, "idx_slot");

            entity.HasIndex(e => e.Owner, "owner");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Abdata).HasColumnType("text").HasColumnName("abdata");
            entity.Property(e => e.CreatedBySpell).HasDefaultValueSql("'0'");
            entity.Property(e => e.Curhappiness).HasColumnName("curhappiness");
            entity.Property(e => e.Curhealth).HasDefaultValueSql("'1'").HasColumnName("curhealth");
            entity.Property(e => e.Curmana).HasColumnName("curmana");
            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.Exp).HasColumnName("exp");
            entity.Property(e => e.Level).HasDefaultValueSql("'1'").HasColumnName("level");
            entity.Property(e => e.Modelid).HasDefaultValueSql("'0'").HasColumnName("modelid");
            entity
                .Property(e => e.Name)
                .HasMaxLength(21)
                .HasDefaultValueSql("'Pet'")
                .HasColumnName("name");
            entity.Property(e => e.Owner).HasColumnName("owner");
            entity.Property(e => e.Renamed).HasColumnName("renamed");
            entity.Property(e => e.Savetime).HasColumnName("savetime");
            entity.Property(e => e.Slot).HasColumnName("slot");
        });

        modelBuilder.Entity<CharacterPetDeclinedname>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("character_pet_declinedname");

            entity.HasIndex(e => e.Owner, "owner_key");

            entity.Property(e => e.Id).HasColumnName("id");
            entity
                .Property(e => e.Accusative)
                .HasMaxLength(12)
                .HasDefaultValueSql("''")
                .HasColumnName("accusative");
            entity
                .Property(e => e.Dative)
                .HasMaxLength(12)
                .HasDefaultValueSql("''")
                .HasColumnName("dative");
            entity
                .Property(e => e.Genitive)
                .HasMaxLength(12)
                .HasDefaultValueSql("''")
                .HasColumnName("genitive");
            entity
                .Property(e => e.Instrumental)
                .HasMaxLength(12)
                .HasDefaultValueSql("''")
                .HasColumnName("instrumental");
            entity.Property(e => e.Owner).HasColumnName("owner");
            entity
                .Property(e => e.Prepositional)
                .HasMaxLength(12)
                .HasDefaultValueSql("''")
                .HasColumnName("prepositional");
        });

        modelBuilder.Entity<CharacterQueststatus>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.Quest }).HasName("PRIMARY");

            entity.ToTable("character_queststatus", tb => tb.HasComment("Player System"));

            entity
                .Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            entity.Property(e => e.Quest).HasComment("Quest Identifier").HasColumnName("quest");
            entity.Property(e => e.Explored).HasColumnName("explored");
            entity.Property(e => e.Itemcount1).HasColumnName("itemcount1");
            entity.Property(e => e.Itemcount2).HasColumnName("itemcount2");
            entity.Property(e => e.Itemcount3).HasColumnName("itemcount3");
            entity.Property(e => e.Itemcount4).HasColumnName("itemcount4");
            entity.Property(e => e.Itemcount5).HasColumnName("itemcount5");
            entity.Property(e => e.Itemcount6).HasColumnName("itemcount6");
            entity.Property(e => e.Mobcount1).HasColumnName("mobcount1");
            entity.Property(e => e.Mobcount2).HasColumnName("mobcount2");
            entity.Property(e => e.Mobcount3).HasColumnName("mobcount3");
            entity.Property(e => e.Mobcount4).HasColumnName("mobcount4");
            entity.Property(e => e.Playercount).HasColumnName("playercount");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Timer).HasColumnName("timer");
        });

        modelBuilder.Entity<CharacterQueststatusDaily>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.Quest }).HasName("PRIMARY");

            entity.ToTable("character_queststatus_daily", tb => tb.HasComment("Player System"));

            entity.HasIndex(e => e.Guid, "idx_guid");

            entity
                .Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            entity.Property(e => e.Quest).HasComment("Quest Identifier").HasColumnName("quest");
            entity.Property(e => e.Time).HasColumnName("time");
        });

        modelBuilder.Entity<CharacterQueststatusMonthly>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.Quest }).HasName("PRIMARY");

            entity.ToTable("character_queststatus_monthly", tb => tb.HasComment("Player System"));

            entity.HasIndex(e => e.Guid, "idx_guid");

            entity
                .Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            entity.Property(e => e.Quest).HasComment("Quest Identifier").HasColumnName("quest");
        });

        modelBuilder.Entity<CharacterQueststatusRewarded>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.Quest }).HasName("PRIMARY");

            entity.ToTable("character_queststatus_rewarded", tb => tb.HasComment("Player System"));

            entity
                .Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            entity.Property(e => e.Quest).HasComment("Quest Identifier").HasColumnName("quest");
            entity.Property(e => e.Active).HasDefaultValueSql("'1'").HasColumnName("active");
        });

        modelBuilder.Entity<CharacterQueststatusSeasonal>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.Quest }).HasName("PRIMARY");

            entity.ToTable("character_queststatus_seasonal", tb => tb.HasComment("Player System"));

            entity.HasIndex(e => e.Guid, "idx_guid");

            entity
                .Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            entity.Property(e => e.Quest).HasComment("Quest Identifier").HasColumnName("quest");
            entity.Property(e => e.Event).HasComment("Event Identifier").HasColumnName("event");
        });

        modelBuilder.Entity<CharacterQueststatusWeekly>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.Quest }).HasName("PRIMARY");

            entity.ToTable("character_queststatus_weekly", tb => tb.HasComment("Player System"));

            entity.HasIndex(e => e.Guid, "idx_guid");

            entity
                .Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            entity.Property(e => e.Quest).HasComment("Quest Identifier").HasColumnName("quest");
        });

        modelBuilder.Entity<CharacterReputation>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.Faction }).HasName("PRIMARY");

            entity.ToTable("character_reputation", tb => tb.HasComment("Player System"));

            entity
                .Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            entity.Property(e => e.Faction).HasColumnName("faction");
            entity.Property(e => e.Flags).HasColumnName("flags");
            entity.Property(e => e.Standing).HasColumnName("standing");
        });

        modelBuilder.Entity<CharacterSetting>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.Source }).HasName("PRIMARY");

            entity.ToTable("character_settings", tb => tb.HasComment("Player Settings"));

            entity.Property(e => e.Guid).HasColumnName("guid");
            entity.Property(e => e.Source).HasMaxLength(40).HasColumnName("source");
            entity.Property(e => e.Data).HasColumnType("text").HasColumnName("data");
        });

        modelBuilder.Entity<CharacterSkill>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.Skill }).HasName("PRIMARY");

            entity.ToTable("character_skills", tb => tb.HasComment("Player System"));

            entity
                .Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            entity.Property(e => e.Skill).HasColumnName("skill");
            entity.Property(e => e.Max).HasColumnName("max");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        modelBuilder.Entity<CharacterSocial>(entity =>
        {
            entity
                .HasKey(e => new
                {
                    e.Guid,
                    e.Friend,
                    e.Flags
                })
                .HasName("PRIMARY");

            entity.ToTable("character_social", tb => tb.HasComment("Player System"));

            entity.HasIndex(e => e.Friend, "friend");

            entity
                .Property(e => e.Guid)
                .HasComment("Character Global Unique Identifier")
                .HasColumnName("guid");
            entity
                .Property(e => e.Friend)
                .HasComment("Friend Global Unique Identifier")
                .HasColumnName("friend");
            entity.Property(e => e.Flags).HasComment("Friend Flags").HasColumnName("flags");
            entity
                .Property(e => e.Note)
                .HasMaxLength(48)
                .HasDefaultValueSql("''")
                .HasComment("Friend Note")
                .HasColumnName("note");
        });

        modelBuilder.Entity<CharacterSpell>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.Spell }).HasName("PRIMARY");

            entity.ToTable("character_spell", tb => tb.HasComment("Player System"));

            entity
                .Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            entity.Property(e => e.Spell).HasComment("Spell Identifier").HasColumnName("spell");
            entity.Property(e => e.SpecMask).HasDefaultValueSql("'1'").HasColumnName("specMask");
        });

        modelBuilder.Entity<CharacterSpellCooldown>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.Spell }).HasName("PRIMARY");

            entity.ToTable("character_spell_cooldown");

            entity
                .Property(e => e.Guid)
                .HasComment("Global Unique Identifier, Low part")
                .HasColumnName("guid");
            entity.Property(e => e.Spell).HasComment("Spell Identifier").HasColumnName("spell");
            entity.Property(e => e.Category).HasDefaultValueSql("'0'").HasColumnName("category");
            entity.Property(e => e.Item).HasComment("Item Identifier").HasColumnName("item");
            entity.Property(e => e.NeedSend).HasDefaultValueSql("'1'").HasColumnName("needSend");
            entity.Property(e => e.Time).HasColumnName("time");
        });

        modelBuilder.Entity<CharacterStat>(entity =>
        {
            entity.HasKey(e => e.Guid).HasName("PRIMARY");

            entity.ToTable("character_stats");

            entity
                .Property(e => e.Guid)
                .HasComment("Global Unique Identifier, Low part")
                .HasColumnName("guid");
            entity.Property(e => e.Agility).HasColumnName("agility");
            entity.Property(e => e.Armor).HasColumnName("armor");
            entity.Property(e => e.AttackPower).HasColumnName("attackPower");
            entity.Property(e => e.BlockPct).HasColumnName("blockPct");
            entity.Property(e => e.CritPct).HasColumnName("critPct");
            entity.Property(e => e.DodgePct).HasColumnName("dodgePct");
            entity.Property(e => e.Intellect).HasColumnName("intellect");
            entity.Property(e => e.Maxhealth).HasColumnName("maxhealth");
            entity.Property(e => e.Maxpower1).HasColumnName("maxpower1");
            entity.Property(e => e.Maxpower2).HasColumnName("maxpower2");
            entity.Property(e => e.Maxpower3).HasColumnName("maxpower3");
            entity.Property(e => e.Maxpower4).HasColumnName("maxpower4");
            entity.Property(e => e.Maxpower5).HasColumnName("maxpower5");
            entity.Property(e => e.Maxpower6).HasColumnName("maxpower6");
            entity.Property(e => e.Maxpower7).HasColumnName("maxpower7");
            entity.Property(e => e.ParryPct).HasColumnName("parryPct");
            entity.Property(e => e.RangedAttackPower).HasColumnName("rangedAttackPower");
            entity.Property(e => e.RangedCritPct).HasColumnName("rangedCritPct");
            entity.Property(e => e.ResArcane).HasColumnName("resArcane");
            entity.Property(e => e.ResFire).HasColumnName("resFire");
            entity.Property(e => e.ResFrost).HasColumnName("resFrost");
            entity.Property(e => e.ResHoly).HasColumnName("resHoly");
            entity.Property(e => e.ResNature).HasColumnName("resNature");
            entity.Property(e => e.ResShadow).HasColumnName("resShadow");
            entity.Property(e => e.Resilience).HasColumnName("resilience");
            entity.Property(e => e.SpellCritPct).HasColumnName("spellCritPct");
            entity.Property(e => e.SpellPower).HasColumnName("spellPower");
            entity.Property(e => e.Spirit).HasColumnName("spirit");
            entity.Property(e => e.Stamina).HasColumnName("stamina");
            entity.Property(e => e.Strength).HasColumnName("strength");
        });

        modelBuilder.Entity<CharacterTalent>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.Spell }).HasName("PRIMARY");

            entity.ToTable("character_talent");

            entity.Property(e => e.Guid).HasColumnName("guid");
            entity.Property(e => e.Spell).HasColumnName("spell");
            entity.Property(e => e.SpecMask).HasColumnName("specMask");
        });

        modelBuilder.Entity<Corpse>(entity =>
        {
            entity.HasKey(e => e.Guid).HasName("PRIMARY");

            entity.ToTable("corpse", tb => tb.HasComment("Death System"));

            entity.HasIndex(e => e.InstanceId, "idx_instance");

            entity.HasIndex(e => e.Time, "idx_time");

            entity.HasIndex(e => e.CorpseType, "idx_type");

            entity
                .Property(e => e.Guid)
                .HasComment("Character Global Unique Identifier")
                .HasColumnName("guid");
            entity.Property(e => e.Bytes1).HasColumnName("bytes1");
            entity.Property(e => e.Bytes2).HasColumnName("bytes2");
            entity.Property(e => e.CorpseType).HasColumnName("corpseType");
            entity.Property(e => e.DisplayId).HasColumnName("displayId");
            entity.Property(e => e.DynFlags).HasColumnName("dynFlags");
            entity.Property(e => e.Flags).HasColumnName("flags");
            entity.Property(e => e.GuildId).HasColumnName("guildId");
            entity
                .Property(e => e.InstanceId)
                .HasComment("Instance Identifier")
                .HasColumnName("instanceId");
            entity.Property(e => e.ItemCache).HasColumnType("text").HasColumnName("itemCache");
            entity.Property(e => e.MapId).HasComment("Map Identifier").HasColumnName("mapId");
            entity.Property(e => e.Orientation).HasColumnName("orientation");
            entity.Property(e => e.PhaseMask).HasDefaultValueSql("'1'").HasColumnName("phaseMask");
            entity.Property(e => e.PosX).HasColumnName("posX");
            entity.Property(e => e.PosY).HasColumnName("posY");
            entity.Property(e => e.PosZ).HasColumnName("posZ");
            entity.Property(e => e.Time).HasColumnName("time");
        });

        modelBuilder.Entity<CreatureRespawn>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.InstanceId }).HasName("PRIMARY");

            entity.ToTable("creature_respawn", tb => tb.HasComment("Grid Loading System"));

            entity.HasIndex(e => e.InstanceId, "idx_instance");

            entity
                .Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            entity
                .Property(e => e.InstanceId)
                .HasComment("Instance Identifier")
                .HasColumnName("instanceId");
            entity.Property(e => e.MapId).HasColumnName("mapId");
            entity.Property(e => e.RespawnTime).HasColumnName("respawnTime");
        });

        modelBuilder.Entity<GameEventConditionSave>(entity =>
        {
            entity.HasKey(e => new { e.EventEntry, e.ConditionId }).HasName("PRIMARY");

            entity.ToTable("game_event_condition_save");

            entity.Property(e => e.EventEntry).HasColumnName("eventEntry");
            entity.Property(e => e.ConditionId).HasColumnName("condition_id");
            entity.Property(e => e.Done).HasDefaultValueSql("'0'").HasColumnName("done");
        });

        modelBuilder.Entity<GameEventSave>(entity =>
        {
            entity.HasKey(e => e.EventEntry).HasName("PRIMARY");

            entity.ToTable("game_event_save");

            entity.Property(e => e.EventEntry).HasColumnName("eventEntry");
            entity.Property(e => e.NextStart).HasColumnName("next_start");
            entity.Property(e => e.State).HasDefaultValueSql("'1'").HasColumnName("state");
        });

        modelBuilder.Entity<GameobjectRespawn>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.InstanceId }).HasName("PRIMARY");

            entity.ToTable("gameobject_respawn", tb => tb.HasComment("Grid Loading System"));

            entity.HasIndex(e => e.InstanceId, "idx_instance");

            entity
                .Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            entity
                .Property(e => e.InstanceId)
                .HasComment("Instance Identifier")
                .HasColumnName("instanceId");
            entity.Property(e => e.MapId).HasColumnName("mapId");
            entity.Property(e => e.RespawnTime).HasColumnName("respawnTime");
        });

        modelBuilder.Entity<GmSubsurvey>(entity =>
        {
            entity.HasKey(e => new { e.SurveyId, e.QuestionId }).HasName("PRIMARY");

            entity.ToTable("gm_subsurvey", tb => tb.HasComment("Player System"));

            entity.Property(e => e.SurveyId).ValueGeneratedOnAdd().HasColumnName("surveyId");
            entity.Property(e => e.QuestionId).HasColumnName("questionId");
            entity.Property(e => e.Answer).HasColumnName("answer");
            entity
                .Property(e => e.AnswerComment)
                .HasColumnType("text")
                .HasColumnName("answerComment");
        });

        modelBuilder.Entity<GmSurvey>(entity =>
        {
            entity.HasKey(e => e.SurveyId).HasName("PRIMARY");

            entity.ToTable("gm_survey", tb => tb.HasComment("Player System"));

            entity.Property(e => e.SurveyId).HasColumnName("surveyId");
            entity.Property(e => e.Comment).HasColumnName("comment");
            entity.Property(e => e.CreateTime).HasColumnName("createTime");
            entity.Property(e => e.Guid).HasColumnName("guid");
            entity.Property(e => e.MainSurvey).HasColumnName("mainSurvey");
            entity.Property(e => e.MaxMmr).HasColumnName("maxMMR");
        });

        modelBuilder.Entity<GmTicket>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("gm_ticket", tb => tb.HasComment("Player System"));

            entity.Property(e => e.Id).HasColumnName("id");
            entity
                .Property(e => e.AssignedTo)
                .HasComment("GUID of admin to whom ticket is assigned")
                .HasColumnName("assignedTo");
            entity
                .Property(e => e.ClosedBy)
                .HasComment("-1 Closed by Console, >0 GUID of GM")
                .HasColumnName("closedBy");
            entity.Property(e => e.Comment).HasColumnType("text").HasColumnName("comment");
            entity.Property(e => e.Completed).HasColumnName("completed");
            entity.Property(e => e.CreateTime).HasColumnName("createTime");
            entity.Property(e => e.Description).HasColumnType("text").HasColumnName("description");
            entity.Property(e => e.Escalated).HasColumnName("escalated");
            entity.Property(e => e.LastModifiedTime).HasColumnName("lastModifiedTime");
            entity.Property(e => e.MapId).HasColumnName("mapId");
            entity
                .Property(e => e.Name)
                .HasMaxLength(12)
                .HasComment("Name of ticket creator")
                .HasColumnName("name");
            entity.Property(e => e.NeedMoreHelp).HasColumnName("needMoreHelp");
            entity
                .Property(e => e.PlayerGuid)
                .HasComment("Global Unique Identifier of ticket creator")
                .HasColumnName("playerGuid");
            entity.Property(e => e.PosX).HasColumnName("posX");
            entity.Property(e => e.PosY).HasColumnName("posY");
            entity.Property(e => e.PosZ).HasColumnName("posZ");
            entity
                .Property(e => e.ResolvedBy)
                .HasComment("-1 Resolved by Console, >0 GUID of GM")
                .HasColumnName("resolvedBy");
            entity.Property(e => e.Response).HasColumnType("text").HasColumnName("response");
            entity
                .Property(e => e.Type)
                .HasComment("0 open, 1 closed, 2 character deleted")
                .HasColumnName("type");
            entity.Property(e => e.Viewed).HasColumnName("viewed");
        });

        modelBuilder.Entity<Group>(entity =>
        {
            entity.HasKey(e => e.Guid).HasName("PRIMARY");

            entity.ToTable("groups", tb => tb.HasComment("Groups"));

            entity.HasIndex(e => e.LeaderGuid, "leaderGuid");

            entity.Property(e => e.Guid).HasColumnName("guid");
            entity.Property(e => e.Difficulty).HasColumnName("difficulty");
            entity.Property(e => e.GroupType).HasColumnName("groupType");
            entity.Property(e => e.Icon1).HasColumnName("icon1");
            entity.Property(e => e.Icon2).HasColumnName("icon2");
            entity.Property(e => e.Icon3).HasColumnName("icon3");
            entity.Property(e => e.Icon4).HasColumnName("icon4");
            entity.Property(e => e.Icon5).HasColumnName("icon5");
            entity.Property(e => e.Icon6).HasColumnName("icon6");
            entity.Property(e => e.Icon7).HasColumnName("icon7");
            entity.Property(e => e.Icon8).HasColumnName("icon8");
            entity.Property(e => e.LeaderGuid).HasColumnName("leaderGuid");
            entity.Property(e => e.LootMethod).HasColumnName("lootMethod");
            entity.Property(e => e.LootThreshold).HasColumnName("lootThreshold");
            entity.Property(e => e.LooterGuid).HasColumnName("looterGuid");
            entity.Property(e => e.MasterLooterGuid).HasColumnName("masterLooterGuid");
            entity.Property(e => e.RaidDifficulty).HasColumnName("raidDifficulty");
        });

        modelBuilder.Entity<GroupMember>(entity =>
        {
            entity.HasKey(e => e.MemberGuid).HasName("PRIMARY");

            entity.ToTable("group_member", tb => tb.HasComment("Groups"));

            entity.Property(e => e.MemberGuid).HasColumnName("memberGuid");
            entity.Property(e => e.Guid).HasColumnName("guid");
            entity.Property(e => e.MemberFlags).HasColumnName("memberFlags");
            entity.Property(e => e.Roles).HasColumnName("roles");
            entity.Property(e => e.Subgroup).HasColumnName("subgroup");
        });

        modelBuilder.Entity<Guild>(entity =>
        {
            entity.HasKey(e => e.Guildid).HasName("PRIMARY");

            entity.ToTable("guild", tb => tb.HasComment("Guild System"));

            entity.Property(e => e.Guildid).HasColumnName("guildid");
            entity.Property(e => e.Createdate).HasColumnName("createdate");
            entity
                .Property(e => e.Info)
                .HasMaxLength(500)
                .HasDefaultValueSql("''")
                .HasColumnName("info");
            entity.Property(e => e.Leaderguid).HasColumnName("leaderguid");
            entity
                .Property(e => e.Motd)
                .HasMaxLength(128)
                .HasDefaultValueSql("''")
                .HasColumnName("motd");
            entity
                .Property(e => e.Name)
                .HasMaxLength(24)
                .HasDefaultValueSql("''")
                .HasColumnName("name");
        });

        modelBuilder.Entity<GuildBankEventlog>(entity =>
        {
            entity
                .HasKey(e => new
                {
                    e.Guildid,
                    e.LogGuid,
                    e.TabId
                })
                .HasName("PRIMARY");

            entity.ToTable("guild_bank_eventlog");

            entity.HasIndex(e => e.LogGuid, "Idx_LogGuid");

            entity.HasIndex(e => e.PlayerGuid, "Idx_PlayerGuid");

            entity.HasIndex(e => e.Guildid, "guildid_key");

            entity
                .Property(e => e.Guildid)
                .HasComment("Guild Identificator")
                .HasColumnName("guildid");
            entity
                .Property(e => e.LogGuid)
                .HasComment("Log record identificator - auxiliary column");
            entity.Property(e => e.TabId).HasComment("Guild bank TabId");
            entity.Property(e => e.DestTabId).HasComment("Destination Tab Id");
            entity.Property(e => e.EventType).HasComment("Event type");
            entity.Property(e => e.TimeStamp).HasComment("Event UNIX time");
        });

        modelBuilder.Entity<GuildBankItem>(entity =>
        {
            entity
                .HasKey(e => new
                {
                    e.Guildid,
                    e.TabId,
                    e.SlotId
                })
                .HasName("PRIMARY");

            entity.ToTable("guild_bank_item");

            entity.HasIndex(e => e.ItemGuid, "Idx_item_guid");

            entity.HasIndex(e => e.Guildid, "guildid_key");

            entity.Property(e => e.Guildid).HasColumnName("guildid");
            entity.Property(e => e.ItemGuid).HasColumnName("item_guid");
        });

        modelBuilder.Entity<GuildBankRight>(entity =>
        {
            entity
                .HasKey(e => new
                {
                    e.Guildid,
                    e.TabId,
                    e.Rid
                })
                .HasName("PRIMARY");

            entity.ToTable("guild_bank_right");

            entity.HasIndex(e => e.Guildid, "guildid_key");

            entity.Property(e => e.Guildid).HasColumnName("guildid");
            entity.Property(e => e.Rid).HasColumnName("rid");
            entity.Property(e => e.Gbright).HasColumnName("gbright");
        });

        modelBuilder.Entity<GuildBankTab>(entity =>
        {
            entity.HasKey(e => new { e.Guildid, e.TabId }).HasName("PRIMARY");

            entity.ToTable("guild_bank_tab");

            entity.HasIndex(e => e.Guildid, "guildid_key");

            entity.Property(e => e.Guildid).HasColumnName("guildid");
            entity.Property(e => e.TabIcon).HasMaxLength(100).HasDefaultValueSql("''");
            entity.Property(e => e.TabName).HasMaxLength(16).HasDefaultValueSql("''");
            entity.Property(e => e.TabText).HasMaxLength(500);
        });

        modelBuilder.Entity<GuildEventlog>(entity =>
        {
            entity.HasKey(e => new { e.Guildid, e.LogGuid }).HasName("PRIMARY");

            entity.ToTable("guild_eventlog", tb => tb.HasComment("Guild Eventlog"));

            entity.HasIndex(e => e.LogGuid, "Idx_LogGuid");

            entity.HasIndex(e => e.PlayerGuid1, "Idx_PlayerGuid1");

            entity.HasIndex(e => e.PlayerGuid2, "Idx_PlayerGuid2");

            entity
                .Property(e => e.Guildid)
                .HasComment("Guild Identificator")
                .HasColumnName("guildid");
            entity
                .Property(e => e.LogGuid)
                .HasComment("Log record identificator - auxiliary column");
            entity.Property(e => e.EventType).HasComment("Event type");
            entity.Property(e => e.NewRank).HasComment("New rank(in case promotion/demotion)");
            entity.Property(e => e.PlayerGuid1).HasComment("Player 1");
            entity.Property(e => e.PlayerGuid2).HasComment("Player 2");
            entity.Property(e => e.TimeStamp).HasComment("Event UNIX time");
        });

        modelBuilder.Entity<GuildMember>(entity =>
        {
            entity.HasNoKey().ToTable("guild_member", tb => tb.HasComment("Guild System"));

            entity.HasIndex(e => e.Guid, "guid_key").IsUnique();

            entity.HasIndex(e => e.Guildid, "guildid_key");

            entity.HasIndex(e => new { e.Guildid, e.Rank }, "guildid_rank_key");

            entity.Property(e => e.Guid).HasColumnName("guid");
            entity
                .Property(e => e.Guildid)
                .HasComment("Guild Identificator")
                .HasColumnName("guildid");
            entity
                .Property(e => e.Offnote)
                .HasMaxLength(31)
                .HasDefaultValueSql("''")
                .HasColumnName("offnote");
            entity
                .Property(e => e.Pnote)
                .HasMaxLength(31)
                .HasDefaultValueSql("''")
                .HasColumnName("pnote");
            entity.Property(e => e.Rank).HasColumnName("rank");
        });

        modelBuilder.Entity<GuildMemberWithdraw>(entity =>
        {
            entity.HasKey(e => e.Guid).HasName("PRIMARY");

            entity.ToTable(
                "guild_member_withdraw",
                tb => tb.HasComment("Guild Member Daily Withdraws")
            );

            entity.Property(e => e.Guid).HasColumnName("guid");
            entity.Property(e => e.Money).HasColumnName("money");
            entity.Property(e => e.Tab0).HasColumnName("tab0");
            entity.Property(e => e.Tab1).HasColumnName("tab1");
            entity.Property(e => e.Tab2).HasColumnName("tab2");
            entity.Property(e => e.Tab3).HasColumnName("tab3");
            entity.Property(e => e.Tab4).HasColumnName("tab4");
            entity.Property(e => e.Tab5).HasColumnName("tab5");
        });

        modelBuilder.Entity<GuildRank>(entity =>
        {
            entity.HasKey(e => new { e.Guildid, e.Rid }).HasName("PRIMARY");

            entity.ToTable("guild_rank", tb => tb.HasComment("Guild System"));

            entity.HasIndex(e => e.Rid, "Idx_rid");

            entity.Property(e => e.Guildid).HasColumnName("guildid");
            entity.Property(e => e.Rid).HasColumnName("rid");
            entity.Property(e => e.Rights).HasDefaultValueSql("'0'").HasColumnName("rights");
            entity
                .Property(e => e.Rname)
                .HasMaxLength(20)
                .HasDefaultValueSql("''")
                .HasColumnName("rname");
        });

        modelBuilder.Entity<Instance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("instance");

            entity.HasIndex(e => e.Difficulty, "difficulty");

            entity.HasIndex(e => e.Map, "map");

            entity.HasIndex(e => e.Resettime, "resettime");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CompletedEncounters).HasColumnName("completedEncounters");
            entity.Property(e => e.Data).HasColumnType("tinytext").HasColumnName("data");
            entity.Property(e => e.Difficulty).HasColumnName("difficulty");
            entity.Property(e => e.Map).HasColumnName("map");
            entity.Property(e => e.Resettime).HasColumnName("resettime");
        });

        modelBuilder.Entity<InstanceReset>(entity =>
        {
            entity.HasKey(e => new { e.Mapid, e.Difficulty }).HasName("PRIMARY");

            entity.ToTable("instance_reset");

            entity.HasIndex(e => e.Difficulty, "difficulty");

            entity.Property(e => e.Mapid).HasColumnName("mapid");
            entity.Property(e => e.Difficulty).HasColumnName("difficulty");
            entity.Property(e => e.Resettime).HasColumnName("resettime");
        });

        modelBuilder.Entity<InstanceSavedGoStateDatum>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.Guid }).HasName("PRIMARY");

            entity.ToTable("instance_saved_go_state_data");

            entity.Property(e => e.Id).HasComment("instance.id").HasColumnName("id");
            entity.Property(e => e.Guid).HasComment("gameobject.guid").HasColumnName("guid");
            entity
                .Property(e => e.State)
                .HasDefaultValueSql("'0'")
                .HasComment("gameobject.state")
                .HasColumnName("state");
        });

        modelBuilder.Entity<ItemInstance>(entity =>
        {
            entity.HasKey(e => e.Guid).HasName("PRIMARY");

            entity.ToTable("item_instance", tb => tb.HasComment("Item System"));

            entity.HasIndex(e => e.OwnerGuid, "idx_owner_guid");

            entity.Property(e => e.Guid).HasColumnName("guid");
            entity.Property(e => e.Charges).HasColumnType("tinytext").HasColumnName("charges");
            entity.Property(e => e.Count).HasDefaultValueSql("'1'").HasColumnName("count");
            entity.Property(e => e.CreatorGuid).HasColumnName("creatorGuid");
            entity.Property(e => e.Durability).HasColumnName("durability");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity
                .Property(e => e.Enchantments)
                .HasColumnType("text")
                .HasColumnName("enchantments");
            entity.Property(e => e.Flags).HasDefaultValueSql("'0'").HasColumnName("flags");
            entity.Property(e => e.GiftCreatorGuid).HasColumnName("giftCreatorGuid");
            entity.Property(e => e.ItemEntry).HasDefaultValueSql("'0'").HasColumnName("itemEntry");
            entity.Property(e => e.OwnerGuid).HasColumnName("owner_guid");
            entity.Property(e => e.PlayedTime).HasColumnName("playedTime");
            entity.Property(e => e.RandomPropertyId).HasColumnName("randomPropertyId");
            entity.Property(e => e.Text).HasColumnType("text").HasColumnName("text");
        });

        modelBuilder.Entity<ItemLootStorage>(entity =>
        {
            entity.HasNoKey().ToTable("item_loot_storage");

            entity.Property(e => e.ConditionLootId).HasColumnName("conditionLootId");
            entity.Property(e => e.ContainerGuid).HasColumnName("containerGUID");
            entity.Property(e => e.Count).HasColumnName("count");
            entity.Property(e => e.FollowLootRules).HasColumnName("follow_loot_rules");
            entity.Property(e => e.Freeforall).HasColumnName("freeforall");
            entity.Property(e => e.IsBlocked).HasColumnName("is_blocked");
            entity.Property(e => e.IsCounted).HasColumnName("is_counted");
            entity.Property(e => e.IsUnderthreshold).HasColumnName("is_underthreshold");
            entity.Property(e => e.ItemIndex).HasColumnName("item_index");
            entity.Property(e => e.Itemid).HasColumnName("itemid");
            entity.Property(e => e.NeedsQuest).HasColumnName("needs_quest");
            entity.Property(e => e.RandomPropertyId).HasColumnName("randomPropertyId");
            entity.Property(e => e.RandomSuffix).HasColumnName("randomSuffix");
        });

        modelBuilder.Entity<ItemRefundInstance>(entity =>
        {
            entity.HasKey(e => new { e.ItemGuid, e.PlayerGuid }).HasName("PRIMARY");

            entity.ToTable("item_refund_instance", tb => tb.HasComment("Item Refund System"));

            entity.Property(e => e.ItemGuid).HasComment("Item GUID").HasColumnName("item_guid");
            entity
                .Property(e => e.PlayerGuid)
                .HasComment("Player GUID")
                .HasColumnName("player_guid");
            entity.Property(e => e.PaidExtendedCost).HasColumnName("paidExtendedCost");
            entity.Property(e => e.PaidMoney).HasColumnName("paidMoney");
        });

        modelBuilder.Entity<ItemSoulboundTradeDatum>(entity =>
        {
            entity.HasKey(e => e.ItemGuid).HasName("PRIMARY");

            entity.ToTable("item_soulbound_trade_data", tb => tb.HasComment("Item Refund System"));

            entity.Property(e => e.ItemGuid).HasComment("Item GUID").HasColumnName("itemGuid");
            entity
                .Property(e => e.AllowedPlayers)
                .HasComment(
                    "Space separated GUID list of players who can receive this item in trade"
                )
                .HasColumnType("text")
                .HasColumnName("allowedPlayers");
        });

        modelBuilder.Entity<LagReport>(entity =>
        {
            entity.HasKey(e => e.ReportId).HasName("PRIMARY");

            entity.ToTable("lag_reports", tb => tb.HasComment("Player System"));

            entity.Property(e => e.ReportId).HasColumnName("reportId");
            entity.Property(e => e.CreateTime).HasColumnName("createTime");
            entity.Property(e => e.Guid).HasColumnName("guid");
            entity.Property(e => e.LagType).HasColumnName("lagType");
            entity.Property(e => e.Latency).HasColumnName("latency");
            entity.Property(e => e.MapId).HasColumnName("mapId");
            entity.Property(e => e.PosX).HasColumnName("posX");
            entity.Property(e => e.PosY).HasColumnName("posY");
            entity.Property(e => e.PosZ).HasColumnName("posZ");
        });

        modelBuilder.Entity<LfgDatum>(entity =>
        {
            entity.HasKey(e => e.Guid).HasName("PRIMARY");

            entity.ToTable("lfg_data", tb => tb.HasComment("LFG Data"));

            entity
                .Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            entity.Property(e => e.Dungeon).HasColumnName("dungeon");
            entity.Property(e => e.State).HasColumnName("state");
        });

        modelBuilder.Entity<LogArenaFight>(entity =>
        {
            entity.HasKey(e => e.FightId).HasName("PRIMARY");

            entity.ToTable("log_arena_fights");

            entity.Property(e => e.FightId).HasColumnName("fight_id");
            entity.Property(e => e.CurrOnline).HasColumnName("currOnline");
            entity.Property(e => e.Duration).HasColumnName("duration");
            entity.Property(e => e.Loser).HasColumnName("loser");
            entity.Property(e => e.LoserMmr).HasColumnName("loser_mmr");
            entity.Property(e => e.LoserTr).HasColumnName("loser_tr");
            entity.Property(e => e.LoserTrChange).HasColumnName("loser_tr_change");
            entity.Property(e => e.Time).HasColumnType("datetime").HasColumnName("time");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Winner).HasColumnName("winner");
            entity.Property(e => e.WinnerMmr).HasColumnName("winner_mmr");
            entity.Property(e => e.WinnerTr).HasColumnName("winner_tr");
            entity.Property(e => e.WinnerTrChange).HasColumnName("winner_tr_change");
        });

        modelBuilder.Entity<LogArenaMemberstat>(entity =>
        {
            entity.HasKey(e => new { e.FightId, e.MemberId }).HasName("PRIMARY");

            entity.ToTable("log_arena_memberstats");

            entity.Property(e => e.FightId).HasColumnName("fight_id");
            entity.Property(e => e.MemberId).HasColumnName("member_id");
            entity.Property(e => e.Account).HasColumnName("account");
            entity.Property(e => e.Damage).HasColumnName("damage");
            entity.Property(e => e.Guid).HasColumnName("guid");
            entity.Property(e => e.Heal).HasColumnName("heal");
            entity.Property(e => e.Ip).HasMaxLength(15).IsFixedLength().HasColumnName("ip");
            entity.Property(e => e.Kblows).HasColumnName("kblows");
            entity.Property(e => e.Name).HasMaxLength(20).IsFixedLength().HasColumnName("name");
            entity.Property(e => e.Team).HasColumnName("team");
        });

        modelBuilder.Entity<LogEncounter>(entity =>
        {
            entity.HasNoKey().ToTable("log_encounter");

            entity.Property(e => e.CreditEntry).HasColumnName("creditEntry");
            entity.Property(e => e.CreditType).HasColumnName("creditType");
            entity.Property(e => e.Difficulty).HasColumnName("difficulty");
            entity.Property(e => e.Map).HasColumnName("map");
            entity.Property(e => e.PlayersInfo).HasColumnType("text").HasColumnName("playersInfo");
            entity.Property(e => e.Time).HasColumnType("datetime").HasColumnName("time");
        });

        modelBuilder.Entity<LogMoney>(entity =>
        {
            entity.HasNoKey().ToTable("log_money");

            entity.Property(e => e.Date).HasColumnType("datetime").HasColumnName("date");
            entity.Property(e => e.Money).HasColumnName("money");
            entity.Property(e => e.ReceiverAcc).HasColumnName("receiver_acc");
            entity
                .Property(e => e.ReceiverName)
                .HasColumnType("text")
                .HasColumnName("receiver_name");
            entity.Property(e => e.SenderAcc).HasColumnName("sender_acc");
            entity.Property(e => e.SenderGuid).HasColumnName("sender_guid");
            entity.Property(e => e.SenderIp).HasColumnType("text").HasColumnName("sender_ip");
            entity.Property(e => e.SenderName).HasColumnType("text").HasColumnName("sender_name");
            entity.Property(e => e.Topic).HasColumnType("text").HasColumnName("topic");
            entity
                .Property(e => e.Type)
                .HasComment("1=COD,2=AH,3=GB DEPOSIT,4=GB WITHDRAW,5=MAIL,6=TRADE")
                .HasColumnName("type");
        });

        modelBuilder.Entity<Mail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mail", tb => tb.HasComment("Mail System"));

            entity.HasIndex(e => e.Receiver, "idx_receiver");

            entity.Property(e => e.Id).HasComment("Identifier").HasColumnName("id");
            entity.Property(e => e.Body).HasColumnName("body");
            entity.Property(e => e.Checked).HasColumnName("checked");
            entity.Property(e => e.Cod).HasColumnName("cod");
            entity.Property(e => e.DeliverTime).HasColumnName("deliver_time");
            entity.Property(e => e.ExpireTime).HasColumnName("expire_time");
            entity.Property(e => e.HasItems).HasColumnName("has_items");
            entity.Property(e => e.MailTemplateId).HasColumnName("mailTemplateId");
            entity.Property(e => e.MessageType).HasColumnName("messageType");
            entity.Property(e => e.Money).HasColumnName("money");
            entity
                .Property(e => e.Receiver)
                .HasComment("Character Global Unique Identifier")
                .HasColumnName("receiver");
            entity
                .Property(e => e.Sender)
                .HasComment("Character Global Unique Identifier")
                .HasColumnName("sender");
            entity
                .Property(e => e.Stationery)
                .HasDefaultValueSql("'41'")
                .HasColumnName("stationery");
            entity.Property(e => e.Subject).HasColumnName("subject");
        });

        modelBuilder.Entity<MailItem>(entity =>
        {
            entity.HasKey(e => e.ItemGuid).HasName("PRIMARY");

            entity.ToTable("mail_items");

            entity.HasIndex(e => e.MailId, "idx_mail_id");

            entity.HasIndex(e => e.Receiver, "idx_receiver");

            entity.Property(e => e.ItemGuid).HasColumnName("item_guid");
            entity.Property(e => e.MailId).HasColumnName("mail_id");
            entity
                .Property(e => e.Receiver)
                .HasComment("Character Global Unique Identifier")
                .HasColumnName("receiver");
        });

        modelBuilder.Entity<MailServerCharacter>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.MailId }).HasName("PRIMARY");

            entity.ToTable("mail_server_character");

            entity.Property(e => e.Guid).HasColumnName("guid");
            entity.Property(e => e.MailId).HasColumnName("mailId");
        });

        modelBuilder.Entity<MailServerTemplate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("mail_server_template");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Active).HasDefaultValueSql("'1'").HasColumnName("active");
            entity.Property(e => e.Body).HasColumnType("text").HasColumnName("body");
            entity.Property(e => e.ItemA).HasColumnName("itemA");
            entity.Property(e => e.ItemCountA).HasColumnName("itemCountA");
            entity.Property(e => e.ItemCountH).HasColumnName("itemCountH");
            entity.Property(e => e.ItemH).HasColumnName("itemH");
            entity.Property(e => e.MoneyA).HasColumnName("moneyA");
            entity.Property(e => e.MoneyH).HasColumnName("moneyH");
            entity.Property(e => e.ReqLevel).HasColumnName("reqLevel");
            entity.Property(e => e.ReqPlayTime).HasColumnName("reqPlayTime");
            entity.Property(e => e.Subject).HasColumnType("text").HasColumnName("subject");
        });

        modelBuilder.Entity<PetAura>(entity =>
        {
            entity
                .HasKey(e => new
                {
                    e.Guid,
                    e.CasterGuid,
                    e.Spell,
                    e.EffectMask
                })
                .HasName("PRIMARY");

            entity.ToTable("pet_aura", tb => tb.HasComment("Pet System"));

            entity
                .Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            entity
                .Property(e => e.CasterGuid)
                .HasComment("Full Global Unique Identifier")
                .HasColumnName("casterGuid");
            entity.Property(e => e.Spell).HasColumnName("spell");
            entity.Property(e => e.EffectMask).HasColumnName("effectMask");
            entity.Property(e => e.Amount0).HasColumnName("amount0");
            entity.Property(e => e.Amount1).HasColumnName("amount1");
            entity.Property(e => e.Amount2).HasColumnName("amount2");
            entity.Property(e => e.BaseAmount0).HasColumnName("base_amount0");
            entity.Property(e => e.BaseAmount1).HasColumnName("base_amount1");
            entity.Property(e => e.BaseAmount2).HasColumnName("base_amount2");
            entity.Property(e => e.MaxDuration).HasColumnName("maxDuration");
            entity.Property(e => e.RecalculateMask).HasColumnName("recalculateMask");
            entity.Property(e => e.RemainCharges).HasColumnName("remainCharges");
            entity.Property(e => e.RemainTime).HasColumnName("remainTime");
            entity
                .Property(e => e.StackCount)
                .HasDefaultValueSql("'1'")
                .HasColumnName("stackCount");
        });

        modelBuilder.Entity<PetSpell>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.Spell }).HasName("PRIMARY");

            entity.ToTable("pet_spell", tb => tb.HasComment("Pet System"));

            entity
                .Property(e => e.Guid)
                .HasComment("Global Unique Identifier")
                .HasColumnName("guid");
            entity.Property(e => e.Spell).HasComment("Spell Identifier").HasColumnName("spell");
            entity.Property(e => e.Active).HasColumnName("active");
        });

        modelBuilder.Entity<PetSpellCooldown>(entity =>
        {
            entity.HasKey(e => new { e.Guid, e.Spell }).HasName("PRIMARY");

            entity.ToTable("pet_spell_cooldown");

            entity
                .Property(e => e.Guid)
                .HasComment("Global Unique Identifier, Low part")
                .HasColumnName("guid");
            entity.Property(e => e.Spell).HasComment("Spell Identifier").HasColumnName("spell");
            entity.Property(e => e.Category).HasDefaultValueSql("'0'").HasColumnName("category");
            entity.Property(e => e.Time).HasColumnName("time");
        });

        modelBuilder.Entity<Petition>(entity =>
        {
            entity.HasKey(e => new { e.Ownerguid, e.Type }).HasName("PRIMARY");

            entity.ToTable("petition", tb => tb.HasComment("Guild System"));

            entity
                .HasIndex(e => new { e.Ownerguid, e.Petitionguid }, "index_ownerguid_petitionguid")
                .IsUnique();

            entity.Property(e => e.Ownerguid).HasColumnName("ownerguid");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.Name).HasMaxLength(24).HasColumnName("name");
            entity
                .Property(e => e.Petitionguid)
                .HasDefaultValueSql("'0'")
                .HasColumnName("petitionguid");
        });

        modelBuilder.Entity<PetitionSign>(entity =>
        {
            entity.HasKey(e => new { e.Petitionguid, e.Playerguid }).HasName("PRIMARY");

            entity.ToTable("petition_sign", tb => tb.HasComment("Guild System"));

            entity.HasIndex(e => e.Ownerguid, "Idx_ownerguid");

            entity.HasIndex(e => e.Playerguid, "Idx_playerguid");

            entity.Property(e => e.Petitionguid).HasColumnName("petitionguid");
            entity.Property(e => e.Playerguid).HasColumnName("playerguid");
            entity.Property(e => e.Ownerguid).HasColumnName("ownerguid");
            entity.Property(e => e.PlayerAccount).HasColumnName("player_account");
            entity.Property(e => e.Type).HasColumnName("type");
        });

        modelBuilder.Entity<PoolQuestSave>(entity =>
        {
            entity.HasKey(e => new { e.PoolId, e.QuestId }).HasName("PRIMARY");

            entity.ToTable("pool_quest_save");

            entity.Property(e => e.PoolId).HasColumnName("pool_id");
            entity.Property(e => e.QuestId).HasColumnName("quest_id");
        });

        modelBuilder.Entity<ProfanityName>(entity =>
        {
            entity.HasKey(e => e.Name).HasName("PRIMARY");

            entity.ToTable("profanity_name");

            entity.Property(e => e.Name).HasMaxLength(12).HasColumnName("name");
        });

        modelBuilder.Entity<PvpstatsBattleground>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("pvpstats_battlegrounds");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.BracketId).HasColumnName("bracket_id");
            entity.Property(e => e.Date).HasColumnType("datetime").HasColumnName("date");
            entity.Property(e => e.Type).HasColumnName("type");
            entity.Property(e => e.WinnerFaction).HasColumnName("winner_faction");
        });

        modelBuilder.Entity<PvpstatsPlayer>(entity =>
        {
            entity.HasKey(e => new { e.BattlegroundId, e.CharacterGuid }).HasName("PRIMARY");

            entity.ToTable("pvpstats_players");

            entity.Property(e => e.BattlegroundId).HasColumnName("battleground_id");
            entity.Property(e => e.CharacterGuid).HasColumnName("character_guid");
            entity.Property(e => e.Attr1).HasDefaultValueSql("'0'").HasColumnName("attr_1");
            entity.Property(e => e.Attr2).HasDefaultValueSql("'0'").HasColumnName("attr_2");
            entity.Property(e => e.Attr3).HasDefaultValueSql("'0'").HasColumnName("attr_3");
            entity.Property(e => e.Attr4).HasDefaultValueSql("'0'").HasColumnName("attr_4");
            entity.Property(e => e.Attr5).HasDefaultValueSql("'0'").HasColumnName("attr_5");
            entity.Property(e => e.ScoreBonusHonor).HasColumnName("score_bonus_honor");
            entity.Property(e => e.ScoreDamageDone).HasColumnName("score_damage_done");
            entity.Property(e => e.ScoreDeaths).HasColumnName("score_deaths");
            entity.Property(e => e.ScoreHealingDone).HasColumnName("score_healing_done");
            entity.Property(e => e.ScoreHonorableKills).HasColumnName("score_honorable_kills");
            entity.Property(e => e.ScoreKillingBlows).HasColumnName("score_killing_blows");
            entity.Property(e => e.Winner).HasColumnType("bit(1)").HasColumnName("winner");
        });

        modelBuilder.Entity<QuestTracker>(entity =>
        {
            entity.HasNoKey().ToTable("quest_tracker");

            entity.Property(e => e.CharacterGuid).HasColumnName("character_guid");
            entity.Property(e => e.CompletedByGm).HasColumnName("completed_by_gm");
            entity
                .Property(e => e.CoreHash)
                .HasMaxLength(120)
                .HasDefaultValueSql("'0'")
                .HasColumnName("core_hash");
            entity
                .Property(e => e.CoreRevision)
                .HasMaxLength(120)
                .HasDefaultValueSql("'0'")
                .HasColumnName("core_revision");
            entity.Property(e => e.Id).HasDefaultValueSql("'0'").HasColumnName("id");
            entity
                .Property(e => e.QuestAbandonTime)
                .HasColumnType("datetime")
                .HasColumnName("quest_abandon_time");
            entity
                .Property(e => e.QuestAcceptTime)
                .HasColumnType("datetime")
                .HasColumnName("quest_accept_time");
            entity
                .Property(e => e.QuestCompleteTime)
                .HasColumnType("datetime")
                .HasColumnName("quest_complete_time");
        });

        modelBuilder.Entity<RecoveryItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("recovery_item");

            entity.HasIndex(e => e.Guid, "idx_guid");

            entity.Property(e => e.ItemEntry).HasDefaultValueSql("'0'");
        });

        modelBuilder.Entity<ReservedName>(entity =>
        {
            entity.HasKey(e => e.Name).HasName("PRIMARY");

            entity.ToTable("reserved_name", tb => tb.HasComment("Player Reserved Names"));

            entity.Property(e => e.Name).HasMaxLength(12).HasColumnName("name");
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

        modelBuilder.Entity<WardenAction>(entity =>
        {
            entity.HasKey(e => e.WardenId).HasName("PRIMARY");

            entity.ToTable("warden_action");

            entity.Property(e => e.WardenId).HasColumnName("wardenId");
            entity.Property(e => e.Action).HasColumnName("action");
        });

        modelBuilder.Entity<Worldstate>(entity =>
        {
            entity.HasKey(e => e.Entry).HasName("PRIMARY");

            entity.ToTable("worldstates", tb => tb.HasComment("Variable Saves"));

            entity.Property(e => e.Entry).HasColumnName("entry");
            entity.Property(e => e.Comment).HasColumnType("tinytext").HasColumnName("comment");
            entity.Property(e => e.Value).HasColumnName("value");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
