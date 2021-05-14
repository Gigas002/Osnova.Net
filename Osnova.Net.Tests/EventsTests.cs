using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Osnova.Net.Enums;

namespace Osnova.Net.Tests
{
    public class EventsTests
    {
        [SetUp]
        public void Setup() => Constants.CreateClient();

        [Test]
        public async Task GetEventsFilters()
        {
            var filters = await Event.GetEventsFiltersAsync(Constants.Client, Constants.Kind).ConfigureAwait(false);
        }

        [Test]
        public async Task GetEvents()
        {
            var events = await Event.GetEventsAsync(Constants.Client, WebsiteKind.Vc).ConfigureAwait(false);
        }

        [Test]
        public async Task GetEventsMore()
        {
            int lastId = 0;

            var events = await Event.GetEventsMoreAsync(Constants.Client, WebsiteKind.Vc, lastId).ConfigureAwait(false);
        }
    }
}
