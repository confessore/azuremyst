using azuremyst.models.abstractions;
using azuremyst.models.enums;
using azuremyst.models.tokens;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace azuremyst.converters
{
    public sealed class TokenConverter : JsonConverter<Token>
    {
        public override bool CanConvert(Type typeToConvert) =>
            typeof(Token).IsAssignableFrom(typeToConvert);

        public override Token? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var clone = reader;
            while (clone.Read())
            {
                if (clone.TokenType == JsonTokenType.PropertyName)
                {
                    var name = clone.GetString();
                    if (name != null)
                    {
                        if (name.ToLower() == nameof(TokenType).ToLower())
                            break;
                    }
                }
            }
            clone.Read();
            var type = (TokenType)clone.GetInt32();
            return type switch
            {
                TokenType.Default => JsonSerializer.Deserialize<DefaultToken>(ref reader, options),
                TokenType.Authentication => JsonSerializer.Deserialize<AuthenticationToken>(ref reader, options),
                TokenType.Refresh => JsonSerializer.Deserialize<RefreshToken>(ref reader, options),
                TokenType.Confirmation => JsonSerializer.Deserialize<ConfirmationToken>(ref reader, options),
                _ => null,
            };
        }

        public override void Write(Utf8JsonWriter writer, Token value, JsonSerializerOptions options) =>
            JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
