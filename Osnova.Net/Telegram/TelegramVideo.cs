using System;
using System.Text.Json.Serialization;

namespace Osnova.Net.Telegram
{
    public class TelegramVideo
    {
        [JsonPropertyName("src")]
        public Uri Url { get; set; }

        [JsonPropertyName("thumbnail_url")]
        public Uri ThumbnailUrl { get; set; }

        [JsonPropertyName("ratio")]
        public double Ratio { get; set; }

        [JsonPropertyName("width")]
        public int Width { get; set; }

        [JsonPropertyName("height")]
        public int Height { get; set; }
    }
}
