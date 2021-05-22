using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.BlockDatas
{
    public class QuizBlockData
    {
        #region Properties

        [JsonPropertyName("uid")]
        public string Uid { get; set; }

        [JsonPropertyName("hash")]
        public string Hash { get; set; }

        [JsonPropertyName("tmp_hash")]
        public string TempHash { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("items")]
        public Dictionary<string, string> Items { get; set; }

        [JsonPropertyName("is_public")]
        public bool IsPublic { get; set; }

        [JsonConverter(typeof(LongDateTimeOffsetJsonConverter))]
        [JsonPropertyName("date_created")]
        public DateTimeOffset DateCreated { get; set; }

        #endregion
    }
}
