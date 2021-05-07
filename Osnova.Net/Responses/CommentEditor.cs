using System.Text.Json.Serialization;

namespace Osnova.Net.Responses
{
    public class CommentEditor
    {
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }
    }
}
