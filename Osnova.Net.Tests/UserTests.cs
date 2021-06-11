using System.Text.Json;
using System.Threading.Tasks;
using NUnit.Framework;
using Osnova.Net.Users;

namespace Osnova.Net.Tests
{
    public class UserTests
    {
        [SetUp]
        public void Setup() => Helper.InitializeHelper();

        [Test]
        public async Task GetUser()
        {
            var user = await User.GetUserAsync(Helper.Client, Helper.Kind, Helper.UserId).ConfigureAwait(false);

            if (user.Undeserialized != null) throw new JsonException("Undeserialized is not empty");

            var json = JsonSerializer.Serialize(user, Core.Options);
        }

        [Test]
        public async Task GetUserMe()
        {
            if (Helper.Secrets == null) return;

            var user = await User.GetMeAsync(Helper.Client, Helper.Kind).ConfigureAwait(false);

            if (user.Undeserialized != null) throw new JsonException("Undeserialized is not empty");

            var json = JsonSerializer.Serialize(user, Core.Options);
        }

        [Test]
        public async Task GetUserMeUpdates()
        {
            if (Helper.Secrets == null) return;

            var notifications = await User.GetMyUpdatesAsync(Helper.Client, Helper.Kind).ConfigureAwait(false);

            foreach (var value in notifications)
            {
                if (value.Undeserialized != null) throw new JsonException("Undeserialized is not empty");
            }

            var json = JsonSerializer.Serialize(notifications, Core.Options);
        }

        [Test]
        public async Task GetUserMeUpdatesCount()
        {
            if (Helper.Secrets == null) return;

            var counter = await User.GetMyUpdatesCountAsync(Helper.Client, Helper.Kind).ConfigureAwait(false);

            if (counter.Undeserialized != null) throw new JsonException("Undeserialized is not empty");

            var json = JsonSerializer.Serialize(counter, Core.Options);
        }

        [Test]
        public async Task GetUserComments()
        {
            var comments = await User.GetUserCommentsAsync(Helper.Client, Helper.Kind, Helper.UserId).ConfigureAwait(false);

            foreach (var value in comments)
            {
                if (value.Undeserialized != null) throw new JsonException("Undeserialized is not empty");
            }

            var json = JsonSerializer.Serialize(comments, Core.Options);
        }

        [Test]
        public async Task GetUserMeComments()
        {
            if (Helper.Secrets == null) return;

            var comments = await User.GetMyCommentsAsync(Helper.Client, Helper.Kind).ConfigureAwait(false);

            foreach (var value in comments)
            {
                if (value.Undeserialized != null) throw new JsonException("Undeserialized is not empty");
            }

            var json = JsonSerializer.Serialize(comments, Core.Options);
        }

        [Test]
        public async Task GetUserEntries()
        {
            var entries = await User.GetUserEntriesAsync(Helper.Client, Helper.Kind, Helper.UserId).ConfigureAwait(false);

            foreach (var value in entries)
            {
                if (value.Undeserialized != null) throw new JsonException("Undeserialized is not empty");
            }

            var json = JsonSerializer.Serialize(entries, Core.Options);
        }

        [Test]
        public async Task GetUserMeEntries()
        {
            if (Helper.Secrets == null) return;

            var entries = await User.GetMyEntriesAsync(Helper.Client, Helper.Kind).ConfigureAwait(false);

            foreach (var value in entries)
            {
                if (value.Undeserialized != null) throw new JsonException("Undeserialized is not empty");
            }

            var json = JsonSerializer.Serialize(entries, Core.Options);
        }

        [Test]
        public async Task GetUserFavoritesEntries()
        {
            if (Helper.Secrets == null) return;

            var entries = await User.GetUserFavoriteEntriesAsync(Helper.Client, Helper.Kind, Helper.UserId)
                          .ConfigureAwait(false);

            foreach (var value in entries)
            {
                if (value.Undeserialized != null) throw new JsonException("Undeserialized is not empty");
            }

            var json = JsonSerializer.Serialize(entries, Core.Options);
        }

