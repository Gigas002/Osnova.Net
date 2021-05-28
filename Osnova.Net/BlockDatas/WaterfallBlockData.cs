using System.Text.Json.Serialization;

namespace Osnova.Net.BlockDatas
{
    /// <summary>
    /// Block for continious data, like tweet feed
    /// <para/>
    /// <remarks>Editoral block</remarks>
    /// </summary>
    public class WaterfallBlockData
    {
        #region Properties

        /// <summary>
        /// ID of waterfall
        /// <para/>
        /// <remarks>Refers to "wtrfallid" property in json</remarks>
        /// </summary>
        [JsonPropertyName("wtrfallid")]
        public string WaterfallId { get; set; }

        #endregion
    }
}
