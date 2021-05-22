using System.Text.Json.Serialization;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.Enums
{
    [JsonConverter(typeof(EnumToStringJsonConverter<TextSize>))]
    public enum TextSize
    {
        Small,
        Big
    }
}
