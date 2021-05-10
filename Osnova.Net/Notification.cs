using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Osnova.Net
{
    public class Notification
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("group_id")]
        public long GroupId { get; set; }

        [JsonPropertyName("type")]
        public NotificationType Type { get; set; }

        [JsonPropertyName("date")]
        public long Date { get; set; }

        [JsonPropertyName("dateRFC")]
        public string DateRfc { get; set; }

        [JsonPropertyName("users")]
        public IEnumerable<User> Users { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("comment_text")]
        public string CommentText { get; set; }

        [JsonPropertyName("url")]
        public Uri Url { get; set; }

        /// <summary>
        ///  TODO: enum
        ///  Enum: "comments_added" "comments_reply_to" "like_up" "like_down" "ui_chronograph" "icon-unpublish-entry" "pencil" "ui_archive"
        /// Название иконки, которая подставляется вместо аватарки.
        /// </summary>
        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        [JsonPropertyName("color")]
        public string Color { get; set; }

        [JsonPropertyName("markdown")]
        public string Markdown { get; set; }
    }
}
