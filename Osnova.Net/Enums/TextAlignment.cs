using System.Text.Json.Serialization;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.Enums
{
    [JsonConverter(typeof(EnumToStringJsonConverter<TextAlignment>))]
    public enum TextAlignment
    {
        Left,
        Centered
    }
}
