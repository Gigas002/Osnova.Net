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
        public async Task PostApiWebhookAdd()
        {
            Uri url = new Uri("https://dtf.ru/");
            string eventName = "new_comment";

            var watcher = await Webhooks.PostApiWebhookAddAsync(Constants.Client, Constants.Kind, url, eventName)
                                         .ConfigureAwait(false);
        }

        [Test]
        public async Task PostApiWebhookDel()
        {
            string eventName = "new_comment";

            var success = await Webhooks.PostApiWebhookDelAsync(Constants.Client, Constants.Kind, eventName)
                                        .ConfigureAwait(false);
        }
    }
}

#endif
