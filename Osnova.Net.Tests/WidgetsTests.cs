using System.Text.Json;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Osnova.Net.Tests
{
    public class WidgetsTests
    {
        [SetUp]
        public void Setup() => Helper.InitializeHelper();

        [Test]
        public async Task GetUserPushTopic()
        {
            var rates = await Widget.GetRatesAsync(Helper.Client, Helper.Kind).ConfigureAwait(false);

            foreach (var value in rates)
            {
                if (value.Value.Undeserialized != null) throw new JsonException("Undeserialized is not empty");
            }

            var json = JsonSerializer.Serialize(rates, Core.Options);
        }
    }
}
