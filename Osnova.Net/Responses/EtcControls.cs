using System.Text.Json.Serialization;

namespace Osnova.Net.Responses
{
    public class EtcControls
    {
        [JsonPropertyName("edit_entry")]
        public bool EditEntry { get; set; }

        [JsonPropertyName("pin_content")]
        public bool PinConnect { get; set; }

        [JsonPropertyName("unpublish_entry")]
        public bool UnpublishEntry { get; set; }

        [JsonPropertyName("ban_subsite")]
        public bool BanSubsite { get; set; }

        [JsonPropertyName("pin_comment")]
        public bool PinComment { get; set; }

        [JsonPropertyName("remove")]
        public bool Remove { get; set; }

        [JsonPropertyName("remove_thread")]
        public bool RemoveThread { get; set; }
    }
}
