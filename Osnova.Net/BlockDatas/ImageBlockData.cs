using System;
using System.Drawing;
using System.Text.Json.Serialization;
using Osnova.Net.Enums;
using Osnova.Net.ExternalServices;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.BlockDatas
{
    public class ImageBlockData
    {
        [JsonConverter(typeof(GuidJsonConverter))]
        [JsonPropertyName("uuid")]
        public Guid Uuid { get; set; }

        [JsonPropertyName("width")]
        public int Width { get; set; }

        [JsonPropertyName("height")]
        public int Height { get; set; }

        /// <summary>
        /// Size of current file in bytes
        /// <para/>
        /// <remarks>Refers to "size" property in json</remarks>
        /// </summary>
        [JsonPropertyName("size")]
        public int Length { get; set; }

        [JsonPropertyName("type")]
        public ImageExtension Extension { get; set; }

        [JsonConverter(typeof(ColorJsonConverter))]
        [JsonPropertyName("color")]
        public Color Color { get; set; }

        [JsonPropertyName("hash")]
        public string Hash { get; set; }

        [JsonConverter(typeof(WrongEmptyArrayJsonConverter<ExternalService>))]
        [JsonPropertyName("external_service")]
        public ExternalService ExternalService { get; set; }
    }
}
