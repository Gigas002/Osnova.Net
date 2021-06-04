using System.Text.Json.Serialization;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.Enums
{
    /// <summary>
    /// Extensions of media files
    /// <para/>
    /// <remarks>Uses default string-to-enum converter</remarks>
    /// </summary>
    [JsonConverter(typeof(StringToEnumJsonConverter<MediaExtension>))]
    public enum MediaExtension // TODO: process all data types
    {
        /// <summary>
        /// Png
        /// </summary>
        Png,
        
        /// <summary>
        /// Jpg
        /// </summary>
        Jpg,
        
        /// <summary>
        /// Webp
        /// </summary>
        Webp,
        
        /// <summary>
        /// Gif
        /// </summary>
        Gif,
        
        /// <summary>
        /// Mp4
        /// </summary>
        Mp4
    }
}
