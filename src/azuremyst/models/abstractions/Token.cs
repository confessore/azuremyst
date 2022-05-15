using azuremyst.converters;
using azuremyst.models.enums;
using azuremyst.models.interfaces;
using System.Text.Json.Serialization;

namespace azuremyst.models.abstractions
{
    [JsonConverter(typeof(TokenConverter))]
    public abstract class Token : Entity<string>, IEntity<string>, IToken
    {
        [JsonConstructor]
        public Token() { }

        public TokenType TokenType { get; set; }
        public string? Hash { get; set; }
        public long Expiration { get; set; }

        public virtual string? UserId { get; set; }
    }
}
