using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Osnova.Net.Enums;
using Osnova.Net.Popular;

namespace Osnova.Net.JsonConverters
{
    /// <summary>
    /// Converts <see cref="ContentType"/> enum to/from <see cref="string"/>
    /// </summary>
    public class PopularContentTypeJsonConverter : JsonConverter<ContentType>
    {
        /// <inheritdoc />
        public override ContentType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return PopularBase.GetPopularType(reader.GetString());
        }

        /// <inheritdoc />
        public override void Write(Utf8JsonWriter writer, ContentType value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(PopularBase.GetPopularTypeString(value));
        }
    }
}
