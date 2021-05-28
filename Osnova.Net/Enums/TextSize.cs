using System.Text.Json.Serialization;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.Enums
{
    [JsonConverter(typeof(StringToEnumJsonConverter<TextSize>))]
    public enum TextSize
    {
        Small,
        Medium,
        Big
    }
}
