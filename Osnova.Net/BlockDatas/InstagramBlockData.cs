using System.Text.Json.Serialization;
using Osnova.Net.Blocks;

namespace Osnova.Net.BlockDatas
{
    /// <summary>
    /// Instagram's data in block
    /// </summary>
    public class InstagramBlockData
    {
        #region Properties

        /// <summary>
        /// Universal block for external services
        /// </summary>
        [JsonPropertyName("instagram")]
        public UniversalBoxBlock Instagram { get; set; }

        /// <summary>
        /// Title
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// Do you want to hide the title?
        /// <para/>
        /// <remarks>Refers to "hide_title" property in json</remarks>
        /// </summary>
        [JsonPropertyName("hide_title")]
        public bool IsHideTitle { get; set; }

        /// <summary>
        /// Markdown text
        /// </summary>
        [JsonPropertyName("markdown")]
        public string Markdown { get; set; }

        #endregion
    }
}
