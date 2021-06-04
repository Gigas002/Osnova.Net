using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Osnova.Net.JsonConverters
{
    /// <summary>
    /// Converts <see cref="DateTimeOffset"/>, presented as unix time, to/from <see cref="long"/>
    /// </summary>
    public class LongDateTimeOffsetJsonConverter : JsonConverter<DateTimeOffset>
    {
        /// <inheritdoc />
        public override DateTimeOffset Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return reader.TokenType == JsonTokenType.Null ? default : DateTimeOffset.FromUnixTimeSeconds(reader.GetInt64());
        }

        /// <inheritdoc />
        public override void Write(Utf8JsonWriter writer, DateTimeOffset value, JsonSerializerOptions options)
        {
            writer.WriteNumberValue(value.ToUnixTimeSeconds());
        }
    }
}
