using azuremyst.models.abstractions;
using azuremyst.models.enums;
using azuremyst.models.roles;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace azuremyst.converters
{
    public sealed class RoleConverter : JsonConverter<Role>
    {
        public override bool CanConvert(Type typeToConvert) =>
            typeof(Role).IsAssignableFrom(typeToConvert);

        public override Role? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var clone = reader;
            while (clone.Read())
            {
                if (clone.TokenType == JsonTokenType.PropertyName)
                {
                    var name = clone.GetString();
                    if (name != null)
                    {
                        if (name.ToLower() == nameof(RoleType).ToLower())
                            break;
                    }
                }
            }
            clone.Read();
            var type = (RoleType)clone.GetInt32();
            return type switch
            {
                RoleType.Default => JsonSerializer.Deserialize<DefaultRole>(ref reader, options),
                //RoleType.Vendor => JsonSerializer.Deserialize<VendorRole>(ref reader, options),
                _ => null,
            };
        }

        public override void Write(Utf8JsonWriter writer, Role value, JsonSerializerOptions options) =>
            JsonSerializer.Serialize(writer, value, value.GetType(), options);
    }
}
