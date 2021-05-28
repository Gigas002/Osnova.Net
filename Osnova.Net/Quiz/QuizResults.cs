using System.Collections.Generic;
using System.Text.Json.Serialization;
using Osnova.Net.Users;

namespace Osnova.Net.Quiz
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

        [JsonExtensionData]
        public Dictionary<string, object> Undeserialized { get; set; }
    }
}
