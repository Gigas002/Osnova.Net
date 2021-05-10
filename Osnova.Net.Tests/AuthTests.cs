using System.Threading.Tasks;
using NUnit.Framework;
using Osnova.Net.Enums;

namespace Osnova.Net.Tests
{
    public class AuthTests
    {
        private WebsiteKind Kind { get; } = WebsiteKind.Dtf;

        [SetUp]
        public void Setup()
        {
            Constants.CreateClient();
        }

        //[Test]
        public async Task PostAuthLogin()
        {
            string login = null;
            string password = null;

            var user = await Authentication.PostAuthLoginGetUserAsync(Constants.Client, Kind, login, password);
        }
    }
}
