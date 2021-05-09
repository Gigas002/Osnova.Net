using NUnit.Framework;
using Osnova.Net.Responses;

namespace Osnova.Net.Tests
{
    public class UserTests
    {
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
                WebsiteKind kind = WebsiteKind.Dtf;

                var user = await User.GetUserAsync(Constants.Client, kind, 260955);
            });
        }

        [Test]
        public void GetUserMe()
        {
            // TODO: throws only on CI, because there are no api key
            Assert.ThrowsAsync<InvalidResponseCodeException>(async () =>
            {
                WebsiteKind kind = WebsiteKind.Dtf;

                var user = await User.GetUserMeAsync(Constants.Client, kind);
            });
        }
    }
}
