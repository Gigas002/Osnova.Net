using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.Telegram
{
    public class TelegramData
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("url")]
        public Uri Url { get; set; }

        [JsonConverter(typeof(VersionJsonConverter))]
        [JsonPropertyName("version")]
        public Version Version { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("author")]
        public TelegramAuthor Author { get; set; }

        [JsonPropertyName("photos")]
        public IEnumerable<TelegramPhoto> Photos { get; set; }

        [JsonPropertyName("videos")]
        public IEnumerable<TelegramVideo> Videos { get; set; }

        /// <summary>
        /// Don't use number types: there can be 880 or 10.7K stuff
        /// </summary>
        [JsonPropertyName("views")]
        public string Views { get; set; }

        [JsonConverter(typeof(LongDateTimeOffsetJsonConverter))]
        [JsonPropertyName("datetime")]
        public DateTimeOffset DateTime { get; set; }

        [JsonPropertyName("is_supported")]
        public bool IsSupported { get; set; }

        [JsonConverter(typeof(WrongEmptyArrayJsonConverter<TelegramAuthor>))]
        [JsonPropertyName("forwarded_from")]
        public TelegramAuthor ForwardedFrom { get; set; }
    }
}
