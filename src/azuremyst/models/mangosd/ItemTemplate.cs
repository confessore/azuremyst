namespace azuremyst.models.mangosd
{
    /// <summary>
    /// Item System
    /// </summary>
    public partial class ItemTemplate
    {
        public uint Entry { get; set; }
        public byte Class { get; set; }
        public byte Subclass { get; set; }
        public int Unk0 { get; set; }
        public string Name { get; set; } = null!;
        public uint Displayid { get; set; }
        public byte Quality { get; set; }
        public uint Flags { get; set; }
        public byte BuyCount { get; set; }
        public uint BuyPrice { get; set; }
        public uint SellPrice { get; set; }
        public byte InventoryType { get; set; }
        public int AllowableClass { get; set; }
        public int AllowableRace { get; set; }
        public byte ItemLevel { get; set; }
        public byte RequiredLevel { get; set; }
        public ushort RequiredSkill { get; set; }
        public ushort RequiredSkillRank { get; set; }
        public uint Requiredspell { get; set; }
        public uint Requiredhonorrank { get; set; }
        public uint RequiredCityRank { get; set; }
        public ushort RequiredReputationFaction { get; set; }
        public ushort RequiredReputationRank { get; set; }
        public ushort Maxcount { get; set; }
        public ushort Stackable { get; set; }
        public byte ContainerSlots { get; set; }
        public byte StatType1 { get; set; }
        public short StatValue1 { get; set; }
        public byte StatType2 { get; set; }
        public short StatValue2 { get; set; }
        public byte StatType3 { get; set; }
        public short StatValue3 { get; set; }
        public byte StatType4 { get; set; }
        public short StatValue4 { get; set; }
        public byte StatType5 { get; set; }
        public short StatValue5 { get; set; }
        public byte StatType6 { get; set; }
        public short StatValue6 { get; set; }
        public byte StatType7 { get; set; }
        public short StatValue7 { get; set; }
        public byte StatType8 { get; set; }
        public short StatValue8 { get; set; }
        public byte StatType9 { get; set; }
        public short StatValue9 { get; set; }
        public byte StatType10 { get; set; }
        public short StatValue10 { get; set; }
        public float DmgMin1 { get; set; }
        public float DmgMax1 { get; set; }
        public byte DmgType1 { get; set; }
        public float DmgMin2 { get; set; }
        public float DmgMax2 { get; set; }
        public byte DmgType2 { get; set; }
        public float DmgMin3 { get; set; }
        public float DmgMax3 { get; set; }
        public byte DmgType3 { get; set; }
        public float DmgMin4 { get; set; }
        public float DmgMax4 { get; set; }
        public byte DmgType4 { get; set; }
        public float DmgMin5 { get; set; }
        public float DmgMax5 { get; set; }
        public byte DmgType5 { get; set; }
        public ushort Armor { get; set; }
        public byte HolyRes { get; set; }
        public byte FireRes { get; set; }
        public byte NatureRes { get; set; }
        public byte FrostRes { get; set; }
        public byte ShadowRes { get; set; }
        public byte ArcaneRes { get; set; }
        public ushort Delay { get; set; }
        public byte AmmoType { get; set; }
        public float RangedModRange { get; set; }
        public uint Spellid1 { get; set; }
        public byte Spelltrigger1 { get; set; }
        public sbyte Spellcharges1 { get; set; }
        public float SpellppmRate1 { get; set; }
        public int Spellcooldown1 { get; set; }
        public ushort Spellcategory1 { get; set; }
        public int Spellcategorycooldown1 { get; set; }
        public uint Spellid2 { get; set; }
        public byte Spelltrigger2 { get; set; }
        public sbyte Spellcharges2 { get; set; }
        public float SpellppmRate2 { get; set; }
        public int Spellcooldown2 { get; set; }
        public ushort Spellcategory2 { get; set; }
        public int Spellcategorycooldown2 { get; set; }
        public uint Spellid3 { get; set; }
        public byte Spelltrigger3 { get; set; }
        public sbyte Spellcharges3 { get; set; }
        public float SpellppmRate3 { get; set; }
        public int Spellcooldown3 { get; set; }
        public ushort Spellcategory3 { get; set; }
        public int Spellcategorycooldown3 { get; set; }
        public uint Spellid4 { get; set; }
        public byte Spelltrigger4 { get; set; }
        public sbyte Spellcharges4 { get; set; }
        public float SpellppmRate4 { get; set; }
        public int Spellcooldown4 { get; set; }
        public ushort Spellcategory4 { get; set; }
        public int Spellcategorycooldown4 { get; set; }
        public uint Spellid5 { get; set; }
        public byte Spelltrigger5 { get; set; }
        public sbyte Spellcharges5 { get; set; }
        public float SpellppmRate5 { get; set; }
        public int Spellcooldown5 { get; set; }
        public ushort Spellcategory5 { get; set; }
        public int Spellcategorycooldown5 { get; set; }
        public byte Bonding { get; set; }
        public string Description { get; set; } = null!;
        public uint PageText { get; set; }
        public byte LanguageId { get; set; }
        public byte PageMaterial { get; set; }
        public uint Startquest { get; set; }
        public uint Lockid { get; set; }
        public sbyte Material { get; set; }
        public byte Sheath { get; set; }
        public uint RandomProperty { get; set; }
        public uint RandomSuffix { get; set; }
        public uint Block { get; set; }
        public uint Itemset { get; set; }
        public ushort MaxDurability { get; set; }
        public uint Area { get; set; }
        public short Map { get; set; }
        public int BagFamily { get; set; }
        public sbyte TotemCategory { get; set; }
        public sbyte SocketColor1 { get; set; }
        public int SocketContent1 { get; set; }
        public sbyte SocketColor2 { get; set; }
        public int SocketContent2 { get; set; }
        public sbyte SocketColor3 { get; set; }
        public int SocketContent3 { get; set; }
        public int SocketBonus { get; set; }
        public int GemProperties { get; set; }
        public short RequiredDisenchantSkill { get; set; }
        public float ArmorDamageModifier { get; set; }
        public string ScriptName { get; set; } = null!;
        public uint DisenchantId { get; set; }
        public byte FoodType { get; set; }
        public uint MinMoneyLoot { get; set; }
        public uint MaxMoneyLoot { get; set; }
        /// <summary>
        /// Duration in seconds
        /// </summary>
        public uint Duration { get; set; }
        public byte ExtraFlags { get; set; }
    }
}
