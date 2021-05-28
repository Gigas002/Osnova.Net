using System.Text.Json.Serialization;

namespace Osnova.Net.Comments
{
    /// <summary>
    /// Settings for comment editor
    /// </summary>
    public class CommentEditorSettings
    {
        /// <summary>
        /// Is comment editor enabled?
        /// <para/>
        /// <remarks>Refers to "enabled" property in json</remarks>
        /// </summary>
        [JsonPropertyName("enabled")]
        public bool IsEnabled { get; set; }
    }
}
