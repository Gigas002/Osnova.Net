using System.Collections.Generic;
using System.Text.Json.Serialization;
using Osnova.Net.Blocks;

namespace Osnova.Net.BlockDatas
{
    public class MediaBlockData
    {
        [JsonPropertyName("items")]
        public IEnumerable<MediaItemBlock> Items { get; set; }

        [JsonPropertyName("with_background")]
        public bool WithBackground { get; set; }

        [JsonPropertyName("with_border")]
        public bool WithBorder { get; set; }
    }
}
