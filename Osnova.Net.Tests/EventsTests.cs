using System.Text.Json;
using System.Threading.Tasks;
using NUnit.Framework;
using Osnova.Net.Enums;
using Osnova.Net.OsnovaEvents;

namespace Osnova.Net.Tests
{
    public class OsnovaEventsTests
    {
        [SetUp]
        public void Setup() => Helper.InitializeHelper();

        [Test]
        public async Task GetEventsFilters()
        {
            var filters = await OsnovaEvent.GetEventsFiltersAsync(Helper.Client, Helper.Kind).ConfigureAwait(false);
            
            var json = JsonSerializer.Serialize(filters, Core.Options);
        }

        [Test]
        public async Task GetEvents()
        {
            var events = await OsnovaEvent.GetEventsAsync(Helper.Client, WebsiteKind.Vc).ConfigureAwait(false);

            foreach (var value in events)
            {
                if (value.Undeserialized != null) throw new JsonException("Undeserialized is not empty");
            }

            var json = JsonSerializer.Serialize(events, Core.Options);
        }

        [Test]
        public async Task GetMoreEvents()
        {
            var events = await OsnovaEvent.GetMoreEventsAsync(Helper.Client, WebsiteKind.Vc).ConfigureAwait(false);

            foreach (var value in events)
            {
                if (value.Undeserialized != null) throw new JsonException("Undeserialized is not empty");
            }

            var json = JsonSerializer.Serialize(events, Core.Options);
        }
    }
}
