using System.Text.Json.Serialization;

namespace Osnova.Net.Twitter.Enterprise
{
    /// <summary>
    /// 1.1
    /// </summary>
    public class TwitterPollOption
    {
        [JsonPropertyName("position")]
        public int Position { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }
}
