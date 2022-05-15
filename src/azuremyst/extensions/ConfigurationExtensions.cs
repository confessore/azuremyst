using azuremyst.models.options;
using System.Text;

namespace azuremyst.extensions
{
    static class ConfigurationExtensions
    {
        public static Task<string> BuildConnectionStringAsync(
            this IConfiguration configuration,
            string context)
        {
            var options = new SqlClientOptions();
            configuration.GetSection("APPLICATION:SQLCLIENTOPTIONS").Bind(options);
            var stringBuilder = new StringBuilder();
            stringBuilder.Append($"Server={options.Server!.Trim()};");
            stringBuilder.Append($"User Id={options.Username!.Trim()};");
            stringBuilder.Append($"Password={options.Password!.Trim()};");
            stringBuilder.Append($"Database={options.Database!.Trim()}.{context};");
            return Task.FromResult(stringBuilder.ToString());
        }

        public static async Task<string> BuildAuthenticationConnectionStringAsync(this IConfiguration configuration) =>
            await configuration.BuildConnectionStringAsync("realmd");

        public static async Task<string> BuildCharacterConnectionStringAsync(this IConfiguration configuration) =>
            await configuration.BuildConnectionStringAsync("character");

        public static async Task<string> BuildDefaultConnectionStringAsync(this IConfiguration configuration) =>
            await configuration.BuildConnectionStringAsync("default");

        public static async Task<string> BuildKeyConnectionStringAsync(this IConfiguration configuration) =>
            await configuration.BuildConnectionStringAsync("key");

        public static async Task<string> BuildWorldConnectionStringAsync(this IConfiguration configuration) =>
            await configuration.BuildConnectionStringAsync("mangosd");

        public static Task<DiscordOptions> BuildDiscordOptionsAsync(this IConfiguration configuration)
        {
            var options = new DiscordOptions();
            configuration.GetSection("APPLICATION:DISCORDOPTIONS").Bind(options);
            return Task.FromResult(options);
        }
    }
}
