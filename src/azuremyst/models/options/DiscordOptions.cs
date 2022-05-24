namespace azuremyst.models.options
{
    sealed class DiscordOptions
    {
        public string? ClientId { get; set; }
        public string? ClientSecret { get; set; }
        public string? BotToken { get; set; }
    }
}
