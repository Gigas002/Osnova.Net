﻿using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Osnova.Net.Blocks;

namespace Osnova.Net.JsonConverters
{
    public class BlockConverter : JsonConverter<Block>
    {
        public override Block Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using JsonDocument doc = JsonDocument.ParseValue(ref reader);

            // Get type for convert
            string type = doc.RootElement.GetProperty("type").GetString();

            // Create new block with default deserializer
            Block block = JsonSerializer.Deserialize<Block>(doc.RootElement.GetRawText());

            var dataJson = doc.RootElement.GetProperty("data").GetRawText();

            // Warning: recursive for types with blocks inside
            block.Data = JsonSerializer.Deserialize(dataJson, Block.GetBlockDataType(type), options);

            return block;
        }

        // TODO: kind of works? needs testing
        public override void Write(Utf8JsonWriter writer, Block value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            writer.WriteString("type", value.Type);

            writer.WritePropertyName("data");

            var type = Block.GetBlockDataType(value.Type);
            JsonSerializer.Serialize(writer, value.Data, type, options);

            writer.WriteBoolean("cover", value.Cover);

            writer.WriteString("anchor", value.Anchor);

            writer.WriteEndObject();
        }
    }
}