using System.Text.Json.Serialization;

namespace Osnova.Net.Comments
{
    public class CommentEditor
    {
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }
    }
}
