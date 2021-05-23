using System.Threading.Tasks;
using NUnit.Framework;

namespace Osnova.Net.Tests
{
    public class PaymentsTests
    {
        [SetUp]
        public void Setup() => Helper.InitializeHelper();

        [Test]
        public async Task GetUserPushTopic()
        {
            if (Helper.Secrets == null) return;

            // Throws InvalidResponseCodeException
            var topic = await Payments.GetPaymentsCheckAsync(Helper.Client, Helper.Kind).ConfigureAwait(false);
        }
    }
}
