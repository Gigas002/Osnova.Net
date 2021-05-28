using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Osnova.Net.Enums;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.Blocks
{
    /// <summary>
    /// Refers to EntryBlock spec without Data.
    /// Implement your own Data in inherited classes
    /// </summary>
    [JsonConverter(typeof(BlockJsonConverter))]
    public abstract class Block
    {
        #region Properties

        /// <summary>
        /// Type of the block
        /// </summary>
        [JsonPropertyName("type")]
        public BlockType Type { get; set; }

        /// <summary>
        /// Has cover?
        /// </summary>
        [JsonPropertyName("cover")]
        public bool HasCover { get; set; }

        /// <summary>
        /// Hyperlink to some object in block
        /// </summary>
        [JsonPropertyName("anchor")]
        public string Anchor { get; set; }

        [JsonExtensionData]
        public Dictionary<string, object> Undeserialized { get; set; } // TODO: remove

        #endregion

        #region Constructors

        /// <summary>
        /// Create <see cref="Block"/>
        /// </summary>
        /// <param name="type">Block type</param>
        protected Block(BlockType type) => Type = type;

        #endregion

        #region Methods

        /// <inheritdoc cref="GetBlockType(BlockType)"/>
        public Type GetBlockType() => GetBlockType(Type);

        /// <summary>
        /// Get block's real <see cref="System.Type"/>
        /// </summary>
        /// <param name="type">Type to switch on</param>
        /// <returns><see cref="System.Type"/></returns>
        public static Type GetBlockType(BlockType type) => type switch
        {
            BlockType.Audio => typeof(AudioBlock),
            BlockType.Code => typeof(CodeBlock),
            BlockType.Delimiter => typeof(DelimiterBlock),
            BlockType.Entry => typeof(EntryBlock),
            BlockType.Header => typeof(HeaderBlock),
            BlockType.Image => typeof(ImageBlock),
            BlockType.Incut => typeof(IncutBlock),
            BlockType.Instagram => typeof(InstagramBlock),
            BlockType.Link => typeof(LinkBlock),
            BlockType.List => typeof(ListBlock),
            BlockType.Media => typeof(MediaBlock),
            BlockType.Movie => typeof(MovieBlock),
            BlockType.Number => typeof(NumberBlock),
            BlockType.Person => typeof(PersonBlock),
            BlockType.Quiz => typeof(QuizBlock),
            BlockType.Quote => typeof(QuoteBlock),
            BlockType.RawHtml => typeof(RawHtmlBlock),
            BlockType.SpecialButton => typeof(SpecialButtonBlock),
            BlockType.Spotify => typeof(SpotifyBlock),
            BlockType.Telegram => typeof(TelegramBlock),
            BlockType.Text => typeof(TextBlock),
            BlockType.TikTok => typeof(TikTokBlock),
            BlockType.Tweet => typeof(TweetBlock),
            BlockType.UniversalBox => typeof(UniversalBoxBlock),
            BlockType.User => typeof(UserBlock),
            BlockType.Video => typeof(VideoBlock),
            BlockType.Warning => typeof(WarningBlock),
            BlockType.Waterfall => typeof(WaterfallBlock),
            BlockType.YandexMusic => typeof(YandexMusicBlock),
            _ => throw new ArgumentOutOfRangeException($"Unknown block type: {type}")
        };

        #endregion
    }
}
