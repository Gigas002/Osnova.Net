using System;
using System.Threading.Tasks;
using NUnit.Framework;
using Osnova.Net.Enums;

namespace Osnova.Net.Tests
{
    public class EntryTests
    {
        private static WebsiteKind Kind => WebsiteKind.Dtf;

        [SetUp]
        public void Setup()
        {
            Constants.CreateClient();
        }

        [Test]
        public void GetEntry()
        {
            Assert.DoesNotThrowAsync(async () =>
            {
                var entry = await Entry.GetEntryByIdAsync(Constants.Client, Kind, 725050);
            });
        }

        [Test]
        public void GetPopularEntries()
        {
            Assert.DoesNotThrowAsync(async () =>
            {
                var entries = await Entry.GetPopularEntriesAsync(Constants.Client, Kind, 725050);
            });
        }

        [Test]
        public void GetEntryLocate()
        {
            Assert.DoesNotThrowAsync(async () =>
            {
                Uri entryUri = new Uri("https://dtf.ru/725050");

                var entry = await Entry.GetEntryLocateAsync(Constants.Client, Kind, entryUri);
            });
        }

#if LOCALTESTS

        [Test]
        public async Task LocalTest()
        {
            var entry = await Entry.GetEntryByIdAsync(Constants.Client, Kind, 725050);
        }

#endif
    }
}