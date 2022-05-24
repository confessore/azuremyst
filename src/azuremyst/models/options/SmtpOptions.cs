namespace azuremyst.models.options
{
    sealed class SmtpOptions
    {
        public string? SmtpHost { get; set; }
        public string? SmtpPort { get; set; }
        public string? SmtpUsername { get; set; }
        public string? SmtpPassword { get; set; }
        public string? SmtpFromAddress { get; set; }
        public string? SmtpFromName { get; set; }
    }
}
