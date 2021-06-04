using System.Text.Json.Serialization;

namespace Osnova.Net.Quiz
{
    /// <summary>
    /// Represents part of quiz items collection
    /// </summary>
    public class QuizResult
    {
        #region Properties

        /// <summary>
        /// Count of votes for this result
        /// </summary>
        [JsonPropertyName("count")]
        public int Count { get; set; }

        /// <summary>
        /// Total count of votes in quiz
        /// </summary>
        [JsonPropertyName("total")]
        public int Total { get; set; }

        /// <summary>
        /// Percentage of votes
        /// </summary>
        [JsonPropertyName("percentage")]
        public int Percentage { get; set; }

        /// <summary>
        /// Is this result winner?
        /// </summary>
        [JsonPropertyName("isWinner")]
        public bool IsWinner { get; set; }
        
        #endregion
    }
}
