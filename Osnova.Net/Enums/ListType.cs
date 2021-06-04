using System.Text.Json.Serialization;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.Enums
{
    /// <summary>
    /// Types of lists
    /// <para/>
    /// <remarks>Uses custom converter</remarks>
    /// </summary>
    [JsonConverter(typeof(ListTypeJsonConverter))]
    public enum ListType
    {
        /// <summary>
        /// Unordered list
        /// <para/>
        /// <remarks>Refers to "UL" in json</remarks>
        /// </summary>
        UnorderedList,
        
        /// <summary>
        /// Ordered list
        /// <para/>
        /// <remarks>Refers to "OL" in json</remarks>
        /// </summary>
        OrderedList
    }
}
