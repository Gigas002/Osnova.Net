using System.Threading.Tasks;
using NUnit.Framework;
using Osnova.Net.Enums;

namespace Osnova.Net.Tests
{
    public class UserTests
    {
        private WebsiteKind Kind { get; } = WebsiteKind.Dtf;

        [SetUp]
        public void Setup()
        {
            Constants.CreateClient();
        }

        [Test]
        public void GetUser()
        {
            Assert.DoesNotThrowAsync(async () =>
            {
                var user = await User.GetUserAsync(Constants.Client, Kind, 260955);
            });
        }


        [Test]
        public void GetUserMe()
        {
            #if LOCALTESTS
            Assert.DoesNotThrowAsync(async () =>
            {
                var user = await User.GetUserMeAsync(Constants.Client, Kind);
            });
            #else
            Assert.ThrowsAsync<InvalidResponseCodeException>(async () =>
            {
                var user = await User.GetUserMeAsync(Constants.Client, Kind);
            });
            #endif
        }

        [Test]
        public void GetUserMeUpdates()
        {
            #if LOCALTESTS
            Assert.DoesNotThrowAsync(async () =>
            {
                var notifications = await User.GetUserMeUpdatesAsync(Constants.Client, Kind);
            });
            #else
            Assert.ThrowsAsync<InvalidResponseCodeException>(async () =>
            {
                var notifications = await User.GetUserMeUpdatesAsync(Constants.Client, Kind);
            });
            #endif
        }

        [Test]
        public void GetUserMeUpdatesCount()
        {
            #if LOCALTESTS
            Assert.DoesNotThrowAsync(async () =>
            {
                var count = await User.GetUserMeUpdatesCountAsync(Constants.Client, Kind);
            });
            #else
            Assert.ThrowsAsync<InvalidResponseCodeException>(async () =>
            {
                var notifications = await User.GetUserMeUpdatesCountAsync(Constants.Client, Kind);
            });
            #endif
        }

        [Test]
        public void GetUserComments()
        {
            Assert.DoesNotThrowAsync(async () =>
            {
                var comments = await User.GetUserCommentsAsync(Constants.Client, Kind, 339033);
            });
        }

#if LOCALTESTS

        [Test]
        public async Task GetUserMeComments()
        {
            var comments = await User.GetUserMeCommentsAsync(Constants.Client, Kind);
        }

        [Test]
        public async Task GetUserEntries()
        {
            var entries = await User.GetUserEntriesAsync(Constants.Client, Kind, 339033);
        }

        [Test]
        public async Task GetUserMeEntries()
        {
            var entries = await User.GetUserMeEntriesAsync(Constants.Client, Kind);
        }

        [Test]
        public async Task GetUserFavoritesEntries()
        {
            var entries = await User.GetUserFavoritesEntriesAsync(Constants.Client, Kind, 260955);
        }

        [Test]
        public async Task GetUserFavoritesComments()
        {
            var comments = await User.GetUserFavoritesCommentsAsync(Constants.Client, Kind, 260955);
        }

        [Test]
        public async Task GetUserFavoritesVacancies()
        {
            var vacancies = await User.GetUserFavoritesVacanciesAsync(Constants.Client, Kind, 260955);
        }

#endif
    }
}
