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
           var layet = await EntryLayout.GetLayoutAsync(Constants.Client, Constants.Kind, Core.ApiVersion)
                                 .ConfigureAwait(false);
        }
    }
}
