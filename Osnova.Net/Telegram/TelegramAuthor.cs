using System;
using System.Text.Json.Serialization;

namespace Osnova.Net.Telegram
{
    public class TelegramAuthor
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("avatar_url")]
        public Uri AvatarUrl { get; set; }

        [JsonPropertyName("url")]
        public Uri Url { get; set; }
    }
}
