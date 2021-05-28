using System;
using System.Drawing;
using System.Text.Json.Serialization;
using Osnova.Net.Enums;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.BlockDatas
{
    /// <summary>
    /// Video with sound in blocks
    /// </summary>
    public class MovieBlockData // TODO: rename to Video? VideoWithSound?
    {
        #region Properties

        /// <summary>
        /// Video's <see cref="Guid"/> on osnova's servers
        /// <para/>
        /// <remarks>You can get the actual URL of the media,
        /// by calling <see cref="Core.GetMediaUri"/> method</remarks>
        /// </summary>
        [JsonConverter(typeof(GuidJsonConverter))]
        [JsonPropertyName("uuid")]
        public Guid Uuid { get; set; }

        /// <summary>
        /// Extension of this video
        /// <para/>
        /// <remarks>Refers to "type" property in json</remarks>
        /// </summary>
        [JsonPropertyName("type")]
        public MediaExtension Extension { get; set; }

        /// <summary>
        /// Width
        /// </summary>
        [JsonPropertyName("width")]
        public int Width { get; set; }

        /// <summary>
        /// Height
        /// </summary>
        [JsonPropertyName("height")]
        public int Height { get; set; }

        /// <summary>
        /// Size of current file in bytes
        /// <para/>
        /// <remarks>Refers to "size" property in json</remarks>
        /// </summary>
        [JsonPropertyName("size")]
        public int Length { get; set; }

        /// <summary>
        /// Bitrate
        /// </summary>
        [JsonPropertyName("bitrate")]
        public int Bitrate { get; set; }

        /// <summary>
        /// Duration in seconds
        /// </summary>
        [JsonPropertyName("duration")]
        public double Duration { get; set; }

        /// <summary>
        /// Color
        /// </summary>
        [JsonConverter(typeof(ColorJsonConverter))]
        [JsonPropertyName("color")]
        public Color Color { get; set; }

        #endregion
    }
}
