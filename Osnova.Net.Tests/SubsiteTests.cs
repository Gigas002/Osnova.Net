using System.Threading.Tasks;
using NUnit.Framework;

namespace Osnova.Net.Tests
{
    public class SubsiteTests
    {
        [SetUp]
        public void Setup() => Constants.CreateClient();

        [Test]
        public async Task GetSubsite()
        {
            var subsite = await Subsite.GetSubsiteAsync(Constants.Client, Constants.Kind, 261696).ConfigureAwait(false);
        }

        [Test]
        public async Task GetSubsiteTimeline()
        {
            var entries = await Subsite.GetSubsiteTimelineAsync(Constants.Client, Constants.Kind, 261696).ConfigureAwait(false);
        }
    }
}
