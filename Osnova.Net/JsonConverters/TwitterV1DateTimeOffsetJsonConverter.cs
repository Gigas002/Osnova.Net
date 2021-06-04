using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Osnova.Net.JsonConverters
{
    /// <summary>
    /// Converts Twitter's v1.1 spec's <see cref="DateTimeOffset"/> to/from <see cref="string"/>
    /// <para/>
    /// <remarks>Pattern: ddd MMM dd HH':'mm':'ss K yyyy</remarks>
    /// </summary>
    public class TwitterV1DateTimeOffsetJsonConverter : JsonConverter<DateTimeOffset>
    {
        /// <inheritdoc />
        public override DateTimeOffset Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            return DateTimeOffset.ParseExact(reader.GetString(), Core.TwitterV1DatePattern, CultureInfo.InvariantCulture);
        }

        /// <inheritdoc />
        public override void Write(Utf8JsonWriter writer, DateTimeOffset value, JsonSerializerOptions options)
        {
            var str = value.ToString(Core.TwitterV1DatePattern, CultureInfo.InvariantCulture);
            str = str.Remove(str.Length - 8, 1);

            writer.WriteStringValue(str);
        }
    }
}
