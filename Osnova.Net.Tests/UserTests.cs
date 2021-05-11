using System.Threading.Tasks;
using NUnit.Framework;

#if !LOCALTESTS
using Osnova.Net.Exceptions;
#endif

namespace Osnova.Net.Tests
{
    public class UserTests
    {
        [SetUp]
        public void Setup() => Constants.CreateClient();

        [Test]
        public void GetUser() =>
            Assert.DoesNotThrowAsync(async () => _ = await User.GetUserAsync(Constants.Client, Constants.Kind, Constants.UserId)
                                                               .ConfigureAwait(false));

        #if LOCALTESTS
        [Test]
        public async Task GetUserMe() =>
            _ = await User.GetUserMeAsync(Constants.Client, Constants.Kind).ConfigureAwait(false);
        #else
        [Test]
        public void GetUserMe() => Assert.ThrowsAsync<InvalidResponseCodeException>(async () => _ =
 await User.GetUserMeAsync(Constants.Client, Constants.Kind).ConfigureAwait(false));
        #endif

        #if LOCALTESTS
        [Test]
        public async Task GetUserMeUpdates() =>
            _ = await User.GetUserMeUpdatesAsync(Constants.Client, Constants.Kind).ConfigureAwait(false);
        #else
        [Test]
        public void GetUserMeUpdates() => Assert.ThrowsAsync<InvalidResponseCodeException>(async () => _ =
 await User.GetUserMeUpdatesAsync(Constants.Client, Constants.Kind)
           .ConfigureAwait(false));
        #endif

        #if LOCALTESTS
        [Test]
        public async Task GetUserMeUpdatesCount() =>
            _ = await User.GetUserMeUpdatesCountAsync(Constants.Client, Constants.Kind).ConfigureAwait(false);
        #else
        [Test]
        public void GetUserMeUpdatesCount() => Assert.ThrowsAsync<InvalidResponseCodeException>(async () => _ =
 await User.GetUserMeUpdatesCountAsync(Constants.Client, Constants.Kind).ConfigureAwait(false));
        #endif

        [Test]
        public async Task GetUserComments() =>
            _ = await User.GetUserCommentsAsync(Constants.Client, Constants.Kind, Constants.UserId)
                          .ConfigureAwait(false);

        #if LOCALTESTS
        [Test]
        public async Task GetUserMeComments() =>
            _ = await User.GetUserMeCommentsAsync(Constants.Client, Constants.Kind).ConfigureAwait(false);
        #else
        [Test]
        public void GetUserMeComments() => Assert.ThrowsAsync<InvalidResponseCodeException>(async () => _ =
 await User.GetUserMeCommentsAsync(Constants.Client, Constants.Kind).ConfigureAwait(false));
        #endif

        [Test]
        public async Task GetUserEntries() =>
            _ = await User.GetUserEntriesAsync(Constants.Client, Constants.Kind, Constants.UserId)
                          .ConfigureAwait(false);

        #if LOCALTESTS
        [Test]
        public async Task GetUserMeEntries() =>
            _ = await User.GetUserMeEntriesAsync(Constants.Client, Constants.Kind).ConfigureAwait(false);
        #else
        [Test]
        public void GetUserMeEntries() => Assert.ThrowsAsync<InvalidResponseCodeException>(async () => _ =
 await User.GetUserMeEntriesAsync(Constants.Client, Constants.Kind).ConfigureAwait(false));
        #endif

        #if LOCALTESTS
        [Test]
        public async Task GetUserFavoritesEntries() =>
            _ = await User.GetUserFavoritesEntriesAsync(Constants.Client, Constants.Kind, Constants.UserId)
                          .ConfigureAwait(false);
        #else
        [Test]
        public void GetUserFavoritesEntries() => Assert.ThrowsAsync<InvalidResponseCodeException>(async () => _ =
 await User.GetUserFavoritesEntriesAsync(Constants.Client, Constants.Kind, Constants.UserId)
           .ConfigureAwait(false));
        #endif

