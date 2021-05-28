using System.Text.Json.Serialization;
using Osnova.Net.JsonConverters;

namespace Osnova.Net
{
    public class Likes
    {
        /// <summary>
        /// Count of likes
        /// </summary>
        [JsonPropertyName("count")]
        public int Count { get; set; }

        /// <summary>
        /// Sum value of likes/dislikes
        /// </summary>
        [JsonPropertyName("summ")]
        public int Sum { get; set; }

        /// <summary>
        /// Is current logged user liked this?
        /// </summary>
        [JsonConverter(typeof(IntToBoolJsonConverter))]
        [JsonPropertyName("is_liked")]
        public bool IsLiked { get; set; }

        [JsonPropertyName("is_hidden")]
        public bool IsHidden { get; set; }
    }
}
