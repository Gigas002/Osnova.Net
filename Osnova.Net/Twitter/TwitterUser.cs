using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Osnova.Net.Twitter.Enterprise;

namespace Osnova.Net.Twitter
{
    /// <summary>
    /// 1.1
    /// </summary>
    public class TwitterUser
    {
        #region Properties

        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("id_str")]
        public string IdString { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("screen_name")]
        public string ScreenName { get; set; }

        [JsonPropertyName("location")]
        public string Location { get; set; }

        [JsonPropertyName("derived")]
        public TwitterUserDerived Derived { get; set; }

        [JsonPropertyName("url")]
        public Uri Url { get; set; }

        [JsonPropertyName("entities")]
        public TwitterUserEntities Entities { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("protected")]
        public bool Protected { get; set; }

        [JsonPropertyName("verified")]
        public bool Verified { get; set; }

        [JsonPropertyName("followers_count")]
        public int FollowersCount { get; set; }

        [JsonPropertyName("friends_count")]
        public int FriendsCount { get; set; }

        [JsonPropertyName("listed_count")]
        public int ListedCount { get; set; }

        [JsonPropertyName("favourites_count")]
        public int FavouritesCount { get; set; }

        [JsonPropertyName("statuses_count")]
        public int StatusesCount { get; set; }

        [JsonPropertyName("created_at")]
        public string CreatedAt { get; set; } // TODO: DateTimeOffset

        [JsonPropertyName("profile_banner_url")]
        public Uri ProfileBannerUrl { get; set; }

        [JsonPropertyName("profile_image_url_https")]
        public Uri ProfileImageUrlHttps { get; set; }

        [JsonPropertyName("default_profile")]
        public bool DefaultProfile { get; set; }

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
