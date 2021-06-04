using System.Text.Json.Serialization;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.Enums
{
    /// <summary>
    /// Audio channels
    /// <para/>
    /// <remarks>Uses default string-to-enum converter</remarks>
    /// </summary>
    [JsonConverter(typeof(StringToEnumJsonConverter<AudioChannel>))]
    public enum AudioChannel
    {
        /// <summary>
        /// Stereo
        /// </summary>
        Stereo = 0,
        
        /// <summary>
        /// Joint stereo
        /// </summary>
        JointStereo,
        
        /// <summary>
        /// Mono
        /// </summary>
        Mono
    }
}
