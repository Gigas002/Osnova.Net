using System;
using System.Text.Json.Serialization;

namespace Osnova.Net.Telegram
{
    public class TelegramPhoto
    {
        [JsonPropertyName("width")]
        public int Width { get; set; }

        [JsonPropertyName("height")]
        public int Height { get; set; }

        [JsonPropertyName("leonardo_url")]
        public Uri LeonardoUrl { get; set; }
    }
}