        [Test]
        public async Task GetUserFavoritesComments()
        {
            if (Helper.Secrets == null) return;

            var comments = await User.GetUserFavoriteCommentsAsync(Helper.Client, Helper.Kind, Helper.UserId)
                          .ConfigureAwait(false);

            foreach (var value in comments)
            {
                if (value.Undeserialized != null) throw new JsonException("Undeserialized is not empty");
            }

            var json = JsonSerializer.Serialize(comments, Core.Options);
        }

        [Test]
        public async Task GetUserFavoritesVacancies()
        {
            if (Helper.Secrets == null) return;

            var vacancies = await User.GetUserFavoriteVacanciesAsync(Helper.Client, Helper.Kind, Helper.UserId)
                          .ConfigureAwait(false);

            foreach (var value in vacancies)
            {
                if (value.Undeserialized != null) throw new JsonException("Undeserialized is not empty");
            }

            var json = JsonSerializer.Serialize(vacancies, Core.Options);
        }

        [Test]
        public async Task GetUserMeFavoritesEntries()
        {
            if (Helper.Secrets == null) return;

            var entries = await User.GetMyFavoriteEntriesAsync(Helper.Client, Helper.Kind).ConfigureAwait(false);

            foreach (var value in entries)
            {
                if (value.Undeserialized != null) throw new JsonException("Undeserialized is not empty");
            }

            var json = JsonSerializer.Serialize(entries, Core.Options);
        }

        [Test]
        public async Task GetUserMeFavoritesComments()
        {
            if (Helper.Secrets == null) return;

            var comments = await User.GetMyFavoriteCommentsAsync(Helper.Client, Helper.Kind).ConfigureAwait(false);

            foreach (var value in comments)
            {
                if (value.Undeserialized != null) throw new JsonException("Undeserialized is not empty");
            }

            var json = JsonSerializer.Serialize(comments, Core.Options);
        }

        [Test]
        public async Task GetUserMeFavoritesVacancies()
        {
            if (Helper.Secrets == null) return;

            var vacancies = await User.GetMyFavoriteVacanciesAsync(Helper.Client, Helper.Kind).ConfigureAwait(false);

            foreach (var value in vacancies)
            {
                if (value.Undeserialized != null) throw new JsonException("Undeserialized is not empty");
            }

            var json = JsonSerializer.Serialize(vacancies, Core.Options);
        }

        [Test]
        public async Task GetUserMeSubscriptionsRecommended()
        {
            if (Helper.Secrets == null) return;

            var users = await User.GetMyRecommendedSubscriptionsAsync(Helper.Client, Helper.Kind).ConfigureAwait(false);

            foreach (var value in users)
            {
                if (value.Undeserialized != null) throw new JsonException("Undeserialized is not empty");
            }

            var json = JsonSerializer.Serialize(users, Core.Options);
        }

        [Test]
        public async Task GetUserMeSubscriptionsSubscribed()
        {
            if (Helper.Secrets == null) return;

            var users = await User.GetMySubscriptionsSubscribedAsync(Helper.Client, Helper.Kind).ConfigureAwait(false);

            foreach (var value in users)
            {
                if (value.Undeserialized != null) throw new JsonException("Undeserialized is not empty");
            }

            var json = JsonSerializer.Serialize(users, Core.Options);
        }

        [Test]
        public async Task GetUserMeTuneCatalog()
        {
            if (Helper.Secrets == null) return;

            var users = await User.GetMyTuneCatalogAsync(Helper.Client, Helper.Kind).ConfigureAwait(false);

            foreach (var value in users)
            {
                if (value.Undeserialized != null) throw new JsonException("Undeserialized is not empty");
            }

            var json = JsonSerializer.Serialize(users, Core.Options);
        }

        [Test]
        public async Task GetIgnoredKeywords()
        {
            if (Helper.Secrets == null) return;

            var keywords = await User.GetIgnoredKeywordsAsync(Helper.Client, Helper.Kind).ConfigureAwait(false);

            if (keywords.Undeserialized != null) throw new JsonException("Undeserialized is not empty");

            var json = JsonSerializer.Serialize(keywords, Core.Options);
        }
    }
}
