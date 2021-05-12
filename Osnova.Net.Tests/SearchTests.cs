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
    }
}
