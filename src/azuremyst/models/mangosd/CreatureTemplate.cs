namespace azuremyst.models.mangosd
{
    /// <summary>
    /// Creature System
    /// </summary>
    public partial class CreatureTemplate
    {
        public uint Entry { get; set; }
        public string Name { get; set; } = null!;
        public string? SubName { get; set; }
        public string? IconName { get; set; }
        public byte MinLevel { get; set; }
        public byte MaxLevel { get; set; }
        public uint HeroicEntry { get; set; }
        public uint ModelId1 { get; set; }
        public uint ModelId2 { get; set; }
        public uint ModelId3 { get; set; }
        public uint ModelId4 { get; set; }
        public ushort Faction { get; set; }
        public float Scale { get; set; }
        public sbyte Family { get; set; }
        public byte CreatureType { get; set; }
        public byte InhabitType { get; set; }
        public byte RegenerateStats { get; set; }
        public byte RacialLeader { get; set; }
        public uint NpcFlags { get; set; }
        public uint UnitFlags { get; set; }
        public uint DynamicFlags { get; set; }
        public uint ExtraFlags { get; set; }
        public uint CreatureTypeFlags { get; set; }
        public float SpeedWalk { get; set; }
        public float SpeedRun { get; set; }
        /// <summary>
        /// Detection range for proximity
        /// </summary>
        public uint Detection { get; set; }
        /// <summary>
        /// Range in which creature calls for help?
        /// </summary>
        public uint CallForHelp { get; set; }
        /// <summary>
        /// When exceeded during pursuit creature evades?
        /// </summary>
        public uint Pursuit { get; set; }
        /// <summary>
        /// Leash range from combat start position
        /// </summary>
        public uint Leash { get; set; }
        /// <summary>
        /// Time for refreshing leashing before evade?
        /// </summary>
        public uint Timeout { get; set; }
        public byte UnitClass { get; set; }
        public byte Rank { get; set; }
        public sbyte Expansion { get; set; }
        public float HealthMultiplier { get; set; }
        public float PowerMultiplier { get; set; }
        public float DamageMultiplier { get; set; }
        public float DamageVariance { get; set; }
        public float ArmorMultiplier { get; set; }
        public float ExperienceMultiplier { get; set; }
        public uint MinLevelHealth { get; set; }
        public uint MaxLevelHealth { get; set; }
        public uint MinLevelMana { get; set; }
        public uint MaxLevelMana { get; set; }
        public float MinMeleeDmg { get; set; }
        public float MaxMeleeDmg { get; set; }
        public float MinRangedDmg { get; set; }
        public float MaxRangedDmg { get; set; }
        public uint Armor { get; set; }
        public uint MeleeAttackPower { get; set; }
        public ushort RangedAttackPower { get; set; }
        public uint MeleeBaseAttackTime { get; set; }
        public uint RangedBaseAttackTime { get; set; }
        public sbyte DamageSchool { get; set; }
        public uint MinLootGold { get; set; }
        public uint MaxLootGold { get; set; }
        public uint LootId { get; set; }
        public uint PickpocketLootId { get; set; }
        public uint SkinningLootId { get; set; }
        public uint KillCredit1 { get; set; }
        public uint KillCredit2 { get; set; }
        public uint MechanicImmuneMask { get; set; }
        public uint SchoolImmuneMask { get; set; }
        public short ResistanceHoly { get; set; }
        public short ResistanceFire { get; set; }
        public short ResistanceNature { get; set; }
        public short ResistanceFrost { get; set; }
        public short ResistanceShadow { get; set; }
        public short ResistanceArcane { get; set; }
        public uint PetSpellDataId { get; set; }
        public byte MovementType { get; set; }
        public sbyte TrainerType { get; set; }
        public uint TrainerSpell { get; set; }
        public byte TrainerClass { get; set; }
        public byte TrainerRace { get; set; }
        public uint TrainerTemplateId { get; set; }
        public uint VendorTemplateId { get; set; }
        public uint EquipmentTemplateId { get; set; }
        public uint GossipMenuId { get; set; }
        public int InteractionPauseTimer { get; set; }
        public sbyte VisibilityDistanceType { get; set; }
        /// <summary>
        /// Time before corpse despawns
        /// </summary>
        public uint CorpseDecay { get; set; }
        /// <summary>
        /// creature_spell_list_entry
        /// </summary>
        public int SpellList { get; set; }
        public string Ainame { get; set; } = null!;
        public string ScriptName { get; set; } = null!;
    }
}
