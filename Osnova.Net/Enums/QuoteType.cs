using System.Text.Json.Serialization;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.Enums
{
    /// <summary>
    /// Quote type
    /// <para/>
    /// <remarks>Uses default string-to-enum converter</remarks>
    /// </summary>
    [JsonConverter(typeof(StringToEnumJsonConverter<QuoteType>))]
    public enum QuoteType
    {
        /// <summary>
        /// Default
        /// </summary>
        Default,
        
        /// <summary>
        /// Opinion
        /// </summary>
        Opinion
    }
}
