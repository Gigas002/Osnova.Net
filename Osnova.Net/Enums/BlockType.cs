using System.Text.Json.Serialization;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.Enums
{
    [JsonConverter(typeof(BlockTypeJsonConverter))]
    public enum BlockType
    {
        Unknown = 0,
        Audio,
        Code,
        Delimiter,
        Entry,
        Header,
        Image,
        Incut,
        Instagram,
        Link,
        List,
        Media,
        Number,
        Person,
        Quiz,
        Quote,
        RawHtml,
        SpecialButton,
        Spotify,
        Telegram,
        Text,
        TikTok,
        Tweet,
        UniversalBox,
        User,
        Video,
        Warning,

        /// <summary>
        /// Refers to wtrfall
        /// </summary>
        Waterfall,
        YaMusic
    }
}
