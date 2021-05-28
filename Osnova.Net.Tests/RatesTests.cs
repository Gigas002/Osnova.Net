using System.Text.Json;
using System.Threading.Tasks;
using NUnit.Framework;
using Osnova.Net.Rates;

namespace Osnova.Net.Tests
{
    public class RatesTests
    {
        [SetUp]
        public void Setup() => Helper.InitializeHelper();

        [Test]
        public async Task GetRates()
        {
            var rates = await Rate.GetRatesAsync(Helper.Client, Helper.Kind).ConfigureAwait(false);

            var json = JsonSerializer.Serialize(rates, Core.Options);
        }
    }
}
