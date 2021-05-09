using System;
using System.Threading.Tasks;
using NUnit.Framework;
using Osnova.Net.Responses;

namespace Osnova.Net.Tests
{
    public class EntryTests
    {
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
                WebsiteKind kind = WebsiteKind.Dtf;

                var entry = await Entry.GetEntryByIdAsync(Constants.Client, kind, 725050);
            });
        }

        [Test]
        public void GetPopularEntries()
        {
            Assert.DoesNotThrowAsync(async () =>
            {
                WebsiteKind kind = WebsiteKind.Dtf;

                var entries = await Entry.GetPopularEntriesAsync(Constants.Client, kind, 725050);
            });
        }

        [Test]
        public void GetEntryLocate()
        {
            Assert.DoesNotThrowAsync(async () =>
            {
                WebsiteKind kind = WebsiteKind.Dtf;
                Uri entryUri = new Uri("https://dtf.ru/725050");

                var entry = await Entry.GetEntryLocateAsync(Constants.Client, kind, entryUri);
            });
        }

        //[Test]
        public async Task Temp()
        {
            WebsiteKind kind = WebsiteKind.Dtf;

            var entry = await Entry.GetEntryByIdAsync(Constants.Client, kind, 725050);
        }
    }
}