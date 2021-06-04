using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Osnova.Net.JsonConverters
{
    /// <summary>
    /// Converts <see cref="CultureInfo"/> to/from <see cref="string"/>
    /// </summary>
    public class CultureInfoJsonConverter : JsonConverter<CultureInfo>
    {
        /// <inheritdoc />
        public override CultureInfo Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            var lang = reader.GetString();

            return lang switch
            {
                "und" => default,
                _ => new CultureInfo(lang)
            };
        }

        /// <inheritdoc />
        public override void Write(Utf8JsonWriter writer, CultureInfo value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
    }
}
