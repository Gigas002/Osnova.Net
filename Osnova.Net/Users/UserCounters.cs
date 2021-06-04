using System.Text.Json.Serialization;

namespace Osnova.Net.Users
{
    /// <summary>
    /// Counters for user entries, comments and favorites
    /// <para/>
    /// <remarks>Refers to Counters specification</remarks>
    /// </summary>
    public class UserCounters // TODO: obsolete with Dictionary<string, IEnumerable<int>>?
    {
        #region Properties
        
        /// <summary>
        /// Count of entries
        /// </summary>
        [JsonPropertyName("entries")]
        public int Entries { get; set; }

        /// <summary>
        /// Count of comments
        /// </summary>
        [JsonPropertyName("comments")]
        public int Comments { get; set; }

        /// <summary>
        /// Favorites count
        /// </summary>
        [JsonPropertyName("favorites")]
        public int Favorites { get; set; }
        
        #endregion
    }
}