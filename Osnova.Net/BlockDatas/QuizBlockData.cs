using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.BlockDatas
{
    /// <summary>
    /// Quiz
    /// </summary>
    public class QuizBlockData
    {
        #region Properties

        /// <summary>
        /// Unique ID of the quiz, not <see cref="Guid"/>
        /// </summary>
        [JsonPropertyName("uid")]
        public string Uid { get; set; }

        /// <summary>
        /// Quiz hash
        /// </summary>
        [JsonPropertyName("hash")]
        public string Hash { get; set; }

        [JsonPropertyName("tmp_hash")]
        public string TempHash { get; set; } // TODO: what is this?

        /// <summary>
        /// Title
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// Quiz questions
        /// </summary>
        [JsonPropertyName("items")]
        public Dictionary<string, string> Items { get; set; }

        /// <summary>
        /// Is this quiz anonymous, our you can look at who voted for what?
        /// <para/>
        /// <remarks>Refers to "is_public" json property</remarks>
        /// </summary>
        [JsonPropertyName("is_public")]
        public bool IsResultPublic { get; set; }

        /// <summary>
        /// Date, when this quiz was created
        /// </summary>
        [JsonConverter(typeof(LongDateTimeOffsetJsonConverter))]
        [JsonPropertyName("date_created")]
        public DateTimeOffset DateCreated { get; set; }

        #endregion
    }
}
