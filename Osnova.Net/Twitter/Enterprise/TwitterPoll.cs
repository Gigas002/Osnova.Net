using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.Twitter.Enterprise
{
    /// <summary>
    /// 1.1
    /// Doc src: https://developer.twitter.com/en/docs/twitter-api/enterprise/data-dictionary/native-enriched-objects/entities
    /// </summary>
    public class TwitterPoll
    {
        /// <summary>
        /// An array of options, each having a poll position, and the text for that position
        /// </summary>
        [JsonPropertyName("options")]
        public IEnumerable<TwitterPollOption> Options { get; set; }

        /// <summary>
        /// Time stamp (UTC) of when poll ends
        /// </summary>
        [JsonConverter(typeof(TwitterV1DateTimeOffsetJsonConverter))]
        [JsonPropertyName("end_datetime")]
        public DateTimeOffset EndDatetime { get; set; }

        /// <summary>
        /// Duration of poll in minutes
        /// </summary>
        [JsonPropertyName("duration_minutes")]
        public int DurationMinutes { get; set; }
    }
}
