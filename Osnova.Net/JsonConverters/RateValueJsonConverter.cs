using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Osnova.Net.JsonConverters
{
    /// <summary>
    /// Converts rates <see cref="double"/> values to/from <see cref="string"/>
    /// </summary>
    public class RateValueJsonConverter : JsonConverter<double>
    {
        /// <inheritdoc />
        public override double Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return double.Parse(reader.GetString(), NumberStyles.Currency, new CultureInfo("RU"));
        }

        /// <inheritdoc />
        public override void Write(Utf8JsonWriter writer, double value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString(new CultureInfo("RU")));
        }
    }
}
