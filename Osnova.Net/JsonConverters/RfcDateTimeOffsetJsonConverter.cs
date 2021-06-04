using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Osnova.Net.JsonConverters
{
    /// <summary>
    /// Converts <see cref="DateTimeOffset"/> to/from RFC2822 <see cref="string"/>
    /// <para/>
    /// <remarks>Pattern: ddd, dd MMM yyyy HH':'mm':'ss K</remarks>
    /// </summary>
    public class RfcDateTimeOffsetJsonConverter : JsonConverter<DateTimeOffset>
    {
        /// <inheritdoc />
        public override DateTimeOffset Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return DateTimeOffset.Parse(reader.GetString());
        }

        /// <inheritdoc />
        public override void Write(Utf8JsonWriter writer, DateTimeOffset value, JsonSerializerOptions options)
        {
            var str = value.ToString(Core.Rfc2822DatePattern, CultureInfo.InvariantCulture);
            str = str.Remove(str.Length - 3, 1);

            writer.WriteStringValue(str);
        }
    }
}
