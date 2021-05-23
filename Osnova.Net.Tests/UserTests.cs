using System.Text.Json;
using System.Threading.Tasks;
using NUnit.Framework;

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

            var user = await User.GetUserMeAsync(Helper.Client, Helper.Kind).ConfigureAwait(false);

            if (user.Undeserialized != null) throw new JsonException("Undeserialized is not empty");

            var json = JsonSerializer.Serialize(user, Core.Options);
        }

        [Test]
        public async Task GetUserMeUpdates()
        {
            if (Helper.Secrets == null) return;

            var notifications = await User.GetUserMeUpdatesAsync(Helper.Client, Helper.Kind).ConfigureAwait(false);

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

            var counter = await User.GetUserMeUpdatesCountAsync(Helper.Client, Helper.Kind).ConfigureAwait(false);

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

            var comments = await User.GetUserMeCommentsAsync(Helper.Client, Helper.Kind).ConfigureAwait(false);

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

            var entries = await User.GetUserMeEntriesAsync(Helper.Client, Helper.Kind).ConfigureAwait(false);

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

            var entries = await User.GetUserFavoritesEntriesAsync(Helper.Client, Helper.Kind, Helper.UserId)
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

            var comments = await User.GetUserFavoritesCommentsAsync(Helper.Client, Helper.Kind, Helper.UserId)
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

            var vacancies = await User.GetUserFavoritesVacanciesAsync(Helper.Client, Helper.Kind, Helper.UserId)
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

            var entries = await User.GetUserMeFavoritesEntriesAsync(Helper.Client, Helper.Kind).ConfigureAwait(false);

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

            var comments = await User.GetUserMeFavoritesCommentsAsync(Helper.Client, Helper.Kind).ConfigureAwait(false);

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

            var vacancies = await User.GetUserMeFavoritesVacanciesAsync(Helper.Client, Helper.Kind).ConfigureAwait(false);

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

            var users = await User.GetUserMeSubscriptionsRecommendedAsync(Helper.Client, Helper.Kind).ConfigureAwait(false);

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

            var users = await User.GetUserMeSubscriptionsSubscribedAsync(Helper.Client, Helper.Kind).ConfigureAwait(false);

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

            var users = await User.GetUserMeTuneCatalogAsync(Helper.Client, Helper.Kind).ConfigureAwait(false);

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
