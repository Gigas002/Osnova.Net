using System;
using System.Text.Json.Serialization;
using Osnova.Net.Enums;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.Popular
{
    /// <summary>
    /// Popular entries/comments
    /// </summary>
    [JsonConverter(typeof(PopularJsonConverter))]
    public abstract class PopularBase
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonConverter(typeof(PopularContentTypeJsonConverter))]
        [JsonPropertyName("item_type")]
        public ContentType Type { get; set; }

        #region Constructors

        protected PopularBase(ContentType type) => Type = type;

        #endregion

        public Type GetPopularType() => GetPopularType(Type);

        public static Type GetPopularType(ContentType type) => type switch
        {
            ContentType.Entry => typeof(PopularEntries),
            ContentType.Comment => typeof(PopularComments),
            _ => typeof(PopularBase)
        };

        public static ContentType GetPopularType(string type) => type switch
        {
            "content" => ContentType.Entry,
            "comment" => ContentType.Comment,
            _ => throw new ArgumentOutOfRangeException()
        };

        public static string GetPopularTypeString(ContentType type) => type switch
        {
            ContentType.Entry => "content",
            ContentType.Comment => "comment",
            _ => throw new ArgumentOutOfRangeException()
        };
    }
}
