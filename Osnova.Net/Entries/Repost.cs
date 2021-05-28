using System.Text.Json.Serialization;

namespace Osnova.Net.Entries
{
    public class Repost
    {
        [JsonPropertyName("author")]
        public User Author { get; set; }
    }
}