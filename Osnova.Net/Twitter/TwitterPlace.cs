using System;
using System.Text.Json.Serialization;

namespace Osnova.Net.Twitter
{
    /// <summary>
    /// 1.1/2.0
    /// </summary>
    public class TwitterPlace
    {
        #region Properties

        #region 1.1 only

        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("url")]
        public Uri Url { get; set; }

        [JsonPropertyName("place_type")]
        public string PlaceType { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("full_name")]
        public string FullName { get; set; }

        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("bounding_box")]
        public TwitterBoundingBox BoundingBox { get; set; }

        [JsonPropertyName("attributes")]
        public TwitterPlaceAttributes Attributes { get; set; }

        #endregion

        #region 2.0

        [JsonPropertyName("contained_within")]
        public object ContainedWithin { get; set; }

        [JsonPropertyName("geo")]
        public TwitterGeo Geo { get; set; }

        #endregion

        #endregion
    }
}
