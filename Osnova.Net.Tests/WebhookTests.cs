#if LOCALTESTS

using System.Threading.Tasks;
using NUnit.Framework;

namespace Osnova.Net.Tests
{
    public class WebhookTests
    {
        [SetUp]
        public void Setup() => Constants.CreateClient();

        [Test]
        public async Task GetApiWebhooksGet()
        {
            var watchers = await Webhooks.GetApiWebhooksGetAsync(Constants.Client, Constants.Kind).ConfigureAwait(false);
        }
    }
}

#endif
