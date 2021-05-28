using System.Text.Json.Serialization;
using Osnova.Net.Enums;

namespace Osnova.Net.BlockDatas
{
    /// <summary>
    /// Delimiter in block
    /// </summary>
    public class DelimiterBlockData
    {
        #region Properties

        /// <summary>
        /// Type of delimiter
        /// </summary>
        [JsonPropertyName("type")]
        public DelimiterType Type { get; set; }

        #endregion
    }
}
