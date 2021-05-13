using System.Threading.Tasks;
using NUnit.Framework;

namespace Osnova.Net.Tests
{
    public class LayoutTests
    {
        [SetUp]
        public void Setup() => Constants.CreateClient();

        [Test]
        public async Task GetLayout()
        {
           var layout = await EntryLayout.GetLayoutAsync(Constants.Client, Constants.Kind, Core.ApiVersion)
                                 .ConfigureAwait(false);
        }

        [Test]
        public async Task GetLayoutHashtag()
        {
            var layout = await EntryLayout.GetLayoutHashtagAsync(Constants.Client, Constants.Kind, "yurucamp")
                                         .ConfigureAwait(false);
        }
    }
}
