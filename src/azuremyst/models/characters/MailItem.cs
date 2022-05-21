namespace azuremyst.models.characters
{
    public partial class MailItem
    {
        public int MailId { get; set; }
        public int ItemGuid { get; set; }
        public int ItemTemplate { get; set; }
        /// <summary>
        /// Character Global Unique Identifier
        /// </summary>
        public uint Receiver { get; set; }
    }
}
