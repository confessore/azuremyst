namespace azuremyst.models.characters
{
    /// <summary>
    /// GM Tickets System
    /// </summary>
    public partial class GmTicket
    {
        /// <summary>
        /// GM Ticket&apos;s unique identifier
        /// </summary>
        public uint Id { get; set; }
        /// <summary>
        /// GM Ticket Category DBC entry&apos;s identifier
        /// </summary>
        public byte Category { get; set; }
        /// <summary>
        /// Ticket&apos;s current state
        /// </summary>
        public byte State { get; set; }
        /// <summary>
        /// Ticket&apos;s current status
        /// </summary>
        public byte Status { get; set; }
        /// <summary>
        /// Ticket&apos;s security level
        /// </summary>
        public byte Level { get; set; }
        /// <summary>
        /// Player&apos;s character Global Unique Identifier
        /// </summary>
        public uint AuthorGuid { get; set; }
        /// <summary>
        /// Player&apos;s character name
        /// </summary>
        public string AuthorName { get; set; } = null!;
        /// <summary>
        /// Player&apos;s client locale name
        /// </summary>
        public string Locale { get; set; } = null!;
        /// <summary>
        /// Character&apos;s map identifier on submission
        /// </summary>
        public uint Mapid { get; set; }
        /// <summary>
        /// Character&apos;s x coordinate on submission
        /// </summary>
        public float X { get; set; }
        /// <summary>
        /// Character&apos;s y coordinate on submission
        /// </summary>
        public float Y { get; set; }
        /// <summary>
        /// Character&apos;s z coordinate on submission
        /// </summary>
        public float Z { get; set; }
        /// <summary>
        /// Character&apos;s orientation angle on submission
        /// </summary>
        public float O { get; set; }
        /// <summary>
        /// Ticket&apos;s message
        /// </summary>
        public string Text { get; set; } = null!;
        /// <summary>
        /// Timestamp: ticket created by a player
        /// </summary>
        public ulong Created { get; set; }
        /// <summary>
        /// Timestamp: ticket text&apos;s last update
        /// </summary>
        public ulong Updated { get; set; }
        /// <summary>
        /// Timestamp: ticket&apos;s last time opened by a GM
        /// </summary>
        public ulong Seen { get; set; }
        /// <summary>
        /// Timestamp: ticket&apos;s last time answered by a GM
        /// </summary>
        public ulong Answered { get; set; }
        /// <summary>
        /// Timestamp: ticket closed by a GM
        /// </summary>
        public ulong Closed { get; set; }
        /// <summary>
        /// Assignee&apos;s character&apos;s Global Unique Identifier
        /// </summary>
        public uint AssigneeGuid { get; set; }
        /// <summary>
        /// Assignee&apos;s character&apos;s name
        /// </summary>
        public string AssigneeName { get; set; } = null!;
        /// <summary>
        /// Assignee&apos;s final conclusion on this ticket
        /// </summary>
        public string Conclusion { get; set; } = null!;
        /// <summary>
        /// Additional notes for GMs
        /// </summary>
        public string Notes { get; set; } = null!;
    }
}
