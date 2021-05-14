using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Osnova.Net.Tests
{
    public class EventsTests
    {
        [SetUp]
        public void Setup() => Constants.CreateClient();

        [Test]
        public async Task GetEventsFilters()
        {
            var filters = await Events.GetEventsFiltersAsync(Constants.Client, Constants.Kind).ConfigureAwait(false);
        }
    }
}
