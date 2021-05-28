using System.Text.Json.Serialization;

namespace Osnova.Net.BlockDatas
{
    /// <summary>
    /// Warning block
    /// <para/>
    /// <remarks>Editoral block</remarks>
    /// </summary>
    public class WarningBlockData
    {
        #region Properties

        /// <summary>
        /// Title
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// Text value
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }

        #endregion
    }
}
