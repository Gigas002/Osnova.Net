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

            //// ��������� �������� �� �����, �������� ������� ����� image � ������:
            //var imageBlocks = await Upload.PostUploaderUploadAsync(Constants.Client, Constants.Kind, files).ConfigureAwait(false);

            //// ������ ������ ������ ��� entry:
            //var entryBlocks = new List<Block>();

            //// �������� � ����� ������� ����� ������ � media-�����, ��� ��� ������� �����:
            //var mediaBlock = new Block
            //{
            //    Type = "media",
            //    // ��������� � ������ �����-����� ������ ����� ������� ������:
            //    Data = new MediaBlockData
            //    {
            //        Items = imageBlocks.Select(block => new MediaItemBlock { Image = block })
            //    }
            //};

            //// ��������� ������� �����-���� � ������ ������ �����:
            //entryBlocks.Add(mediaBlock);

            //// ������ ���� � ��������� ��� �����:
            //Entry postEntry = new Entry
            //{
            //    Title = "����������� ����!",
            //    Blocks = entryBlocks
            //};

            //// ����� �������!
            //var readyEntry = await Entry.PostEntryCreateAsync(Constants.Client, Constants.Kind, id, postEntry);
        }
    }
}