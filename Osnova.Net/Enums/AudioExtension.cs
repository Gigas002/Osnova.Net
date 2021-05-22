using System.Text.Json.Serialization;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.Enums
{
    [JsonConverter(typeof(EnumToStringJsonConverter<AudioExtension>))]
    public enum AudioExtension
    {
        Mp3
    }
}
