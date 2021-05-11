using System;
using NUnit.Framework;

namespace Osnova.Net.Tests
{
    public class EntryTests
    {
        [SetUp]
        public void Setup() => Constants.CreateClient();

        [Test]
        public void GetEntry() => Assert.DoesNotThrowAsync(async () => _ = await Entry.GetEntryByIdAsync(Constants.Client, Constants.Kind, Constants.EntryId).ConfigureAwait(false));

        [Test]
        public void GetPopularEntries() => Assert.DoesNotThrowAsync(async () => _ = await Entry.GetPopularEntriesAsync(Constants.Client, Constants.Kind, Constants.EntryId).ConfigureAwait(false));

        [Test]
        public void GetEntryLocate() => Assert.DoesNotThrowAsync(async () =>
        {
            Uri entryUri = new($"https://dtf.ru/{Constants.EntryId}");

            _ = await Entry.GetEntryLocateAsync(Constants.Client, Constants.Kind, entryUri).ConfigureAwait(false);
        });
    }
}