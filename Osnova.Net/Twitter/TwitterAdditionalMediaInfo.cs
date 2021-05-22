using System.Text.Json.Serialization;

namespace Osnova.Net.Twitter
{
    public class TwitterAdditionalMediaInfo
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("embeddable")]
        public bool Embeddable { get; set; }

        [JsonPropertyName("monetizable")]
        public bool Monetizable { get; set; }
    }
}