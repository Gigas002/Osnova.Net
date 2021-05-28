using System.Text.Json.Serialization;

namespace Osnova.Net.Comments
{
    public class CommentEditorSettings
    {
        [JsonPropertyName("enabled")]
        public bool Enabled { get; set; }
    }
}
