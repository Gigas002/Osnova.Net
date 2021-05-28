using System;
using System.Text.Json;
using System.Threading.Tasks;
using NUnit.Framework;
using Osnova.Net.Entries;

namespace Osnova.Net.Tests
{
    public class EntryTests
    {
        [SetUp]
        public void Setup() => Helper.InitializeHelper();

        [Test]
        public async Task GetEntry()
        {
            var entry = await Entry.GetEntryAsync(Helper.Client, Helper.Kind, Helper.EntryId)
                                   .ConfigureAwait(false);

            if (entry.Undeserialized != null) throw new JsonException("Undeserialized is not empty");

            var json = JsonSerializer.Serialize(entry, Core.Options);
        }

        [Test]
        public async Task GetPopularEntries()
        {
            var entries = await Entry.GetPopularEntriesAsync(Helper.Client, Helper.Kind, Helper.EntryId).ConfigureAwait(false);

            foreach (var entry in entries)
            {
                if (entry.Undeserialized != null) throw new JsonException("Undeserialized is not empty");
            }

            var json = JsonSerializer.Serialize(entries, Core.Options);
        }

        [Test]
        public async Task GetEntryLocate()
        {
            Uri entryUri = new($"https://dtf.ru/{Helper.EntryId}");

            var entry = await Entry.GetEntryLocateAsync(Helper.Client, Helper.Kind, entryUri).ConfigureAwait(false);

            if (entry.Undeserialized != null) throw new JsonException("Undeserialized is not empty");

            var json = JsonSerializer.Serialize(entry, Core.Options);
        }

        //[Test]
        //public async Task PostEntryCreate()
        //{
        //    const int id = 130721;

        //    string filePath1 = "D:/Downloads/test.jpg";
        //    string filePath2 = "D:/Downloads/test2.jpg";

        //    List<byte[]> files = new()
        //    {
        //        await File.ReadAllBytesAsync(filePath1), await File.ReadAllBytesAsync(filePath2)
        //    };

        //    // Upload images to ochoba and get ImageBlocks in response:
        //    var imageBlocks = await Upload.PostUploaderUploadAsync(Helper.Client,
        //                                    Helper.Kind, files).ConfigureAwait(false);

        //    // Create collection of Blocks for Entry
        //    var entryBlocks = new List<Block>();

        //    // Since we can load images to ochoba only using MediaBlock, let's create one:
        //    var mediaBlock = new MediaBlock(new MediaBlockData
        //    {
        //        Items = imageBlocks.Select(block => new MediaItemBlock {Image = block})
        //    });

        //    // Add ready MediaBlock to the collection of Blocks
        //    entryBlocks.Add(mediaBlock);

        //    // Create an entry and add some blocks:
        //    Entry postEntry = new("Awesome entry!", entryBlocks);

        //    // We can post now:
        //    var readyEntry = await Entry.PostEntryCreateAsync(Helper.Client, Helper.Kind, id, postEntry);
        //}
    }
}