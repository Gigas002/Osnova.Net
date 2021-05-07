using System.Text.Json.Serialization;

namespace Osnova.Net.Responses
{
    public class Counters
    {
        [JsonPropertyName("entries")]
        public long Entries { get; set; }

        [JsonPropertyName("comments")]
        public long Comments { get; set; }

        [JsonPropertyName("favorites")]
        public long Favorites { get; set; }
    }
}