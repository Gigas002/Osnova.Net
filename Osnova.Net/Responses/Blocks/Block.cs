using System;
using System.Text.Json.Serialization;
using Osnova.Net.Responses.BlockDatas;

namespace Osnova.Net.Responses.Blocks
{
    public class Block
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("data")]
        public BlockData Data { get; set; }

        [JsonPropertyName("cover")]
        public bool Cover { get; set; }

        [JsonPropertyName("anchor")]
        public string Anchor { get; set; }

        public static Type GetBlockDataType(string type) => type switch
        {
            "audio" => typeof(AudioBlockData),
            "code" => typeof(CodeBlockData),
            "delimiter" => typeof(DelimiterBlockData),
            "header" => typeof(HeaderBlockData),
            "image" => typeof(ImageBlockData),
            "incut" => typeof(IncutBlockData),
            "instagram" => typeof(InstagramBlockData),
            "link" => typeof(LinkBlockData),
            "list" => typeof(ListBlockData),
            "media" => typeof(MediaBlockData),
            "number" => typeof(NumberBlockData),
            "person" => typeof(PersonBlockData),
            "quiz" => typeof(QuizBlockData),
            "quote" => typeof(QuoteBlockData),
            "rawhtml" => typeof(RawHtmlBlockData),
            "special_button" => typeof(SpecialButtonBlockData),
            "spotify" => typeof(SpotifyBlockData),
            "telegram" => typeof(TelegramBlockData),
            "text" => typeof(TextBlockData),
            "tiktok" => typeof(TikTokBlockData),
            "tweet" => typeof(TweetBlockData),
            "universalbox" => typeof(UniversalBoxBlockData),
            "video" => typeof(VideoBlockData),
            "wtrfall" => typeof(WaterfallBlockData),
            "yamusic" => typeof(YaMusicBlockData),
            _ => typeof(object)
        };
    }
}
