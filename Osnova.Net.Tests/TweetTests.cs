using System.Text.Json;
using System.Threading.Tasks;
using NUnit.Framework;
using Osnova.Net.Twitter;

namespace Osnova.Net.Tests
{
    public class TweetTests
    {
        [SetUp]
        public void Setup() => Helper.InitializeHelper();

        [Test]
        public async Task GetTweets()
        {
            var tweets = await OsnovaTweet.GetTweetsAsync(Helper.Client, Helper.Kind).ConfigureAwait(false);

            foreach (var value in tweets)
            {
                if (value.Undeserialized != null) throw new JsonException("Undeserialized is not empty");
            }

            var json = JsonSerializer.Serialize(tweets, Core.Options);
        }
    }
}
