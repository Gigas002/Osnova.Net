using System.Text.Json.Serialization;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.Enums
{
    [JsonConverter(typeof(EnumToStringJsonConverter<QuoteType>))]
    public enum QuoteType
    {
        Default,
        Opinion
    }
}
