using System.Text.Json.Serialization;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.Enums
{
    [JsonConverter(typeof(StringToEnumJsonConverter<ExternalServiceType>))]
    public enum ExternalServiceType
    {
        Instagram,
        YaMusic,
        Spotify,
        TikTok
    }
}
