using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Osnova.Net
{
    public class Hashtag
    {
        #region Properties

        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("content_count")]
        public int ContentCount { get; set; }

        [JsonExtensionData]
        public Dictionary<string, object> Undeserialized { get; set; }

        #endregion
    }
}
