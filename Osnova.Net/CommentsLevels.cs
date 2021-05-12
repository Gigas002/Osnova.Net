using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Osnova.Net
{
    public class CommentsLevels
    {
        [JsonPropertyName("items")]
        public IEnumerable<Comment> Items { get; set; }

        [JsonPropertyName("root_load_more")]
        public LoadMore RootLoadMore { get; set; }
    }
}
