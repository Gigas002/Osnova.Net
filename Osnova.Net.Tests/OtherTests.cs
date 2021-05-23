using System;
using System.Text.Json;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Osnova.Net.Tests
{
    public class OtherTests
    {
        [SetUp]
        public void Setup() => Helper.InitializeHelper();

        [Test]
        public async Task GetLocate()
        {
            var entryBlock = await Other.GetLocateAsync(Helper.Client, Helper.Kind, new Uri($"https://dtf.ru/{Helper.EntryId}"));

            if (entryBlock.Undeserialized != null) throw new JsonException("Undeserialized is not empty");

            var json = JsonSerializer.Serialize(entryBlock, Core.Options);

            var userBlock = await Other.GetLocateAsync(Helper.Client, Helper.Kind, new Uri($"https://dtf.ru/u/{Helper.UserId}"));

            if (userBlock.Undeserialized != null) throw new JsonException("Undeserialized is not empty");

            json = JsonSerializer.Serialize(userBlock, Core.Options);
        }
    }
}
