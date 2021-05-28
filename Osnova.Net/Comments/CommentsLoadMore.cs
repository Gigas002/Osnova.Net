using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Osnova.Net.Comments
{
    public class CommentsLoadMore
    {
        /// <summary>
        /// Collection of comments IDs to load
        /// </summary>
        [JsonPropertyName("ids")]
        public IEnumerable<int> Ids { get; set; }

        /// <summary>
        /// Count of comments to load
        /// </summary>
        [JsonPropertyName("count")]
        public int Count { get; set; }

        /// <summary>
        /// Collection of user's avatars
        /// </summary>
        [JsonPropertyName("avatars")]
        public IEnumerable<Uri> AvatarsUrls { get; set; }
    }
}