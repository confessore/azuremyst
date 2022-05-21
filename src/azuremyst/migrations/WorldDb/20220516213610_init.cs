using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace azuremyst.Migrations.WorldDb
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "areatrigger_involvedrelation",
                columns: table => new
                {
                    id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'", comment: "Identifier"),
                    quest = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'", comment: "Quest Identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_areatrigger_involvedrelation", x => x.id);
                },
                comment: "Trigger System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "areatrigger_tavern",
                columns: table => new
                {
                    id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'", comment: "Identifier"),
                    name = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_areatrigger_tavern", x => x.id);
                },
                comment: "Trigger System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "areatrigger_teleport",
                columns: table => new
                {
                    id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'", comment: "Identifier"),
                    name = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    required_level = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    required_item = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    required_item2 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    heroic_key = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    heroic_key2 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    required_quest_done = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    required_quest_done_heroic = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    target_map = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    target_position_x = table.Column<float>(type: "float", nullable: false),
                    target_position_y = table.Column<float>(type: "float", nullable: false),
                    target_position_z = table.Column<float>(type: "float", nullable: false),
                    target_orientation = table.Column<float>(type: "float", nullable: false),
                    condition_id = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    status_failed_text = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_areatrigger_teleport", x => x.id);
                },
                comment: "Trigger System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "battleground_events",
                columns: table => new
                {
                    map = table.Column<short>(type: "smallint(5)", nullable: false),
                    event1 = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    event2 = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.map, x.event1, x.event2 })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "battleground_template",
                columns: table => new
                {
                    id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    MinPlayersPerTeam = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    MaxPlayersPerTeam = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    MinLvl = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    MaxLvl = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    AllianceStartLoc = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    HordeStartLoc = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    StartMaxDist = table.Column<float>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_battleground_template", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "battlemaster_entry",
                columns: table => new
                {
                    entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'", comment: "Entry of a creature"),
                    bg_template = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'", comment: "Battleground template id")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.entry);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "command",
                columns: table => new
                {
                    name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    security = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    help = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.name);
                },
                comment: "Chat System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "conditions",
                columns: table => new
                {
                    condition_entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, comment: "Identifier")
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    type = table.Column<sbyte>(type: "tinyint(3)", nullable: false, comment: "Type of the condition"),
                    value1 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'", comment: "data field one for the condition"),
                    value2 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'", comment: "data field two for the condition"),
                    value3 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'", comment: "data field three for the condition"),
                    value4 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'", comment: "data field four for the condition"),
                    flags = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    comments = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.condition_entry);
                },
                comment: "Condition System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "creature",
                columns: table => new
                {
                    guid = table.Column<uint>(type: "int(10) unsigned", nullable: false, comment: "Global Unique Identifier")
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'", comment: "Creature Identifier"),
                    map = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false, comment: "Map Identifier"),
                    spawnMask = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false, defaultValueSql: "'1'"),
                    modelid = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    equipment_id = table.Column<int>(type: "mediumint(9)", nullable: false, defaultValueSql: "'0'"),
                    position_x = table.Column<float>(type: "float", nullable: false),
                    position_y = table.Column<float>(type: "float", nullable: false),
                    position_z = table.Column<float>(type: "float", nullable: false),
                    orientation = table.Column<float>(type: "float", nullable: false),
                    spawntimesecsmin = table.Column<uint>(type: "int(10) unsigned", nullable: false, defaultValueSql: "'120'", comment: "Creature respawn time minimum"),
                    spawntimesecsmax = table.Column<uint>(type: "int(10) unsigned", nullable: false, defaultValueSql: "'120'", comment: "Creature respawn time maximum"),
                    spawndist = table.Column<float>(type: "float", nullable: false, defaultValueSql: "'5'"),
                    currentwaypoint = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    curhealth = table.Column<uint>(type: "int(10) unsigned", nullable: false, defaultValueSql: "'1'"),
                    curmana = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    DeathState = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    MovementType = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.guid);
                },
                comment: "Creature System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "creature_addon",
                columns: table => new
                {
                    guid = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    mount = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    bytes1 = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    b2_0_sheath = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    b2_1_flags = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    emote = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    moveflags = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    auras = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.guid);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "creature_ai_scripts",
                columns: table => new
                {
                    id = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Identifier")
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    creature_id = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Creature Template Identifier"),
                    event_type = table.Column<byte>(type: "tinyint(5) unsigned", nullable: false, comment: "Event Type"),
                    event_inverse_phase_mask = table.Column<int>(type: "int(11)", nullable: false, comment: "Mask which phases this event will not trigger in"),
                    event_chance = table.Column<uint>(type: "int(3) unsigned", nullable: false, defaultValueSql: "'100'"),
                    event_flags = table.Column<uint>(type: "int(3) unsigned", nullable: false),
                    event_param1 = table.Column<int>(type: "int(11)", nullable: false),
                    event_param2 = table.Column<int>(type: "int(11)", nullable: false),
                    event_param3 = table.Column<int>(type: "int(11)", nullable: false),
                    event_param4 = table.Column<int>(type: "int(11)", nullable: false),
                    event_param5 = table.Column<int>(type: "int(11)", nullable: false),
                    event_param6 = table.Column<int>(type: "int(11)", nullable: false),
                    action1_type = table.Column<byte>(type: "tinyint(5) unsigned", nullable: false, comment: "Action Type"),
                    action1_param1 = table.Column<int>(type: "int(11)", nullable: false),
                    action1_param2 = table.Column<int>(type: "int(11)", nullable: false),
                    action1_param3 = table.Column<int>(type: "int(11)", nullable: false),
                    action2_type = table.Column<byte>(type: "tinyint(5) unsigned", nullable: false, comment: "Action Type"),
                    action2_param1 = table.Column<int>(type: "int(11)", nullable: false),
                    action2_param2 = table.Column<int>(type: "int(11)", nullable: false),
                    action2_param3 = table.Column<int>(type: "int(11)", nullable: false),
                    action3_type = table.Column<byte>(type: "tinyint(5) unsigned", nullable: false, comment: "Action Type"),
                    action3_param1 = table.Column<int>(type: "int(11)", nullable: false),
                    action3_param2 = table.Column<int>(type: "int(11)", nullable: false),
                    action3_param3 = table.Column<int>(type: "int(11)", nullable: false),
                    comment = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, defaultValueSql: "''", comment: "Event Comment", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_creature_ai_scripts", x => x.id);
                },
                comment: "EventAI Scripts")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "creature_ai_summons",
                columns: table => new
                {
                    id = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Location Identifier")
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    position_x = table.Column<float>(type: "float", nullable: false),
                    position_y = table.Column<float>(type: "float", nullable: false),
                    position_z = table.Column<float>(type: "float", nullable: false),
                    orientation = table.Column<float>(type: "float", nullable: false),
                    spawntimesecs = table.Column<uint>(type: "int(11) unsigned", nullable: false, defaultValueSql: "'120'"),
                    comment = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, defaultValueSql: "''", comment: "Summon Comment", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_creature_ai_summons", x => x.id);
                },
                comment: "EventAI Summoning Locations")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "creature_ai_texts",
                columns: table => new
                {
                    entry = table.Column<int>(type: "mediumint(8)", nullable: false),
                    content_default = table.Column<string>(type: "text", nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    content_loc1 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    content_loc2 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    content_loc3 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    content_loc4 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    content_loc5 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    content_loc6 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    content_loc7 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    content_loc8 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    sound = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    type = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    language = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    emote = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    broadcast_text_id = table.Column<int>(type: "int(11)", nullable: false),
                    comment = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.entry);
                },
                comment: "Script Texts")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "creature_battleground",
                columns: table => new
                {
                    guid = table.Column<uint>(type: "int(10) unsigned", nullable: false, comment: "Creature's GUID"),
                    event1 = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false, comment: "main event"),
                    event2 = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false, comment: "sub event")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.guid);
                },
                comment: "Creature battleground indexing system")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "creature_conditional_spawn",
                columns: table => new
                {
                    Guid = table.Column<uint>(type: "int(10) unsigned", nullable: false, comment: "Global Unique Identifier")
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    EntryAlliance = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'", comment: "Alliance Creature Identifier"),
                    EntryHorde = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'", comment: "Horde Creature Identifier"),
                    Comments = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Guid);
                },
                comment: "Creature System (Conditional Spawn)")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "creature_cooldowns",
                columns: table => new
                {
                    Entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    SpellId = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    CooldownMin = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    CooldownMax = table.Column<uint>(type: "int(10) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.Entry, x.SpellId })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "creature_equip_template",
                columns: table => new
                {
                    entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'", comment: "Unique entry"),
                    equipentry1 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    equipentry2 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    equipentry3 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.entry);
                },
                comment: "Creature System (Equipment)")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "creature_equip_template_raw",
                columns: table => new
                {
                    entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'", comment: "Unique entry"),
                    equipmodel1 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    equipmodel2 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    equipmodel3 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    equipinfo1 = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    equipinfo2 = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    equipinfo3 = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    equipslot1 = table.Column<int>(type: "int(11)", nullable: false),
                    equipslot2 = table.Column<int>(type: "int(11)", nullable: false),
                    equipslot3 = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.entry);
                },
                comment: "Creature System (Equipment)")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "creature_immunities",
                columns: table => new
                {
                    Entry = table.Column<uint>(type: "int(10) unsigned", nullable: false, comment: "creature_template entry"),
                    SetId = table.Column<uint>(type: "int(10) unsigned", nullable: false, comment: "immunity set ID"),
                    Type = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false, comment: "enum SpellImmunity"),
                    Value = table.Column<uint>(type: "int(10) unsigned", nullable: false, comment: "value depending on type")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.Entry, x.SetId, x.Type, x.Value })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "creature_involvedrelation",
                columns: table => new
                {
                    id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'", comment: "Identifier"),
                    quest = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'", comment: "Quest Identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.id, x.quest })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                },
                comment: "Creature System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "creature_linking",
                columns: table => new
                {
                    guid = table.Column<uint>(type: "int(10) unsigned", nullable: false, comment: "creature.guid of the slave mob that is linked"),
                    master_guid = table.Column<uint>(type: "int(10) unsigned", nullable: false, comment: "master to trigger events"),
                    flag = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, comment: "flag - describing what should happen when")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.guid);
                },
                comment: "Creature Linking System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "creature_linking_template",
                columns: table => new
                {
                    entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'", comment: "creature_template.entry of the slave mob that is linked"),
                    map = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false, comment: "Id of map of the mobs"),
                    master_entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'", comment: "master to trigger events"),
                    flag = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'", comment: "flag - describing what should happen when"),
                    search_range = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'", comment: "search_range - describing in which range (spawn-coords) master and slave are linked together")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.entry, x.map })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                },
                comment: "Creature Linking System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "creature_loot_template",
                columns: table => new
                {
                    entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'", comment: "entry 0 used for player insignia loot"),
                    item = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    ChanceOrQuestChance = table.Column<float>(type: "float", nullable: false, defaultValueSql: "'100'"),
                    groupid = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    mincountOrRef = table.Column<int>(type: "mediumint(9)", nullable: false, defaultValueSql: "'1'"),
                    maxcount = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false, defaultValueSql: "'1'"),
                    condition_id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    comments = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.entry, x.item })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                },
                comment: "Loot System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "creature_model_info",
                columns: table => new
                {
                    modelid = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    bounding_radius = table.Column<float>(type: "float", nullable: false),
                    combat_reach = table.Column<float>(type: "float", nullable: false),
                    SpeedWalk = table.Column<float>(type: "float", nullable: false, defaultValueSql: "'1'", comment: "Default walking speed for any creature with model"),
                    SpeedRun = table.Column<float>(type: "float", nullable: false, defaultValueSql: "'1.14286'", comment: "Default running speed for any creature with model"),
                    gender = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false, defaultValueSql: "'2'"),
                    modelid_other_gender = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    modelid_alternative = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.modelid);
                },
                comment: "Creature System (Model related info)")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "creature_model_race",
                columns: table => new
                {
                    modelid = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    racemask = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    creature_entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'", comment: "option 1, modelid_N from creature_template"),
                    modelid_racial = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'", comment: "option 2, explicit modelid")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.modelid, x.racemask })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                },
                comment: "Model system")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "creature_movement",
                columns: table => new
                {
                    Id = table.Column<uint>(type: "int(10) unsigned", nullable: false, comment: "Creature GUID"),
                    Point = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    PositionX = table.Column<float>(type: "float", nullable: false),
                    PositionY = table.Column<float>(type: "float", nullable: false),
                    PositionZ = table.Column<float>(type: "float", nullable: false),
                    Orientation = table.Column<float>(type: "float", nullable: false),
                    WaitTime = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    ScriptId = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    Comment = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.Id, x.Point })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                },
                comment: "Creature System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "creature_movement_template",
                columns: table => new
                {
                    Entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, comment: "Creature entry"),
                    PathId = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Path ID for entry"),
                    Point = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    PositionX = table.Column<float>(type: "float", nullable: false),
                    PositionY = table.Column<float>(type: "float", nullable: false),
                    PositionZ = table.Column<float>(type: "float", nullable: false),
                    Orientation = table.Column<float>(type: "float", nullable: false),
                    WaitTime = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    ScriptId = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    Comment = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.Entry, x.PathId, x.Point })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
                },
                comment: "Creature waypoint system")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "creature_onkill_reputation",
                columns: table => new
                {
                    creature_id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'", comment: "Creature Identifier"),
                    RewOnKillRepFaction1 = table.Column<short>(type: "smallint(6)", nullable: false),
                    RewOnKillRepFaction2 = table.Column<short>(type: "smallint(6)", nullable: false),
                    MaxStanding1 = table.Column<sbyte>(type: "tinyint(4)", nullable: false),
                    IsTeamAward1 = table.Column<sbyte>(type: "tinyint(4)", nullable: false),
                    RewOnKillRepValue1 = table.Column<int>(type: "mediumint(9)", nullable: false, defaultValueSql: "'0'"),
                    MaxStanding2 = table.Column<sbyte>(type: "tinyint(4)", nullable: false),
                    IsTeamAward2 = table.Column<sbyte>(type: "tinyint(4)", nullable: false),
                    RewOnKillRepValue2 = table.Column<int>(type: "mediumint(9)", nullable: false, defaultValueSql: "'0'"),
                    TeamDependent = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.creature_id);
                },
                comment: "Creature OnKill Reputation gain")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "creature_questrelation",
                columns: table => new
                {
                    id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'", comment: "Identifier"),
                    quest = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'", comment: "Quest Identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.id, x.quest })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                },
                comment: "Creature System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "creature_spawn_data",
                columns: table => new
                {
                    Guid = table.Column<uint>(type: "int(10) unsigned", nullable: false, comment: "guid of creature"),
                    Id = table.Column<uint>(type: "int(10) unsigned", nullable: false, comment: "ID of template")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Guid);
                },
                comment: "Creature System (Spawn Data)")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "creature_spawn_data_template",
                columns: table => new
                {
                    Entry = table.Column<uint>(type: "int(10) unsigned", nullable: false, comment: "ID of template"),
                    UnitFlags = table.Column<long>(type: "bigint(20)", nullable: false, defaultValueSql: "-1"),
                    ModelId = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    EquipmentId = table.Column<int>(type: "mediumint(9)", nullable: false, defaultValueSql: "'0'"),
                    CurHealth = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    CurMana = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    SpawnFlags = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    NpcFlags = table.Column<int>(type: "int(11)", nullable: false, defaultValueSql: "-1"),
                    Faction = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    RelayId = table.Column<uint>(type: "int(10) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.Entry, x.UnitFlags, x.ModelId, x.EquipmentId, x.CurHealth, x.CurMana, x.SpawnFlags })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0, 0 });
                },
                comment: "Creature System (Spawn Data Template)")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "creature_spawn_entry",
                columns: table => new
                {
                    guid = table.Column<uint>(type: "int(10) unsigned", nullable: false, comment: "Global Unique Identifier"),
                    entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.guid, x.entry })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                },
                comment: "Creature System (Spawn Entry)")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "creature_spell_list",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int(11)", nullable: false, comment: "List ID"),
                    Position = table.Column<int>(type: "int(11)", nullable: false, comment: "Position on list"),
                    SpellId = table.Column<int>(type: "int(11)", nullable: false, comment: "Spell ID"),
                    Flags = table.Column<int>(type: "int(11)", nullable: false, comment: "Spell Flags"),
                    TargetId = table.Column<int>(type: "int(11)", nullable: false, comment: "Targeting ID"),
                    ScriptId = table.Column<int>(type: "int(11)", nullable: false, comment: "Dbscript to be launched on success"),
                    Availability = table.Column<int>(type: "int(11)", nullable: false, comment: "Chance on spawn for spell to be included"),
                    Probability = table.Column<int>(type: "int(11)", nullable: false, comment: "Weight of spell when multiple are available"),
                    InitialMin = table.Column<int>(type: "int(11)", nullable: false, comment: "Initial delay minimum"),
                    InitialMax = table.Column<int>(type: "int(11)", nullable: false, comment: "Initial delay maximum"),
                    RepeatMin = table.Column<int>(type: "int(11)", nullable: false, comment: "Repeated delay minimum"),
                    RepeatMax = table.Column<int>(type: "int(11)", nullable: false, comment: "Repeated delay maximum"),
                    Comments = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, comment: "Description of spell use", collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.Id, x.Position })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "creature_spell_list_entry",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int(11)", nullable: false, comment: "List ID"),
                    Name = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false, comment: "Description of usage", collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ChanceSupportAction = table.Column<int>(type: "int(11)", nullable: false, comment: "Chance of support action per tick"),
                    ChanceRangedAttack = table.Column<int>(type: "int(11)", nullable: false, comment: "Chance of ranged attack per tick")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_creature_spell_list_entry", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "creature_spell_targeting",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int(11)", nullable: false, comment: "Targeting ID"),
                    Type = table.Column<int>(type: "int(11)", nullable: false, comment: "Type of targeting ID"),
                    Param1 = table.Column<int>(type: "int(11)", nullable: false, comment: "First parameter"),
                    Param2 = table.Column<int>(type: "int(11)", nullable: false, comment: "Second parameter"),
                    Param3 = table.Column<int>(type: "int(11)", nullable: false, comment: "Third parameter"),
                    Comments = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, comment: "Description of target", collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_creature_spell_targeting", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "creature_template",
                columns: table => new
                {
                    Entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    Name = table.Column<string>(type: "char(100)", fixedLength: true, maxLength: 100, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    SubName = table.Column<string>(type: "char(100)", fixedLength: true, maxLength: 100, nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    IconName = table.Column<string>(type: "char(100)", fixedLength: true, maxLength: 100, nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    MinLevel = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false, defaultValueSql: "'1'"),
                    MaxLevel = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false, defaultValueSql: "'1'"),
                    HeroicEntry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    ModelId1 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    ModelId2 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    ModelId3 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    ModelId4 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    Faction = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    Scale = table.Column<float>(type: "float", nullable: false, defaultValueSql: "'1'"),
                    Family = table.Column<sbyte>(type: "tinyint(4)", nullable: false),
                    CreatureType = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    InhabitType = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false, defaultValueSql: "'3'"),
                    RegenerateStats = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false, defaultValueSql: "'3'"),
                    RacialLeader = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    NpcFlags = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    UnitFlags = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    DynamicFlags = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    ExtraFlags = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    CreatureTypeFlags = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    SpeedWalk = table.Column<float>(type: "float", nullable: false),
                    SpeedRun = table.Column<float>(type: "float", nullable: false),
                    Detection = table.Column<uint>(type: "int(10) unsigned", nullable: false, defaultValueSql: "'20'", comment: "Detection range for proximity"),
                    CallForHelp = table.Column<uint>(type: "int(10) unsigned", nullable: false, comment: "Range in which creature calls for help?"),
                    Pursuit = table.Column<uint>(type: "int(10) unsigned", nullable: false, comment: "When exceeded during pursuit creature evades?"),
                    Leash = table.Column<uint>(type: "int(10) unsigned", nullable: false, comment: "Leash range from combat start position"),
                    Timeout = table.Column<uint>(type: "int(10) unsigned", nullable: false, comment: "Time for refreshing leashing before evade?"),
                    UnitClass = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    Rank = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    Expansion = table.Column<sbyte>(type: "tinyint(3)", nullable: false, defaultValueSql: "-1"),
                    HealthMultiplier = table.Column<float>(type: "float", nullable: false, defaultValueSql: "'1'"),
                    PowerMultiplier = table.Column<float>(type: "float", nullable: false, defaultValueSql: "'1'"),
                    DamageMultiplier = table.Column<float>(type: "float", nullable: false, defaultValueSql: "'1'"),
                    DamageVariance = table.Column<float>(type: "float", nullable: false, defaultValueSql: "'1'"),
                    ArmorMultiplier = table.Column<float>(type: "float", nullable: false, defaultValueSql: "'1'"),
                    ExperienceMultiplier = table.Column<float>(type: "float", nullable: false, defaultValueSql: "'1'"),
                    MinLevelHealth = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    MaxLevelHealth = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    MinLevelMana = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    MaxLevelMana = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    MinMeleeDmg = table.Column<float>(type: "float", nullable: false),
                    MaxMeleeDmg = table.Column<float>(type: "float", nullable: false),
                    MinRangedDmg = table.Column<float>(type: "float", nullable: false),
                    MaxRangedDmg = table.Column<float>(type: "float", nullable: false),
                    Armor = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    MeleeAttackPower = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    RangedAttackPower = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    MeleeBaseAttackTime = table.Column<uint>(type: "int(10) unsigned", nullable: false, defaultValueSql: "'2000'"),
                    RangedBaseAttackTime = table.Column<uint>(type: "int(10) unsigned", nullable: false, defaultValueSql: "'2000'"),
                    DamageSchool = table.Column<sbyte>(type: "tinyint(4)", nullable: false),
                    MinLootGold = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    MaxLootGold = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    LootId = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    PickpocketLootId = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    SkinningLootId = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    KillCredit1 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    KillCredit2 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    MechanicImmuneMask = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    SchoolImmuneMask = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    ResistanceHoly = table.Column<short>(type: "smallint(5)", nullable: false),
                    ResistanceFire = table.Column<short>(type: "smallint(5)", nullable: false),
                    ResistanceNature = table.Column<short>(type: "smallint(5)", nullable: false),
                    ResistanceFrost = table.Column<short>(type: "smallint(5)", nullable: false),
                    ResistanceShadow = table.Column<short>(type: "smallint(5)", nullable: false),
                    ResistanceArcane = table.Column<short>(type: "smallint(5)", nullable: false),
                    PetSpellDataId = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    MovementType = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    TrainerType = table.Column<sbyte>(type: "tinyint(4)", nullable: false),
                    TrainerSpell = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    TrainerClass = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    TrainerRace = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    TrainerTemplateId = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    VendorTemplateId = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    EquipmentTemplateId = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    GossipMenuId = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    InteractionPauseTimer = table.Column<int>(type: "int(10)", nullable: false, defaultValueSql: "-1"),
                    VisibilityDistanceType = table.Column<sbyte>(type: "tinyint(4)", nullable: false),
                    CorpseDecay = table.Column<uint>(type: "int(10) unsigned", nullable: false, comment: "Time before corpse despawns"),
                    SpellList = table.Column<int>(type: "int(11)", nullable: false, comment: "creature_spell_list_entry"),
                    AIName = table.Column<string>(type: "char(64)", fixedLength: true, maxLength: 64, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    ScriptName = table.Column<string>(type: "char(64)", fixedLength: true, maxLength: 64, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Entry);
                },
                comment: "Creature System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "creature_template_addon",
                columns: table => new
                {
                    entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    mount = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    bytes1 = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    b2_0_sheath = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    b2_1_flags = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    emote = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    moveflags = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    auras = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.entry);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "creature_template_spells",
                columns: table => new
                {
                    entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    setId = table.Column<uint>(type: "int(10) unsigned", nullable: false, comment: "Id of set of spells"),
                    spell1 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    spell2 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    spell3 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    spell4 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    spell5 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    spell6 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    spell7 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    spell8 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    spell9 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    spell10 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.entry, x.setId })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                },
                comment: "Creature System (Spells used by creature)")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "custom_texts",
                columns: table => new
                {
                    entry = table.Column<int>(type: "mediumint(8)", nullable: false),
                    content_default = table.Column<string>(type: "text", nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    content_loc1 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    content_loc2 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    content_loc3 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    content_loc4 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    content_loc5 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    content_loc6 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    content_loc7 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    content_loc8 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    sound = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    type = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    language = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    emote = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    comment = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.entry);
                },
                comment: "Custom Texts")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "db_version",
                columns: table => new
                {
                    version = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    creature_ai_version = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    required_s2450_01_mangos_quest_maxlevel = table.Column<ulong>(type: "bit(1)", nullable: true)
                },
                constraints: table =>
                {
                },
                comment: "Used DB version notes")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "dbscript_random_templates",
                columns: table => new
                {
                    id = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Id of template"),
                    type = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Type of template"),
                    target_id = table.Column<int>(type: "int(11)", nullable: false, comment: "Id of chanced element"),
                    chance = table.Column<int>(type: "int(11)", nullable: false, comment: "Chance for element to occur in %"),
                    comments = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.id, x.type, x.target_id })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
                },
                comment: "DBScript system")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "dbscript_string",
                columns: table => new
                {
                    entry = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    content_default = table.Column<string>(type: "text", nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    content_loc1 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    content_loc2 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    content_loc3 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    content_loc4 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    content_loc5 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    content_loc6 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    content_loc7 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    content_loc8 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    sound = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    type = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    language = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    emote = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    broadcast_text_id = table.Column<int>(type: "int(11)", nullable: false),
                    comment = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.entry);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "dbscript_string_template",
                columns: table => new
                {
                    id = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Id of template")
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    string_id = table.Column<int>(type: "int(11)", nullable: false, comment: "dbscript_string id")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.id, x.string_id })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                },
                comment: "DBScript system")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "dbscripts_on_creature_death",
                columns: table => new
                {
                    id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    delay = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    priority = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    command = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    datalong = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    datalong2 = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    datalong3 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    buddy_entry = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    search_radius = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    data_flags = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    dataint = table.Column<int>(type: "int(11)", nullable: false),
                    dataint2 = table.Column<int>(type: "int(11)", nullable: false),
                    dataint3 = table.Column<int>(type: "int(11)", nullable: false),
                    dataint4 = table.Column<int>(type: "int(11)", nullable: false),
                    datafloat = table.Column<float>(type: "float", nullable: false),
                    x = table.Column<float>(type: "float", nullable: false),
                    y = table.Column<float>(type: "float", nullable: false),
                    z = table.Column<float>(type: "float", nullable: false),
                    o = table.Column<float>(type: "float", nullable: false),
                    speed = table.Column<float>(type: "float", nullable: false),
                    condition_id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    comments = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "dbscripts_on_creature_movement",
                columns: table => new
                {
                    id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    delay = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    priority = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    command = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    datalong = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    datalong2 = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    datalong3 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    buddy_entry = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    search_radius = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    data_flags = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    dataint = table.Column<int>(type: "int(11)", nullable: false),
                    dataint2 = table.Column<int>(type: "int(11)", nullable: false),
                    dataint3 = table.Column<int>(type: "int(11)", nullable: false),
                    dataint4 = table.Column<int>(type: "int(11)", nullable: false),
                    datafloat = table.Column<float>(type: "float", nullable: false),
                    x = table.Column<float>(type: "float", nullable: false),
                    y = table.Column<float>(type: "float", nullable: false),
                    z = table.Column<float>(type: "float", nullable: false),
                    o = table.Column<float>(type: "float", nullable: false),
                    speed = table.Column<float>(type: "float", nullable: false),
                    condition_id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    comments = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "dbscripts_on_event",
                columns: table => new
                {
                    id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    delay = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    priority = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    command = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    datalong = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    datalong2 = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    datalong3 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    buddy_entry = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    search_radius = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    data_flags = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    dataint = table.Column<int>(type: "int(11)", nullable: false),
                    dataint2 = table.Column<int>(type: "int(11)", nullable: false),
                    dataint3 = table.Column<int>(type: "int(11)", nullable: false),
                    dataint4 = table.Column<int>(type: "int(11)", nullable: false),
                    datafloat = table.Column<float>(type: "float", nullable: false),
                    x = table.Column<float>(type: "float", nullable: false),
                    y = table.Column<float>(type: "float", nullable: false),
                    z = table.Column<float>(type: "float", nullable: false),
                    o = table.Column<float>(type: "float", nullable: false),
                    speed = table.Column<float>(type: "float", nullable: false),
                    condition_id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    comments = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "dbscripts_on_go_template_use",
                columns: table => new
                {
                    id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    delay = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    priority = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    command = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    datalong = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    datalong2 = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    datalong3 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    buddy_entry = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    search_radius = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    data_flags = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    dataint = table.Column<int>(type: "int(11)", nullable: false),
                    dataint2 = table.Column<int>(type: "int(11)", nullable: false),
                    dataint3 = table.Column<int>(type: "int(11)", nullable: false),
                    dataint4 = table.Column<int>(type: "int(11)", nullable: false),
                    datafloat = table.Column<float>(type: "float", nullable: false),
                    x = table.Column<float>(type: "float", nullable: false),
                    y = table.Column<float>(type: "float", nullable: false),
                    z = table.Column<float>(type: "float", nullable: false),
                    o = table.Column<float>(type: "float", nullable: false),
                    speed = table.Column<float>(type: "float", nullable: false),
                    condition_id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    comments = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "dbscripts_on_go_use",
                columns: table => new
                {
                    id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    delay = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    priority = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    command = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    datalong = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    datalong2 = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    datalong3 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    buddy_entry = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    search_radius = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    data_flags = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    dataint = table.Column<int>(type: "int(11)", nullable: false),
                    dataint2 = table.Column<int>(type: "int(11)", nullable: false),
                    dataint3 = table.Column<int>(type: "int(11)", nullable: false),
                    dataint4 = table.Column<int>(type: "int(11)", nullable: false),
                    datafloat = table.Column<float>(type: "float", nullable: false),
                    x = table.Column<float>(type: "float", nullable: false),
                    y = table.Column<float>(type: "float", nullable: false),
                    z = table.Column<float>(type: "float", nullable: false),
                    o = table.Column<float>(type: "float", nullable: false),
                    speed = table.Column<float>(type: "float", nullable: false),
                    condition_id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    comments = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "dbscripts_on_gossip",
                columns: table => new
                {
                    id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    delay = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    priority = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    command = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    datalong = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    datalong2 = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    datalong3 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    buddy_entry = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    search_radius = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    data_flags = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    dataint = table.Column<int>(type: "int(11)", nullable: false),
                    dataint2 = table.Column<int>(type: "int(11)", nullable: false),
                    dataint3 = table.Column<int>(type: "int(11)", nullable: false),
                    dataint4 = table.Column<int>(type: "int(11)", nullable: false),
                    datafloat = table.Column<float>(type: "float", nullable: false),
                    x = table.Column<float>(type: "float", nullable: false),
                    y = table.Column<float>(type: "float", nullable: false),
                    z = table.Column<float>(type: "float", nullable: false),
                    o = table.Column<float>(type: "float", nullable: false),
                    speed = table.Column<float>(type: "float", nullable: false),
                    condition_id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    comments = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "dbscripts_on_quest_end",
                columns: table => new
                {
                    id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    delay = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    priority = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    command = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    datalong = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    datalong2 = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    datalong3 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    buddy_entry = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    search_radius = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    data_flags = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    dataint = table.Column<int>(type: "int(11)", nullable: false),
                    dataint2 = table.Column<int>(type: "int(11)", nullable: false),
                    dataint3 = table.Column<int>(type: "int(11)", nullable: false),
                    dataint4 = table.Column<int>(type: "int(11)", nullable: false),
                    datafloat = table.Column<float>(type: "float", nullable: false),
                    x = table.Column<float>(type: "float", nullable: false),
                    y = table.Column<float>(type: "float", nullable: false),
                    z = table.Column<float>(type: "float", nullable: false),
                    o = table.Column<float>(type: "float", nullable: false),
                    speed = table.Column<float>(type: "float", nullable: false),
                    condition_id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    comments = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "dbscripts_on_quest_start",
                columns: table => new
                {
                    id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    delay = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    priority = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    command = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    datalong = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    datalong2 = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    datalong3 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    buddy_entry = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    search_radius = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    data_flags = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    dataint = table.Column<int>(type: "int(11)", nullable: false),
                    dataint2 = table.Column<int>(type: "int(11)", nullable: false),
                    dataint3 = table.Column<int>(type: "int(11)", nullable: false),
                    dataint4 = table.Column<int>(type: "int(11)", nullable: false),
                    datafloat = table.Column<float>(type: "float", nullable: false),
                    x = table.Column<float>(type: "float", nullable: false),
                    y = table.Column<float>(type: "float", nullable: false),
                    z = table.Column<float>(type: "float", nullable: false),
                    o = table.Column<float>(type: "float", nullable: false),
                    speed = table.Column<float>(type: "float", nullable: false),
                    condition_id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    comments = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "dbscripts_on_spell",
                columns: table => new
                {
                    id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    delay = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    priority = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    command = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    datalong = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    datalong2 = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    datalong3 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    buddy_entry = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    search_radius = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    data_flags = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    dataint = table.Column<int>(type: "int(11)", nullable: false),
                    dataint2 = table.Column<int>(type: "int(11)", nullable: false),
                    dataint3 = table.Column<int>(type: "int(11)", nullable: false),
                    dataint4 = table.Column<int>(type: "int(11)", nullable: false),
                    datafloat = table.Column<float>(type: "float", nullable: false),
                    x = table.Column<float>(type: "float", nullable: false),
                    y = table.Column<float>(type: "float", nullable: false),
                    z = table.Column<float>(type: "float", nullable: false),
                    o = table.Column<float>(type: "float", nullable: false),
                    speed = table.Column<float>(type: "float", nullable: false),
                    condition_id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    comments = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "disenchant_loot_template",
                columns: table => new
                {
                    entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'", comment: "Recommended id selection: item_level*100 + item_quality"),
                    item = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    ChanceOrQuestChance = table.Column<float>(type: "float", nullable: false, defaultValueSql: "'100'"),
                    groupid = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    mincountOrRef = table.Column<int>(type: "mediumint(9)", nullable: false, defaultValueSql: "'1'"),
                    maxcount = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false, defaultValueSql: "'1'"),
                    condition_id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    comments = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.entry, x.item })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                },
                comment: "Loot System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "exploration_basexp",
                columns: table => new
                {
                    level = table.Column<sbyte>(type: "tinyint(4)", nullable: false),
                    basexp = table.Column<int>(type: "mediumint(9)", nullable: false, defaultValueSql: "'0'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.level);
                },
                comment: "Exploration System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "fishing_loot_template",
                columns: table => new
                {
                    entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'", comment: "entry 0 used for junk loot at fishing fail (if allowed by config option)"),
                    item = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    ChanceOrQuestChance = table.Column<float>(type: "float", nullable: false, defaultValueSql: "'100'"),
                    groupid = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    mincountOrRef = table.Column<int>(type: "mediumint(9)", nullable: false, defaultValueSql: "'1'"),
                    maxcount = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false, defaultValueSql: "'1'"),
                    condition_id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    comments = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.entry, x.item })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                },
                comment: "Loot System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "game_event",
                columns: table => new
                {
                    entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, comment: "Entry of the game event"),
                    occurence = table.Column<ulong>(type: "bigint(20) unsigned", nullable: false, defaultValueSql: "'86400'", comment: "Delay in minutes between occurences of the event"),
                    length = table.Column<ulong>(type: "bigint(20) unsigned", nullable: false, defaultValueSql: "'43200'", comment: "Length in minutes of the event"),
                    holiday = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'", comment: "Client side holiday id"),
                    linkedTo = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'", comment: "This event starts only if defined LinkedTo event is started"),
                    EventGroup = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'", comment: "Used for events that are randomized daily/weekly"),
                    description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, comment: "Description of the event displayed in console", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.entry);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "game_event_creature",
                columns: table => new
                {
                    guid = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    @event = table.Column<short>(name: "event", type: "smallint(6)", nullable: false, comment: "Negatives value to remove during event and ignore pool grouping, positive value for spawn during event and if guid is part of pool then al pool memebers must be listed as part of event spawn.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.guid, x.@event })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "game_event_creature_data",
                columns: table => new
                {
                    guid = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    @event = table.Column<ushort>(name: "event", type: "smallint(5) unsigned", nullable: false),
                    entry_id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    modelid = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    equipment_id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    vendor_id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    spell_start = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    spell_end = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.guid, x.@event })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "game_event_gameobject",
                columns: table => new
                {
                    guid = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    @event = table.Column<short>(name: "event", type: "smallint(6)", nullable: false, comment: "Negatives value to remove during event and ignore pool grouping, positive value for spawn during event and if guid is part of pool then al pool memebers must be listed as part of event spawn.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.guid, x.@event })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "game_event_mail",
                columns: table => new
                {
                    @event = table.Column<short>(name: "event", type: "smallint(6)", nullable: false, comment: "Negatives value to send at event stop, positive value for send at event start."),
                    raceMask = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    quest = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    mailTemplateId = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    senderEntry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.@event, x.raceMask, x.quest })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
                },
                comment: "Game event system")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "game_event_quest",
                columns: table => new
                {
                    quest = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'", comment: "entry from quest_template"),
                    @event = table.Column<ushort>(name: "event", type: "smallint(5) unsigned", nullable: false, comment: "entry from game_event")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.quest, x.@event })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                },
                comment: "Game event system")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "game_event_time",
                columns: table => new
                {
                    entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, comment: "Entry of the game event"),
                    start_time = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'", comment: "Absolute start date, the event will never start before"),
                    end_time = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "'1970-01-01 00:00:00'", comment: "Absolute end date, the event will never start after")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.entry);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "game_graveyard_zone",
                columns: table => new
                {
                    id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    ghost_loc = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    link_kind = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    faction = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.id, x.ghost_loc, x.link_kind })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
                },
                comment: "Graveyard link definitions")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "game_tele",
                columns: table => new
                {
                    id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    position_x = table.Column<float>(type: "float", nullable: false),
                    position_y = table.Column<float>(type: "float", nullable: false),
                    position_z = table.Column<float>(type: "float", nullable: false),
                    orientation = table.Column<float>(type: "float", nullable: false),
                    map = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_game_tele", x => x.id);
                },
                comment: "Tele Command")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "game_weather",
                columns: table => new
                {
                    zone = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    spring_rain_chance = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false, defaultValueSql: "'25'"),
                    spring_snow_chance = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false, defaultValueSql: "'25'"),
                    spring_storm_chance = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false, defaultValueSql: "'25'"),
                    summer_rain_chance = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false, defaultValueSql: "'25'"),
                    summer_snow_chance = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false, defaultValueSql: "'25'"),
                    summer_storm_chance = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false, defaultValueSql: "'25'"),
                    fall_rain_chance = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false, defaultValueSql: "'25'"),
                    fall_snow_chance = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false, defaultValueSql: "'25'"),
                    fall_storm_chance = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false, defaultValueSql: "'25'"),
                    winter_rain_chance = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false, defaultValueSql: "'25'"),
                    winter_snow_chance = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false, defaultValueSql: "'25'"),
                    winter_storm_chance = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false, defaultValueSql: "'25'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.zone);
                },
                comment: "Weather System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "gameobject",
                columns: table => new
                {
                    guid = table.Column<uint>(type: "int(10) unsigned", nullable: false, comment: "Global Unique Identifier")
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'", comment: "Gameobject Identifier"),
                    map = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false, comment: "Map Identifier"),
                    spawnMask = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false, defaultValueSql: "'1'"),
                    position_x = table.Column<float>(type: "float", nullable: false),
                    position_y = table.Column<float>(type: "float", nullable: false),
                    position_z = table.Column<float>(type: "float", nullable: false),
                    orientation = table.Column<float>(type: "float", nullable: false),
                    rotation0 = table.Column<float>(type: "float", nullable: false),
                    rotation1 = table.Column<float>(type: "float", nullable: false),
                    rotation2 = table.Column<float>(type: "float", nullable: false),
                    rotation3 = table.Column<float>(type: "float", nullable: false),
                    spawntimesecsmin = table.Column<int>(type: "int(11)", nullable: false, comment: "GameObject respawn time minimum"),
                    spawntimesecsmax = table.Column<int>(type: "int(11)", nullable: false, comment: "Gameobject respawn time maximum"),
                    animprogress = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    state = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.guid);
                },
                comment: "Gameobject System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "gameobject_battleground",
                columns: table => new
                {
                    guid = table.Column<uint>(type: "int(10) unsigned", nullable: false, comment: "GameObject's GUID"),
                    event1 = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false, comment: "main event"),
                    event2 = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false, comment: "sub event")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.guid);
                },
                comment: "GameObject battleground indexing system")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "gameobject_involvedrelation",
                columns: table => new
                {
                    id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    quest = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'", comment: "Quest Identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.id, x.quest })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "gameobject_loot_template",
                columns: table => new
                {
                    entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    item = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    ChanceOrQuestChance = table.Column<float>(type: "float", nullable: false, defaultValueSql: "'100'"),
                    groupid = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    mincountOrRef = table.Column<int>(type: "mediumint(9)", nullable: false, defaultValueSql: "'1'"),
                    maxcount = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false, defaultValueSql: "'1'"),
                    condition_id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    comments = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.entry, x.item })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                },
                comment: "Loot System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "gameobject_questrelation",
                columns: table => new
                {
                    id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    quest = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'", comment: "Quest Identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.id, x.quest })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "gameobject_spawn_entry",
                columns: table => new
                {
                    guid = table.Column<uint>(type: "int(10) unsigned", nullable: false, comment: "Gameobject table guid"),
                    entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, comment: "Gameobject Template entry")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.guid, x.entry })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "gameobject_template",
                columns: table => new
                {
                    entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    type = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    displayId = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    IconName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    castBarCaption = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    faction = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    flags = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    ExtraFlags = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    size = table.Column<float>(type: "float", nullable: false, defaultValueSql: "'1'"),
                    data0 = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    data1 = table.Column<int>(type: "int(10)", nullable: false),
                    data2 = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    data3 = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    data4 = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    data5 = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    data6 = table.Column<int>(type: "int(10)", nullable: false),
                    data7 = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    data8 = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    data9 = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    data10 = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    data11 = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    data12 = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    data13 = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    data14 = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    data15 = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    data16 = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    data17 = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    data18 = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    data19 = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    data20 = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    data21 = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    data22 = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    data23 = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    CustomData1 = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    mingold = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    maxgold = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    ScriptName = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.entry);
                },
                comment: "Gameobject System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "gameobject_template_addon",
                columns: table => new
                {
                    Entry = table.Column<uint>(type: "int(10) unsigned", nullable: false, comment: "gameobject_template"),
                    Artkit0 = table.Column<int>(type: "int(11)", nullable: false),
                    Artkit1 = table.Column<int>(type: "int(11)", nullable: false),
                    Artkit2 = table.Column<int>(type: "int(11)", nullable: false),
                    Artkit3 = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Entry);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "gossip_menu",
                columns: table => new
                {
                    entry = table.Column<ushort>(type: "smallint(6) unsigned", nullable: false),
                    text_id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    script_id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'", comment: "script in `dbscripts_on_gossip` - will be executed on GossipHello"),
                    condition_id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.entry, x.text_id, x.script_id })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "gossip_menu_option",
                columns: table => new
                {
                    menu_id = table.Column<ushort>(type: "smallint(6) unsigned", nullable: false),
                    id = table.Column<ushort>(type: "smallint(6) unsigned", nullable: false),
                    option_icon = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    option_text = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    option_broadcast_text = table.Column<int>(type: "int(11)", nullable: false),
                    option_id = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    npc_option_npcflag = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    action_menu_id = table.Column<int>(type: "mediumint(8)", nullable: false, defaultValueSql: "'0'"),
                    action_poi_id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    action_script_id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    box_coded = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    box_money = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    box_text = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    box_broadcast_text = table.Column<int>(type: "int(11)", nullable: false),
                    condition_id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.menu_id, x.id })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "gossip_texts",
                columns: table => new
                {
                    entry = table.Column<int>(type: "mediumint(8)", nullable: false),
                    content_default = table.Column<string>(type: "text", nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    content_loc1 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    content_loc2 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    content_loc3 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    content_loc4 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    content_loc5 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    content_loc6 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    content_loc7 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    content_loc8 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    comment = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.entry);
                },
                comment: "Gossip Texts")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "instance_encounters",
                columns: table => new
                {
                    entry = table.Column<uint>(type: "int(10) unsigned", nullable: false, comment: "Unique entry from DungeonEncounter.dbc"),
                    creditType = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    creditEntry = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    lastEncounterDungeon = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false, comment: "If not 0, LfgDungeon.dbc entry for the instance it is last encounter in")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.entry);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "instance_template",
                columns: table => new
                {
                    map = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    parent = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    levelMin = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    levelMax = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    maxPlayers = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    reset_delay = table.Column<uint>(type: "int(10) unsigned", nullable: false, comment: "Reset time in days"),
                    ScriptName = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    mountAllowed = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.map);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "item_enchantment_template",
                columns: table => new
                {
                    entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    ench = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    chance = table.Column<float>(type: "float unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.entry, x.ench })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                },
                comment: "Item Random Enchantment System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "item_loot_template",
                columns: table => new
                {
                    entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    item = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    ChanceOrQuestChance = table.Column<float>(type: "float", nullable: false, defaultValueSql: "'100'"),
                    groupid = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    mincountOrRef = table.Column<int>(type: "mediumint(9)", nullable: false, defaultValueSql: "'1'"),
                    maxcount = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false, defaultValueSql: "'1'"),
                    condition_id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    comments = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.entry, x.item })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                },
                comment: "Loot System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "item_required_target",
                columns: table => new
                {
                    entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    type = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    targetEntry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "item_template",
                columns: table => new
                {
                    entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    @class = table.Column<byte>(name: "class", type: "tinyint(3) unsigned", nullable: false),
                    subclass = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    unk0 = table.Column<int>(type: "int(11)", nullable: false, defaultValueSql: "-1"),
                    name = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    displayid = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    Quality = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    Flags = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    BuyCount = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false, defaultValueSql: "'1'"),
                    BuyPrice = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    SellPrice = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    InventoryType = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    AllowableClass = table.Column<int>(type: "mediumint(9)", nullable: false, defaultValueSql: "-1"),
                    AllowableRace = table.Column<int>(type: "mediumint(9)", nullable: false, defaultValueSql: "-1"),
                    ItemLevel = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    RequiredLevel = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    RequiredSkill = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    RequiredSkillRank = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    requiredspell = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    requiredhonorrank = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    RequiredCityRank = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    RequiredReputationFaction = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    RequiredReputationRank = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    maxcount = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    stackable = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false, defaultValueSql: "'1'"),
                    ContainerSlots = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    stat_type1 = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    stat_value1 = table.Column<short>(type: "smallint(6)", nullable: false),
                    stat_type2 = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    stat_value2 = table.Column<short>(type: "smallint(6)", nullable: false),
                    stat_type3 = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    stat_value3 = table.Column<short>(type: "smallint(6)", nullable: false),
                    stat_type4 = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    stat_value4 = table.Column<short>(type: "smallint(6)", nullable: false),
                    stat_type5 = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    stat_value5 = table.Column<short>(type: "smallint(6)", nullable: false),
                    stat_type6 = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    stat_value6 = table.Column<short>(type: "smallint(6)", nullable: false),
                    stat_type7 = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    stat_value7 = table.Column<short>(type: "smallint(6)", nullable: false),
                    stat_type8 = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    stat_value8 = table.Column<short>(type: "smallint(6)", nullable: false),
                    stat_type9 = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    stat_value9 = table.Column<short>(type: "smallint(6)", nullable: false),
                    stat_type10 = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    stat_value10 = table.Column<short>(type: "smallint(6)", nullable: false),
                    dmg_min1 = table.Column<float>(type: "float", nullable: false),
                    dmg_max1 = table.Column<float>(type: "float", nullable: false),
                    dmg_type1 = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    dmg_min2 = table.Column<float>(type: "float", nullable: false),
                    dmg_max2 = table.Column<float>(type: "float", nullable: false),
                    dmg_type2 = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    dmg_min3 = table.Column<float>(type: "float", nullable: false),
                    dmg_max3 = table.Column<float>(type: "float", nullable: false),
                    dmg_type3 = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    dmg_min4 = table.Column<float>(type: "float", nullable: false),
                    dmg_max4 = table.Column<float>(type: "float", nullable: false),
                    dmg_type4 = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    dmg_min5 = table.Column<float>(type: "float", nullable: false),
                    dmg_max5 = table.Column<float>(type: "float", nullable: false),
                    dmg_type5 = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    armor = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    holy_res = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    fire_res = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    nature_res = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    frost_res = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    shadow_res = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    arcane_res = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    delay = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false, defaultValueSql: "'1000'"),
                    ammo_type = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    RangedModRange = table.Column<float>(type: "float", nullable: false),
                    spellid_1 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    spelltrigger_1 = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    spellcharges_1 = table.Column<sbyte>(type: "tinyint(4)", nullable: false),
                    spellppmRate_1 = table.Column<float>(type: "float", nullable: false),
                    spellcooldown_1 = table.Column<int>(type: "int(11)", nullable: false, defaultValueSql: "-1"),
                    spellcategory_1 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    spellcategorycooldown_1 = table.Column<int>(type: "int(11)", nullable: false, defaultValueSql: "-1"),
                    spellid_2 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    spelltrigger_2 = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    spellcharges_2 = table.Column<sbyte>(type: "tinyint(4)", nullable: false),
                    spellppmRate_2 = table.Column<float>(type: "float", nullable: false),
                    spellcooldown_2 = table.Column<int>(type: "int(11)", nullable: false, defaultValueSql: "-1"),
                    spellcategory_2 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    spellcategorycooldown_2 = table.Column<int>(type: "int(11)", nullable: false, defaultValueSql: "-1"),
                    spellid_3 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    spelltrigger_3 = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    spellcharges_3 = table.Column<sbyte>(type: "tinyint(4)", nullable: false),
                    spellppmRate_3 = table.Column<float>(type: "float", nullable: false),
                    spellcooldown_3 = table.Column<int>(type: "int(11)", nullable: false, defaultValueSql: "-1"),
                    spellcategory_3 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    spellcategorycooldown_3 = table.Column<int>(type: "int(11)", nullable: false, defaultValueSql: "-1"),
                    spellid_4 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    spelltrigger_4 = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    spellcharges_4 = table.Column<sbyte>(type: "tinyint(4)", nullable: false),
                    spellppmRate_4 = table.Column<float>(type: "float", nullable: false),
                    spellcooldown_4 = table.Column<int>(type: "int(11)", nullable: false, defaultValueSql: "-1"),
                    spellcategory_4 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    spellcategorycooldown_4 = table.Column<int>(type: "int(11)", nullable: false, defaultValueSql: "-1"),
                    spellid_5 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    spelltrigger_5 = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    spellcharges_5 = table.Column<sbyte>(type: "tinyint(4)", nullable: false),
                    spellppmRate_5 = table.Column<float>(type: "float", nullable: false),
                    spellcooldown_5 = table.Column<int>(type: "int(11)", nullable: false, defaultValueSql: "-1"),
                    spellcategory_5 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    spellcategorycooldown_5 = table.Column<int>(type: "int(11)", nullable: false, defaultValueSql: "-1"),
                    bonding = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    PageText = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    LanguageID = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    PageMaterial = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    startquest = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    lockid = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    Material = table.Column<sbyte>(type: "tinyint(4)", nullable: false),
                    sheath = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    RandomProperty = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    RandomSuffix = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    block = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    itemset = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    MaxDurability = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    area = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    Map = table.Column<short>(type: "smallint(6)", nullable: false),
                    BagFamily = table.Column<int>(type: "mediumint(9)", nullable: false, defaultValueSql: "'0'"),
                    TotemCategory = table.Column<sbyte>(type: "tinyint(4)", nullable: false),
                    socketColor_1 = table.Column<sbyte>(type: "tinyint(4)", nullable: false),
                    socketContent_1 = table.Column<int>(type: "mediumint(9)", nullable: false, defaultValueSql: "'0'"),
                    socketColor_2 = table.Column<sbyte>(type: "tinyint(4)", nullable: false),
                    socketContent_2 = table.Column<int>(type: "mediumint(9)", nullable: false, defaultValueSql: "'0'"),
                    socketColor_3 = table.Column<sbyte>(type: "tinyint(4)", nullable: false),
                    socketContent_3 = table.Column<int>(type: "mediumint(9)", nullable: false, defaultValueSql: "'0'"),
                    socketBonus = table.Column<int>(type: "mediumint(9)", nullable: false, defaultValueSql: "'0'"),
                    GemProperties = table.Column<int>(type: "mediumint(9)", nullable: false, defaultValueSql: "'0'"),
                    RequiredDisenchantSkill = table.Column<short>(type: "smallint(6)", nullable: false, defaultValueSql: "-1"),
                    ArmorDamageModifier = table.Column<float>(type: "float", nullable: false),
                    ScriptName = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    DisenchantID = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    FoodType = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    minMoneyLoot = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    maxMoneyLoot = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    Duration = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Duration in seconds"),
                    ExtraFlags = table.Column<byte>(type: "tinyint(1) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.entry);
                },
                comment: "Item System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "locales_areatrigger_teleport",
                columns: table => new
                {
                    Entry = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Entry of Areatrigger Teleport"),
                    Text_loc1 = table.Column<string>(type: "longtext", nullable: true, comment: "Text of the status_failed locale 1", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text_loc2 = table.Column<string>(type: "longtext", nullable: true, comment: "Text of the status_failed locale 2", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text_loc3 = table.Column<string>(type: "longtext", nullable: true, comment: "Text of the status_failed locale 3", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text_loc4 = table.Column<string>(type: "longtext", nullable: true, comment: "Text of the status_failed locale 4", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text_loc5 = table.Column<string>(type: "longtext", nullable: true, comment: "Text of the status_failed locale 5", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text_loc6 = table.Column<string>(type: "longtext", nullable: true, comment: "Text of the status_failed locale 6", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text_loc7 = table.Column<string>(type: "longtext", nullable: true, comment: "Text of the status_failed locale 7", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text_loc8 = table.Column<string>(type: "longtext", nullable: true, comment: "Text of the status_failed locale 8", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Entry);
                },
                comment: "Areatrigger System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "locales_creature",
                columns: table => new
                {
                    entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    name_loc1 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    name_loc2 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    name_loc3 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    name_loc4 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    name_loc5 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    name_loc6 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    name_loc7 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    name_loc8 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    subname_loc1 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    subname_loc2 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    subname_loc3 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    subname_loc4 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    subname_loc5 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    subname_loc6 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    subname_loc7 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    subname_loc8 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.entry);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "locales_gameobject",
                columns: table => new
                {
                    entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    name_loc1 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    name_loc2 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    name_loc3 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    name_loc4 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    name_loc5 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    name_loc6 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    name_loc7 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    name_loc8 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    castbarcaption_loc1 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    castbarcaption_loc2 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    castbarcaption_loc3 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    castbarcaption_loc4 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    castbarcaption_loc5 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    castbarcaption_loc6 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    castbarcaption_loc7 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    castbarcaption_loc8 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.entry);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "locales_gossip_menu_option",
                columns: table => new
                {
                    menu_id = table.Column<ushort>(type: "smallint(6) unsigned", nullable: false),
                    id = table.Column<ushort>(type: "smallint(6) unsigned", nullable: false),
                    option_text_loc1 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    option_text_loc2 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    option_text_loc3 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    option_text_loc4 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    option_text_loc5 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    option_text_loc6 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    option_text_loc7 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    option_text_loc8 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    box_text_loc1 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    box_text_loc2 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    box_text_loc3 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    box_text_loc4 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    box_text_loc5 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    box_text_loc6 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    box_text_loc7 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    box_text_loc8 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.menu_id, x.id })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "locales_item",
                columns: table => new
                {
                    entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    name_loc1 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    name_loc2 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    name_loc3 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    name_loc4 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    name_loc5 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    name_loc6 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    name_loc7 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    name_loc8 = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    description_loc1 = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    description_loc2 = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    description_loc3 = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    description_loc4 = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    description_loc5 = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    description_loc6 = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    description_loc7 = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    description_loc8 = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.entry);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "locales_npc_text",
                columns: table => new
                {
                    entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    Text0_0_loc1 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text0_0_loc2 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text0_0_loc3 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text0_0_loc4 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text0_0_loc5 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text0_0_loc6 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text0_0_loc7 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text0_0_loc8 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text0_1_loc1 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text0_1_loc2 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text0_1_loc3 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text0_1_loc4 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text0_1_loc5 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text0_1_loc6 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text0_1_loc7 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text0_1_loc8 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text1_0_loc1 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text1_0_loc2 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text1_0_loc3 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text1_0_loc4 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text1_0_loc5 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text1_0_loc6 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text1_0_loc7 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text1_0_loc8 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text1_1_loc1 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text1_1_loc2 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text1_1_loc3 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text1_1_loc4 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text1_1_loc5 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text1_1_loc6 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text1_1_loc7 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text1_1_loc8 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text2_0_loc1 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text2_0_loc2 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text2_0_loc3 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text2_0_loc4 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text2_0_loc5 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text2_0_loc6 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text2_0_loc7 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text2_0_loc8 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text2_1_loc1 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text2_1_loc2 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text2_1_loc3 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text2_1_loc4 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text2_1_loc5 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text2_1_loc6 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text2_1_loc7 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text2_1_loc8 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text3_0_loc1 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text3_0_loc2 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text3_0_loc3 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text3_0_loc4 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text3_0_loc5 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text3_0_loc6 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text3_0_loc7 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text3_0_loc8 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text3_1_loc1 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text3_1_loc2 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text3_1_loc3 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text3_1_loc4 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text3_1_loc5 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text3_1_loc6 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text3_1_loc7 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text3_1_loc8 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text4_0_loc1 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text4_0_loc2 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text4_0_loc3 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text4_0_loc4 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text4_0_loc5 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text4_0_loc6 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text4_0_loc7 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text4_0_loc8 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text4_1_loc1 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text4_1_loc2 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text4_1_loc3 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text4_1_loc4 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text4_1_loc5 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text4_1_loc6 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text4_1_loc7 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text4_1_loc8 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text5_0_loc1 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text5_0_loc2 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text5_0_loc3 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text5_0_loc4 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text5_0_loc5 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text5_0_loc6 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text5_0_loc7 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text5_0_loc8 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text5_1_loc1 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text5_1_loc2 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text5_1_loc3 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text5_1_loc4 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text5_1_loc5 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text5_1_loc6 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text5_1_loc7 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text5_1_loc8 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text6_0_loc1 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text6_0_loc2 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text6_0_loc3 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text6_0_loc4 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text6_0_loc5 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text6_0_loc6 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text6_0_loc7 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text6_0_loc8 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text6_1_loc1 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text6_1_loc2 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text6_1_loc3 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text6_1_loc4 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text6_1_loc5 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text6_1_loc6 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text6_1_loc7 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text6_1_loc8 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text7_0_loc1 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text7_0_loc2 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text7_0_loc3 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text7_0_loc4 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text7_0_loc5 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text7_0_loc6 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text7_0_loc7 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text7_0_loc8 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text7_1_loc1 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text7_1_loc2 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text7_1_loc3 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text7_1_loc4 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text7_1_loc5 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text7_1_loc6 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text7_1_loc7 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text7_1_loc8 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.entry);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "locales_page_text",
                columns: table => new
                {
                    entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    Text_loc1 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text_loc2 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text_loc3 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text_loc4 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text_loc5 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text_loc6 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text_loc7 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text_loc8 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.entry);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "locales_points_of_interest",
                columns: table => new
                {
                    entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    icon_name_loc1 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    icon_name_loc2 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    icon_name_loc3 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    icon_name_loc4 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    icon_name_loc5 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    icon_name_loc6 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    icon_name_loc7 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    icon_name_loc8 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.entry);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "locales_quest",
                columns: table => new
                {
                    entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    Title_loc1 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Title_loc2 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Title_loc3 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Title_loc4 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Title_loc5 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Title_loc6 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Title_loc7 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Title_loc8 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Details_loc1 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Details_loc2 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Details_loc3 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Details_loc4 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Details_loc5 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Details_loc6 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Details_loc7 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Details_loc8 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Objectives_loc1 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Objectives_loc2 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Objectives_loc3 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Objectives_loc4 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Objectives_loc5 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Objectives_loc6 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Objectives_loc7 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Objectives_loc8 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    OfferRewardText_loc1 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    OfferRewardText_loc2 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    OfferRewardText_loc3 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    OfferRewardText_loc4 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    OfferRewardText_loc5 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    OfferRewardText_loc6 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    OfferRewardText_loc7 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    OfferRewardText_loc8 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    RequestItemsText_loc1 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    RequestItemsText_loc2 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    RequestItemsText_loc3 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    RequestItemsText_loc4 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    RequestItemsText_loc5 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    RequestItemsText_loc6 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    RequestItemsText_loc7 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    RequestItemsText_loc8 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    EndText_loc1 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    EndText_loc2 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    EndText_loc3 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    EndText_loc4 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    EndText_loc5 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    EndText_loc6 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    EndText_loc7 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    EndText_loc8 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    ObjectiveText1_loc1 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    ObjectiveText1_loc2 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    ObjectiveText1_loc3 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    ObjectiveText1_loc4 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    ObjectiveText1_loc5 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    ObjectiveText1_loc6 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    ObjectiveText1_loc7 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    ObjectiveText1_loc8 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    ObjectiveText2_loc1 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    ObjectiveText2_loc2 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    ObjectiveText2_loc3 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    ObjectiveText2_loc4 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    ObjectiveText2_loc5 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    ObjectiveText2_loc6 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    ObjectiveText2_loc7 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    ObjectiveText2_loc8 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    ObjectiveText3_loc1 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    ObjectiveText3_loc2 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    ObjectiveText3_loc3 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    ObjectiveText3_loc4 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    ObjectiveText3_loc5 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    ObjectiveText3_loc6 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    ObjectiveText3_loc7 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    ObjectiveText3_loc8 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    ObjectiveText4_loc1 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    ObjectiveText4_loc2 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    ObjectiveText4_loc3 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    ObjectiveText4_loc4 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    ObjectiveText4_loc5 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    ObjectiveText4_loc6 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    ObjectiveText4_loc7 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    ObjectiveText4_loc8 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.entry);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "locales_questgiver_greeting",
                columns: table => new
                {
                    Entry = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Entry of Questgiver"),
                    Type = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Type of entry"),
                    Text_loc1 = table.Column<string>(type: "longtext", nullable: true, comment: "Text of the greeting locale 1", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text_loc2 = table.Column<string>(type: "longtext", nullable: true, comment: "Text of the greeting locale 2", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text_loc3 = table.Column<string>(type: "longtext", nullable: true, comment: "Text of the greeting locale 3", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text_loc4 = table.Column<string>(type: "longtext", nullable: true, comment: "Text of the greeting locale 4", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text_loc5 = table.Column<string>(type: "longtext", nullable: true, comment: "Text of the greeting locale 5", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text_loc6 = table.Column<string>(type: "longtext", nullable: true, comment: "Text of the greeting locale 6", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text_loc7 = table.Column<string>(type: "longtext", nullable: true, comment: "Text of the greeting locale 7", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text_loc8 = table.Column<string>(type: "longtext", nullable: true, comment: "Text of the greeting locale 8", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.Entry, x.Type })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                },
                comment: "Quest and Gossip system")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "locales_trainer_greeting",
                columns: table => new
                {
                    Entry = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Entry of Trainer"),
                    Text_loc1 = table.Column<string>(type: "longtext", nullable: true, comment: "Text of the greeting locale 1", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text_loc2 = table.Column<string>(type: "longtext", nullable: true, comment: "Text of the greeting locale 2", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text_loc3 = table.Column<string>(type: "longtext", nullable: true, comment: "Text of the greeting locale 3", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text_loc4 = table.Column<string>(type: "longtext", nullable: true, comment: "Text of the greeting locale 4", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text_loc5 = table.Column<string>(type: "longtext", nullable: true, comment: "Text of the greeting locale 5", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text_loc6 = table.Column<string>(type: "longtext", nullable: true, comment: "Text of the greeting locale 6", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text_loc7 = table.Column<string>(type: "longtext", nullable: true, comment: "Text of the greeting locale 7", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Text_loc8 = table.Column<string>(type: "longtext", nullable: true, comment: "Text of the greeting locale 8", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Entry);
                },
                comment: "Trainer system")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "mail_level_reward",
                columns: table => new
                {
                    level = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    raceMask = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    mailTemplateId = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    senderEntry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.level, x.raceMask })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                },
                comment: "Mail System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "mail_loot_template",
                columns: table => new
                {
                    entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    item = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    ChanceOrQuestChance = table.Column<float>(type: "float", nullable: false, defaultValueSql: "'100'"),
                    groupid = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    mincountOrRef = table.Column<int>(type: "mediumint(9)", nullable: false, defaultValueSql: "'1'"),
                    maxcount = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false, defaultValueSql: "'1'"),
                    condition_id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    comments = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.entry, x.item })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                },
                comment: "Loot System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "mangos_string",
                columns: table => new
                {
                    entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    content_default = table.Column<string>(type: "text", nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    content_loc1 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    content_loc2 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    content_loc3 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    content_loc4 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    content_loc5 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    content_loc6 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    content_loc7 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    content_loc8 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.entry);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "npc_gossip",
                columns: table => new
                {
                    npc_guid = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    textid = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.npc_guid);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "npc_text",
                columns: table => new
                {
                    ID = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    text0_0 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    text0_1 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    lang0 = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    prob0 = table.Column<float>(type: "float", nullable: false),
                    em0_0 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    em0_1 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    em0_2 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    em0_3 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    em0_4 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    em0_5 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    text1_0 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    text1_1 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    lang1 = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    prob1 = table.Column<float>(type: "float", nullable: false),
                    em1_0 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    em1_1 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    em1_2 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    em1_3 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    em1_4 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    em1_5 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    text2_0 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    text2_1 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    lang2 = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    prob2 = table.Column<float>(type: "float", nullable: false),
                    em2_0 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    em2_1 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    em2_2 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    em2_3 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    em2_4 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    em2_5 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    text3_0 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    text3_1 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    lang3 = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    prob3 = table.Column<float>(type: "float", nullable: false),
                    em3_0 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    em3_1 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    em3_2 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    em3_3 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    em3_4 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    em3_5 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    text4_0 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    text4_1 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    lang4 = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    prob4 = table.Column<float>(type: "float", nullable: false),
                    em4_0 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    em4_1 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    em4_2 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    em4_3 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    em4_4 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    em4_5 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    text5_0 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    text5_1 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    lang5 = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    prob5 = table.Column<float>(type: "float", nullable: false),
                    em5_0 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    em5_1 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    em5_2 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    em5_3 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    em5_4 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    em5_5 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    text6_0 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    text6_1 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    lang6 = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    prob6 = table.Column<float>(type: "float", nullable: false),
                    em6_0 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    em6_1 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    em6_2 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    em6_3 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    em6_4 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    em6_5 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    text7_0 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    text7_1 = table.Column<string>(type: "longtext", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    lang7 = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    prob7 = table.Column<float>(type: "float", nullable: false),
                    em7_0 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    em7_1 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    em7_2 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    em7_3 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    em7_4 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    em7_5 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_npc_text", x => x.ID);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "npc_text_broadcast_text",
                columns: table => new
                {
                    Id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, comment: "Identifier"),
                    Prob0 = table.Column<float>(type: "float", nullable: false),
                    Prob1 = table.Column<float>(type: "float", nullable: false),
                    Prob2 = table.Column<float>(type: "float", nullable: false),
                    Prob3 = table.Column<float>(type: "float", nullable: false),
                    Prob4 = table.Column<float>(type: "float", nullable: false),
                    Prob5 = table.Column<float>(type: "float", nullable: false),
                    Prob6 = table.Column<float>(type: "float", nullable: false),
                    Prob7 = table.Column<float>(type: "float", nullable: false),
                    BroadcastTextId0 = table.Column<int>(type: "int(11)", nullable: false),
                    BroadcastTextId1 = table.Column<int>(type: "int(11)", nullable: false),
                    BroadcastTextId2 = table.Column<int>(type: "int(11)", nullable: false),
                    BroadcastTextId3 = table.Column<int>(type: "int(11)", nullable: false),
                    BroadcastTextId4 = table.Column<int>(type: "int(11)", nullable: false),
                    BroadcastTextId5 = table.Column<int>(type: "int(11)", nullable: false),
                    BroadcastTextId6 = table.Column<int>(type: "int(11)", nullable: false),
                    BroadcastTextId7 = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_npc_text_broadcast_text", x => x.Id);
                },
                comment: "Broadcast Text npc_text equivalent")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "npc_trainer",
                columns: table => new
                {
                    entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    spell = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    spellcost = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    reqskill = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    reqskillvalue = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    reqlevel = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    condition_id = table.Column<uint>(type: "int(11) unsigned", nullable: false)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "npc_trainer_template",
                columns: table => new
                {
                    entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    spell = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    spellcost = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    reqskill = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    reqskillvalue = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    reqlevel = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    condition_id = table.Column<uint>(type: "int(11) unsigned", nullable: false)
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "npc_vendor",
                columns: table => new
                {
                    entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    item = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    maxcount = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    incrtime = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    slot = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    ExtendedCost = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    condition_id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.entry, x.item })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                },
                comment: "Npc System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "npc_vendor_template",
                columns: table => new
                {
                    entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    item = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    maxcount = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    incrtime = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    slot = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    ExtendedCost = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    condition_id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.entry, x.item })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                },
                comment: "Npc System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "page_text",
                columns: table => new
                {
                    entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    text = table.Column<string>(type: "longtext", nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    next_page = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.entry);
                },
                comment: "Item System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "pet_levelstats",
                columns: table => new
                {
                    creature_entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    level = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    hp = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    mana = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    armor = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    str = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    agi = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    sta = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    inte = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    spi = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.creature_entry, x.level })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                },
                comment: "Stores pet levels stats.")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "pet_name_generation",
                columns: table => new
                {
                    id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    word = table.Column<string>(type: "tinytext", nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    half = table.Column<sbyte>(type: "tinyint(4)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pet_name_generation", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "petcreateinfo_spell",
                columns: table => new
                {
                    entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    Spell1 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    Spell2 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    Spell3 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    Spell4 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.entry);
                },
                comment: "Pet Create Spells")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "pickpocketing_loot_template",
                columns: table => new
                {
                    entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    item = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    ChanceOrQuestChance = table.Column<float>(type: "float", nullable: false, defaultValueSql: "'100'"),
                    groupid = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    mincountOrRef = table.Column<int>(type: "mediumint(9)", nullable: false, defaultValueSql: "'1'"),
                    maxcount = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false, defaultValueSql: "'1'"),
                    condition_id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    comments = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.entry, x.item })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                },
                comment: "Loot System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "player_classlevelstats",
                columns: table => new
                {
                    @class = table.Column<byte>(name: "class", type: "tinyint(3) unsigned", nullable: false),
                    level = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    basehp = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    basemana = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.@class, x.level })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                },
                comment: "Stores levels stats.")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "player_levelstats",
                columns: table => new
                {
                    race = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    @class = table.Column<byte>(name: "class", type: "tinyint(3) unsigned", nullable: false),
                    level = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    str = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    agi = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    sta = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    inte = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    spi = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.race, x.@class, x.level })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
                },
                comment: "Stores levels stats.")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "player_xp_for_level",
                columns: table => new
                {
                    lvl = table.Column<uint>(type: "int(3) unsigned", nullable: false),
                    xp_for_next_level = table.Column<uint>(type: "int(10) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.lvl);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "playercreateinfo",
                columns: table => new
                {
                    race = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    @class = table.Column<byte>(name: "class", type: "tinyint(3) unsigned", nullable: false),
                    map = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    zone = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    position_x = table.Column<float>(type: "float", nullable: false),
                    position_y = table.Column<float>(type: "float", nullable: false),
                    position_z = table.Column<float>(type: "float", nullable: false),
                    orientation = table.Column<float>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.race, x.@class })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "playercreateinfo_action",
                columns: table => new
                {
                    race = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    @class = table.Column<byte>(name: "class", type: "tinyint(3) unsigned", nullable: false),
                    button = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    action = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    type = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.race, x.@class, x.button })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "playercreateinfo_item",
                columns: table => new
                {
                    race = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    @class = table.Column<byte>(name: "class", type: "tinyint(3) unsigned", nullable: false),
                    itemid = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    amount = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false, defaultValueSql: "'1'")
                },
                constraints: table =>
                {
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "playercreateinfo_skills",
                columns: table => new
                {
                    raceMask = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    classMask = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    skill = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    step = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    note = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.raceMask, x.classMask, x.skill })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "playercreateinfo_spell",
                columns: table => new
                {
                    race = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    @class = table.Column<byte>(name: "class", type: "tinyint(3) unsigned", nullable: false),
                    Spell = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    Note = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.race, x.@class, x.Spell })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "points_of_interest",
                columns: table => new
                {
                    entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    x = table.Column<float>(type: "float", nullable: false),
                    y = table.Column<float>(type: "float", nullable: false),
                    icon = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    flags = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    data = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    icon_name = table.Column<string>(type: "text", nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.entry);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "pool_creature",
                columns: table => new
                {
                    guid = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    pool_entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    chance = table.Column<float>(type: "float unsigned", nullable: false),
                    description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.guid);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "pool_creature_template",
                columns: table => new
                {
                    id = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    pool_entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    chance = table.Column<float>(type: "float unsigned", nullable: false),
                    description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pool_creature_template", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "pool_gameobject",
                columns: table => new
                {
                    guid = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    pool_entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    chance = table.Column<float>(type: "float unsigned", nullable: false),
                    description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.guid);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "pool_gameobject_template",
                columns: table => new
                {
                    id = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    pool_entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    chance = table.Column<float>(type: "float unsigned", nullable: false),
                    description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pool_gameobject_template", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "pool_pool",
                columns: table => new
                {
                    pool_id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    mother_pool = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    chance = table.Column<float>(type: "float", nullable: false),
                    description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.pool_id);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "pool_template",
                columns: table => new
                {
                    entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'", comment: "Pool entry"),
                    max_limit = table.Column<uint>(type: "int(10) unsigned", nullable: false, comment: "Max number of objects (0) is no limit"),
                    description = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.entry);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "prospecting_loot_template",
                columns: table => new
                {
                    entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    item = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    ChanceOrQuestChance = table.Column<float>(type: "float", nullable: false, defaultValueSql: "'100'"),
                    groupid = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    mincountOrRef = table.Column<int>(type: "mediumint(9)", nullable: false, defaultValueSql: "'1'"),
                    maxcount = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false, defaultValueSql: "'1'"),
                    condition_id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    comments = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.entry, x.item })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                },
                comment: "Loot System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "quest_template",
                columns: table => new
                {
                    entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    Method = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false, defaultValueSql: "'2'"),
                    ZoneOrSort = table.Column<short>(type: "smallint(6)", nullable: false),
                    MinLevel = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    MaxLevel = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false, defaultValueSql: "'255'"),
                    QuestLevel = table.Column<short>(type: "smallint(6)", nullable: false),
                    Type = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    RequiredClasses = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    RequiredRaces = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    RequiredSkill = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    RequiredSkillValue = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    RequiredCondition = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    RepObjectiveFaction = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    RepObjectiveValue = table.Column<int>(type: "mediumint(9)", nullable: false, defaultValueSql: "'0'"),
                    RequiredMinRepFaction = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    RequiredMinRepValue = table.Column<int>(type: "mediumint(9)", nullable: false, defaultValueSql: "'0'"),
                    RequiredMaxRepFaction = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    RequiredMaxRepValue = table.Column<int>(type: "mediumint(9)", nullable: false, defaultValueSql: "'0'"),
                    SuggestedPlayers = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    LimitTime = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    QuestFlags = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    SpecialFlags = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    CharTitleId = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    PrevQuestId = table.Column<int>(type: "mediumint(9)", nullable: false, defaultValueSql: "'0'"),
                    NextQuestId = table.Column<int>(type: "mediumint(9)", nullable: false, defaultValueSql: "'0'"),
                    ExclusiveGroup = table.Column<int>(type: "mediumint(9)", nullable: false, defaultValueSql: "'0'"),
                    BreadcrumbForQuestId = table.Column<uint>(type: "mediumint(9) unsigned", nullable: false, defaultValueSql: "'0'"),
                    NextQuestInChain = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    SrcItemId = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    SrcItemCount = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    SrcSpell = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    Title = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Details = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Objectives = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    OfferRewardText = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    RequestItemsText = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    EndText = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    ObjectiveText1 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    ObjectiveText2 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    ObjectiveText3 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    ObjectiveText4 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    ReqItemId1 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    ReqItemId2 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    ReqItemId3 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    ReqItemId4 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    ReqItemCount1 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    ReqItemCount2 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    ReqItemCount3 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    ReqItemCount4 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    ReqSourceId1 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    ReqSourceId2 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    ReqSourceId3 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    ReqSourceId4 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    ReqSourceCount1 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    ReqSourceCount2 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    ReqSourceCount3 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    ReqSourceCount4 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    ReqCreatureOrGOId1 = table.Column<int>(type: "mediumint(9)", nullable: false, defaultValueSql: "'0'"),
                    ReqCreatureOrGOId2 = table.Column<int>(type: "mediumint(9)", nullable: false, defaultValueSql: "'0'"),
                    ReqCreatureOrGOId3 = table.Column<int>(type: "mediumint(9)", nullable: false, defaultValueSql: "'0'"),
                    ReqCreatureOrGOId4 = table.Column<int>(type: "mediumint(9)", nullable: false, defaultValueSql: "'0'"),
                    ReqCreatureOrGOCount1 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    ReqCreatureOrGOCount2 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    ReqCreatureOrGOCount3 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    ReqCreatureOrGOCount4 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    ReqSpellCast1 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    ReqSpellCast2 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    ReqSpellCast3 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    ReqSpellCast4 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    RewChoiceItemId1 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    RewChoiceItemId2 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    RewChoiceItemId3 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    RewChoiceItemId4 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    RewChoiceItemId5 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    RewChoiceItemId6 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    RewChoiceItemCount1 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    RewChoiceItemCount2 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    RewChoiceItemCount3 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    RewChoiceItemCount4 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    RewChoiceItemCount5 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    RewChoiceItemCount6 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    RewItemId1 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    RewItemId2 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    RewItemId3 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    RewItemId4 = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    RewItemCount1 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    RewItemCount2 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    RewItemCount3 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    RewItemCount4 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    RewRepFaction1 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false, comment: "faction id from Faction.dbc in this case"),
                    RewRepFaction2 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false, comment: "faction id from Faction.dbc in this case"),
                    RewRepFaction3 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false, comment: "faction id from Faction.dbc in this case"),
                    RewRepFaction4 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false, comment: "faction id from Faction.dbc in this case"),
                    RewRepFaction5 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false, comment: "faction id from Faction.dbc in this case"),
                    RewRepValue1 = table.Column<int>(type: "mediumint(9)", nullable: false, defaultValueSql: "'0'"),
                    RewRepValue2 = table.Column<int>(type: "mediumint(9)", nullable: false, defaultValueSql: "'0'"),
                    RewRepValue3 = table.Column<int>(type: "mediumint(9)", nullable: false, defaultValueSql: "'0'"),
                    RewRepValue4 = table.Column<int>(type: "mediumint(9)", nullable: false, defaultValueSql: "'0'"),
                    RewRepValue5 = table.Column<int>(type: "mediumint(9)", nullable: false, defaultValueSql: "'0'"),
                    RewMaxRepValue1 = table.Column<int>(type: "mediumint(9)", nullable: false, defaultValueSql: "'42999'"),
                    RewMaxRepValue2 = table.Column<int>(type: "mediumint(9)", nullable: false, defaultValueSql: "'42999'"),
                    RewMaxRepValue3 = table.Column<int>(type: "mediumint(9)", nullable: false, defaultValueSql: "'42999'"),
                    RewMaxRepValue4 = table.Column<int>(type: "mediumint(9)", nullable: false, defaultValueSql: "'42999'"),
                    RewMaxRepValue5 = table.Column<int>(type: "mediumint(9)", nullable: false, defaultValueSql: "'42999'"),
                    RewHonorableKills = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    RewOrReqMoney = table.Column<int>(type: "int(11)", nullable: false),
                    RewMoneyMaxLevel = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    RewSpell = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    RewSpellCast = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    RewMailTemplateId = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    RewMailDelaySecs = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    PointMapId = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    PointX = table.Column<float>(type: "float", nullable: false),
                    PointY = table.Column<float>(type: "float", nullable: false),
                    PointOpt = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    DetailsEmote1 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    DetailsEmote2 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    DetailsEmote3 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    DetailsEmote4 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    DetailsEmoteDelay1 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    DetailsEmoteDelay2 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    DetailsEmoteDelay3 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    DetailsEmoteDelay4 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    IncompleteEmote = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    CompleteEmote = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    OfferRewardEmote1 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    OfferRewardEmote2 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    OfferRewardEmote3 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    OfferRewardEmote4 = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    OfferRewardEmoteDelay1 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    OfferRewardEmoteDelay2 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    OfferRewardEmoteDelay3 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    OfferRewardEmoteDelay4 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    StartScript = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    CompleteScript = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.entry);
                },
                comment: "Quest System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "questgiver_greeting",
                columns: table => new
                {
                    Entry = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Entry of Questgiver"),
                    Type = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Type of entry"),
                    Text = table.Column<string>(type: "longtext", nullable: true, comment: "Text of the greeting", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    EmoteId = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Emote ID of greeting"),
                    EmoteDelay = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Emote delay of the greeting")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.Entry, x.Type })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                },
                comment: "Quest and Gossip system")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "reference_loot_template",
                columns: table => new
                {
                    entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    item = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    ChanceOrQuestChance = table.Column<float>(type: "float", nullable: false, defaultValueSql: "'100'"),
                    groupid = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    mincountOrRef = table.Column<int>(type: "mediumint(9)", nullable: false, defaultValueSql: "'1'"),
                    maxcount = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false, defaultValueSql: "'1'"),
                    condition_id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    comments = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.entry, x.item })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                },
                comment: "Loot System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "reputation_reward_rate",
                columns: table => new
                {
                    faction = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    quest_rate = table.Column<float>(type: "float", nullable: false, defaultValueSql: "'1'"),
                    creature_rate = table.Column<float>(type: "float", nullable: false, defaultValueSql: "'1'"),
                    spell_rate = table.Column<float>(type: "float", nullable: false, defaultValueSql: "'1'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.faction);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "reputation_spillover_template",
                columns: table => new
                {
                    faction = table.Column<ushort>(type: "smallint(6) unsigned", nullable: false, comment: "faction entry"),
                    faction1 = table.Column<ushort>(type: "smallint(6) unsigned", nullable: false, comment: "faction to give spillover for"),
                    rate_1 = table.Column<float>(type: "float", nullable: false, comment: "the given rep points * rate"),
                    rank_1 = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false, comment: "max rank, above this will not give any spillover"),
                    faction2 = table.Column<ushort>(type: "smallint(6) unsigned", nullable: false),
                    rate_2 = table.Column<float>(type: "float", nullable: false),
                    rank_2 = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    faction3 = table.Column<ushort>(type: "smallint(6) unsigned", nullable: false),
                    rate_3 = table.Column<float>(type: "float", nullable: false),
                    rank_3 = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    faction4 = table.Column<ushort>(type: "smallint(6) unsigned", nullable: false),
                    rate_4 = table.Column<float>(type: "float", nullable: false),
                    rank_4 = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.faction);
                },
                comment: "Reputation spillover reputation gain")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "reserved_name",
                columns: table => new
                {
                    name = table.Column<string>(type: "varchar(12)", maxLength: 12, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.name);
                },
                comment: "Player Reserved Names")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "script_texts",
                columns: table => new
                {
                    entry = table.Column<int>(type: "mediumint(8)", nullable: false),
                    content_default = table.Column<string>(type: "text", nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    content_loc1 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    content_loc2 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    content_loc3 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    content_loc4 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    content_loc5 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    content_loc6 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    content_loc7 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    content_loc8 = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    sound = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    type = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    language = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    emote = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    broadcast_text_id = table.Column<int>(type: "int(11)", nullable: false),
                    comment = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.entry);
                },
                comment: "Script Texts")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "script_waypoint",
                columns: table => new
                {
                    Entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'", comment: "creature_template entry"),
                    PathId = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    Point = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    PositionX = table.Column<float>(type: "float", nullable: false),
                    PositionY = table.Column<float>(type: "float", nullable: false),
                    PositionZ = table.Column<float>(type: "float", nullable: false),
                    Orientation = table.Column<float>(type: "float", nullable: false),
                    WaitTime = table.Column<uint>(type: "int(10) unsigned", nullable: false, comment: "waittime in millisecs"),
                    ScriptId = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    Comment = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.Entry, x.PathId, x.Point })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });
                },
                comment: "Script Creature waypoints")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "scripted_areatrigger",
                columns: table => new
                {
                    entry = table.Column<int>(type: "mediumint(8)", nullable: false),
                    ScriptName = table.Column<string>(type: "char(64)", fixedLength: true, maxLength: 64, nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.entry);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "scripted_event_id",
                columns: table => new
                {
                    id = table.Column<int>(type: "mediumint(8)", nullable: false),
                    ScriptName = table.Column<string>(type: "char(64)", fixedLength: true, maxLength: 64, nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_scripted_event_id", x => x.id);
                },
                comment: "Script library scripted events")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "skill_discovery_template",
                columns: table => new
                {
                    spellId = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'", comment: "SpellId of the discoverable spell"),
                    reqSpell = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'", comment: "spell requirement"),
                    chance = table.Column<float>(type: "float", nullable: false, comment: "chance to discover")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.spellId);
                },
                comment: "Skill Discovery System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "skill_extra_item_template",
                columns: table => new
                {
                    spellId = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'", comment: "SpellId of the item creation spell"),
                    requiredSpecialization = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'", comment: "Specialization spell id"),
                    additionalCreateChance = table.Column<float>(type: "float", nullable: false, comment: "chance to create add"),
                    additionalMaxNum = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false, comment: "max num of adds")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.spellId);
                },
                comment: "Skill Specialization System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "skill_fishing_base_level",
                columns: table => new
                {
                    entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'", comment: "Area identifier"),
                    skill = table.Column<short>(type: "smallint(6)", nullable: false, comment: "Base skill level requirement")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.entry);
                },
                comment: "Fishing system")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "skinning_loot_template",
                columns: table => new
                {
                    entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    item = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    ChanceOrQuestChance = table.Column<float>(type: "float", nullable: false, defaultValueSql: "'100'"),
                    groupid = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    mincountOrRef = table.Column<int>(type: "mediumint(9)", nullable: false, defaultValueSql: "'1'"),
                    maxcount = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false, defaultValueSql: "'1'"),
                    condition_id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    comments = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.entry, x.item })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                },
                comment: "Loot System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "spam_records",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    record = table.Column<string>(type: "varchar(512)", maxLength: 512, nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_spam_records", x => x.id);
                },
                comment: "REGEX Spam records")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "spawn_group",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int(11)", nullable: false, comment: "Spawn Group ID"),
                    Name = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false, comment: "Description of usage", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    Type = table.Column<int>(type: "int(11)", nullable: false, comment: "Creature or GO spawn group"),
                    MaxCount = table.Column<int>(type: "int(11)", nullable: false, comment: "Maximum total count of all spawns in a group"),
                    WorldState = table.Column<int>(type: "int(11)", nullable: false, comment: "Worldstate which enables spawning of given group"),
                    Flags = table.Column<uint>(type: "int(10) unsigned", nullable: false, comment: "Flags for various behaviour")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_spawn_group", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "spawn_group_entry",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int(11)", nullable: false, comment: "Spawn Group ID"),
                    Entry = table.Column<int>(type: "int(11)", nullable: false, comment: "Entry of creature or GO"),
                    MinCount = table.Column<int>(type: "int(11)", nullable: false, comment: "Minimum count of entry in a group before random"),
                    MaxCount = table.Column<int>(type: "int(11)", nullable: false, comment: "Maximum total count of entry in a group"),
                    Chance = table.Column<int>(type: "int(11)", nullable: false, comment: "Chance for entry to be selected")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.Id, x.Entry })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "spawn_group_formation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int(11)", nullable: false, comment: "Spawn group id"),
                    FormationType = table.Column<sbyte>(type: "tinyint(11)", nullable: false, comment: "Formation shape 0..6"),
                    FormationSpread = table.Column<float>(type: "float(11,0)", nullable: false, comment: "Distance between formation members"),
                    FormationOptions = table.Column<int>(type: "int(11)", nullable: false, comment: "Keep formation compact (bit 1)"),
                    PathId = table.Column<int>(type: "int(11)", nullable: false, comment: "PathId from waypoint_path path"),
                    MovementType = table.Column<sbyte>(type: "tinyint(11)", nullable: false, comment: "Same as creature table"),
                    Comment = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_spawn_group_formation", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "spawn_group_linked_group",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int(11)", nullable: false, comment: "Spawn Group ID"),
                    LinkedId = table.Column<int>(type: "int(11)", nullable: false, comment: "Linked Spawn Group ID")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.Id, x.LinkedId })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "spawn_group_spawn",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int(11)", nullable: false, comment: "Spawn Group ID"),
                    Guid = table.Column<int>(type: "int(11)", nullable: false, comment: "Guid of creature or GO"),
                    SlotId = table.Column<sbyte>(type: "tinyint(4)", nullable: false, defaultValueSql: "-1", comment: "0 is the leader, -1 not part of the formation"),
                    Chance = table.Column<uint>(type: "int(10) unsigned", nullable: false, comment: "Chance for a spawn to occur")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.Id, x.Guid })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "spell_affect",
                columns: table => new
                {
                    entry = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    effectId = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    SpellFamilyMask = table.Column<ulong>(type: "bigint(20) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.entry, x.effectId })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "spell_area",
                columns: table => new
                {
                    spell = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    area = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    quest_start = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    quest_start_active = table.Column<byte>(type: "tinyint(1) unsigned", nullable: false),
                    aura_spell = table.Column<int>(type: "mediumint(8)", nullable: false, defaultValueSql: "'0'"),
                    racemask = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    gender = table.Column<byte>(type: "tinyint(1) unsigned", nullable: false, defaultValueSql: "'2'"),
                    quest_end = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    condition_id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    autocast = table.Column<byte>(type: "tinyint(1) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.spell, x.area, x.quest_start, x.quest_start_active, x.aura_spell, x.racemask, x.gender })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0, 0 });
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "spell_bonus_data",
                columns: table => new
                {
                    entry = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    direct_bonus = table.Column<float>(type: "float", nullable: false),
                    dot_bonus = table.Column<float>(type: "float", nullable: false),
                    ap_bonus = table.Column<float>(type: "float", nullable: false),
                    ap_dot_bonus = table.Column<float>(type: "float", nullable: false),
                    comments = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.entry);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "spell_chain",
                columns: table => new
                {
                    spell_id = table.Column<int>(type: "mediumint(9)", nullable: false, defaultValueSql: "'0'"),
                    prev_spell = table.Column<int>(type: "mediumint(9)", nullable: false, defaultValueSql: "'0'"),
                    first_spell = table.Column<int>(type: "mediumint(9)", nullable: false, defaultValueSql: "'0'"),
                    rank = table.Column<sbyte>(type: "tinyint(4)", nullable: false),
                    req_spell = table.Column<int>(type: "mediumint(9)", nullable: false, defaultValueSql: "'0'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.spell_id);
                },
                comment: "Spell Additinal Data")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "spell_elixir",
                columns: table => new
                {
                    entry = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "SpellId of potion"),
                    mask = table.Column<byte>(type: "tinyint(1) unsigned", nullable: false, comment: "Mask 0x1 battle 0x2 guardian 0x3 flask 0x7 unstable flasks 0xB shattrath flasks")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.entry);
                },
                comment: "Spell System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "spell_learn_spell",
                columns: table => new
                {
                    entry = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    SpellID = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    Active = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false, defaultValueSql: "'1'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.entry, x.SpellID })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                },
                comment: "Item System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "spell_pet_auras",
                columns: table => new
                {
                    spell = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, comment: "dummy spell id"),
                    pet = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'", comment: "pet id; 0 = all"),
                    aura = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, comment: "pet aura id")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.spell, x.pet })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "spell_proc_event",
                columns: table => new
                {
                    entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    SchoolMask = table.Column<byte>(type: "tinyint(4) unsigned", nullable: false),
                    SpellFamilyName = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    SpellFamilyMask0 = table.Column<ulong>(type: "bigint(40) unsigned", nullable: false),
                    SpellFamilyMask1 = table.Column<ulong>(type: "bigint(40) unsigned", nullable: false),
                    SpellFamilyMask2 = table.Column<ulong>(type: "bigint(40) unsigned", nullable: false),
                    procFlags = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    procEx = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    ppmRate = table.Column<float>(type: "float", nullable: false),
                    CustomChance = table.Column<float>(type: "float", nullable: false),
                    Cooldown = table.Column<uint>(type: "int(10) unsigned", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.entry);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "spell_proc_item_enchant",
                columns: table => new
                {
                    entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    ppmRate = table.Column<float>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.entry);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "spell_script_target",
                columns: table => new
                {
                    entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    type = table.Column<byte>(type: "tinyint(3) unsigned", nullable: false),
                    targetEntry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    inverseEffectMask = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'")
                },
                constraints: table =>
                {
                },
                comment: "Spell System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "spell_target_position",
                columns: table => new
                {
                    id = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'", comment: "Identifier"),
                    target_map = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    target_position_x = table.Column<float>(type: "float", nullable: false),
                    target_position_y = table.Column<float>(type: "float", nullable: false),
                    target_position_z = table.Column<float>(type: "float", nullable: false),
                    target_orientation = table.Column<float>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_spell_target_position", x => x.id);
                },
                comment: "Spell System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "spell_template",
                columns: table => new
                {
                    id = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    proc_flags = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    proc_chance = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    duration_index = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    effect0 = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    effect0_implicit_target_a = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    effect0_radius_idx = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    effect0_apply_aura_name = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    effect0_misc_value = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    effect0_misc_value_b = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    effect0_trigger_spell = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    comments = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_spell_template", x => x.id);
                },
                comment: "MaNGOS server side spells")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "spell_threat",
                columns: table => new
                {
                    entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false),
                    Threat = table.Column<short>(type: "smallint(6)", nullable: false),
                    multiplier = table.Column<float>(type: "float", nullable: false, defaultValueSql: "'1'", comment: "threat multiplier for damage/healing"),
                    ap_bonus = table.Column<float>(type: "float", nullable: false, comment: "additional threat bonus from attack power")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.entry);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "taxi_shortcuts",
                columns: table => new
                {
                    pathid = table.Column<uint>(type: "int(10) unsigned", nullable: false, comment: "Flight path entry id"),
                    takeoff = table.Column<uint>(type: "int(10) unsigned", nullable: false, comment: "Amount of waypoints to skip in the beginning of the flight"),
                    landing = table.Column<uint>(type: "int(10) unsigned", nullable: false, comment: "Amount of waypoints to skip at the end of the flight"),
                    comments = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.pathid);
                },
                comment: "Taxi System")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "trainer_greeting",
                columns: table => new
                {
                    Entry = table.Column<uint>(type: "int(11) unsigned", nullable: false, comment: "Entry of Trainer"),
                    Text = table.Column<string>(type: "longtext", nullable: true, comment: "Text of the greeting", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.Entry);
                },
                comment: "Trainer system")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "transports",
                columns: table => new
                {
                    entry = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    name = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    period = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.entry);
                },
                comment: "Transports")
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "warden_scans",
                columns: table => new
                {
                    id = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    type = table.Column<int>(type: "int(2)", nullable: true, defaultValueSql: "'0'"),
                    str = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    data = table.Column<string>(type: "text", nullable: true, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    address = table.Column<int>(type: "int(8)", nullable: true, defaultValueSql: "'0'"),
                    length = table.Column<int>(type: "int(2)", nullable: true, defaultValueSql: "'0'"),
                    result = table.Column<string>(type: "tinytext", nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    flags = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    comment = table.Column<string>(type: "tinytext", nullable: false, collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "waypoint_path",
                columns: table => new
                {
                    PathId = table.Column<uint>(type: "int(10) unsigned", nullable: false, comment: "Unique path id"),
                    Point = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    PositionX = table.Column<float>(type: "float", nullable: false),
                    PositionY = table.Column<float>(type: "float", nullable: false),
                    PositionZ = table.Column<float>(type: "float", nullable: false),
                    Orientation = table.Column<float>(type: "float", nullable: false),
                    WaitTime = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    ScriptId = table.Column<uint>(type: "mediumint(8) unsigned", nullable: false, defaultValueSql: "'0'"),
                    Comment = table.Column<string>(type: "text", nullable: true, collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.PathId, x.Point })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateTable(
                name: "world_safe_locs",
                columns: table => new
                {
                    id = table.Column<uint>(type: "int(11) unsigned", nullable: false),
                    map = table.Column<uint>(type: "int(10) unsigned", nullable: false),
                    x = table.Column<float>(type: "float", nullable: false),
                    y = table.Column<float>(type: "float", nullable: false),
                    z = table.Column<float>(type: "float", nullable: false),
                    o = table.Column<float>(type: "float", nullable: false),
                    name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, defaultValueSql: "''", collation: "latin1_swedish_ci")
                        .Annotation("MySql:CharSet", "latin1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_world_safe_locs", x => x.id);
                })
                .Annotation("MySql:CharSet", "latin1")
                .Annotation("Relational:Collation", "latin1_swedish_ci");

            migrationBuilder.CreateTable(
                name: "world_template",
                columns: table => new
                {
                    map = table.Column<ushort>(type: "smallint(5) unsigned", nullable: false),
                    ScriptName = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false, defaultValueSql: "''", collation: "utf8mb3_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb3")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.map);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_general_ci");

            migrationBuilder.CreateTable(
                name: "worldstate_name",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int(11)", nullable: false, comment: "Worldstate variable Id"),
                    Name = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false, comment: "Name and use of variable", collation: "utf8mb4_general_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_worldstate_name", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_general_ci");

            migrationBuilder.CreateIndex(
                name: "unique_conditions",
                table: "conditions",
                columns: new[] { "type", "value1", "value2", "value3", "value4", "flags" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "idx_map",
                table: "creature",
                column: "map");

            migrationBuilder.CreateIndex(
                name: "index_id",
                table: "creature",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "idx_id",
                table: "gameobject",
                column: "id");

            migrationBuilder.CreateIndex(
                name: "idx_map1",
                table: "gameobject",
                column: "map");

            migrationBuilder.CreateIndex(
                name: "entry_type_target",
                table: "item_required_target",
                columns: new[] { "entry", "type", "targetEntry" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "items_index",
                table: "item_template",
                column: "class");

            migrationBuilder.CreateIndex(
                name: "entry_spell",
                table: "npc_trainer",
                columns: new[] { "entry", "spell" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "entry_spell",
                table: "npc_trainer_template",
                columns: new[] { "entry", "spell" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "playercreateinfo_race_class_index",
                table: "playercreateinfo_item",
                columns: new[] { "race", "class" });

            migrationBuilder.CreateIndex(
                name: "pool_idx",
                table: "pool_creature",
                column: "pool_entry");

            migrationBuilder.CreateIndex(
                name: "pool_idx1",
                table: "pool_creature_template",
                column: "pool_entry");

            migrationBuilder.CreateIndex(
                name: "pool_idx2",
                table: "pool_gameobject",
                column: "pool_entry");

            migrationBuilder.CreateIndex(
                name: "pool_idx3",
                table: "pool_gameobject_template",
                column: "pool_entry");

            migrationBuilder.CreateIndex(
                name: "pool_idx4",
                table: "pool_pool",
                column: "mother_pool");

            migrationBuilder.CreateIndex(
                name: "entry_type_target",
                table: "spell_script_target",
                columns: new[] { "entry", "type", "targetEntry" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "id",
                table: "warden_scans",
                column: "id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "areatrigger_involvedrelation");

            migrationBuilder.DropTable(
                name: "areatrigger_tavern");

            migrationBuilder.DropTable(
                name: "areatrigger_teleport");

            migrationBuilder.DropTable(
                name: "battleground_events");

            migrationBuilder.DropTable(
                name: "battleground_template");

            migrationBuilder.DropTable(
                name: "battlemaster_entry");

            migrationBuilder.DropTable(
                name: "command");

            migrationBuilder.DropTable(
                name: "conditions");

            migrationBuilder.DropTable(
                name: "creature");

            migrationBuilder.DropTable(
                name: "creature_addon");

            migrationBuilder.DropTable(
                name: "creature_ai_scripts");

            migrationBuilder.DropTable(
                name: "creature_ai_summons");

            migrationBuilder.DropTable(
                name: "creature_ai_texts");

            migrationBuilder.DropTable(
                name: "creature_battleground");

            migrationBuilder.DropTable(
                name: "creature_conditional_spawn");

            migrationBuilder.DropTable(
                name: "creature_cooldowns");

            migrationBuilder.DropTable(
                name: "creature_equip_template");

            migrationBuilder.DropTable(
                name: "creature_equip_template_raw");

            migrationBuilder.DropTable(
                name: "creature_immunities");

            migrationBuilder.DropTable(
                name: "creature_involvedrelation");

            migrationBuilder.DropTable(
                name: "creature_linking");

            migrationBuilder.DropTable(
                name: "creature_linking_template");

            migrationBuilder.DropTable(
                name: "creature_loot_template");

            migrationBuilder.DropTable(
                name: "creature_model_info");

            migrationBuilder.DropTable(
                name: "creature_model_race");

            migrationBuilder.DropTable(
                name: "creature_movement");

            migrationBuilder.DropTable(
                name: "creature_movement_template");

            migrationBuilder.DropTable(
                name: "creature_onkill_reputation");

            migrationBuilder.DropTable(
                name: "creature_questrelation");

            migrationBuilder.DropTable(
                name: "creature_spawn_data");

            migrationBuilder.DropTable(
                name: "creature_spawn_data_template");

            migrationBuilder.DropTable(
                name: "creature_spawn_entry");

            migrationBuilder.DropTable(
                name: "creature_spell_list");

            migrationBuilder.DropTable(
                name: "creature_spell_list_entry");

            migrationBuilder.DropTable(
                name: "creature_spell_targeting");

            migrationBuilder.DropTable(
                name: "creature_template");

            migrationBuilder.DropTable(
                name: "creature_template_addon");

            migrationBuilder.DropTable(
                name: "creature_template_spells");

            migrationBuilder.DropTable(
                name: "custom_texts");

            migrationBuilder.DropTable(
                name: "db_version");

            migrationBuilder.DropTable(
                name: "dbscript_random_templates");

            migrationBuilder.DropTable(
                name: "dbscript_string");

            migrationBuilder.DropTable(
                name: "dbscript_string_template");

            migrationBuilder.DropTable(
                name: "dbscripts_on_creature_death");

            migrationBuilder.DropTable(
                name: "dbscripts_on_creature_movement");

            migrationBuilder.DropTable(
                name: "dbscripts_on_event");

            migrationBuilder.DropTable(
                name: "dbscripts_on_go_template_use");

            migrationBuilder.DropTable(
                name: "dbscripts_on_go_use");

            migrationBuilder.DropTable(
                name: "dbscripts_on_gossip");

            migrationBuilder.DropTable(
                name: "dbscripts_on_quest_end");

            migrationBuilder.DropTable(
                name: "dbscripts_on_quest_start");

            migrationBuilder.DropTable(
                name: "dbscripts_on_spell");

            migrationBuilder.DropTable(
                name: "disenchant_loot_template");

            migrationBuilder.DropTable(
                name: "exploration_basexp");

            migrationBuilder.DropTable(
                name: "fishing_loot_template");

            migrationBuilder.DropTable(
                name: "game_event");

            migrationBuilder.DropTable(
                name: "game_event_creature");

            migrationBuilder.DropTable(
                name: "game_event_creature_data");

            migrationBuilder.DropTable(
                name: "game_event_gameobject");

            migrationBuilder.DropTable(
                name: "game_event_mail");

            migrationBuilder.DropTable(
                name: "game_event_quest");

            migrationBuilder.DropTable(
                name: "game_event_time");

            migrationBuilder.DropTable(
                name: "game_graveyard_zone");

            migrationBuilder.DropTable(
                name: "game_tele");

            migrationBuilder.DropTable(
                name: "game_weather");

            migrationBuilder.DropTable(
                name: "gameobject");

            migrationBuilder.DropTable(
                name: "gameobject_battleground");

            migrationBuilder.DropTable(
                name: "gameobject_involvedrelation");

            migrationBuilder.DropTable(
                name: "gameobject_loot_template");

            migrationBuilder.DropTable(
                name: "gameobject_questrelation");

            migrationBuilder.DropTable(
                name: "gameobject_spawn_entry");

            migrationBuilder.DropTable(
                name: "gameobject_template");

            migrationBuilder.DropTable(
                name: "gameobject_template_addon");

            migrationBuilder.DropTable(
                name: "gossip_menu");

            migrationBuilder.DropTable(
                name: "gossip_menu_option");

            migrationBuilder.DropTable(
                name: "gossip_texts");

            migrationBuilder.DropTable(
                name: "instance_encounters");

            migrationBuilder.DropTable(
                name: "instance_template");

            migrationBuilder.DropTable(
                name: "item_enchantment_template");

            migrationBuilder.DropTable(
                name: "item_loot_template");

            migrationBuilder.DropTable(
                name: "item_required_target");

            migrationBuilder.DropTable(
                name: "item_template");

            migrationBuilder.DropTable(
                name: "locales_areatrigger_teleport");

            migrationBuilder.DropTable(
                name: "locales_creature");

            migrationBuilder.DropTable(
                name: "locales_gameobject");

            migrationBuilder.DropTable(
                name: "locales_gossip_menu_option");

            migrationBuilder.DropTable(
                name: "locales_item");

            migrationBuilder.DropTable(
                name: "locales_npc_text");

            migrationBuilder.DropTable(
                name: "locales_page_text");

            migrationBuilder.DropTable(
                name: "locales_points_of_interest");

            migrationBuilder.DropTable(
                name: "locales_quest");

            migrationBuilder.DropTable(
                name: "locales_questgiver_greeting");

            migrationBuilder.DropTable(
                name: "locales_trainer_greeting");

            migrationBuilder.DropTable(
                name: "mail_level_reward");

            migrationBuilder.DropTable(
                name: "mail_loot_template");

            migrationBuilder.DropTable(
                name: "mangos_string");

            migrationBuilder.DropTable(
                name: "npc_gossip");

            migrationBuilder.DropTable(
                name: "npc_text");

            migrationBuilder.DropTable(
                name: "npc_text_broadcast_text");

            migrationBuilder.DropTable(
                name: "npc_trainer");

            migrationBuilder.DropTable(
                name: "npc_trainer_template");

            migrationBuilder.DropTable(
                name: "npc_vendor");

            migrationBuilder.DropTable(
                name: "npc_vendor_template");

            migrationBuilder.DropTable(
                name: "page_text");

            migrationBuilder.DropTable(
                name: "pet_levelstats");

            migrationBuilder.DropTable(
                name: "pet_name_generation");

            migrationBuilder.DropTable(
                name: "petcreateinfo_spell");

            migrationBuilder.DropTable(
                name: "pickpocketing_loot_template");

            migrationBuilder.DropTable(
                name: "player_classlevelstats");

            migrationBuilder.DropTable(
                name: "player_levelstats");

            migrationBuilder.DropTable(
                name: "player_xp_for_level");

            migrationBuilder.DropTable(
                name: "playercreateinfo");

            migrationBuilder.DropTable(
                name: "playercreateinfo_action");

            migrationBuilder.DropTable(
                name: "playercreateinfo_item");

            migrationBuilder.DropTable(
                name: "playercreateinfo_skills");

            migrationBuilder.DropTable(
                name: "playercreateinfo_spell");

            migrationBuilder.DropTable(
                name: "points_of_interest");

            migrationBuilder.DropTable(
                name: "pool_creature");

            migrationBuilder.DropTable(
                name: "pool_creature_template");

            migrationBuilder.DropTable(
                name: "pool_gameobject");

            migrationBuilder.DropTable(
                name: "pool_gameobject_template");

            migrationBuilder.DropTable(
                name: "pool_pool");

            migrationBuilder.DropTable(
                name: "pool_template");

            migrationBuilder.DropTable(
                name: "prospecting_loot_template");

            migrationBuilder.DropTable(
                name: "quest_template");

            migrationBuilder.DropTable(
                name: "questgiver_greeting");

            migrationBuilder.DropTable(
                name: "reference_loot_template");

            migrationBuilder.DropTable(
                name: "reputation_reward_rate");

            migrationBuilder.DropTable(
                name: "reputation_spillover_template");

            migrationBuilder.DropTable(
                name: "reserved_name");

            migrationBuilder.DropTable(
                name: "script_texts");

            migrationBuilder.DropTable(
                name: "script_waypoint");

            migrationBuilder.DropTable(
                name: "scripted_areatrigger");

            migrationBuilder.DropTable(
                name: "scripted_event_id");

            migrationBuilder.DropTable(
                name: "skill_discovery_template");

            migrationBuilder.DropTable(
                name: "skill_extra_item_template");

            migrationBuilder.DropTable(
                name: "skill_fishing_base_level");

            migrationBuilder.DropTable(
                name: "skinning_loot_template");

            migrationBuilder.DropTable(
                name: "spam_records");

            migrationBuilder.DropTable(
                name: "spawn_group");

            migrationBuilder.DropTable(
                name: "spawn_group_entry");

            migrationBuilder.DropTable(
                name: "spawn_group_formation");

            migrationBuilder.DropTable(
                name: "spawn_group_linked_group");

            migrationBuilder.DropTable(
                name: "spawn_group_spawn");

            migrationBuilder.DropTable(
                name: "spell_affect");

            migrationBuilder.DropTable(
                name: "spell_area");

            migrationBuilder.DropTable(
                name: "spell_bonus_data");

            migrationBuilder.DropTable(
                name: "spell_chain");

            migrationBuilder.DropTable(
                name: "spell_elixir");

            migrationBuilder.DropTable(
                name: "spell_learn_spell");

            migrationBuilder.DropTable(
                name: "spell_pet_auras");

            migrationBuilder.DropTable(
                name: "spell_proc_event");

            migrationBuilder.DropTable(
                name: "spell_proc_item_enchant");

            migrationBuilder.DropTable(
                name: "spell_script_target");

            migrationBuilder.DropTable(
                name: "spell_target_position");

            migrationBuilder.DropTable(
                name: "spell_template");

            migrationBuilder.DropTable(
                name: "spell_threat");

            migrationBuilder.DropTable(
                name: "taxi_shortcuts");

            migrationBuilder.DropTable(
                name: "trainer_greeting");

            migrationBuilder.DropTable(
                name: "transports");

            migrationBuilder.DropTable(
                name: "warden_scans");

            migrationBuilder.DropTable(
                name: "waypoint_path");

            migrationBuilder.DropTable(
                name: "world_safe_locs");

            migrationBuilder.DropTable(
                name: "world_template");

            migrationBuilder.DropTable(
                name: "worldstate_name");
        }
    }
}
