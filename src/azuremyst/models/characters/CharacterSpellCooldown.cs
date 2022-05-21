namespace azuremyst.models.characters
{
    public partial class CharacterSpellCooldown
    {
        /// <summary>
        /// Global Unique Identifier, Low part
        /// </summary>
        public uint Guid { get; set; }
        /// <summary>
        /// Spell Identifier
        /// </summary>
        public uint SpellId { get; set; }
        /// <summary>
        /// Spell cooldown expire time
        /// </summary>
        public ulong SpellExpireTime { get; set; }
        /// <summary>
        /// Spell category
        /// </summary>
        public uint Category { get; set; }
        /// <summary>
        /// Spell category cooldown expire time
        /// </summary>
        public ulong CategoryExpireTime { get; set; }
        /// <summary>
        /// Item Identifier
        /// </summary>
        public uint ItemId { get; set; }
    }
}
