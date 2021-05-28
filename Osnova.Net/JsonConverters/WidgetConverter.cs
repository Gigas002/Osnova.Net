using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Osnova.Net.Popular;

namespace Osnova.Net.JsonConverters
{
    public class WidgetConverter : JsonConverter<PopularBase>
    {
        public override PopularBase Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using JsonDocument doc = JsonDocument.ParseValue(ref reader);

            // Get type for convert
            string itemType = doc.RootElement.GetProperty("item_type").GetString();

            // Create new widget with default deserializer
            PopularBase widget = JsonSerializer.Deserialize<PopularBase>(doc.RootElement.GetRawText());

            var itemsJson = doc.RootElement.GetProperty("items").GetRawText();

            widget.Items = JsonSerializer.Deserialize(itemsJson, PopularBase.GetItemsType(itemType), options);

            return widget;
        }

        // TODO: serialize all properties, see BlockConverter
        public override void Write(Utf8JsonWriter writer, PopularBase value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            writer.WritePropertyName("items");

            var type = PopularBase.GetItemsType(value.ItemType);
            JsonSerializer.Serialize(writer, value.Items, type, options);

            writer.WriteEndObject();
        }
    }
}
