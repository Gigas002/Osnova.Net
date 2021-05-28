using System.Text.Json.Serialization;

namespace Osnova.Net.BlockDatas
{
    /// <summary>
    /// Block of code in entry
    /// </summary>
    public class CodeBlockData
    {
        #region Properties

        /// <summary>
        /// Code as text
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }

        /// <summary>
        /// Programming language
        /// </summary>
        [JsonPropertyName("lang")]
        public string Language { get; set; }

        #endregion
    }
}
