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
    }
}
