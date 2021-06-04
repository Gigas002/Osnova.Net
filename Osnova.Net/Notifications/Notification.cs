using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.Json.Serialization;
using Osnova.Net.Enums;
using Osnova.Net.JsonConverters;
using Osnova.Net.Users;

namespace Osnova.Net.Notifications
{
    /// <summary>
    /// Notification
    /// </summary>
    public class Notification : INotification
    {
        #region Properties

        #region INotification implementation

        /// <inheritdoc />
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("type")]
        public NotificationType Type { get; set; }

        /// <inheritdoc />
        [JsonConverter(typeof(LongDateTimeOffsetJsonConverter))]
        [JsonPropertyName("date")]
        public DateTimeOffset Date { get; set; }

        /// <inheritdoc />
        [JsonConverter(typeof(RfcDateTimeOffsetJsonConverter))]
        [JsonPropertyName("dateRFC")]
        public DateTimeOffset DateRfc { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("users")]
        public IEnumerable<User> Users { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("text")]
        public string Text { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("comment_text")]
        public string CommentText { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("url")]
        public Uri Url { get; set; }

        /// <inheritdoc />
        [JsonPropertyName("icon")]
        public NotificationIcon Icon { get; set; }

        #endregion

        #region From real queries

        [JsonPropertyName("group_id")]
        public int GroupId { get; set; }

        [JsonConverter(typeof(NamedColorJsonConverter))]
        [JsonPropertyName("color")]
        public Color Color { get; set; }

        [JsonPropertyName("markdown")]
        public string Markdown { get; set; }

        #endregion

        [JsonExtensionData]
        public Dictionary<string, object> Undeserialized { get; set; }

        #endregion
    }
}
