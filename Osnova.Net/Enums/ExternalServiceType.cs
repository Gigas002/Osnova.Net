using System.Text.Json.Serialization;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.Enums
{
    /// <summary>
    /// External service type
    /// <para/>
    /// <remarks>Uses default string-to-enum converter</remarks>
    /// </summary>
    [JsonConverter(typeof(StringToEnumJsonConverter<ExternalServiceType>))]
    public enum ExternalServiceType
    {
        /// <summary>
        /// Instagram
        /// </summary>
        Instagram,
        
        /// <summary>
        /// Yandex music
        /// </summary>
        YaMusic, // TODO: rename and create converter
        
        /// <summary>
        /// Spotify
        /// </summary>
        Spotify,
        
        /// <summary>
        /// TikTok
        /// </summary>
        TikTok
    }
}
