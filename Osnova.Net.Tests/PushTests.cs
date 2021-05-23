using System.Threading.Tasks;
using NUnit.Framework;

namespace Osnova.Net.Tests
{
    public class PushTests
    {
        [SetUp]
        public void Setup() => Helper.InitializeHelper();

        [Test]
        public async Task GetUserPushTopic()
        {
            if (Helper.Secrets == null) return;

            var topic = await Push.GetUserPushTopicAsync(Helper.Client, Helper.Kind).ConfigureAwait(false);
        }

        [Test]
        public async Task GetUserPushSettings()
        {
            if (Helper.Secrets == null) return;

            var settings = await Push.GetUserPushSettingsAsync(Helper.Client, Helper.Kind).ConfigureAwait(false);
        }
    }
}
