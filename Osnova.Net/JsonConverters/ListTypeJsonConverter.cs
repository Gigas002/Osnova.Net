using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Osnova.Net.Enums;

namespace Osnova.Net.JsonConverters
{
    public class ListTypeJsonConverter : JsonConverter<ListType>
    {
        public override ListType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string listTypeString = reader.GetString();

            return listTypeString switch
            {
                "OL" => ListType.OrderedList,
                _ => ListType.UnorderedList
            };
        }

        public override void Write(Utf8JsonWriter writer, ListType value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case ListType.OrderedList:
                {
                    writer.WriteStringValue("OL");

                    return;
                }
                default:
                {
                    writer.WriteStringValue("UL");

                    return;
                }
            }
        }
    }
}
