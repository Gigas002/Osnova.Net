using System.Text.Json;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Osnova.Net.Tests
{
    public class QuizTests
    {
        [SetUp]
        public void Setup() => Helper.InitializeHelper();

        [Test]
        public async Task GetQuizResults()
        {
            var results = await Quiz.Quiz.GetQuizResultsAsync(Helper.Client, Helper.Kind, "35488bb5d1695283").ConfigureAwait(false);

            if (results.Undeserialized != null) throw new JsonException("Undeserialized is not empty");

            var json = JsonSerializer.Serialize(results, Core.Options);
        }
    }
}
