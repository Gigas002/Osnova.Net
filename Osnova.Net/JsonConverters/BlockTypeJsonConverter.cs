using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Osnova.Net.Enums;

namespace Osnova.Net.JsonConverters
{
    public class BlockTypeJsonConverter : JsonConverter<BlockType>
    {
        public override BlockType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string blockTypeString = reader.GetString();

            switch (blockTypeString)
            {
                case "wtrfall":
                {
                    return BlockType.Waterfall;
                }
                case "special_button":
                {
                    return BlockType.SpecialButton;
                }
                default:
                {
                    bool isParsed = Enum.TryParse<BlockType>(blockTypeString, true, out var type);

                    return isParsed ? type : BlockType.Unknown;
                }
            }
        }

        public override void Write(Utf8JsonWriter writer, BlockType value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case BlockType.Waterfall:
                {
                    writer.WriteStringValue("wtrfall");

                    return;
                }
                case BlockType.SpecialButton:
                {
                    writer.WriteStringValue("special_button");

                    return;
                }
                case BlockType.Unknown:
                {
                    throw new InvalidOperationException("Trying to serialize unknown block type");
                }
                default:
                {
                    writer.WriteStringValue(value.ToString().ToLowerInvariant());

                    return;
                }
            }
        }
    }
}
