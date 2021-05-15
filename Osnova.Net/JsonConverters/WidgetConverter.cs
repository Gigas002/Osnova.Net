using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Osnova.Net.JsonConverters
{
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

        // TODO: serialize all properties, see BlockConverter
        public override void Write(Utf8JsonWriter writer, Widget value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            writer.WritePropertyName("items");

            var type = Widget.GetItemsType(value.ItemType);
            JsonSerializer.Serialize(writer, value.Items, type, options);

            writer.WriteEndObject();
        }
    }
}
