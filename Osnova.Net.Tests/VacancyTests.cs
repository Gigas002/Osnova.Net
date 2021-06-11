using System.Text.Json;
using System.Threading.Tasks;
using NUnit.Framework;
using Osnova.Net.Vacancies;

namespace Osnova.Net.Tests
{
    public class VacancyTests
    {
        [SetUp]
        public void Setup() => Helper.InitializeHelper();

        [Test]
        public async Task GetJobs()
        {
            var jobs = await Vacancy.GetVacanciesAsync(Helper.Client, Helper.Kind).ConfigureAwait(false);

            foreach (var value in jobs)
            {
                if (value.Undeserialized != null) throw new JsonException("Undeserialized is not empty");
            }

            var json = JsonSerializer.Serialize(jobs, Core.Options);
        }

        [Test]
        public async Task GetJobsMore()
        {
            var jobs = await Vacancy.GetMoreVacanciesAsync(Helper.Client, Helper.Kind).ConfigureAwait(false);

            foreach (var value in jobs)
            {
                if (value.Undeserialized != null) throw new JsonException("Undeserialized is not empty");
            }

            var json = JsonSerializer.Serialize(jobs, Core.Options);
        }

        [Test]
        public async Task GetJobFilters()
        {
            var filters = await Vacancy.GetVacancyFiltersAsync(Helper.Client, Helper.Kind).ConfigureAwait(false);
            
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
