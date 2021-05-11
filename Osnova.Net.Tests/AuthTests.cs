using System.Net.Http;
using System.Threading.Tasks;
using NUnit.Framework;
using Osnova.Net.Enums;

namespace Osnova.Net.Tests
{
    public class AuthTests
    {
        private static WebsiteKind Kind => WebsiteKind.Dtf;

        [SetUp]
        public void Setup()
        {
            // TODO: init client without token
            //Constants.CreateClient();
        }

#if LOCALTESTS

        [Test]
        public async Task PostAuthQr()
        {
            // TODO: requires testing
            string qrToken = null;

            using var client = new HttpClient(); // don't use client with token specified already!

            var token = await Authentication.PostAuthQrGetTokenAsync(client, Kind, qrToken);
        }

        [Test]
        public async Task PostAuthSocial()
        {
            // TODO: requires testing

            var socialType = SocialType.GooglePlus;
            string loginToken = null;
            string email = null;

            using var client = new HttpClient(); // don't use client with token specified already!

            var token = await Authentication.PostAuthSocialGetTokenAsync(client, Kind, socialType, loginToken, email);
        }

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
