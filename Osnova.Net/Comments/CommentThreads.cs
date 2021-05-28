using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Osnova.Net.Comments
{
    public class CommentThreads
    {
        [JsonPropertyName("items")]
        public IEnumerable<Comment> Items { get; set; }

        [JsonPropertyName("root_load_more")]
        public CommentsLoadMore RootLoadMore { get; set; }

        [JsonExtensionData]
        public Dictionary<string, object> Undeserialized { get; set; }
    }
}
