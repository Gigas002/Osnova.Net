using System.Text.Json.Serialization;

namespace Osnova.Net.Twitter
{
    /// <summary>
    /// 1.1
    /// </summary>
    public class TweetMediaSize
    {
        [JsonPropertyName("w")]
        public int Width { get; set; }

        [JsonPropertyName("h")]
        public int Height { get; set; }

        [JsonPropertyName("resize")]
        public string Resize { get; set; } // TODO: Enum
    }
}
