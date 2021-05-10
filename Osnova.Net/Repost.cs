using System.Text.Json.Serialization;

namespace Osnova.Net
{
    public class Repost
    {
        [JsonPropertyName("author")]
        public User Author { get; set; }
    }
}