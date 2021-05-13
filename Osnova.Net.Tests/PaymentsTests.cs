#if LOCALTESTS

using System.Threading.Tasks;
using NUnit.Framework;

namespace Osnova.Net.Tests
{
    public class PaymentsTests
    {
        [SetUp]
        public void Setup() => Constants.CreateClient();

        [Test]
        public async Task GetUserPushTopic()
        {
            // Throws InvalidResponseCodeException
            var topic = await Payments.GetPaymentsCheckAsync(Constants.Client, Constants.Kind).ConfigureAwait(false);
        }
    }
}

#endif
