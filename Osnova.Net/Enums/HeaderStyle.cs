using System.Text.Json.Serialization;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.Enums
{
    [JsonConverter(typeof(EnumToStringJsonConverter<HeaderStyle>))]
    public enum HeaderStyle
    {
        H2,
        H3,
        H4
    }
}
