﻿using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Osnova.Net.Responses.BlockDatas;

namespace Osnova.Net.Responses.Blocks
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
            block.Data = (BlockData)JsonSerializer.Deserialize(dataJson, Block.GetBlockDataType(type), options);

            return block;
        }

        public override void Write(Utf8JsonWriter writer, Block value, JsonSerializerOptions options)
        {
            //JsonSerializer.Serialize(writer, value.Data, options);
            //JsonSerializer.Serialize(writer, value);
            throw new NotImplementedException();
        }
    }
}
