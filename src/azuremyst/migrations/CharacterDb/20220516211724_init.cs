using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace azuremyst.Migrations.CharacterDb
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "account_data",
                columns: table => new
                {
                    account = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    type = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    time = table.Column<ulong>(type: "bigint(11) unsigned", nullable: false),
                    data = table.Column<byte[]>(type: "longblob", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.account, x.type })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "account_instances_entered",
                columns: table => new
                {
                    AccountId = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Player account"),
                    InstanceId = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "ID of instance entered"),
                    ExpireTime = table.Column<long>(type: "bigint(40)", nullable: false, comment: "Time when instance was entered")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.AccountId, x.InstanceId })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                },
                comment: "Instance reset limit system")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "ahbot_items",
                columns: table => new
                {
                    item = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Item Identifier"),
                    value = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Item value, a value of 0 bans item from being sold/bought by AHBot"),
                    add_chance = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Chance item is added to AH upon bot visit, 0 for normal loot sources"),
                    min_amount = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Min amount added, not used when add_chance is 0"),
                    max_amount = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Max amount added, not used when add_chance is 0")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.item);
                },
                comment: "AuctionHouseBot overridden item settings")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "arena_team",
                columns: table => new
                {
                    arenateamid = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    name = table.Column<string>(type: "char(255)", fixedLength: true, maxLength: 255, nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    captainguid = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    type = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    BackgroundColor = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    EmblemStyle = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    EmblemColor = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    BorderStyle = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    BorderColor = table.Column<uint>(type: "int(10) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_arena_team", x => x.arenateamid);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "arena_team_member",
                columns: table => new
                {
                    arenateamid = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    guid = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    played_week = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    wons_week = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    played_season = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    wons_season = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    personal_rating = table.Column<uint>(type: "int(10) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.arenateamid, x.guid })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "arena_team_stats",
                columns: table => new
                {
                    arenateamid = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    rating = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    games_week = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    wins_week = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    games_season = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    wins_season = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    rank = table.Column<uint>(type: "int(10) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.arenateamid);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "auction",
                columns: table => new
                {
                    id = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    houseid = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    itemguid = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    item_template = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Item Identifier"),
                    item_count = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    item_randompropertyid = table.Column<int>(type: "int(11)", nullable: false),
                    itemowner = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    buyoutprice = table.Column<int>(type: "int(11)", nullable: false),
                    time = table.Column<ulong>(type: "bigint(40) unsigned", nullable: false),
                    buyguid = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    lastbid = table.Column<int>(type: "int(11)", nullable: false),
                    startbid = table.Column<int>(type: "int(11)", nullable: false),
                    deposit = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_auction", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "bugreport",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false, comment: "Identifier")
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    type = table.Column<string>(type: "longtext", nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    content = table.Column<string>(type: "longtext", nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bugreport", x => x.id);
                },
                comment: "Debug System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "character_account_data",
                columns: table => new
                {
                    guid = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    type = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    time = table.Column<ulong>(type: "bigint(11) unsigned", nullable: false),
                    data = table.Column<byte[]>(type: "longblob", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.guid, x.type })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "character_action",
                columns: table => new
                {
                    guid = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Global Unique Identifier"),
                    button = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    action = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    type = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.guid, x.button })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                },
                comment: "Player System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "character_aura",
                columns: table => new
                {
                    guid = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Global Unique Identifier"),
                    caster_guid = table.Column<ulong>(type: "bigint(20) unsigned", nullable: false, comment: "Full Global Unique Identifier"),
                    item_guid = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    spell = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    stackcount = table.Column<uint>(type: "int(11) unsigned", nullable: false, defaultValueSql: "'1'"),
                    remaincharges = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    basepoints0 = table.Column<int>(type: "int(11)", nullable: false),
                    basepoints1 = table.Column<int>(type: "int(11)", nullable: false),
                    basepoints2 = table.Column<int>(type: "int(11)", nullable: false),
                    periodictime0 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    periodictime1 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    periodictime2 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    maxduration = table.Column<int>(type: "int(11)", nullable: false),
                    remaintime = table.Column<int>(type: "int(11)", nullable: false),
                    effIndexMask = table.Column<uint>(type: "int(11) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.guid, x.caster_guid, x.item_guid, x.spell })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });
                },
                comment: "Player System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "character_battleground_data",
                columns: table => new
                {
                    guid = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Global Unique Identifier"),
                    instance_id = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    team = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    join_x = table.Column<float>(type: "float", nullable: false),
                    join_y = table.Column<float>(type: "float", nullable: false),
                    join_z = table.Column<float>(type: "float", nullable: false),
                    join_o = table.Column<float>(type: "float", nullable: false),
                    join_map = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.guid);
                },
                comment: "Player System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "character_db_version",
                columns: table => new
                {
                    required_s2429_01_characters_raf = table.Column<ulong>(type: "bit(1)", nullable: true)
                },
                constraints: table =>
                {
                },
                comment: "Last applied sql update to DB")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "character_declinedname",
                columns: table => new
                {
                    guid = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Global Unique Identifier"),
                    genitive = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    dative = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    accusative = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    instrumental = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    prepositional = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.guid);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "character_gifts",
                columns: table => new
                {
                    item_guid = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    guid = table.Column<uint>(type: "int(20) unsigned", nullable: false),
                    entry = table.Column<uint>(type: "int(20) unsigned", nullable: false),
                    flags = table.Column<uint>(type: "int(20) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.item_guid);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "character_homebind",
                columns: table => new
                {
                    guid = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Global Unique Identifier"),
                    map = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Map Identifier"),
                    zone = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Zone Identifier"),
                    position_x = table.Column<float>(type: "float", nullable: false),
                    position_y = table.Column<float>(type: "float", nullable: false),
                    position_z = table.Column<float>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.guid);
                },
                comment: "Player System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "character_instance",
                columns: table => new
                {
                    guid = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    instance = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    permanent = table.Column<byte>(type: "tinyint(1) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.guid, x.instance })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "character_inventory",
                columns: table => new
                {
                    item = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Item Global Unique Identifier"),
                    guid = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Global Unique Identifier"),
                    bag = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    slot = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    item_template = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Item Identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.item);
                },
                comment: "Player System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "character_pet",
                columns: table => new
                {
                    id = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    entry = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    owner = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    modelid = table.Column<uint>(type: "int(11) unsigned", nullable: true, defaultValueSql: "'0'"),
                    CreatedBySpell = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    PetType = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    level = table.Column<uint>(type: "int(11) unsigned", nullable: false, defaultValueSql: "'1'"),
                    exp = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    Reactstate = table.Column<byte>(type: "tinyint(1) unsigned", nullable: false),
                    loyaltypoints = table.Column<int>(type: "int(11)", nullable: false),
                    loyalty = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    xpForNextLoyalty = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    trainpoint = table.Column<int>(type: "int(11)", nullable: false),
                    name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, defaultValueSql: "'Pet'", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    renamed = table.Column<byte>(type: "tinyint(1) unsigned", nullable: false),
                    slot = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    curhealth = table.Column<uint>(type: "int(11) unsigned", nullable: false, defaultValueSql: "'1'"),
                    curmana = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    curhappiness = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    savetime = table.Column<ulong>(type: "bigint(20) unsigned", nullable: false),
                    resettalents_cost = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    resettalents_time = table.Column<ulong>(type: "bigint(20) unsigned", nullable: false),
                    abdata = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    teachspelldata = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_character_pet", x => x.id);
                },
                comment: "Pet System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "character_pet_declinedname",
                columns: table => new
                {
                    id = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    owner = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    genitive = table.Column<string>(type: "varchar(12)", maxLength: 12, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    dative = table.Column<string>(type: "varchar(12)", maxLength: 12, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    accusative = table.Column<string>(type: "varchar(12)", maxLength: 12, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    instrumental = table.Column<string>(type: "varchar(12)", maxLength: 12, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    prepositional = table.Column<string>(type: "varchar(12)", maxLength: 12, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_character_pet_declinedname", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "character_queststatus",
                columns: table => new
                {
                    guid = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Global Unique Identifier"),
                    quest = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Quest Identifier"),
                    status = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    rewarded = table.Column<byte>(type: "tinyint(1) unsigned", nullable: false),
                    explored = table.Column<byte>(type: "tinyint(1) unsigned", nullable: false),
                    timer = table.Column<ulong>(type: "bigint(20) unsigned", nullable: false),
                    mobcount1 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    mobcount2 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    mobcount3 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    mobcount4 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    itemcount1 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    itemcount2 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    itemcount3 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    itemcount4 = table.Column<uint>(type: "int(11) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.guid, x.quest })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                },
                comment: "Player System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "character_queststatus_daily",
                columns: table => new
                {
                    guid = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Global Unique Identifier"),
                    quest = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Quest Identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.guid, x.quest })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                },
                comment: "Player System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "character_queststatus_monthly",
                columns: table => new
                {
                    guid = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Global Unique Identifier"),
                    quest = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Quest Identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.guid, x.quest })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                },
                comment: "Player System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "character_queststatus_weekly",
                columns: table => new
                {
                    guid = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Global Unique Identifier"),
                    quest = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Quest Identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.guid, x.quest })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                },
                comment: "Player System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "character_reputation",
                columns: table => new
                {
                    guid = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Global Unique Identifier"),
                    faction = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    standing = table.Column<int>(type: "int(11)", nullable: false),
                    flags = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.guid, x.faction })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                },
                comment: "Player System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "character_skills",
                columns: table => new
                {
                    guid = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Global Unique Identifier"),
                    skill = table.Column<uint>(type: "mediumint(9) unsigned", nullable: false),
                    value = table.Column<uint>(type: "mediumint(9) unsigned", nullable: false),
                    max = table.Column<uint>(type: "mediumint(9) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.guid, x.skill })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                },
                comment: "Player System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "character_social",
                columns: table => new
                {
                    guid = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Character Global Unique Identifier"),
                    friend = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Friend Global Unique Identifier"),
                    flags = table.Column<byte>(type: "tinyint(1) unsigned", nullable: false, comment: "Friend Flags"),
                    note = table.Column<string>(type: "varchar(48)", maxLength: 48, nullable: false, defaultValueSql: "''", comment: "Friend Note", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.guid, x.friend, x.flags })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
                },
                comment: "Player System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "character_spell",
                columns: table => new
                {
                    guid = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Global Unique Identifier"),
                    spell = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Spell Identifier"),
                    active = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false, defaultValueSql: "'1'"),
                    disabled = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.guid, x.spell })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                },
                comment: "Player System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "character_spell_cooldown",
                columns: table => new
                {
                    guid = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Global Unique Identifier, Low part"),
                    SpellId = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Spell Identifier"),
                    SpellExpireTime = table.Column<ulong>(type: "bigint(20) unsigned", nullable: false, comment: "Spell cooldown expire time"),
                    Category = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Spell category"),
                    CategoryExpireTime = table.Column<ulong>(type: "bigint(20) unsigned", nullable: false, comment: "Spell category cooldown expire time"),
                    ItemId = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Item Identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.guid, x.SpellId })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "character_stats",
                columns: table => new
                {
                    guid = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Global Unique Identifier, Low part"),
                    maxhealth = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    maxpower1 = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    maxpower2 = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    maxpower3 = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    maxpower4 = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    maxpower5 = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    maxpower6 = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    maxpower7 = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    strength = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    agility = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    stamina = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    intellect = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    spirit = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    armor = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    resHoly = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    resFire = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    resNature = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    resFrost = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    resShadow = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    resArcane = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    blockPct = table.Column<float>(type: "float unsigned", nullable: false),
                    dodgePct = table.Column<float>(type: "float unsigned", nullable: false),
                    parryPct = table.Column<float>(type: "float unsigned", nullable: false),
                    critPct = table.Column<float>(type: "float unsigned", nullable: false),
                    rangedCritPct = table.Column<float>(type: "float unsigned", nullable: false),
                    spellCritPct = table.Column<float>(type: "float unsigned", nullable: false),
                    attackPower = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    rangedAttackPower = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    spellPower = table.Column<uint>(type: "int(10) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.guid);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "character_tutorial",
                columns: table => new
                {
                    account = table.Column<ulong>(type: "bigint(20) unsigned", nullable: false, comment: "Account Identifier")
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    tut0 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    tut1 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    tut2 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    tut3 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    tut4 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    tut5 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    tut6 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    tut7 = table.Column<uint>(type: "int(11) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.account);
                },
                comment: "Player System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "characters",
                columns: table => new
                {
                    guid = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Global Unique Identifier"),
                    account = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Account Identifier"),
                    name = table.Column<string>(type: "varchar(12)", maxLength: 12, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    race = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    @class = table.Column<byte>(name: "class", type: "tinyint(3) unsigned", nullable: false),
                    gender = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    level = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    xp = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    money = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    playerBytes = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    playerBytes2 = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    playerFlags = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    position_x = table.Column<float>(type: "float", nullable: false),
                    position_y = table.Column<float>(type: "float", nullable: false),
                    position_z = table.Column<float>(type: "float", nullable: false),
                    map = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Map Identifier"),
                    dungeon_difficulty = table.Column<byte>(type: "tinyint(1) unsigned", nullable: false),
                    orientation = table.Column<float>(type: "float", nullable: false),
                    taximask = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    online = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    cinematic = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    totaltime = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    leveltime = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    logout_time = table.Column<ulong>(type: "bigint(20) unsigned", nullable: false),
                    is_logout_resting = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    rest_bonus = table.Column<float>(type: "float", nullable: false),
                    resettalents_cost = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    resettalents_time = table.Column<ulong>(type: "bigint(20) unsigned", nullable: false),
                    trans_x = table.Column<float>(type: "float", nullable: false),
                    trans_y = table.Column<float>(type: "float", nullable: false),
                    trans_z = table.Column<float>(type: "float", nullable: false),
                    trans_o = table.Column<float>(type: "float", nullable: false),
                    transguid = table.Column<ulong>(type: "bigint(20) unsigned", nullable: false),
                    extra_flags = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    stable_slots = table.Column<byte>(type: "tinyint(1) unsigned", nullable: false),
                    at_login = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    zone = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    death_expire_time = table.Column<ulong>(type: "bigint(20) unsigned", nullable: false),
                    taxi_path = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    arenaPoints = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    totalHonorPoints = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    todayHonorPoints = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    yesterdayHonorPoints = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    totalKills = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    todayKills = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    yesterdayKills = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    chosenTitle = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    watchedFaction = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    drunk = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    health = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    power1 = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    power2 = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    power3 = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    power4 = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    power5 = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    exploredZones = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    equipmentCache = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    ammoId = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    knownTitles = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    actionBars = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    grantableLevels = table.Column<uint>(type: "int(10) unsigned", nullable: true, defaultValueSql: "'0'"),
                    deleteInfos_Account = table.Column<uint>(type: "int(11) unsigned", nullable: true),
                    deleteInfos_Name = table.Column<string>(type: "varchar(12)", maxLength: 12, nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    deleteDate = table.Column<ulong>(type: "bigint(20) unsigned", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.guid);
                },
                comment: "Player System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "corpse",
                columns: table => new
                {
                    guid = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Global Unique Identifier"),
                    player = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Character Global Unique Identifier"),
                    position_x = table.Column<float>(type: "float", nullable: false),
                    position_y = table.Column<float>(type: "float", nullable: false),
                    position_z = table.Column<float>(type: "float", nullable: false),
                    orientation = table.Column<float>(type: "float", nullable: false),
                    map = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Map Identifier"),
                    time = table.Column<ulong>(type: "bigint(20) unsigned", nullable: false),
                    corpse_type = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    instance = table.Column<uint>(type: "int(11) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.guid);
                },
                comment: "Death System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "creature_respawn",
                columns: table => new
                {
                    guid = table.Column<uint>(type: "int(10) unsigned", nullable: false, comment: "Global Unique Identifier"),
                    instance = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    respawntime = table.Column<ulong>(type: "bigint(20) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.guid, x.instance })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                },
                comment: "Grid Loading System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "event_group_chosen",
                columns: table => new
                {
                    eventGroup = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.eventGroup, x.entry })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                },
                comment: "Quest Group picked")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "game_event_status",
                columns: table => new
                {
                    @event = table.Column<ushort>(name: "event", type: "smallint(6) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.@event);
                },
                comment: "Game event system")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "gameobject_respawn",
                columns: table => new
                {
                    guid = table.Column<uint>(type: "int(10) unsigned", nullable: false, comment: "Global Unique Identifier"),
                    instance = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    respawntime = table.Column<ulong>(type: "bigint(20) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.guid, x.instance })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                },
                comment: "Grid Loading System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "gm_surveys",
                columns: table => new
                {
                    ticketid = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "GM Ticket's unique identifier"),
                    surveyid = table.Column<uint>(type: "int(2) unsigned", nullable: false, comment: "Survey DBC entry's identifier"),
                    answer1 = table.Column<byte>(type: "tinyint(2) unsigned", nullable: true),
                    answer2 = table.Column<byte>(type: "tinyint(2) unsigned", nullable: true),
                    answer3 = table.Column<byte>(type: "tinyint(2) unsigned", nullable: true),
                    answer4 = table.Column<byte>(type: "tinyint(2) unsigned", nullable: true),
                    answer5 = table.Column<byte>(type: "tinyint(2) unsigned", nullable: true),
                    answer6 = table.Column<byte>(type: "tinyint(2) unsigned", nullable: true),
                    answer7 = table.Column<byte>(type: "tinyint(2) unsigned", nullable: true),
                    answer8 = table.Column<byte>(type: "tinyint(2) unsigned", nullable: true),
                    answer9 = table.Column<byte>(type: "tinyint(2) unsigned", nullable: true),
                    answer10 = table.Column<byte>(type: "tinyint(2) unsigned", nullable: true),
                    comment = table.Column<string>(type: "text", nullable: true, comment: "Player's feedback", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.ticketid);
                },
                comment: "GM Tickets System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "gm_tickets",
                columns: table => new
                {
                    id = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "GM Ticket's unique identifier")
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    category = table.Column<byte>(type: "tinyint(2) unsigned", nullable: false, comment: "GM Ticket Category DBC entry's identifier"),
                    state = table.Column<byte>(type: "tinyint(1) unsigned", nullable: false, comment: "Ticket's current state"),
                    status = table.Column<byte>(type: "tinyint(1) unsigned", nullable: false, comment: "Ticket's current status"),
                    level = table.Column<byte>(type: "tinyint(1) unsigned", nullable: false, comment: "Ticket's security level"),
                    author_guid = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Player's character Global Unique Identifier"),
                    author_name = table.Column<string>(type: "varchar(12)", maxLength: 12, nullable: false, comment: "Player's character name", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    locale = table.Column<string>(type: "varchar(4)", maxLength: 4, nullable: false, defaultValueSql: "'enUS'", comment: "Player's client locale name", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    mapid = table.Column<uint>(type: "int(4) unsigned", nullable: false, comment: "Character's map identifier on submission"),
                    x = table.Column<float>(type: "float", nullable: false, comment: "Character's x coordinate on submission"),
                    y = table.Column<float>(type: "float", nullable: false, comment: "Character's y coordinate on submission"),
                    z = table.Column<float>(type: "float", nullable: false, comment: "Character's z coordinate on submission"),
                    o = table.Column<float>(type: "float", nullable: false, comment: "Character's orientation angle on submission"),
                    text = table.Column<string>(type: "text", nullable: false, comment: "Ticket's message", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    created = table.Column<ulong>(type: "bigint(40) unsigned", nullable: false, comment: "Timestamp: ticket created by a player"),
                    updated = table.Column<ulong>(type: "bigint(40) unsigned", nullable: false, comment: "Timestamp: ticket text's last update"),
                    seen = table.Column<ulong>(type: "bigint(40) unsigned", nullable: false, comment: "Timestamp: ticket's last time opened by a GM"),
                    answered = table.Column<ulong>(type: "bigint(40) unsigned", nullable: false, comment: "Timestamp: ticket's last time answered by a GM"),
                    closed = table.Column<ulong>(type: "bigint(40) unsigned", nullable: false, comment: "Timestamp: ticket closed by a GM"),
                    assignee_guid = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Assignee's character's Global Unique Identifier"),
                    assignee_name = table.Column<string>(type: "varchar(12)", maxLength: 12, nullable: false, defaultValueSql: "''", comment: "Assignee's character's name", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    conclusion = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, defaultValueSql: "''", comment: "Assignee's final conclusion on this ticket", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    notes = table.Column<string>(type: "varchar(10000)", maxLength: 10000, nullable: false, defaultValueSql: "''", comment: "Additional notes for GMs", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gm_tickets", x => x.id);
                },
                comment: "GM Tickets System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "group_instance",
                columns: table => new
                {
                    leaderGuid = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    instance = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    permanent = table.Column<byte>(type: "tinyint(1) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.leaderGuid, x.instance })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "group_member",
                columns: table => new
                {
                    groupId = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    memberGuid = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    assistant = table.Column<byte>(type: "tinyint(1) unsigned", nullable: false),
                    subgroup = table.Column<ushort>(type: "smallint(6) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.groupId, x.memberGuid })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                },
                comment: "Groups")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "groups",
                columns: table => new
                {
                    groupId = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    leaderGuid = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    mainTank = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    mainAssistant = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    lootMethod = table.Column<byte>(type: "tinyint(4) unsigned", nullable: false),
                    looterGuid = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    lootThreshold = table.Column<byte>(type: "tinyint(4) unsigned", nullable: false),
                    icon1 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    icon2 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    icon3 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    icon4 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    icon5 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    icon6 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    icon7 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    icon8 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    isRaid = table.Column<byte>(type: "tinyint(1) unsigned", nullable: false),
                    difficulty = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_groups", x => x.groupId);
                },
                comment: "Groups")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "guild",
                columns: table => new
                {
                    guildid = table.Column<uint>(type: "int(6) unsigned", nullable: false),
                    name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    leaderguid = table.Column<uint>(type: "int(6) unsigned", nullable: false),
                    EmblemStyle = table.Column<int>(type: "int(5)", nullable: false),
                    EmblemColor = table.Column<int>(type: "int(5)", nullable: false),
                    BorderStyle = table.Column<int>(type: "int(5)", nullable: false),
                    BorderColor = table.Column<int>(type: "int(5)", nullable: false),
                    BackgroundColor = table.Column<int>(type: "int(5)", nullable: false),
                    info = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    motd = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    createdate = table.Column<ulong>(type: "bigint(20) unsigned", nullable: false),
                    BankMoney = table.Column<ulong>(type: "bigint(20) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_guild", x => x.guildid);
                },
                comment: "Guild System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "guild_bank_eventlog",
                columns: table => new
                {
                    guildid = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Guild Identificator"),
                    LogGuid = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Log record identificator - auxiliary column"),
                    TabId = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false, comment: "Guild bank TabId"),
                    EventType = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false, comment: "Event type"),
                    PlayerGuid = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    ItemOrMoney = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    ItemStackCount = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    DestTabId = table.Column<byte>(type: "tinyint(1) unsigned", nullable: false, comment: "Destination Tab Id"),
                    TimeStamp = table.Column<ulong>(type: "bigint(20) unsigned", nullable: false, comment: "Event UNIX time")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.guildid, x.LogGuid, x.TabId })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "guild_bank_item",
                columns: table => new
                {
                    guildid = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    TabId = table.Column<byte>(type: "tinyint(1) unsigned", nullable: false),
                    SlotId = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    item_guid = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    item_entry = table.Column<uint>(type: "int(11) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.guildid, x.TabId, x.SlotId })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "guild_bank_right",
                columns: table => new
                {
                    guildid = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    TabId = table.Column<byte>(type: "tinyint(1) unsigned", nullable: false),
                    rid = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    gbright = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    SlotPerDay = table.Column<uint>(type: "int(11) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.guildid, x.TabId, x.rid })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "guild_bank_tab",
                columns: table => new
                {
                    guildid = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    TabId = table.Column<byte>(type: "tinyint(1) unsigned", nullable: false),
                    TabName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    TabIcon = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    TabText = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.guildid, x.TabId })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "guild_eventlog",
                columns: table => new
                {
                    guildid = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Guild Identificator"),
                    LogGuid = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Log record identificator - auxiliary column"),
                    EventType = table.Column<byte>(type: "tinyint(1) unsigned", nullable: false, comment: "Event type"),
                    PlayerGuid1 = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Player 1"),
                    PlayerGuid2 = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Player 2"),
                    NewRank = table.Column<byte>(type: "tinyint(2) unsigned", nullable: false, comment: "New rank(in case promotion/demotion)"),
                    TimeStamp = table.Column<ulong>(type: "bigint(20) unsigned", nullable: false, comment: "Event UNIX time")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.guildid, x.LogGuid })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                },
                comment: "Guild Eventlog")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "guild_member",
                columns: table => new
                {
                    guildid = table.Column<uint>(type: "int(6) unsigned", nullable: false),
                    guid = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    rank = table.Column<byte>(type: "tinyint(2) unsigned", nullable: false),
                    pnote = table.Column<string>(type: "varchar(31)", maxLength: 31, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    offnote = table.Column<string>(type: "varchar(31)", maxLength: 31, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    BankResetTimeMoney = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    BankRemMoney = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    BankResetTimeTab0 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    BankRemSlotsTab0 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    BankResetTimeTab1 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    BankRemSlotsTab1 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    BankResetTimeTab2 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    BankRemSlotsTab2 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    BankResetTimeTab3 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    BankRemSlotsTab3 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    BankResetTimeTab4 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    BankRemSlotsTab4 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    BankResetTimeTab5 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    BankRemSlotsTab5 = table.Column<uint>(type: "int(11) unsigned", nullable: false)
                },
                constraints: table =>
                {
                },
                comment: "Guild System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "guild_rank",
                columns: table => new
                {
                    guildid = table.Column<uint>(type: "int(6) unsigned", nullable: false),
                    rid = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    rname = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    rights = table.Column<uint>(type: "int(3) unsigned", nullable: false),
                    BankMoneyPerDay = table.Column<uint>(type: "int(11) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.guildid, x.rid })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                },
                comment: "Guild System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "instance",
                columns: table => new
                {
                    id = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    map = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    resettime = table.Column<ulong>(type: "bigint(40) unsigned", nullable: false),
                    encountersMask = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    difficulty = table.Column<byte>(type: "tinyint(1) unsigned", nullable: false),
                    data = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_instance", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "instance_reset",
                columns: table => new
                {
                    mapid = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    resettime = table.Column<ulong>(type: "bigint(40) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.mapid);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "item_instance",
                columns: table => new
                {
                    guid = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    owner_guid = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    itemEntry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    creatorGuid = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    giftCreatorGuid = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    count = table.Column<uint>(type: "int(10) unsigned", nullable: false, defaultValueSql: "'1'"),
                    duration = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    charges = table.Column<string>(type: "text", nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    flags = table.Column<uint>(type: "int(8) unsigned", nullable: false),
                    enchantments = table.Column<string>(type: "text", nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    randomPropertyId = table.Column<short>(type: "smallint(5)", nullable: false),
                    durability = table.Column<uint>(type: "int(5) unsigned", nullable: false),
                    itemTextId = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.guid);
                },
                comment: "Item System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "item_loot",
                columns: table => new
                {
                    guid = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    itemid = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    owner_guid = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    amount = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    suffix = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    property = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.guid, x.itemid })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                },
                comment: "Item System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "item_text",
                columns: table => new
                {
                    id = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    text = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_item_text", x => x.id);
                },
                comment: "Item System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "mail",
                columns: table => new
                {
                    id = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Identifier"),
                    messageType = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    stationery = table.Column<sbyte>(type: "tinyint(3)", nullable: false, defaultValueSql: "'41'"),
                    mailTemplateId = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    sender = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Character Global Unique Identifier"),
                    receiver = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Character Global Unique Identifier"),
                    subject = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    itemTextId = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    has_items = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    expire_time = table.Column<ulong>(type: "bigint(40) unsigned", nullable: false),
                    deliver_time = table.Column<ulong>(type: "bigint(40) unsigned", nullable: false),
                    money = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    cod = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    @checked = table.Column<byte>(name: "checked", type: "tinyint(3) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mail", x => x.id);
                },
                comment: "Mail System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "mail_items",
                columns: table => new
                {
                    mail_id = table.Column<int>(type: "int(11)", nullable: false),
                    item_guid = table.Column<int>(type: "int(11)", nullable: false),
                    item_template = table.Column<int>(type: "int(11)", nullable: false),
                    receiver = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Character Global Unique Identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.mail_id, x.item_guid })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "pet_aura",
                columns: table => new
                {
                    guid = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Global Unique Identifier"),
                    caster_guid = table.Column<ulong>(type: "bigint(20) unsigned", nullable: false, comment: "Full Global Unique Identifier"),
                    item_guid = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    spell = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    stackcount = table.Column<uint>(type: "int(11) unsigned", nullable: false, defaultValueSql: "'1'"),
                    remaincharges = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    basepoints0 = table.Column<int>(type: "int(11)", nullable: false),
                    basepoints1 = table.Column<int>(type: "int(11)", nullable: false),
                    basepoints2 = table.Column<int>(type: "int(11)", nullable: false),
                    periodictime0 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    periodictime1 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    periodictime2 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    maxduration = table.Column<int>(type: "int(11)", nullable: false),
                    remaintime = table.Column<int>(type: "int(11)", nullable: false),
                    effIndexMask = table.Column<uint>(type: "int(11) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.guid, x.caster_guid, x.item_guid, x.spell })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });
                },
                comment: "Pet System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "pet_spell",
                columns: table => new
                {
                    guid = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Global Unique Identifier"),
                    spell = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Spell Identifier"),
                    active = table.Column<uint>(type: "int(11) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.guid, x.spell })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                },
                comment: "Pet System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "pet_spell_cooldown",
                columns: table => new
                {
                    guid = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Global Unique Identifier, Low part"),
                    spell = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Spell Identifier"),
                    time = table.Column<ulong>(type: "bigint(20) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.guid, x.spell })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "petition",
                columns: table => new
                {
                    ownerguid = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    type = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    petitionguid = table.Column<uint>(type: "int(10) unsigned", nullable: true, defaultValueSql: "'0'"),
                    name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.ownerguid, x.type })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                },
                comment: "Guild System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "petition_sign",
                columns: table => new
                {
                    petitionguid = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    playerguid = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    ownerguid = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    player_account = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    type = table.Column<uint>(type: "int(10) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.petitionguid, x.playerguid })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                },
                comment: "Guild System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "playerbot_saved_data",
                columns: table => new
                {
                    guid = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    combat_order = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    primary_target = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    secondary_target = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    pname = table.Column<string>(type: "varchar(12)", maxLength: 12, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    sname = table.Column<string>(type: "varchar(12)", maxLength: 12, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    combat_delay = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    auto_follow = table.Column<uint>(type: "int(11) unsigned", nullable: false, defaultValueSql: "'1'"),
                    autoequip = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.guid);
                },
                comment: "Persistent Playerbot settings per alt")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "pvpstats_battlegrounds",
                columns: table => new
                {
                    id = table.Column<ulong>(type: "bigint(20) unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    winner_team = table.Column<sbyte>(type: "tinyint(3)", nullable: false),
                    bracket_id = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    type = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    date = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pvpstats_battlegrounds", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "pvpstats_players",
                columns: table => new
                {
                    battleground_id = table.Column<ulong>(type: "bigint(20) unsigned", nullable: false),
                    character_guid = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    score_killing_blows = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    score_deaths = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    score_honorable_kills = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    score_bonus_honor = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    score_damage_done = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    score_healing_done = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    attr_1 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    attr_2 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    attr_3 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    attr_4 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    attr_5 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.battleground_id, x.character_guid })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "saved_variables",
                columns: table => new
                {
                    NextArenaPointDistributionTime = table.Column<ulong>(type: "bigint(40) unsigned", nullable: false),
                    NextDailyQuestResetTime = table.Column<ulong>(type: "bigint(40) unsigned", nullable: false),
                    NextWeeklyQuestResetTime = table.Column<ulong>(type: "bigint(40) unsigned", nullable: false),
                    NextMonthlyQuestResetTime = table.Column<ulong>(type: "bigint(40) unsigned", nullable: false),
                    cleaning_flags = table.Column<uint>(type: "int(11) unsigned", nullable: false)
                },
                constraints: table =>
                {
                },
                comment: "Variable Saves")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "world",
                columns: table => new
                {
                    map = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    data = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.map);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "world_state",
                columns: table => new
                {
                    Id = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Internal save ID"),
                    Data = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_world_state", x => x.Id);
                },
                comment: "WorldState save system")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateIndex(
                name: "idx_guid",
                table: "character_gifts",
                column: "guid");

            migrationBuilder.CreateIndex(
                name: "instance",
                table: "character_instance",
                column: "instance");

            migrationBuilder.CreateIndex(
                name: "idx_guid1",
                table: "character_inventory",
                column: "guid");

            migrationBuilder.CreateIndex(
                name: "owner",
                table: "character_pet",
                column: "owner");

            migrationBuilder.CreateIndex(
                name: "owner_key",
                table: "character_pet_declinedname",
                column: "owner");

            migrationBuilder.CreateIndex(
                name: "friend_flags",
                table: "character_social",
                columns: new[] { "friend", "flags" });

            migrationBuilder.CreateIndex(
                name: "guid_flags",
                table: "character_social",
                columns: new[] { "guid", "flags" });

            migrationBuilder.CreateIndex(
                name: "Idx_spell",
                table: "character_spell",
                column: "spell");

            migrationBuilder.CreateIndex(
                name: "idx_account",
                table: "characters",
                column: "account");

            migrationBuilder.CreateIndex(
                name: "idx_name",
                table: "characters",
                column: "name");

            migrationBuilder.CreateIndex(
                name: "idx_online",
                table: "characters",
                column: "online");

            migrationBuilder.CreateIndex(
                name: "Idx_player",
                table: "corpse",
                column: "player");

            migrationBuilder.CreateIndex(
                name: "Idx_time",
                table: "corpse",
                column: "time");

            migrationBuilder.CreateIndex(
                name: "idx_type",
                table: "corpse",
                column: "corpse_type");

            migrationBuilder.CreateIndex(
                name: "instance1",
                table: "corpse",
                column: "instance");

            migrationBuilder.CreateIndex(
                name: "instance2",
                table: "creature_respawn",
                column: "instance");

            migrationBuilder.CreateIndex(
                name: "instance3",
                table: "gameobject_respawn",
                column: "instance");

            migrationBuilder.CreateIndex(
                name: "instance4",
                table: "group_instance",
                column: "instance");

            migrationBuilder.CreateIndex(
                name: "Idx_memberGuid",
                table: "group_member",
                column: "memberGuid");

            migrationBuilder.CreateIndex(
                name: "leaderGuid",
                table: "groups",
                column: "leaderGuid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Idx_LogGuid",
                table: "guild_bank_eventlog",
                column: "LogGuid");

            migrationBuilder.CreateIndex(
                name: "Idx_PlayerGuid",
                table: "guild_bank_eventlog",
                column: "PlayerGuid");

            migrationBuilder.CreateIndex(
                name: "Idx_item_guid",
                table: "guild_bank_item",
                column: "item_guid");

            migrationBuilder.CreateIndex(
                name: "Idx_LogGuid1",
                table: "guild_eventlog",
                column: "LogGuid");

            migrationBuilder.CreateIndex(
                name: "Idx_PlayerGuid1",
                table: "guild_eventlog",
                column: "PlayerGuid1");

            migrationBuilder.CreateIndex(
                name: "Idx_PlayerGuid2",
                table: "guild_eventlog",
                column: "PlayerGuid2");

            migrationBuilder.CreateIndex(
                name: "guid_key",
                table: "guild_member",
                column: "guid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "guildid_rank_key",
                table: "guild_member",
                columns: new[] { "guildid", "rank" });

            migrationBuilder.CreateIndex(
                name: "Idx_rid",
                table: "guild_rank",
                column: "rid");

            migrationBuilder.CreateIndex(
                name: "map",
                table: "instance",
                column: "map");

            migrationBuilder.CreateIndex(
                name: "resettime",
                table: "instance",
                column: "resettime");

            migrationBuilder.CreateIndex(
                name: "idx_owner_guid",
                table: "item_instance",
                column: "owner_guid");

            migrationBuilder.CreateIndex(
                name: "idx_owner_guid1",
                table: "item_loot",
                column: "owner_guid");

            migrationBuilder.CreateIndex(
                name: "idx_receiver",
                table: "mail",
                column: "receiver");

            migrationBuilder.CreateIndex(
                name: "idx_receiver1",
                table: "mail_items",
                column: "receiver");

            migrationBuilder.CreateIndex(
                name: "index_ownerguid_petitionguid",
                table: "petition",
                columns: new[] { "ownerguid", "petitionguid" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "Idx_ownerguid",
                table: "petition_sign",
                column: "ownerguid");

            migrationBuilder.CreateIndex(
                name: "Idx_playerguid",
                table: "petition_sign",
                column: "playerguid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "account_data");

            migrationBuilder.DropTable(
                name: "account_instances_entered");

            migrationBuilder.DropTable(
                name: "ahbot_items");

            migrationBuilder.DropTable(
                name: "arena_team");

            migrationBuilder.DropTable(
                name: "arena_team_member");

            migrationBuilder.DropTable(
                name: "arena_team_stats");

            migrationBuilder.DropTable(
                name: "auction");

            migrationBuilder.DropTable(
                name: "bugreport");

            migrationBuilder.DropTable(
                name: "character_account_data");

            migrationBuilder.DropTable(
                name: "character_action");

            migrationBuilder.DropTable(
                name: "character_aura");

            migrationBuilder.DropTable(
                name: "character_battleground_data");

            migrationBuilder.DropTable(
                name: "character_db_version");

            migrationBuilder.DropTable(
                name: "character_declinedname");

            migrationBuilder.DropTable(
                name: "character_gifts");

            migrationBuilder.DropTable(
                name: "character_homebind");

            migrationBuilder.DropTable(
                name: "character_instance");

            migrationBuilder.DropTable(
                name: "character_inventory");

            migrationBuilder.DropTable(
                name: "character_pet");

            migrationBuilder.DropTable(
                name: "character_pet_declinedname");

            migrationBuilder.DropTable(
                name: "character_queststatus");

            migrationBuilder.DropTable(
                name: "character_queststatus_daily");

            migrationBuilder.DropTable(
                name: "character_queststatus_monthly");

            migrationBuilder.DropTable(
                name: "character_queststatus_weekly");

            migrationBuilder.DropTable(
                name: "character_reputation");

            migrationBuilder.DropTable(
                name: "character_skills");

            migrationBuilder.DropTable(
                name: "character_social");

            migrationBuilder.DropTable(
                name: "character_spell");

            migrationBuilder.DropTable(
                name: "character_spell_cooldown");

            migrationBuilder.DropTable(
                name: "character_stats");

            migrationBuilder.DropTable(
                name: "character_tutorial");

            migrationBuilder.DropTable(
                name: "characters");

            migrationBuilder.DropTable(
                name: "corpse");

            migrationBuilder.DropTable(
                name: "creature_respawn");

            migrationBuilder.DropTable(
                name: "event_group_chosen");

            migrationBuilder.DropTable(
                name: "game_event_status");

            migrationBuilder.DropTable(
                name: "gameobject_respawn");

            migrationBuilder.DropTable(
                name: "gm_surveys");

            migrationBuilder.DropTable(
                name: "gm_tickets");

            migrationBuilder.DropTable(
                name: "group_instance");

            migrationBuilder.DropTable(
                name: "group_member");

            migrationBuilder.DropTable(
                name: "groups");

            migrationBuilder.DropTable(
                name: "guild");

            migrationBuilder.DropTable(
                name: "guild_bank_eventlog");

            migrationBuilder.DropTable(
                name: "guild_bank_item");

            migrationBuilder.DropTable(
                name: "guild_bank_right");

            migrationBuilder.DropTable(
                name: "guild_bank_tab");

            migrationBuilder.DropTable(
                name: "guild_eventlog");

            migrationBuilder.DropTable(
                name: "guild_member");

            migrationBuilder.DropTable(
                name: "guild_rank");

            migrationBuilder.DropTable(
                name: "instance");

            migrationBuilder.DropTable(
                name: "instance_reset");

            migrationBuilder.DropTable(
                name: "item_instance");

            migrationBuilder.DropTable(
                name: "item_loot");

            migrationBuilder.DropTable(
                name: "item_text");

            migrationBuilder.DropTable(
                name: "mail");

            migrationBuilder.DropTable(
                name: "mail_items");

            migrationBuilder.DropTable(
                name: "pet_aura");

            migrationBuilder.DropTable(
                name: "pet_spell");

            migrationBuilder.DropTable(
                name: "pet_spell_cooldown");

            migrationBuilder.DropTable(
                name: "petition");

            migrationBuilder.DropTable(
                name: "petition_sign");

            migrationBuilder.DropTable(
                name: "playerbot_saved_data");

            migrationBuilder.DropTable(
                name: "pvpstats_battlegrounds");

            migrationBuilder.DropTable(
                name: "pvpstats_players");

            migrationBuilder.DropTable(
                name: "saved_variables");

            migrationBuilder.DropTable(
                name: "world");

            migrationBuilder.DropTable(
                name: "world_state");
        }
    }
}
