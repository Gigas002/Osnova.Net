using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Osnova.Net.JsonConverters;
using Osnova.Net.Twitter.Enterprise;

namespace Osnova.Net.Twitter
{
    /// <summary>
    /// 1.1
    /// Doc source: https://developer.twitter.com/en/docs/twitter-api/enterprise/data-dictionary/native-enriched-objects/user
    /// </summary>
    public class TwitterUser
    {
        #region Properties

        /// <summary>
        /// The integer representation of the unique identifier for this User
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }

        /// <summary>
        /// The string representation of the unique identifier for this User
        /// </summary>
        [JsonPropertyName("id_str")]
        public string IdString { get; set; }

        /// <summary>
        /// The name of the user, as they’ve defined it. Not necessarily a person’s name
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The screen name, handle, or alias that this user identifies themselves with
        /// </summary>
        [JsonPropertyName("screen_name")]
        public string ScreenName { get; set; }

        /// <summary>
        /// Nullable . The user-defined location for this account’s profile. Not necessarily a location, nor machine-parseable
        /// </summary>
        [JsonPropertyName("location")]
        public string Location { get; set; }

        /// <summary>
        /// Enterprise APIs only Collection of Enrichment metadata derived for user.
        /// Provides the Profile Geo Enrichment metadata
        /// </summary>
        [JsonPropertyName("derived")]
        public TwitterUserDerived Derived { get; set; }

        /// <summary>
        /// Nullable. A URL provided by the user in association with their profile
        /// </summary>
        [JsonPropertyName("url")]
        public Uri Url { get; set; }

        [JsonPropertyName("entities")]
        public TwitterUserEntities Entities { get; set; }

        /// <summary>
        /// Nullable. The user-defined UTF-8 string describing their account
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// When true, indicates that this user has chosen to protect their Tweets
        /// </summary>
        [JsonPropertyName("protected")]
        public bool Protected { get; set; }

        /// <summary>
        /// When true, indicates that the user has a verified account
        /// </summary>
        [JsonPropertyName("verified")]
        public bool Verified { get; set; }

        /// <summary>
        /// The number of followers this account currently has
        /// </summary>
        [JsonPropertyName("followers_count")]
        public int FollowersCount { get; set; }

        /// <summary>
        /// The number of users this account is following (AKA their “followings”)
        /// </summary>
        [JsonPropertyName("friends_count")]
        public int FriendsCount { get; set; }

        /// <summary>
        /// The number of public lists that this user is a member of
        /// </summary>
        [JsonPropertyName("listed_count")]
        public int ListedCount { get; set; }

        /// <summary>
        /// The number of Tweets this user has liked in the account’s lifetime
        /// </summary>
        // No, that's not a typo
        [JsonPropertyName("favourites_count")]
        public int FavoritesCount { get; set; }

        /// <summary>
        /// The number of Tweets (including retweets) issued by the user
        /// </summary>
        [JsonPropertyName("statuses_count")]
        public int StatusesCount { get; set; }

        /// <summary>
        /// The UTC datetime that the user account was created on Twitter
        /// </summary>
        [JsonConverter(typeof(TwitterV1DateTimeOffsetJsonConverter))]
        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// The HTTPS-based URL pointing to the standard web representation of the user’s uploaded profile banner
        /// </summary>
        [JsonPropertyName("profile_banner_url")]
        public Uri ProfileBannerUrl { get; set; }

        /// <summary>
        /// A HTTPS-based URL pointing to the user’s profile image
        /// </summary>
        [JsonPropertyName("profile_image_url_https")]
        public Uri ProfileImageUrlHttps { get; set; }

        /// <summary>
        /// When true, indicates that the user has not altered the theme or background of their user profile
        /// </summary>
        [JsonPropertyName("default_profile")]
        public bool DefaultProfile { get; set; }

        /// <summary>
        /// When true, indicates that the user has not uploaded their own profile image and a default image is used instead
        /// </summary>
        [JsonPropertyName("default_profile_image")]
        public bool DefaultProfileImage { get; set; }

        [JsonPropertyName("withheld_in_countries")]
        public IEnumerable<string> WithheldInCountries { get; set; }

        [JsonPropertyName("withheld_scope")]
        public string WithheldScope { get; set; }

        #region Deprecated

        [Obsolete("null")]
        [JsonPropertyName("utc_offset")]
        public object UtcOffset { get; set; } = null;

        [Obsolete("null")]
        [JsonPropertyName("time_zone")]
        public object TimeZone { get; set; } = null;

        [Obsolete("null")]
        [JsonPropertyName("lang")]
        public object Language { get; set; } = null;

        [Obsolete("null")]
        [JsonPropertyName("geo_enabled")]
        public bool? GeoEnabled { get; set; } = null;

        [Obsolete("null")]
        [JsonPropertyName("following")]
        public object Following { get; set; } = null;

        [Obsolete("null")]
        [JsonPropertyName("follow_request_sent")]
        public object FollowRequestSent { get; set; } = null;

        [Obsolete("null")]
        [JsonPropertyName("has_extended_profile")]
        public bool? HasExtendedProfile { get; set; } = null;

        [Obsolete("null")]
        [JsonPropertyName("notifications")]
        public object Notifications { get; set; } = null;

        [Obsolete("null")]
        [JsonPropertyName("profile_location")]
        public object ProfileLocation { get; set; } = null;

        [Obsolete("null")]
        [JsonPropertyName("contributors_enabled")]
        public bool? ContributorsEnabled { get; set; } = null;

        [Obsolete("null")]
        [JsonPropertyName("profile_image_url")]
        public Uri ProfileImageUrl { get; set; } = null;

        [Obsolete("null")]
        [JsonPropertyName("profile_background_color")]
        public string ProfileBackgroundColor { get; set; } = null;

        [Obsolete("null")]
        [JsonPropertyName("profile_background_image_url")]
        public Uri ProfileBackgroundImageUrl { get; set; } = null;

        [Obsolete("null")]
        [JsonPropertyName("profile_background_image_url_https")]
        public Uri ProfileBackgroundImageUrlHttps { get; set; } = null;

        [Obsolete("null")]
        [JsonPropertyName("profile_background_tile")]
        public bool? ProfileBackgroundTile { get; set; } = null;

        [Obsolete("null")]
        [JsonPropertyName("profile_link_color")]
        public string ProfileLinkColor { get; set; } = null;

        [Obsolete("null")]
        [JsonPropertyName("profile_sidebar_border_color")]
        public string ProfileSidebarBorderColor { get; set; } = null;

        [Obsolete("null")]
        [JsonPropertyName("profile_sidebar_fill_color")]
        public string ProfileSidebarFillColor { get; set; } = null;

        [Obsolete("null")]
        [JsonPropertyName("profile_text_color")]
        public string ProfileTextColor { get; set; } = null;

        [Obsolete("null")]
        [JsonPropertyName("profile_use_background_image")]
        public bool? ProfileUseBackgroundImage { get; set; } = null;

        [Obsolete("null")]
        [JsonPropertyName("is_translator")]
        public bool? IsTranslator { get; set; } = null;

        [Obsolete("null")]
        [JsonPropertyName("is_translation_enabled")]
        public bool? IsTranslationEnabled { get; set; } = null;

        [Obsolete("null")]
        [JsonPropertyName("translator_type")]
        public string TranslatorType { get; set; } = null;

        #endregion

        #endregion
    }
}
