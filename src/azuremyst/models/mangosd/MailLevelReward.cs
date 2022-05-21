namespace azuremyst.models.mangosd
{
    /// <summary>
    /// Mail System
    /// </summary>
    public partial class MailLevelReward
    {
        public uint Level { get; set; }
        public uint RaceMask { get; set; }
        public uint MailTemplateId { get; set; }
        public uint SenderEntry { get; set; }
    }
}
