namespace azuremyst.models.mangosd
{
    /// <summary>
    /// Used DB version notes
    /// </summary>
    public partial class DbVersion
    {
        public string? Version { get; set; }
        public string? CreatureAiVersion { get; set; }
        public ulong? RequiredS245001MangosQuestMaxlevel { get; set; }
    }
}
