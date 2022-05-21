namespace azuremyst.models.realmd
{
    public partial class AccountLogon
    {
        public int Id { get; set; }
        public uint AccountId { get; set; }
        public string Ip { get; set; } = null!;
        public DateTime LoginTime { get; set; }
        public uint LoginSource { get; set; }
    }
}
