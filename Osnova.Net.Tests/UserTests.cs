using System.Threading.Tasks;
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
        public async Task GetUserMe()
        {
            WebsiteKind kind = WebsiteKind.Dtf;

            var user = await User.GetUserMeAsync(Constants.Client, kind);
        }
    }
}
