using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Osnova.Net.Enums;
using Osnova.Net.JsonConverters;

namespace Osnova.Net.Blocks
{
    [JsonConverter(typeof(BlockJsonConverter))]
    public abstract class Block
    {
        #region Properties

        [JsonPropertyName("type")]
        public BlockType Type { get; set; }

        [JsonPropertyName("cover")]
        public bool HasCover { get; set; }

        /// <summary>
        /// Hyperlink to something in block
        /// </summary>
        [JsonPropertyName("anchor")]
        public string Anchor { get; set; }

        [JsonExtensionData]
        public Dictionary<string, object> Undeserialized { get; set; }

        #endregion

        #region Constructors

        protected Block(BlockType type) => Type = type;

        #endregion

        #region Methods

        public Type GetBlockType() => GetBlockType(Type);

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
            BlockType.YaMusic => typeof(YaMusicBlock),
            _ => typeof(Block)
        };

        #endregion
    }
}
