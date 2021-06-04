using System.Text.Json.Serialization;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.Enums
{
    /// <summary>
    /// Delimiter type
    /// <para/>
    /// <remarks>Uses default string-to-enum converter</remarks>
    /// </summary>
    [JsonConverter(typeof(StringToEnumJsonConverter<DelimiterType>))]
    public enum DelimiterType // TODO: more types
    {
        /// <summary>
        /// Default
        /// </summary>
        Default
    }
}
