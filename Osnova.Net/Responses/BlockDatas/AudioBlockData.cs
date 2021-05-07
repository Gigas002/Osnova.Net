using System;
using System.Text.Json.Serialization;
using Osnova.Net.Responses.Blocks;

namespace Osnova.Net.Responses.BlockDatas
{
    public class AudioBlockData : BlockData
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("hash")]
        public string Hash { get; set; }

        [JsonPropertyName("image")]
        public Block Image { get; set; }

        [JsonPropertyName("audio")]
        public Block Audio { get; set; }

        #region In audio block data

        [JsonPropertyName("uuid")]
        public Guid Uuid { get; set; }

        [JsonPropertyName("filename")]
        public string FileName { get; set; }

        [JsonPropertyName("size")]
        public long Size { get; set; }

        [JsonPropertyName("audio_info")]
        public AudioInfo AudioInfo { get; set; }

        #endregion
    }
}
