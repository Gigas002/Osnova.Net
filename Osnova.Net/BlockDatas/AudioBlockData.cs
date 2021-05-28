using System;
using System.Text.Json.Serialization;
using Osnova.Net.Blocks;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.BlockDatas
{
    /// <summary>
    /// Block with audio file in entry
    /// </summary>
    public class AudioBlockData
    {
        #region Properties

        // In AudioBlock's data

        /// <summary>
        /// Audio title
        /// <para/>
        /// <remarks>Exists on higher level of AudioBlock.Data</remarks>
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// Audio hash
        /// <para/>
        /// <remarks>Exists on higher level of AudioBlock.Data</remarks>
        /// </summary>
        [JsonPropertyName("hash")]
        public string Hash { get; set; }

        /// <summary>
        /// Image preview if any
        /// <para/>
        /// <remarks>Exists on higher level, e.g. AudioBlock.Data</remarks>
        /// </summary>
        [JsonPropertyName("image")]
        public ImageBlock Image { get; set; }

        /// <summary>
        /// Audio itself
        /// <para/>
        /// <remarks>Exists on higher level, e.g. AudioBlock.Data</remarks>
        /// </summary>
        [JsonPropertyName("audio")]
        public AudioBlock Audio { get; set; }

        // In AudioBlockData.Audio.Data

        /// <summary>
        /// Audio file's <see cref="Guid"/> on osnova's servers
        /// <para/>
        /// <remarks>You can get the actual URL of the media,
        /// by calling <see cref="Core.GetMediaUri"/> method</remarks>
        /// <para/>
        /// <remarks>Exists on lower level, e.g. AudioBlock.Data.Audio.Data</remarks>
        /// </summary>
        [JsonConverter(typeof(GuidJsonConverter))]
        [JsonPropertyName("uuid")]
        public Guid Uuid { get; set; }

        /// <summary>
        /// Audio file name
        /// <para/>
        /// <remarks>Exists on lower level, e.g. AudioBlock.Data.Audio.Data</remarks>
        /// </summary>
        [JsonPropertyName("filename")]
        public string FileName { get; set; }

        /// <summary>
        /// Size of current file in bytes
        /// <para/>
        /// <remarks>Refers to "size" property in json</remarks>
        /// <para/>
        /// <remarks>Exists on lower level, e.g. AudioBlock.Data.Audio.Data</remarks>
        /// </summary>
        [JsonPropertyName("size")]
        public int Length { get; set; }

        /// <summary>
        /// Additional info about audio file
        /// <para/>
        /// <remarks>Exists on lower level, e.g. AudioBlock.Data.Audio.Data</remarks>
        /// </summary>
        [JsonPropertyName("audio_info")]
        public AudioInfo AudioInfo { get; set; }

        #endregion
    }
}
