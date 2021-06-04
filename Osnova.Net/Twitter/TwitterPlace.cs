using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Osnova.Net.Twitter
{
    /// <summary>
    /// Twitter place
    /// <para/>
    /// <remarks>API version: 1.1, 2.0;
    /// <para/>
    /// Docs sources:
    /// <para/>
    /// 1.1: https://developer.twitter.com/en/docs/twitter-api/enterprise/data-dictionary/native-enriched-objects/geo
    /// <para/>
    /// 2.0: https://developer.twitter.com/en/docs/twitter-api/data-dictionary/object-model/place
    /// </remarks>
    /// </summary>
    public class TwitterPlace
    {
        #region Properties

        #region 1.1 only

        /// <summary>
        /// ID representing this place
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// URL representing the location of additional place metadata for this place
        /// </summary>
        [JsonPropertyName("url")]
        public Uri Url { get; set; }

        /// <summary>
        /// The type of location represented by this place
        /// </summary>
        [JsonPropertyName("place_type")]
        public string PlaceType { get; set; }

        /// <summary>
        /// Short human-readable representation of the place’s name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Full human-readable representation of the place’s name
        /// </summary>
        [JsonPropertyName("full_name")]
        public string FullName { get; set; }

        /// <summary>
        /// Shortened country code representing the country containing this place
        /// </summary>
        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; }

        /// <summary>
        /// Name of the country containing this place
        /// </summary>
        [JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// A bounding box of coordinates which encloses this place
        /// </summary>
        [JsonPropertyName("bounding_box")]
        public TwitterCoordinates<IEnumerable<IEnumerable<IEnumerable<float>>>> BoundingBox { get; set; }

        /// <summary>
        /// When using PowerTrack, 30-Day and Full-Archive Search APIs, and Volume Streams this hash is null
        /// </summary>
        [JsonPropertyName("attributes")]
        public object Attributes { get; set; }

        #endregion

        #region 2.0

        /// <summary>
        /// Returns the identifiers of known places that contain the referenced place
        /// </summary>
        [JsonPropertyName("contained_within")]
        public object ContainedWithin { get; set; }

        /// <summary>
        /// Contains place details in GeoJSON format
        /// </summary>
        [JsonPropertyName("geo")]
        public TwitterGeo Geo { get; set; }

        #endregion

        #endregion
    }
}
