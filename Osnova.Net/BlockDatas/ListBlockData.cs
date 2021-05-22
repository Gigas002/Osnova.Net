using System.Collections.Generic;
using System.Text.Json.Serialization;
using Osnova.Net.Enums;

namespace Osnova.Net.BlockDatas
{
    public class ListBlockData
    {
        #region Properties

        [JsonPropertyName("items")]
        public IEnumerable<string> Items { get; set; }

        [JsonPropertyName("type")]
        public ListType Type { get; set; }

        #endregion
    }
}
