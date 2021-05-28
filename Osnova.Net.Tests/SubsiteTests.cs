using System.Text.Json;
using System.Threading.Tasks;
using NUnit.Framework;
using Osnova.Net.Users;

namespace Osnova.Net.Tests
{
    public class SubsiteTests
    {
        [SetUp]
        public void Setup() => Helper.InitializeHelper();

        [Test]
        public async Task GetSubsite()
        {
            var subsite = await Subsite.GetSubsiteAsync(Helper.Client, Helper.Kind, Constants.DtfSubsiteIds.Weaboo).ConfigureAwait(false);

            if (subsite.Undeserialized != null) throw new JsonException("Undeserialized is not empty");

            var json = JsonSerializer.Serialize(subsite, Core.Options);
        }

        [Test]
        public async Task GetSubsiteTimeline()
        {
            var entries = await Subsite.GetSubsiteTimelineAsync(Helper.Client, Helper.Kind, Constants.DtfSubsiteIds.Weaboo).ConfigureAwait(false);

            foreach (var value in entries)
            {
                if (value.Undeserialized != null) throw new JsonException("Undeserialized is not empty");
            }

            var json = JsonSerializer.Serialize(entries, Core.Options);
        }

        [Test]
        public async Task GetSubsitesList()
        {
            var subsites = await Subsite.GetSubsitesListAsync(Helper.Client, Helper.Kind).ConfigureAwait(false);

            foreach (var value in subsites)
            {
                if (value.Undeserialized != null) throw new JsonException("Undeserialized is not empty");
            }

            var json = JsonSerializer.Serialize(subsites, Core.Options);
        }

        [Test]
        public async Task GetSubsiteVacancies()
        {
            var vacancies = await Subsite.GetSubsiteVacanciesAsync(Helper.Client, Helper.Kind, 75184).ConfigureAwait(false);

            foreach (var value in vacancies)
            {
                if (value.Undeserialized != null) throw new JsonException("Undeserialized is not empty");
            }

            var json = JsonSerializer.Serialize(vacancies, Core.Options);
        }

        [Test]
        public async Task GetSubsiteVacanciesMore()
        {
            var vacancies = await Subsite.GetSubsiteVacanciesMoreAsync(Helper.Client, Helper.Kind, 75184).ConfigureAwait(false);

            foreach (var value in vacancies)
            {
                if (value.Undeserialized != null) throw new JsonException("Undeserialized is not empty");
            }

            var json = JsonSerializer.Serialize(vacancies, Core.Options);
        }

        [Test]
        public async Task GetSubsiteSubscribe()
        {
            if (Helper.Secrets == null) return;

            var isSubscribed = await Subsite.GetSubsiteSubscribeAsync(Helper.Client, Helper.Kind, Constants.DtfSubsiteIds.Weaboo).ConfigureAwait(false);
        }

        [Test]
        public async Task GetSubsiteUnsubscribe()
        {
            if (Helper.Secrets == null) return;

            var isUnsubscribed = await Subsite.GetSubsiteUnsubscribeAsync(Helper.Client, Helper.Kind, Constants.DtfSubsiteIds.Weaboo).ConfigureAwait(false);
        }
    }
}
