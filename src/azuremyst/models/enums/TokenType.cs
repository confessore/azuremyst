using System.ComponentModel;

namespace azuremyst.models.enums
{
    public enum TokenType
    {
        [Description("Default")]
        Default,
        [Description("Authentication")]
        Authentication,
        [Description("Refresh")]
        Refresh
    }
}
