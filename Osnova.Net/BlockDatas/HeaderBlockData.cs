﻿using System.Text.Json.Serialization;

namespace Osnova.Net.BlockDatas
{
    public class HeaderBlockData
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("style")]
        public string Style { get; set; }
    }
}
