using System.Text.Json.Serialization;

namespace Osnova.Net.Responses
{
    public class OsnovaImage
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("data")]
        public AttachImage Data { get; set; }
    }
}