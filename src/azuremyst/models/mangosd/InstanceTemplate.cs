namespace azuremyst.models.mangosd
{
    public partial class InstanceTemplate
    {
        public ushort Map { get; set; }
        public ushort Parent { get; set; }
        public byte LevelMin { get; set; }
        public byte LevelMax { get; set; }
        public byte MaxPlayers { get; set; }
        /// <summary>
        /// Reset time in days
        /// </summary>
        public uint ResetDelay { get; set; }
        public string ScriptName { get; set; } = null!;
        public byte MountAllowed { get; set; }
    }
}
