using System.Text.Json.Serialization;

namespace Osnova.Net
{
    public class Hashtag
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("content_count")]
        public int ContentCount { get; set; }
    }
}
