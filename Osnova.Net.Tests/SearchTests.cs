using System.Threading.Tasks;
using NUnit.Framework;

namespace Osnova.Net.Tests
{
    public class SearchTests
    {
        [SetUp]
        public void Setup() => Constants.CreateClient();

        [Test]
        public async Task GetSearch()
        {
            var entries = await Search.GetSearchAsync(Constants.Client, Constants.Kind, "yurucamp");
        }

        [Test]
        public async Task GetSearchSubsite()
        {
            var users = await Search.GetSearchSubsiteAsync(Constants.Client, Constants.Kind, "yurucamp");
        }

        [Test]
        public async Task GetSearchHashtag()
        {
            var hashtags = await Search.GetSearchHashtagAsync(Constants.Client, Constants.Kind, "yurucamp");
        }

        [Test]
        public async Task GetTag()
        {
            var entries = await Search.GetTagAsync(Constants.Client, Constants.Kind, "yurucamp", 69308);
        }
    }
}
