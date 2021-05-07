using System.Text.Json.Serialization;

namespace Osnova.Net.Responses
{
    public class Likes
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("summ")]
        public int Summ { get; set; }

        [JsonPropertyName("is_liked")]
        public int IsLiked { get; set; }

        [JsonPropertyName("is_hidden")]
        public bool IsHidden { get; set; }
    }
}
