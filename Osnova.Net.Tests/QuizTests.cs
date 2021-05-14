using System.Threading.Tasks;
using NUnit.Framework;

namespace Osnova.Net.Tests
{
    public class QuizTests
    {
        [SetUp]
        public void Setup() => Constants.CreateClient();

        [Test]
        public async Task GetQuizResults()
        {
            var results = await Quiz.GetQuizResultsAsync(Constants.Client, Constants.Kind, "35488bb5d1695283").ConfigureAwait(false);
        }
    }
}
