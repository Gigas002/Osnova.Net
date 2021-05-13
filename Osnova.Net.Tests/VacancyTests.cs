using System.Threading.Tasks;
using NUnit.Framework;

namespace Osnova.Net.Tests
{
    public class VacancyTests
    {
        [SetUp]
        public void Setup() => Constants.CreateClient();

        [Test]
        public async Task GetJobs()
        {
            var jobs = await Vacancy.GetJobsAsync(Constants.Client, Constants.Kind).ConfigureAwait(false);
        }

        [Test]
        public async Task GetJobsMore()
        {
            var jobs = await Vacancy.GetJobsMoreAsync(Constants.Client, Constants.Kind).ConfigureAwait(false);
        }

        [Test]
        public async Task GetJobFilters()
        {
            var filters = await Vacancy.GetJobFiltersAsync(Constants.Client, Constants.Kind).ConfigureAwait(false);
        }

        [Test]
        public async Task GetVacancies()
        {
            var vacancies = await Vacancy.GetVacanciesAsync(Constants.Client, Constants.Kind).ConfigureAwait(false);
        }
    }
}
