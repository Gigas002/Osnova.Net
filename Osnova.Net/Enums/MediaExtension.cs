using System.Text.Json.Serialization;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.Enums
{
    [JsonConverter(typeof(StringToEnumJsonConverter<MediaExtension>))]
    public enum MediaExtension
    {
        // TODO: process all data types
        Png,
        Jpg,
        Webp,
        Gif,
        Mp4
    }
}
