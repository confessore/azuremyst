namespace azuremyst.models.characters
{
    /// <summary>
    /// GM Tickets System
    /// </summary>
    public partial class GmSurvey
    {
        /// <summary>
        /// GM Ticket&apos;s unique identifier
        /// </summary>
        public uint Ticketid { get; set; }
        /// <summary>
        /// Survey DBC entry&apos;s identifier
        /// </summary>
        public uint Surveyid { get; set; }
        public byte? Answer1 { get; set; }
        public byte? Answer2 { get; set; }
        public byte? Answer3 { get; set; }
        public byte? Answer4 { get; set; }
        public byte? Answer5 { get; set; }
        public byte? Answer6 { get; set; }
        public byte? Answer7 { get; set; }
        public byte? Answer8 { get; set; }
        public byte? Answer9 { get; set; }
        public byte? Answer10 { get; set; }
        /// <summary>
        /// Player&apos;s feedback
        /// </summary>
        public string? Comment { get; set; }
    }
}
