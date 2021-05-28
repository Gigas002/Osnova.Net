using System.Text.Json.Serialization;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.Enums
{
    [JsonConverter(typeof(NotificationIconJsonConverter))]
    public enum NotificationIcon // TODO: better naming?
    {
        Comment,
        Reply,
        LikeUp,
        LikeDown,

        /// <summary>
        /// mini_check
        /// </summary>
        Subscribe,

        /// <summary>
        /// Ad removed
        /// </summary>
        Archive,

        /// <summary>
        /// Ad added
        /// </summary>
        Plus,

        /// <summary>
        /// Unpublish
        /// </summary>
        Upset,

        Mention,


        UiChronograph,
        Pencil,
    }
}
