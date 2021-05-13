using System.Threading.Tasks;
using NUnit.Framework;

namespace Osnova.Net.Tests
{
    public class SubsiteTests
    {
        [SetUp]
        public void Setup() => Constants.CreateClient();

        [Test]
        public async Task GetSubsite()
        {
            var subsite = await Subsite.GetSubsiteAsync(Constants.Client, Constants.Kind, 261696).ConfigureAwait(false);
        }

        [Test]
        public async Task GetSubsiteTimeline()
        {
            var entries = await Subsite.GetSubsiteTimelineAsync(Constants.Client, Constants.Kind, 261696).ConfigureAwait(false);
        }

        [Test]
        public async Task GetSubsitesList()
        {
            var subsites = await Subsite.GetSubsitesListAsync(Constants.Client, Constants.Kind).ConfigureAwait(false);
        }

        [Test]
        public async Task GetSubsiteVacancies()
        {
            var vacancies = await Subsite.GetSubsiteVacanciesAsync(Constants.Client, Constants.Kind, 75184).ConfigureAwait(false);
        }

        [Test]
        public async Task GetSubsiteVacanciesMore()
        {
            var vacancies = await Subsite.GetSubsiteVacanciesMoreAsync(Constants.Client, Constants.Kind, 75184).ConfigureAwait(false);
        }

        #if LOCALTESTS

        [Test]
        public async Task GetSubsiteSubscribe()
        {
            var isSubscribed = await Subsite.GetSubsiteSubscribeAsync(Constants.Client, Constants.Kind, 261696).ConfigureAwait(false);
        }

        [Test]
        public async Task GetSubsiteUnsubscribe()
        {
            var isUnsubscribed = await Subsite.GetSubsiteUnsubscribeAsync(Constants.Client, Constants.Kind, 261696).ConfigureAwait(false);
        }

        #endif
    }
}
