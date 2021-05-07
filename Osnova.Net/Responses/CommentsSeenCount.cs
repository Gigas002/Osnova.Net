using System.Text.Json.Serialization;

namespace Osnova.Net.Responses
{
    public class CommentsSeenCount
    {
        [JsonPropertyName("count")]
        public long Count { get; set; }

        [JsonPropertyName("date")]
        public long Date { get; set; }
    }
}