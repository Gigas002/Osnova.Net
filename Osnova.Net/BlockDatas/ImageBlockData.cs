using System;
using System.Drawing;
using System.Text.Json.Serialization;
using Osnova.Net.Enums;
using Osnova.Net.ExternalServices;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.BlockDatas
{
    /// <summary>
    /// Image in blocks
    /// </summary>
    public class ImageBlockData
    {
        #region Properties

        /// <summary>
        /// Image's <see cref="Guid"/> on osnova's servers
        /// <para/>
        /// <remarks>You can get the actual URL of the media,
        /// by calling <see cref="Core.GetMediaUri"/> method</remarks>
        /// </summary>
        [JsonConverter(typeof(GuidJsonConverter))]
        [JsonPropertyName("uuid")]
        public Guid Uuid { get; set; }

        /// <summary>
        /// Image width
        /// </summary>
        [JsonPropertyName("width")]
        public int Width { get; set; }

        /// <summary>
        /// Image height
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
        /// File extension
        /// <para/>
        /// <remarks>Refers to "type" property in json</remarks>
        /// </summary>
        [JsonPropertyName("type")]
        public MediaExtension Extension { get; set; }

        /// <summary>
        /// Color
        /// </summary>
        [JsonConverter(typeof(ColorJsonConverter))]
        [JsonPropertyName("color")]
        public Color Color { get; set; }

        /// <summary>
        /// Image hash
        /// </summary>
        [JsonPropertyName("hash")]
        public string Hash { get; set; }

        /// <summary>
        /// External service, to which the image is bound to, if any
        /// </summary>
        [JsonConverter(typeof(WrongEmptyArrayJsonConverter<ExternalService>))]
        [JsonPropertyName("external_service")]
        public ExternalService ExternalService { get; set; }

        #endregion
    }
}
