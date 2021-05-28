using System.Text.Json.Serialization;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.Enums
{
    [JsonConverter(typeof(StringToEnumJsonConverter<DelimiterType>))]
    public enum DelimiterType
    {
        Default
    }
}
