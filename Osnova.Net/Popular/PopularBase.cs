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
        #region Properties

        /// <summary>
        /// Title
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// Content type (entry or comment)
        /// <para/>
        /// <remarks>Refers to "item_type" property in json</remarks>
        /// </summary>
        [JsonConverter(typeof(PopularContentTypeJsonConverter))]
        [JsonPropertyName("item_type")]
        public ContentType Type { get; set; }
        
        #endregion

        #region Constructors

        /// <summary>
        /// Create new popular object of specified type
        /// </summary>
        /// <param name="type">Type of popular object</param>
        protected PopularBase(ContentType type) => Type = type;

        #endregion

        #region Methods

        /// <summary>
        /// Get real <see cref="System.Type"/> of this object
        /// </summary>
        /// <returns><see cref="System.Type"/></returns>
        public Type GetPopularType() => GetPopularType(Type);

        /// <summary>
        /// Get real <see cref="System.Type"/>
        /// </summary>
        /// <param name="type">Enum type of popular object</param>
        /// <returns><see cref="System.Type"/></returns>
        /// <exception cref="ArgumentOutOfRangeException"/>
        public static Type GetPopularType(ContentType type) => type switch
        {
            ContentType.Entry => typeof(PopularEntries),
            ContentType.Comment => typeof(PopularComments),
            _ => throw new ArgumentOutOfRangeException(nameof(type), $"Specified content type is not valid for Popular: {type}")
        };

        /// <summary>
        /// Get <see cref="ContentType"/> from <see cref="string"/>
        /// </summary>
        /// <param name="type">Type as string</param>
        /// <returns><see cref="ContentType"/></returns>
        /// <exception cref="ArgumentOutOfRangeException"/>
        public static ContentType GetPopularType(string type) => type switch
        {
            "content" => ContentType.Entry,
            "comment" => ContentType.Comment,
            _ => throw new ArgumentOutOfRangeException(nameof(type), $"Specified content type is not valid for Popular: {type}")
        };

        /// <summary>
        /// Get <see cref="string"/> from <see cref="ContentType"/>
        /// </summary>
        /// <param name="type">Type as string</param>
        /// <returns><see cref="string"/></returns>
        /// <exception cref="ArgumentOutOfRangeException"/>
        public static string GetPopularTypeString(ContentType type) => type switch
        {
            ContentType.Entry => "content",
            ContentType.Comment => "comment",
            _ => throw new ArgumentOutOfRangeException(nameof(type), $"Specified content type is not valid for Popular: {type}")
        };
        
        #endregion
    }
}
