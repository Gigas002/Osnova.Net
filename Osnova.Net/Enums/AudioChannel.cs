using System.Text.Json.Serialization;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.Enums
{
    [JsonConverter(typeof(StringToEnumJsonConverter<AudioChannel>))]
    public enum AudioChannel
    {
        Stereo = 0,
        JointStereo,
        Mono
    }
}
