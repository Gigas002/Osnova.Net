using System.Text.Json.Serialization;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.Enums
{
    /// <summary>
    /// Header style/level
    /// <para/>
    /// <remarks>Uses default string-to-enum converter</remarks>
    /// </summary>
    [JsonConverter(typeof(StringToEnumJsonConverter<HeaderStyle>))]
    public enum HeaderStyle
    {
        /// <summary>
        /// Level 2 header
        /// </summary>
        H2,
        
        /// <summary>
        /// Level 3 header
        /// </summary>
        H3,
        
        /// <summary>
        /// Level 4 header
        /// </summary>
        H4
    }
}
