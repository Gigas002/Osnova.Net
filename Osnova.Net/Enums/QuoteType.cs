using System.Text.Json.Serialization;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.Enums
{
    [JsonConverter(typeof(StringToEnumJsonConverter<QuoteType>))]
    public enum QuoteType
    {
        Default,
        Opinion
    }
}
