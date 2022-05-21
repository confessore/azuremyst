namespace azuremyst.models.characters
{
    /// <summary>
    /// Player System
    /// </summary>
    public partial class Character
    {
        /// <summary>
        /// Global Unique Identifier
        /// </summary>
        public uint Guid { get; set; }
        /// <summary>
        /// Account Identifier
        /// </summary>
        public uint Account { get; set; }
        public string Name { get; set; } = null!;
        public byte Race { get; set; }
        public byte Class { get; set; }
        public byte Gender { get; set; }
        public byte Level { get; set; }
        public uint Xp { get; set; }
        public uint Money { get; set; }
        public uint PlayerBytes { get; set; }
        public uint PlayerBytes2 { get; set; }
        public uint PlayerFlags { get; set; }
        public float PositionX { get; set; }
        public float PositionY { get; set; }
        public float PositionZ { get; set; }
        /// <summary>
        /// Map Identifier
        /// </summary>
        public uint Map { get; set; }
        public byte DungeonDifficulty { get; set; }
        public float Orientation { get; set; }
        public string? Taximask { get; set; }
        public byte Online { get; set; }
        public byte Cinematic { get; set; }
        public uint Totaltime { get; set; }
        public uint Leveltime { get; set; }
        public ulong LogoutTime { get; set; }
        public byte IsLogoutResting { get; set; }
        public float RestBonus { get; set; }
        public uint ResettalentsCost { get; set; }
        public ulong ResettalentsTime { get; set; }
        public float TransX { get; set; }
        public float TransY { get; set; }
        public float TransZ { get; set; }
        public float TransO { get; set; }
        public ulong Transguid { get; set; }
        public uint ExtraFlags { get; set; }
        public byte StableSlots { get; set; }
        public uint AtLogin { get; set; }
        public uint Zone { get; set; }
        public ulong DeathExpireTime { get; set; }
        public string? TaxiPath { get; set; }
        public uint ArenaPoints { get; set; }
        public uint TotalHonorPoints { get; set; }
        public uint TodayHonorPoints { get; set; }
        public uint YesterdayHonorPoints { get; set; }
        public uint TotalKills { get; set; }
        public ushort TodayKills { get; set; }
        public ushort YesterdayKills { get; set; }
        public uint ChosenTitle { get; set; }
        public uint WatchedFaction { get; set; }
        public ushort Drunk { get; set; }
        public uint Health { get; set; }
        public uint Power1 { get; set; }
        public uint Power2 { get; set; }
        public uint Power3 { get; set; }
        public uint Power4 { get; set; }
        public uint Power5 { get; set; }
        public string? ExploredZones { get; set; }
        public string? EquipmentCache { get; set; }
        public uint AmmoId { get; set; }
        public string? KnownTitles { get; set; }
        public byte ActionBars { get; set; }
        public uint? GrantableLevels { get; set; }
        public uint? DeleteInfosAccount { get; set; }
        public string? DeleteInfosName { get; set; }
        public ulong? DeleteDate { get; set; }
    }
}
