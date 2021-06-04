using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Osnova.Net.JsonConverters
{
    /// <summary>
    /// Converts <see cref="Version"/> to/from <see cref="int"/>/<see cref="string"/>
    /// </summary>

    public class VersionJsonConverter : JsonConverter<Version>
    {
        /// <inheritdoc />
        public override Version Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var tokenType = reader.TokenType;

            return tokenType switch
            {
                JsonTokenType.Number => new Version(reader.GetInt32(), 0),
                JsonTokenType.String => Version.Parse(reader.GetString()),
                _ => throw new ArgumentOutOfRangeException(nameof(reader), "Unsupported type for version")
            };
        }

        /// <inheritdoc />
        public override void Write(Utf8JsonWriter writer, Version value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
    }
}
