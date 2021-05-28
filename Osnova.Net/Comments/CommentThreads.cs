using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Osnova.Net.Comments
{
    /// <summary>
    /// Represents comments threads
    /// <para/>
    /// <remarks>Refers to CommentsLevels in spec</remarks>
    /// </summary>
    public class CommentThreads // TODO: better naming?
    {
        #region Properties

        /// <summary>
        /// Collections of comments
        /// </summary>
        [JsonPropertyName("items")]
        public IEnumerable<Comment> Items { get; set; }

        [JsonPropertyName("root_load_more")]
        public CommentsLoadMore RootLoadMore { get; set; }

        [JsonExtensionData]
        public Dictionary<string, object> Undeserialized { get; set; }

        #endregion
    }
}
