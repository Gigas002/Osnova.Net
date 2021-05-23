﻿using System.Text.Json;
using System.Threading.Tasks;
using NUnit.Framework;
using Osnova.Net.Enums;

namespace Osnova.Net.Tests
{
    public class EventsTests
    {
        [SetUp]
        public void Setup() => Helper.InitializeHelper();

        [Test]
        public async Task GetEventsFilters()
        {
            var filters = await Event.GetEventsFiltersAsync(Helper.Client, Helper.Kind).ConfigureAwait(false);

            if (filters.Undeserialized != null) throw new JsonException("Undeserialized is not empty");

            var json = JsonSerializer.Serialize(filters, Core.Options);
        }

        [Test]
        public async Task GetEvents()
        {
            var events = await Event.GetEventsAsync(Helper.Client, WebsiteKind.Vc).ConfigureAwait(false);

            foreach (var value in events)
            {
                if (value.Undeserialized != null) throw new JsonException("Undeserialized is not empty");
            }

            var json = JsonSerializer.Serialize(events, Core.Options);
        }

        [Test]
        public async Task GetEventsMore()
        {
            const int lastId = 0;

            var events = await Event.GetEventsMoreAsync(Helper.Client, WebsiteKind.Vc, lastId).ConfigureAwait(false);

            foreach (var value in events)
            {
                if (value.Undeserialized != null) throw new JsonException("Undeserialized is not empty");
            }

            var json = JsonSerializer.Serialize(events, Core.Options);
        }
    }
}
