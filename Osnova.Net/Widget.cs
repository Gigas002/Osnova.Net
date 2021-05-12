using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Osnova.Net.BlockDatas;
using Osnova.Net.Blocks;

namespace Osnova.Net
{
    public class Widget
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("item_type")]
        public string ItemType { get; set; }

        [JsonPropertyName("items")]
        public object Items { get; set; }

        public static Type GetItemsType(string itemType) => itemType switch
        {
            "content" => typeof(IEnumerable<Entry>),
            "comment" => typeof(IEnumerable<Comment>),
            _ => typeof(object)
        };
    }

    public class WidgetConverter : JsonConverter<Widget>
    {
        public override Widget Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using JsonDocument doc = JsonDocument.ParseValue(ref reader);

            // Get type for convert
            string itemType = doc.RootElement.GetProperty("item_type").GetString();

            // Create new widget with default deserializer
            Widget widget = JsonSerializer.Deserialize<Widget>(doc.RootElement.GetRawText());

            var itemsJson = doc.RootElement.GetProperty("items").GetRawText();

            widget.Items = JsonSerializer.Deserialize(itemsJson, Widget.GetItemsType(itemType), options);

            return widget;
        }

        public override void Write(Utf8JsonWriter writer, Widget value, JsonSerializerOptions options)
        {
            //if (value.ItemType != "content")
            //{
            //    var itemsType = Widget.GetItemsType(value.ItemType);

            //    JsonSerializerOptions ops = new JsonSerializerOptions() { IgnoreNullValues = true };

            //    var str = JsonSerializer.Serialize(value.Items, itemsType, ops);
            //}

            throw new NotImplementedException();
        }
    }
}
