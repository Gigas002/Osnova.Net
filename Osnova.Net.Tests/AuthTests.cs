using System.Net.Http;
using System.Threading.Tasks;
using NUnit.Framework;
using Osnova.Net.Enums;

namespace Osnova.Net.Tests
{
    public class AuthTests
    {
        #if LOCALTESTS

        private static HttpClient Client => new();

        [SetUp]
        public void Setup()
        {
            // TODO: init client without token
            //Constants.CreateClient();
        }

        [Test]
        public async Task PostAuthQr()
        {
            // TODO: requires testing
            string qrToken = null;

            _ = await Authentication.PostAuthQrGetTokenAsync(Client, Constants.Kind, qrToken).ConfigureAwait(false);
        }

        [Test]
        public async Task PostAuthSocial()
        {
            // TODO: requires testing

            var socialType = SocialType.GooglePlus;
            string loginToken = null;
            string email = null;

            _ = await Authentication.PostAuthSocialGetTokenAsync(Client, Constants.Kind, socialType, loginToken, email).ConfigureAwait(false);
        }

        [Test]
        public async Task PostAuthLogin()
        {
            string login = null;
            string password = null;

            _ = await Authentication.PostAuthLoginGetTokenAsync(Client, Constants.Kind, login, password).ConfigureAwait(false);
        }

        #endif
    }
}
