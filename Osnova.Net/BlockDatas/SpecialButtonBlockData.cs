using System;
using System.Text.Json.Serialization;

namespace Osnova.Net.BlockDatas
{
    public class SpecialButtonBlockData : BlockData
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("textColor")]
        public string TextColor { get; set; }

        [JsonPropertyName("backgroundColor")]
        public string BackgroundColor { get; set; }

        [JsonPropertyName("url")]
        public Uri Url { get; set; }
    }
}
