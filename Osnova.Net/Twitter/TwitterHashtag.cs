using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Osnova.Net.Twitter
{
    /// <summary>
    /// 1.1
    /// </summary>
    public class TwitterHashtag
    {
        [JsonPropertyName("indices")]
        public IEnumerable<int> Indices { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }
}
