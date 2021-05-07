using System.Collections.Generic;
using System.Text.Json.Serialization;
using Osnova.Net.Responses.Blocks;

namespace Osnova.Net.Responses.BlockDatas
{
    public class MediaBlockData : BlockData
    {
        [JsonPropertyName("items")]
        public IEnumerable<MediaItemBlock> Items { get; set; }

        [JsonPropertyName("with_background")]
        public bool WithBackground { get; set; }

        [JsonPropertyName("with_border")]
        public bool WithBorder { get; set; }
    }
}
