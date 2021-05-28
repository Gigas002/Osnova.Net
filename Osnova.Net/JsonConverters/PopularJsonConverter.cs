using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Osnova.Net.Enums;
using Osnova.Net.Popular;

namespace Osnova.Net.JsonConverters
{
    public class PopularJsonConverter : JsonConverter<PopularBase>
    {
        public override PopularBase Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using var document = JsonDocument.ParseValue(ref reader);

            var opts = new JsonSerializerOptions { Converters = { new PopularContentTypeJsonConverter() } };
            var popularType = JsonSerializer.Deserialize<ContentType>(document.RootElement.GetProperty("item_type").GetRawText(), opts);

            var type = PopularBase.GetPopularType(popularType);

            return (PopularBase)JsonSerializer.Deserialize(document.RootElement.GetRawText(), type);
        }

        public override void Write(Utf8JsonWriter writer, PopularBase value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value, value.GetPopularType(), options);
        }
    }
}
