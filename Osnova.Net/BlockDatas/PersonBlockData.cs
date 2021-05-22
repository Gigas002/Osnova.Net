using System.Text.Json.Serialization;
using Osnova.Net.Blocks;

namespace Osnova.Net.BlockDatas
{
    public class PersonBlockData
    {
        #region Properties

        [JsonPropertyName("image")]
        public ImageBlock Image { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        #endregion
    }
}
