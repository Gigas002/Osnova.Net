using System.Text.Json.Serialization;

namespace Osnova.Net
{
    public class CommentEditor
    {
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }
    }
}
