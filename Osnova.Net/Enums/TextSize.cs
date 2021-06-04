using System.Text.Json.Serialization;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.Enums
{
    /// <summary>
    /// Text's size
    /// <para/>
    /// <remarks>Uses default string-to-enum converter</remarks>
    /// </summary>
    [JsonConverter(typeof(StringToEnumJsonConverter<TextSize>))]
    public enum TextSize
    {
        /// <summary>
        /// Small
        /// </summary>
        Small,
        
        /// <summary>
        /// Medium
        /// </summary>
        Medium,
        
        /// <summary>
        /// Big
        /// </summary>
        Big
    }
}
