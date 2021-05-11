using System.Net.Http;
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

#if LOCALTESTS

        [Test]
        public async Task PostAuthLogin()
        {
            string login = null;
            string password = null;

            using var client = new HttpClient(); // don't use client with token specified already!

            var token = await Authentication.PostAuthLoginGetTokenAsync(client, Kind, login, password);
        }

#endif
    }
}
