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
            var entry = await Entry.GetEntryByIdAsync(Helper.Client, Helper.Kind, Helper.EntryId)
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
        public async Task PostEntryCreate()
        {
            //long id = 130721;

            //string filePath1 = "D:/Downloads/test.jpg";
            //string filePath2 = "D:/Downloads/test2.jpg";

            //List<byte[]> files = new();
            //files.Add(await File.ReadAllBytesAsync(filePath1));
            //files.Add(await File.ReadAllBytesAsync(filePath2));

            //// Загружаем картинки на очобу, получаем рабочие блоки image в ответе:
            //var imageBlocks = await Upload.PostUploaderUploadAsync(Constants.Client, Constants.Kind, files).ConfigureAwait(false);

            //// Делаем список блоков для entry:
            //var entryBlocks = new List<Block>();

            //// Картинки в очобу грузить можно только в media-блоки, так что создаем новый:
            //var mediaBlock = new Block
            //{
            //    Type = "media",
            //    // Добавляем в данные медиа-блока список наших готовых блоков:
            //    Data = new MediaBlockData
            //    {
            //        Items = imageBlocks.Select(block => new MediaItemBlock { Image = block })
            //    }
            //};

            //// Добавляем готовый медиа-блок к списку блоков поста:
            //entryBlocks.Add(mediaBlock);

            //// Делаем пост и добавляем ему блоки:
            //Entry postEntry = new Entry
            //{
            //    Title = "Охуительный пост!",
            //    Blocks = entryBlocks
            //};

            //// Можем постить!
            //var readyEntry = await Entry.PostEntryCreateAsync(Constants.Client, Constants.Kind, id, postEntry);
        }
    }
}