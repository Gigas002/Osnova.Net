using System.Threading.Tasks;
using NUnit.Framework;

namespace Osnova.Net.Tests
{
    public class WidgetsTests
    {
        [SetUp]
        public void Setup() => Constants.CreateClient();

        [Test]
        public async Task GetUserPushTopic()
        {
            var rates = await Widget.GetRatesAsync(Constants.Client, Constants.Kind).ConfigureAwait(false);
        }
    }
}