        #if LOCALTESTS
        [Test]
        public async Task GetUserFavoritesComments() =>
            _ = await User.GetUserFavoritesCommentsAsync(Constants.Client, Constants.Kind, Constants.UserId)
                          .ConfigureAwait(false);
        #else
        [Test]
        public void GetUserFavoritesComments() => Assert.ThrowsAsync<InvalidResponseCodeException>(async () => _ =
 await User.GetUserFavoritesCommentsAsync(Constants.Client, Constants.Kind, Constants.UserId)
           .ConfigureAwait(false));
        #endif

        #if LOCALTESTS
        [Test]
        public async Task GetUserFavoritesVacancies() =>
            _ = await User.GetUserFavoritesVacanciesAsync(Constants.Client, Constants.Kind, Constants.UserId)
                          .ConfigureAwait(false);
        #else
        [Test]
        public void GetUserFavoritesVacancies() => Assert.ThrowsAsync<InvalidResponseCodeException>(async () => _ =
 await User.GetUserFavoritesVacanciesAsync(Constants.Client, Constants.Kind, Constants.UserId)
           .ConfigureAwait(false));

        #endif

        #if LOCALTESTS
        [Test]
        public async Task GetUserMeFavoritesEntries() =>
            _ = await User.GetUserMeFavoritesEntriesAsync(Constants.Client, Constants.Kind).ConfigureAwait(false);
        #else
        [Test]
        public void GetUserMeFavoritesEntries() => Assert.ThrowsAsync<InvalidResponseCodeException>(async () => _ =
 await User.GetUserMeFavoritesEntriesAsync(Constants.Client, Constants.Kind)
           .ConfigureAwait(false));
        #endif

        #if LOCALTESTS
        [Test]
        public async Task GetUserMeFavoritesComments() =>
            _ = await User.GetUserMeFavoritesCommentsAsync(Constants.Client, Constants.Kind).ConfigureAwait(false);
        #else
        [Test]
        public void GetUserMeFavoritesComments() => Assert.ThrowsAsync<InvalidResponseCodeException>(async () => _ =
 await User.GetUserMeFavoritesCommentsAsync(Constants.Client, Constants.Kind)
           .ConfigureAwait(false));
        #endif

        #if LOCALTESTS
        [Test]
        public async Task GetUserMeFavoritesVacancies() =>
            _ = await User.GetUserMeFavoritesVacanciesAsync(Constants.Client, Constants.Kind).ConfigureAwait(false);
        #else
        [Test]
        public void GetUserMeFavoritesVacancies() => Assert.ThrowsAsync<InvalidResponseCodeException>(async () => _ =
 await User.GetUserMeFavoritesVacanciesAsync(Constants.Client, Constants.Kind)
           .ConfigureAwait(false));
        #endif

        [Test]
        public async Task GetUserMeSubscriptionsRecommended() =>
            _ = await User.GetUserMeSubscriptionsRecommendedAsync(Constants.Client, Constants.Kind)
                          .ConfigureAwait(false);

        [Test]
        public async Task GetUserMeSubscriptionsSubscribed() =>
            _ = await User.GetUserMeSubscriptionsSubscribedAsync(Constants.Client, Constants.Kind)
                          .ConfigureAwait(false);

        [Test]
        public async Task GetUserMeTuneCatalog() =>
            _ = await User.GetUserMeTuneCatalogAsync(Constants.Client, Constants.Kind).ConfigureAwait(false);

        #if LOCALTESTS
        [Test]
        public async Task GetIgnoredKeywords() =>
            _ = await User.GetIgnoredKeywordsAsync(Constants.Client, Constants.Kind).ConfigureAwait(false);
        #else
        [Test]
        public void GetIgnoredKeywords() => Assert.ThrowsAsync<InvalidResponseCodeException>(async () => _ =
 await User.GetIgnoredKeywordsAsync(Constants.Client, Constants.Kind).ConfigureAwait(false));
        #endif
    }
}
