using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Osnova.Net.BlockDatas
{
    public class MediaBlockData
    {
        #region Properties

        [JsonPropertyName("items")]
        public IEnumerable<MediaItem> Items { get; set; }

        [JsonPropertyName("with_background")]
        public bool WithBackground { get; set; }

        [JsonPropertyName("with_border")]
        public bool WithBorder { get; set; }

        #endregion
    }
}
