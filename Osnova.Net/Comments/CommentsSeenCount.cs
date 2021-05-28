using System.Text.Json.Serialization;

namespace Osnova.Net.Comments
{
    public class CommentsSeenCount // TODO: wtf is this? comments count? seen count? both?
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("date")]
        public long Date { get; set; } // TODO: datetimeoffset?
    }
}