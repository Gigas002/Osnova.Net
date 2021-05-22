using System;
using System.Text.Json.Serialization;
using Osnova.Net.Blocks;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.BlockDatas
{
    public class AudioBlockData
    {
        #region Properties

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("hash")]
        public string Hash { get; set; }

        [JsonPropertyName("image")]
        public ImageBlock Image { get; set; }

        [JsonPropertyName("audio")]
        public AudioBlock Audio { get; set; }

        #region In audio block data

        [JsonConverter(typeof(GuidJsonConverter))]
        [JsonPropertyName("uuid")]
        public Guid Uuid { get; set; }

        [JsonPropertyName("filename")]
        public string FileName { get; set; }

        /// <summary>
        /// Size of current file in bytes
        /// <para/>
        /// <remarks>Refers to "size" property in json</remarks>
        /// </summary>
        [JsonPropertyName("size")]
        public int Length { get; set; }

        [JsonPropertyName("audio_info")]
        public AudioInfo AudioInfo { get; set; }

        #endregion

        #endregion
    }
}
