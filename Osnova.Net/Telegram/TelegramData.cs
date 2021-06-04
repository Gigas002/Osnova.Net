using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.Telegram
{
    /// <summary>
    /// Data of telegram post
    /// </summary>
    public class TelegramData
    {
        #region Properties

        /// <summary>
        /// ID of the post
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// URL of the post
        /// </summary>
        [JsonPropertyName("url")]
        public Uri Url { get; set; }

        /// <summary>
        /// Version
        /// </summary>
        [JsonConverter(typeof(VersionJsonConverter))]
        [JsonPropertyName("version")]
        public Version Version { get; set; }

        /// <summary>
        /// Post's text
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }

        /// <summary>
        /// Post's author
        /// </summary>
        [JsonPropertyName("author")]
        public TelegramAuthor Author { get; set; }

        /// <summary>
        /// Collection of photos in post
        /// </summary>
        [JsonPropertyName("photos")]
        public IEnumerable<TelegramPhoto> Photos { get; set; }

        /// <summary>
        /// Collection of videos in post
        /// </summary>
        [JsonPropertyName("videos")]
        public IEnumerable<TelegramVideo> Videos { get; set; }

        /// <summary>
        /// Count of views
        /// </summary>
        // Don't use number types: there can be 880 or 10.7K stuff
        [JsonPropertyName("views")]
        public string Views { get; set; }

        /// <summary>
        /// Date, when this post was created
        /// <para/>
        /// <remarks>Refers to "datetime" propert in json</remarks>
        /// </summary>
        [JsonConverter(typeof(LongDateTimeOffsetJsonConverter))]
        [JsonPropertyName("datetime")]
        public DateTimeOffset DateCreated { get; set; }

        /// <summary>
        /// Is supported?
        /// </summary>
        [JsonPropertyName("is_supported")]
        public bool IsSupported { get; set; }

        /// <summary>
        /// Author, if post was supported
        /// </summary>
        [JsonConverter(typeof(WrongEmptyArrayJsonConverter<TelegramAuthor>))]
        [JsonPropertyName("forwarded_from")]
        public TelegramAuthor ForwardedFrom { get; set; }
        
        #endregion
    }
}
