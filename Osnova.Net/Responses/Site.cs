﻿using System;
using System.Text.Json.Serialization;

namespace Osnova.Net.Responses
{
    public class Site
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("url")]
        public Uri Url { get; set; }
    }
}