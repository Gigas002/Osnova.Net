#if LOCALTESTS

using System;
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

        [Test]
        public async Task PostApiWebhooksAdd()
        {
            Uri url = new Uri("https://dtf.ru/");
            string eventName = "new_comment";

            var watcher = await Webhooks.PostApiWebhooksAddAsync(Constants.Client, Constants.Kind, url, eventName)
                                         .ConfigureAwait(false);
        }
    }
}

#endif
