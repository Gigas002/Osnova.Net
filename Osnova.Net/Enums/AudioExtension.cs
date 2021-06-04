using System.Text.Json.Serialization;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.Enums
{
    /// <summary>
    /// Audio file's extensions
    /// <para/>
    /// <remarks>Uses default string-to-enum converter</remarks>
    /// </summary>
    [JsonConverter(typeof(StringToEnumJsonConverter<AudioExtension>))]
    public enum AudioExtension // TODO: move to MediaExtension as Mp3?
    {
        /// <summary>
        /// mp3
        /// </summary>
        Mp3
    }
}
