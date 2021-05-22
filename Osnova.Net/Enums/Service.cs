using System.Text.Json.Serialization;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.Enums
{
    [JsonConverter(typeof(EnumToStringJsonConverter<Service>))]
    public enum Service
    {
        Instagram,
        YaMusic,
        Spotify,
        TikTok
    }
}
