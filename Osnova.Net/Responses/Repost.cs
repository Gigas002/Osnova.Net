using System.Text.Json.Serialization;

namespace Osnova.Net.Responses
{
    public class Repost
    {
        [JsonPropertyName("author")]
        public User Author { get; set; }
    }
}