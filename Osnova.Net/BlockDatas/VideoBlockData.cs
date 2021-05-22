﻿using System.Text.Json.Serialization;
using Osnova.Net.Blocks;

namespace Osnova.Net.BlockDatas
{
    public class VideoBlockData
    {
        #region Properties

        [JsonPropertyName("video")]
        public VideoBlock Video { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        #region Inside video block data

        [JsonPropertyName("thumbnail")]
        public ImageBlock Thumbnail { get; set; }

        [JsonPropertyName("width")]
        public int Width { get; set; }

        [JsonPropertyName("height")]
        public int Height { get; set; }

        [JsonPropertyName("time")]
        public int Time { get; set; }

        [JsonPropertyName("external_service")]
        public ExternalService ExternalService { get; set; }

        #endregion

        #endregion
    }
}
