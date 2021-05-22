using System;
using System.Text.Json.Serialization;
using Osnova.Net.Blocks;

namespace Osnova.Net
{
    public class BoxData
    {
        [JsonPropertyName("src")]
        public Uri Src { get; set; }

        [JsonPropertyName("url")]
        public Uri Url { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("thumbnail")]
        public ImageBlock Thumbnail { get; set; }

        [JsonPropertyName("data_encoded")]
        public string DataEncoded { get; set; }

        [JsonPropertyName("image")]
        public ImageBlock Image { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("version")]
        public string Version { get; set; }

        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}
