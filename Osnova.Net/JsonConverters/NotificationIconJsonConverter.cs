using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Osnova.Net.Enums;

namespace Osnova.Net.JsonConverters
{
    /// <summary>
    /// Converts <see cref="NotificationIcon"/> enum to/from <see cref="string"/>
    /// </summary>
    public class NotificationIconJsonConverter : JsonConverter<NotificationIcon>
    {
        /// <inheritdoc />
        public override NotificationIcon Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string value = reader.GetString();

            return value switch // TODO: move to Notification class?
            {
                "comment" => NotificationIcon.Comment,
                "reply" => NotificationIcon.Reply,
                "like_up" => NotificationIcon.LikeUp,
                "like_down" => NotificationIcon.LikeDown,
                "mini_check" => NotificationIcon.Subscribe,
                "archive" => NotificationIcon.Archive,
                "plus" => NotificationIcon.Plus,
                "upset" => NotificationIcon.Upset,
                "mention" => NotificationIcon.Mention,

                "ui_chronograph" => NotificationIcon.UiChronograph,
                "pencil" => NotificationIcon.Pencil,
                _ => throw new ArgumentOutOfRangeException(nameof(reader), $"Unknown notification icon: {value}")
            };
        }

        /// <inheritdoc />
        public override void Write(Utf8JsonWriter writer, NotificationIcon value, JsonSerializerOptions options)
        {
            string str = value switch
            {
                NotificationIcon.Comment => "comment",
                NotificationIcon.Reply => "reply",
                NotificationIcon.LikeUp => "like_up",
                NotificationIcon.LikeDown => "like_down",
                NotificationIcon.Subscribe => "mini_check",
                NotificationIcon.Archive => "archive",
                NotificationIcon.Plus => "plus",
                NotificationIcon.Upset => "upset",
                NotificationIcon.Mention => "mention",

                NotificationIcon.UiChronograph => "ui_chronograph",
                NotificationIcon.Pencil => "pencil",
                _ => throw new ArgumentOutOfRangeException(nameof(value), $"Unknown notification icon: {value}")
            };

            writer.WriteStringValue(str);
        }
    }
}
