using System.Text.Json.Serialization;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.Enums
{
    /// <summary>
    /// Alignment of the element
    /// <para/>
    /// <remarks>Uses default string-to-enum converter</remarks>
    /// </summary>
    [JsonConverter(typeof(StringToEnumJsonConverter<Alignment>))]
    public enum Alignment
    {
        /// <summary>
        /// Left
        /// </summary>
        Left,
        
        /// <summary>
        /// Centered
        /// </summary>
        Centered,
        
        /// <summary>
        /// Top
        /// </summary>
        Top,
        
        /// <summary>
        /// Bottom
        /// </summary>
        Bottom
    }
}
