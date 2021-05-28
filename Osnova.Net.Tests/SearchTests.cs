using System.Text.Json;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Osnova.Net.Tests
{
    public class SearchTests
    {
        [SetUp]
        public void Setup() => Helper.InitializeHelper();

        [Test]
        public async Task GetSearch()
        {
            var entries = await Search.GetSearchAsync(Helper.Client, Helper.Kind, "yurucamp");

            foreach (var value in entries)
            {
                if (value.Undeserialized != null) throw new JsonException("Undeserialized is not empty");
            }

            var json = JsonSerializer.Serialize(entries, Core.Options);
        }

        [Test]
        public async Task GetSearchSubsite()
        {
            // TODO: weaboo?
            var users = await Search.GetSearchSubsiteAsync(Helper.Client, Helper.Kind, "yurucamp");

            foreach (var value in users)
            {
                if (value.Undeserialized != null) throw new JsonException("Undeserialized is not empty");
            }

            var json = JsonSerializer.Serialize(users, Core.Options);
        }

        [Test]
        public async Task GetSearchHashtag()
        {
            var hashtags = await Search.GetSearchHashtagAsync(Helper.Client, Helper.Kind, "yurucamp");

            foreach (var value in hashtags)
            {
                if (value.Undeserialized != null) throw new JsonException("Undeserialized is not empty");
            }

            var json = JsonSerializer.Serialize(hashtags, Core.Options);
        }

        [Test]
        public async Task GetTag()
        {
            var entries = await Search.GetTagAsync(Helper.Client, Helper.Kind, "yurucamp", 69308);

            foreach (var value in entries)
            {
                if (value.Undeserialized != null) throw new JsonException("Undeserialized is not empty");
            }

            var json = JsonSerializer.Serialize(entries, Core.Options);
        }
    }
}
