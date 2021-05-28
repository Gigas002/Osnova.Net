using System.Text.Json.Serialization;
using Osnova.Net.Enums;

namespace Osnova.Net.BlockDatas
{
    /// <summary>
    /// Headers in block
    /// </summary>
    public class HeaderBlockData
    {
        #region Properties

        /// <summary>
        /// Text value
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }

        /// <summary>
        /// Header style/level
        /// <para/>
        /// <remarks>H1 is used only for entry's title</remarks>
        /// </summary>
        [JsonPropertyName("style")]
        public HeaderStyle Style { get; set; }

        #endregion
    }
}
