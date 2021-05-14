using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Osnova.Net
{
    public class QuizResults
    {
        [JsonPropertyName("items")]
        public Dictionary<string, QuizResult> Items { get; set; }

        [JsonPropertyName("winner")]
        public string Winner { get; set; }

        [JsonPropertyName("userVoted")]
        public string UserVoted { get; set; }

        [JsonPropertyName("randomVotedUsers")]
        public Dictionary<string, IEnumerable<User>> RandomVotedUsers { get; set; } // TODO: needs testing
    }
}
