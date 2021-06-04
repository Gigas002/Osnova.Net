using System.Text.Json.Serialization;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.Enums
{
    /// <summary>
    /// Notification's icons
    /// <para/>
    /// <remarks>Uses custom converter</remarks>
    /// </summary>
    [JsonConverter(typeof(NotificationIconJsonConverter))]
    public enum NotificationIcon // TODO: better naming?
    {
        /// <summary>
        /// New comment
        /// </summary>
        Comment,
        
        /// <summary>
        /// Reply
        /// </summary>
        Reply,
        
        /// <summary>
        /// Liked
        /// </summary>
        LikeUp,
        
        /// <summary>
        /// Disliked
        /// </summary>
        LikeDown,

        /// <summary>
        /// Subscribed
        /// <para/>
        /// <remarks>Refers to "mini_check" in json</remarks>
        /// </summary>
        Subscribe,

        /// <summary>
        /// Advertisement removed
        /// </summary>
        Archive,

        /// <summary>
        /// Advertisement added
        /// </summary>
        Plus,

        /// <summary>
        /// Unpublished entry
        /// </summary>
        Upset,

        /// <summary>
        /// Mentioned somewhere
        /// </summary>
        Mention,
        
        UiChronograph,
        Pencil,
    }
}
