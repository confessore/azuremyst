namespace azuremyst.models.mangosd
{
    public partial class GameEventTime
    {
        /// <summary>
        /// Entry of the game event
        /// </summary>
        public uint Entry { get; set; }
        /// <summary>
        /// Absolute start date, the event will never start before
        /// </summary>
        public DateTime StartTime { get; set; }
        /// <summary>
        /// Absolute end date, the event will never start after
        /// </summary>
        public DateTime EndTime { get; set; }
    }
}
