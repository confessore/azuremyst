namespace azuremyst.models.characters
{
    /// <summary>
    /// Mail System
    /// </summary>
    public partial class Mail
    {
        /// <summary>
        /// Identifier
        /// </summary>
        public uint Id { get; set; }
        public byte MessageType { get; set; }
        public sbyte Stationery { get; set; }
        public uint MailTemplateId { get; set; }
        /// <summary>
        /// Character Global Unique Identifier
        /// </summary>
        public uint Sender { get; set; }
        /// <summary>
        /// Character Global Unique Identifier
        /// </summary>
        public uint Receiver { get; set; }
        public string? Subject { get; set; }
        public uint ItemTextId { get; set; }
        public byte HasItems { get; set; }
        public ulong ExpireTime { get; set; }
        public ulong DeliverTime { get; set; }
        public uint Money { get; set; }
        public uint Cod { get; set; }
        public byte Checked { get; set; }
    }
}
