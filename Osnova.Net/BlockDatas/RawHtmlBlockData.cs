using System.Text.Json.Serialization;

namespace Osnova.Net.BlockDatas
{
    /// <summary>
    /// HTML text with unique features
    /// <para/>
    /// <remarks>Editoral block</remarks>
    /// </summary>
    public class RawHtmlBlockData
    {
        #region Properties

        /// <summary>
        /// HTML text
        /// <para/>
        /// <remarks>Refers to "raw" property in json</remarks>
        /// </summary>
        [JsonPropertyName("raw")]
        public string Text { get; set; }

        #endregion
    }
}
