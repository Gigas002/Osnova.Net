using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Osnova.Net.Responses
{
    public class Comment
    {
        #region From getEntryById -> commentsPreview docs

        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("date")]
        public long Date { get; set; }

        [JsonPropertyName("dateRFC")]
        public string DateRFC { get; set; }

        [JsonPropertyName("author")]
        public User Author { get; set; }

        /// <summary>
        /// Текст комментария с html
        /// </summary>
        [JsonPropertyName("text")]
        public string Text { get; set; }

        /// <summary>
        /// Текст комментария с markdown
        /// </summary>
        [JsonPropertyName("text_wo_md")]
        public string TextWoMd { get; set; }

        [JsonPropertyName("media")]
        public IEnumerable<Media> Media { get; set; }

        [JsonPropertyName("likes")]
        public Likes Likes { get; set; }

        // TODO: recursive?
        [JsonPropertyName("entry")]
        public Entry Entry { get; set; }

        [JsonPropertyName("replyTo")]
        public int ReplyTo { get; set; }

        [JsonPropertyName("isFavorited")]
        public bool IsFavorited { get; set; }

        [JsonPropertyName("is_pinned")]
        public bool IsPinned { get; set; }

        [JsonPropertyName("isEdited")]
        public bool IsEdited { get; set; }

        [JsonPropertyName("level")]
        public int Level { get; set; }

        /// <summary>
        /// С какой OS был написан комментарий:
        /// 0 - Other
        /// 1 - iOS
        /// 2 - Android
        /// </summary>
        [JsonPropertyName("source_id")]
        public int SourceOs { get; set; }

        [JsonPropertyName("load_more")]
        public LoadMore LoadMore { get; set; }

        [JsonPropertyName("attaches")]
        public IEnumerable<Attach> Attaches { get; set; }

        [JsonPropertyName("etcControls")]
        public EtcControls EtcControls { get; set; }

        #endregion
    }
}