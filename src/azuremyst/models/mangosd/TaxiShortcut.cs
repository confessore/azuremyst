namespace azuremyst.models.mangosd
{
    /// <summary>
    /// Taxi System
    /// </summary>
    public partial class TaxiShortcut
    {
        /// <summary>
        /// Flight path entry id
        /// </summary>
        public uint Pathid { get; set; }
        /// <summary>
        /// Amount of waypoints to skip in the beginning of the flight
        /// </summary>
        public uint Takeoff { get; set; }
        /// <summary>
        /// Amount of waypoints to skip at the end of the flight
        /// </summary>
        public uint Landing { get; set; }
        public string Comments { get; set; } = null!;
    }
}
