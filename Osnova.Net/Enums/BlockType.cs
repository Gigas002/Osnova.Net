using System.Text.Json.Serialization;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.Enums
{
    /// <summary>
    /// Type of blocks
    /// </summary>
    [JsonConverter(typeof(BlockTypeJsonConverter))]
    public enum BlockType
    {
        /// <summary>
        /// Unknown type. You should throw an exception if you got this
        /// </summary>
        Unknown = 0,
        
        /// <summary>
        /// Audio
        /// </summary>
        Audio,
        
        /// <summary>
        /// Code
        /// </summary>
        Code,
        
        /// <summary>
        /// Delimiter
        /// </summary>
        Delimiter,
        
        /// <summary>
        /// Entry
        /// </summary>
        Entry,
        
        /// <summary>
        /// Header
        /// </summary>
        Header,
        
        /// <summary>
        /// Image
        /// </summary>
        Image,
        
        /// <summary>
        /// Incut
        /// </summary>
        Incut,
        
        /// <summary>
        /// Instagram
        /// </summary>
        Instagram,
        
        /// <summary>
        /// Link
        /// </summary>
        Link,
        
        /// <summary>
        /// List
        /// </summary>
        List,
        
        /// <summary>
        /// Media block with children blocks
        /// </summary>
        Media,
        
        /// <summary>
        /// Video block
        /// </summary>
        Movie,
        
        /// <summary>
        /// Number
        /// </summary>
        Number,
        
        /// <summary>
        /// PErson
        /// </summary>
        Person,
        
        /// <summary>
        /// Quiz
        /// </summary>
        Quiz,
        
        /// <summary>
        /// Quote
        /// </summary>
        Quote,
        
        /// <summary>
        /// Raw html
        /// <para/>
        /// <remarks>This is editorial block</remarks>
        /// </summary>
        RawHtml,
        
        /// <summary>
        /// Special button
        /// <para/>
        /// <remarks>This is editorial block</remarks>
        /// </summary>
        SpecialButton,
        
        /// <summary>
        /// Spotify
        /// </summary>
        Spotify,
        
        /// <summary>
        /// Telegram
        /// </summary>
        Telegram,
        
        /// <summary>
        /// Text
        /// </summary>
        Text,
        
        /// <summary>
        /// TikTok
        /// </summary>
        TikTok,
        
        /// <summary>
        /// Tweet
        /// </summary>
        Tweet,
        
        /// <summary>
        /// Universal box
        /// <para/>
        /// <remarks>Used for some subtypes, like TikTok</remarks>
        /// </summary>
        UniversalBox,
        
        /// <summary>
        /// User
        /// </summary>
        User,
        
        /// <summary>
        /// Video
        /// </summary>
        Video,
        
        /// <summary>
        /// Warning
        /// <para/>
        /// <remarks>This is editorial block</remarks>
        /// </summary>
        Warning,

        /// <summary>
        /// Refers to "wtrfall"
        /// <para/>
        /// <remarks>This is editorial block</remarks>
        /// </summary>
        Waterfall,
        
        /// <summary>
        /// Refers to "yamusic"
        /// </summary>
        YandexMusic
    }
}
