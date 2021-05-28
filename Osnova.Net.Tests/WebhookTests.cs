using System;
using System.Text.Json;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Osnova.Net.Tests
{
    public class WebhookTests
    {
        [SetUp]
        public void Setup() => Helper.InitializeHelper();

        [Test]
        public async Task GetApiWebhooksGet()
        {
            if (Helper.Secrets == null) return;

            var watchers = await WebHooks.WebHooks.GetApiWebhooksGetAsync(Helper.Client, Helper.Kind).ConfigureAwait(false);

            foreach (var value in watchers)
            {
                if (value.Undeserialized != null) throw new JsonException("Undeserialized is not empty");
            }

            var json = JsonSerializer.Serialize(watchers, Core.Options);
        }

        [Test]
        public async Task PostApiWebhookAdd()
        {
            if (Helper.Secrets == null) return;

            Uri url = new Uri("https://dtf.ru/");
            string eventName = "new_comment";

            var watcher = await WebHooks.WebHooks.PostApiWebhookAddAsync(Helper.Client, Helper.Kind, url, eventName)
                                        .ConfigureAwait(false);

            if (watcher.Undeserialized != null) throw new JsonException("Undeserialized is not empty");

            var json = JsonSerializer.Serialize(watcher, Core.Options);
        }

        [Test]
        public async Task PostApiWebhookDel()
        {
            if (Helper.Secrets == null) return;

            string eventName = "new_comment";

            var success = await WebHooks.WebHooks.PostApiWebhookDelAsync(Helper.Client, Helper.Kind, eventName)
                                        .ConfigureAwait(false);
        }
    }
}
