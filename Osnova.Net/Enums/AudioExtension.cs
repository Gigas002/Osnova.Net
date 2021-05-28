using System.Text.Json.Serialization;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.Enums
{
    [JsonConverter(typeof(StringToEnumJsonConverter<AudioExtension>))]
    public enum AudioExtension
    {
        Mp3
    }
}
