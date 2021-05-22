using System.Text.Json.Serialization;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.Enums
{
    [JsonConverter(typeof(EnumToStringJsonConverter<DelimiterType>))]
    public enum DelimiterType
    {
        Default
    }
}
