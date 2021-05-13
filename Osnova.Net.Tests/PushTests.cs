#if LOCALTESTS

using System.Threading.Tasks;
using NUnit.Framework;

namespace Osnova.Net.Tests
{
    public class PushTests
    {
        [SetUp]
        public void Setup() => Constants.CreateClient();

        [Test]
        public async Task GetUserPushTopic()
        {
            var topic = await Push.GetUserPushTopicAsync(Constants.Client, Constants.Kind).ConfigureAwait(false);
        }

        [Test]
        public async Task GetUserPushSettings()
        {
            var settings = await Push.GetUserPushSettingsAsync(Constants.Client, Constants.Kind).ConfigureAwait(false);
        }
    }
}

#endif
