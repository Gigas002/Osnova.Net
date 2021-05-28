using System.Collections.Generic;
using System.Text.Json.Serialization;
using Osnova.Net.Enums;

namespace Osnova.Net.BlockDatas
{
    /// <summary>
    /// Lists in blocks
    /// </summary>
    public class ListBlockData
    {
        #region Properties

        /// <summary>
        /// String values of the list
        /// </summary>
        [JsonPropertyName("items")]
        public IEnumerable<string> Items { get; set; }

        /// <summary>
        /// Type of the list
        /// </summary>
        [JsonPropertyName("type")]
        public ListType Type { get; set; }

        #endregion
    }
}
