﻿using System.Text.Json.Serialization;

namespace Osnova.Net.Comments
{
    public class CommentsSeenCount
    {
        [JsonPropertyName("count")]
        public long Count { get; set; }

        [JsonPropertyName("date")]
        public long Date { get; set; }
    }
}