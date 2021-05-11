using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Osnova.Net.Enums;

namespace Osnova.Net.Tests
{
    public class TimelineTests
    {
        private static WebsiteKind Kind => WebsiteKind.Dtf;

        [SetUp]
        public void Setup()
        {
            Constants.CreateClient();
        }

        #if LOCALTESTS

        [Test]
        public async Task GetTimeline()
        {
            var category = TimelineCategory.MainPage;
            var sorting = TimelineSorting.Recent;

            var entries = await Timeline.GetTimelineAsync(Constants.Client, Kind, category, sorting);
        }

        #endif
    }
}
