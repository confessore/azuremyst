namespace azuremyst.models.mangosd
{
    /// <summary>
    /// Game event system
    /// </summary>
    public partial class GameEventMail
    {
        /// <summary>
        /// Negatives value to send at event stop, positive value for send at event start.
        /// </summary>
        public short Event { get; set; }
        public uint RaceMask { get; set; }
        public uint Quest { get; set; }
        public uint MailTemplateId { get; set; }
        public uint SenderEntry { get; set; }
    }
}
