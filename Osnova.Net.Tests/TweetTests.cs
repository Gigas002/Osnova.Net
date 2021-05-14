using System.Threading.Tasks;
using NUnit.Framework;

namespace Osnova.Net.Tests
{
    public class TweetTests
    {
        [SetUp]
        public void Setup() => Constants.CreateClient();

        [Test]
        public async Task GetTweets()
        {
            var tweets = await Tweet.GetTweetsAsync(Constants.Client, Constants.Kind).ConfigureAwait(false);
        }
    }
}
