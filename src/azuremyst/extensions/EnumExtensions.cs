using System.ComponentModel;
using System.Reflection;

namespace azuremyst.extensions
{
    static class EnumExtensions
    {
        public static string GetDescription(this Enum value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());
            if (fieldInfo == null)
                return string.Empty;
            var attribute = (DescriptionAttribute?)fieldInfo.GetCustomAttribute(typeof(DescriptionAttribute));
            return attribute!.Description;
        }
    }
}
