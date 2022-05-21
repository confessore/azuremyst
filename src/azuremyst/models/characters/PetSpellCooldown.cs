namespace azuremyst.models.characters
{
    public partial class PetSpellCooldown
    {
        /// <summary>
        /// Global Unique Identifier, Low part
        /// </summary>
        public uint Guid { get; set; }
        /// <summary>
        /// Spell Identifier
        /// </summary>
        public uint Spell { get; set; }
        public ulong Time { get; set; }
    }
}
