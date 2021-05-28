using System.Text.Json.Serialization;

namespace Osnova.Net.Quiz
{
    public class QuizResult
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }

        [JsonPropertyName("percentage")]
        public int Percentage { get; set; }

        [JsonPropertyName("isWinner")]
        public bool IsWinner { get; set; }
    }
}
