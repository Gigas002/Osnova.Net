using System.Text.Json.Serialization;
using Osnova.Net.Blocks;
using Osnova.Net.ExternalServices;

namespace Osnova.Net.BlockDatas
{
    /// <summary>
    /// Class for gifs and video without sound
    /// </summary>
    public class VideoBlockData // TODO: rename?
    {
        #region Properties

        // In VideoBlock's Data

        /// <summary>
        /// Block with video's data
        /// <para/>
        /// <remarks>Exists on higher level, e.g. VideoBlock.Data</remarks>
        /// </summary>
        [JsonPropertyName("video")]
        public VideoBlock Video { get; set; }

        /// <summary>
        /// Title
        /// <para/>
        /// <remarks>Exists on higher level, e.g. VideoBlock.Data</remarks>
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        // In VideoBlockData.Video.Data

        /// <summary>
        /// Thumbnail image
        /// <para/>
        /// <remarks>Exists on lower level, e.g. VideoBlockData.Video.Data</remarks>
        /// </summary>
        [JsonPropertyName("thumbnail")]
        public ImageBlock Thumbnail { get; set; }

        /// <summary>
        /// Width
        /// <para/>
        /// <remarks>Exists on lower level, e.g. VideoBlockData.Video.Data</remarks>
        /// </summary>
        [JsonPropertyName("width")]
        public int Width { get; set; }

        /// <summary>
        /// Height
        /// <para/>
        /// <remarks>Exists on lower level, e.g. VideoBlockData.Video.Data</remarks>
        /// </summary>
        [JsonPropertyName("height")]
        public int Height { get; set; }

        /// <summary>
        /// Duration
        /// <para/>
        /// <remarks>Refers to "time" property in json</remarks>
        /// <para/>
        /// <remarks>Exists on lower level, e.g. VideoBlockData.Video.Data</remarks>
        /// </summary>
        [JsonPropertyName("time")]
        public int Duration { get; set; }

        /// <summary>
        /// External service, if any
        /// <para/>
        /// <remarks>Exists on lower level, e.g. VideoBlockData.Video.Data</remarks>
        /// </summary>
        [JsonPropertyName("external_service")]
        public ExternalService ExternalService { get; set; }

        #endregion
    }
}
