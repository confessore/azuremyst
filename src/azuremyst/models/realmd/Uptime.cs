namespace azuremyst.models.realmd
{
    /// <summary>
    /// Uptime system
    /// </summary>
    public partial class Uptime
    {
        public uint Realmid { get; set; }
        public ulong Starttime { get; set; }
        public string Startstring { get; set; } = null!;
        public ulong Uptime1 { get; set; }
        public ushort Maxplayers { get; set; }
    }
}
