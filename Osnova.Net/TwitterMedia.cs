using System;
using System.Text.Json.Serialization;

namespace Osnova.Net
{
    public class TwitterMedia
    {
        [JsonPropertyName("type")]
        public int Type { get; set; }

        [JsonPropertyName("thumbnail_url")]
        public Uri ThumbnailUrl { get; set; }

        [JsonPropertyName("media_url")]
        public Uri MediaUrl { get; set; }

        [JsonPropertyName("thumbnail_width")]
        public int ThumbnailWidth { get; set; }

        [JsonPropertyName("thumbnail_height")]
        public int ThumbnailHeight { get; set; }

        [JsonPropertyName("ratio")]
        public double Ratio { get; set; }
    }
}
