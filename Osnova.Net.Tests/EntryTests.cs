using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using NUnit.Framework;
using Osnova.Net.BlockDatas;
using Osnova.Net.Blocks;

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

        #if LOCALTESTS

        //[Test]
        public async Task PostEntryCreate()
        {
            long id = 130721;

            string filePath1 = "D:/Downloads/test.jpg";
            string filePath2 = "D:/Downloads/test2.jpg";

            List<byte[]> files = new();
            files.Add(await File.ReadAllBytesAsync(filePath1));
            files.Add(await File.ReadAllBytesAsync(filePath2));

            // Загружаем картинки на очобу, получаем рабочие блоки image в ответе:
            var imageBlocks = await Upload.PostUploaderUploadAsync(Constants.Client, Constants.Kind, files).ConfigureAwait(false);

            // Делаем список блоков для entry:
            var entryBlocks = new List<Block>();

            // Картинки в очобу грузить можно только в media-блоки, так что создаем новый:
            var mediaBlock = new Block
            {
                Type = "media",
                // Добавляем в данные медиа-блока список наших готовых блоков:
                Data = new MediaBlockData
                {
                    Items = imageBlocks.Select(block => new MediaItemBlock { Image = block })
                }
            };

            // Добавляем готовый медиа-блок к списку блоков поста:
            entryBlocks.Add(mediaBlock);

            // Делаем пост и добавляем ему блоки:
            Entry postEntry = new Entry
            {
                Title = "Охуительный пост!",
                Blocks = entryBlocks
            };

            // Можем постить!
            var readyEntry = await Entry.PostEntryCreateAsync(Constants.Client, Constants.Kind, id, postEntry);
        }

        #endif
    }
}