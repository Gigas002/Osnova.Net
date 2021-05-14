using System;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Osnova.Net.Tests
{
    public class EntryTests
    {
        [SetUp]
        public void Setup() => Constants.CreateClient();

        [Test]
        public async Task GetEntry()
        {
            var entry = await Entry.GetEntryByIdAsync(Constants.Client, Constants.Kind, Constants.EntryId)
                                   .ConfigureAwait(false);
        }

        [Test]
        public async Task GetPopularEntries() => _ = await Entry.GetPopularEntriesAsync(Constants.Client, Constants.Kind, Constants.EntryId)
                                                                .ConfigureAwait(false);

        [Test]
        public void GetEntryLocate() => Assert.DoesNotThrowAsync(async () =>
        {
            Uri entryUri = new($"https://dtf.ru/{Constants.EntryId}");

            _ = await Entry.GetEntryLocateAsync(Constants.Client, Constants.Kind, entryUri).ConfigureAwait(false);
        });

        // TODO: doesn't work yet
        //[Test]
        //public async Task PostEntryCreate()
        //{
        //    long id = 130721;

        //    //var entry = await Entry.GetEntryByIdAsync(Constants.Client, Constants.Kind, Constants.EntryId);
        //    var entry = new Entry();
        //    entry.Title = "Говномешалка!!!";

        //    string filePath1 = "D:/Downloads/test.jpg";
        //    string filePath2 = "D:/Downloads/test2.jpg";

        //    List<byte[]> files = new();
        //    files.Add(await File.ReadAllBytesAsync(filePath1));
        //    files.Add(await File.ReadAllBytesAsync(filePath2));

        //    var imageBlocks = await Upload.PostUploaderUploadAsync(Constants.Client, Constants.Kind, files).ConfigureAwait(false);

        //    entry.Blocks = imageBlocks;

        //    var smthng = await Entry.PostEntryCreateResponseAsync(Constants.Client, Constants.Kind, id, entry);
        //    var json = await smthng.Content.ReadAsStringAsync();
        //}
    }
}