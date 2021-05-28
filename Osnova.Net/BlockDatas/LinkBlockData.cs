using System;
using System.Text.Json.Serialization;
using Osnova.Net.Blocks;

namespace Osnova.Net.BlockDatas
{
    /// <summary>
    /// Link to some external services
    /// </summary>
    public class LinkBlockData
    {
        #region Properties

        // In LinkBlock's Data

        /// <summary>
        /// Block with link's data
        /// <para/>
        /// <remarks>Exists on higher level, e.g. LinkBlock.Data</remarks>
        /// </summary>
        [JsonPropertyName("link")]
        public LinkBlock Link { get; set; }

        // In LinkBlockData.Link.Data

        /// <summary>
        /// URL to an external service
        /// <para/>
        /// <remarks>Exists on lower level, e.g. LinkBlock.Data.Link.Data</remarks>
        /// </summary>
        [JsonPropertyName("url")]
        public Uri Url { get; set; }

        /// <summary>
        /// Title of link block
        /// <para/>
        /// <remarks>Exists on lower level, e.g. LinkBlock.Data.Link.Data</remarks>
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// Description of link block
        /// <para/>
        /// <remarks>Exists on lower level, e.g. LinkBlock.Data.Link.Data</remarks>
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Image thumbnail, if any
        /// <para/>
        /// <remarks>Exists on lower level, e.g. LinkBlock.Data.Link.Data</remarks>
        /// </summary>
        [JsonPropertyName("image")]
        public ImageBlock Image { get; set; }

        [JsonPropertyName("v")]
        public int V { get; set; } // TODO: wtf is "v"? version?

        #endregion
    }
}
