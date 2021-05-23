using System.Text.Json;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Osnova.Net.Tests
{
    public class VacancyTests
    {
        [SetUp]
        public void Setup() => Helper.InitializeHelper();

        [Test]
        public async Task GetJobs()
        {
            var jobs = await Vacancy.GetJobsAsync(Helper.Client, Helper.Kind).ConfigureAwait(false);

            foreach (var value in jobs)
            {
                if (value.Undeserialized != null) throw new JsonException("Undeserialized is not empty");
            }

            var json = JsonSerializer.Serialize(jobs, Core.Options);
        }

        [Test]
        public async Task GetJobsMore()
        {
            var jobs = await Vacancy.GetJobsMoreAsync(Helper.Client, Helper.Kind).ConfigureAwait(false);

            foreach (var value in jobs)
            {
                if (value.Undeserialized != null) throw new JsonException("Undeserialized is not empty");
            }

            var json = JsonSerializer.Serialize(jobs, Core.Options);
        }

        [Test]
        public async Task GetJobFilters()
        {
            var filters = await Vacancy.GetJobFiltersAsync(Helper.Client, Helper.Kind).ConfigureAwait(false);

            if (filters.Undeserialized != null) throw new JsonException("Undeserialized is not empty");

            var json = JsonSerializer.Serialize(filters, Core.Options);
        }

        [Test]
        public async Task GetVacancies()
        {
            var vacancies = await Vacancy.GetVacanciesAsync(Helper.Client, Helper.Kind).ConfigureAwait(false);

            foreach (var value in vacancies)
            {
                if (value.Undeserialized != null) throw new JsonException("Undeserialized is not empty");
            }

            var json = JsonSerializer.Serialize(vacancies, Core.Options);
        }
    }
}
