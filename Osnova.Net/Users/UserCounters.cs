using System.Text.Json.Serialization;

namespace Osnova.Net.Users
{
    /// <summary>
    /// Refers to Counters specification
    /// </summary>
    public class UserCounters
    {
        [JsonPropertyName("entries")]
        public int Entries { get; set; }

        [JsonPropertyName("comments")]
        public int Comments { get; set; }

        [JsonPropertyName("favorites")]
        public int Favorites { get; set; }
    }
}