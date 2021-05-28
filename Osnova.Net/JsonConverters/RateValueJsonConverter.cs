using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Osnova.Net.JsonConverters
{
    public class RateValueJsonConverter : JsonConverter<double>
    {
        public override double Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return double.Parse(reader.GetString(), NumberStyles.Currency);
        }

        public override void Write(Utf8JsonWriter writer, double value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString(CultureInfo.CurrentCulture));
        }
    }
}
