using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Osnova.Net.Blocks;
using Osnova.Net.Enums;

namespace Osnova.Net.JsonConverters
{
    /// <summary>
    /// Converts <see cref="Block"/> to specified children type
    /// </summary>
    public class BlockJsonConverter : JsonConverter<Block>
    {
        /// <inheritdoc />
        public override Block Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using var document = JsonDocument.ParseValue(ref reader);

            var opts = new JsonSerializerOptions {Converters = {new BlockTypeJsonConverter()}};
            var blockType = JsonSerializer.Deserialize<BlockType>(document.RootElement.GetProperty("type").GetRawText(), opts);

            var type = Block.GetBlockType(blockType);

            return (Block)JsonSerializer.Deserialize(document.RootElement.GetRawText(), type);
        }

        /// <inheritdoc />
        public override void Write(Utf8JsonWriter writer, Block value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value, value.GetBlockType(), options);
        }
    }
}
