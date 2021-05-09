using System.Threading.Tasks;
using NUnit.Framework;
using Osnova.Net.Responses;

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
        public async Task GetUserComments()
        {
            #if LOCALTESTS
            Assert.DoesNotThrowAsync(async () =>
            {
                var comments = await User.GetUserCommentsAsync(Constants.Client, Kind, 339033);
            });
            #else
            Assert.ThrowsAsync<InvalidResponseCodeException>(async () =>
            {
                var comments = await User.GetUserCommentsAsync(Constants.Client, Kind, 339033);
            });
            #endif
        }
    }
}
