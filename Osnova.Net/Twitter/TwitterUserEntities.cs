using System.Text.Json.Serialization;

namespace Osnova.Net.Twitter
{
    /// <summary>
    /// 1.1
    /// </summary>
    public class TwitterUserEntities
    {
        [JsonPropertyName("url")]
        public TwitterEntities Url { get; set; }

        [JsonPropertyName("description")]
        public TwitterEntities Description { get; set; }
    }
}
