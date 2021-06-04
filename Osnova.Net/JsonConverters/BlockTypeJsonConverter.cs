using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Osnova.Net.Enums;

namespace Osnova.Net.JsonConverters
{
    /// <summary>
    /// Converts <see cref="BlockType"/> enum to/from <see cref="string"/>
    /// </summary>
    public class BlockTypeJsonConverter : JsonConverter<BlockType>
    {
        /// <inheritdoc />
        public override BlockType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string blockTypeString = reader.GetString();

            switch (blockTypeString) // TODO: move to Block class?
            {
                case "wtrfall":
                {
                    return BlockType.Waterfall;
                }
                case "special_button":
                {
                    return BlockType.SpecialButton;
                }
                case "yamusic":
                {
                    return BlockType.YandexMusic;
                }
                default:
                {
                    bool isParsed = Enum.TryParse<BlockType>(blockTypeString, true, out var type);

                    return isParsed ? type : BlockType.Unknown; // TODO: throw an exception
                }
            }
        }

        /// <inheritdoc />
        /// <exception cref="ArgumentOutOfRangeException"/>
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
                case BlockType.YandexMusic:
                {
                    writer.WriteStringValue("yamusic");

                    return;
                }
                case BlockType.Unknown:
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Trying to serialize unknown block type");
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
