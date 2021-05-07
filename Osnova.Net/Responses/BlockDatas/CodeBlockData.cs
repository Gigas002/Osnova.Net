﻿using System.Text.Json.Serialization;

namespace Osnova.Net.Responses.BlockDatas
{
    public class CodeBlockData : BlockData
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("lang")]
        public string Lang { get; set; }
    }
}
