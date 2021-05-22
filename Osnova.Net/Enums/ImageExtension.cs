using System.Text.Json.Serialization;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.Enums
{
    [JsonConverter(typeof(EnumToStringJsonConverter<ImageExtension>))]
    public enum ImageExtension
    {
        // TODO: process all data types
        Png,
        Jpg,
        Webp,
        Gif
    }
}
