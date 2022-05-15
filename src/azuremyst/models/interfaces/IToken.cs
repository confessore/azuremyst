using azuremyst.models.enums;

namespace azuremyst.models.interfaces
{
    public interface IToken
    {
        TokenType TokenType { get; set; }
        string? Hash { get; set; }
        long Expiration { get; set; }
    }
}
