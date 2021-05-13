#if LOCALTESTS

using System.Threading.Tasks;
using NUnit.Framework;

namespace Osnova.Net.Tests
{
    public class BlacklistTests
    {
        [SetUp]
        public void Setup() => Constants.CreateClient();

        [Test]
        public async Task GetIgnoresHashtags()
        {
            var tags = await Blacklist.GetIgnoresHashtagsAsync(Constants.Client, Constants.Kind).ConfigureAwait(false);
        }
    }
}

#endif
