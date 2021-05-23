using System.Net.Http;
using System.Threading.Tasks;
using NUnit.Framework;
using Osnova.Net.Enums;

namespace Osnova.Net.Tests
{
    public class AuthTests
    {
        private static HttpClient Client => Core.CreateDefaultClient();

        [SetUp]
        public void Setup() => Helper.InitializeHelper();

        [Test]
        public async Task PostAuthQr()
        {
            if (Helper.Secrets == null) return;

            string token = await Authentication.PostAuthQrGetTokenAsync(Client, Helper.Kind, Helper.Secrets.DtfQrToken).ConfigureAwait(false);
        }

        [Test]
        public async Task PostAuthSocial()
        {
            if (Helper.Secrets == null) return;

            var socialType = SocialType.GooglePlus;
            string loginToken = null;
            string email = null;

            string token = await Authentication.PostAuthSocialGetTokenAsync(Client, Helper.Kind, socialType, loginToken, email).ConfigureAwait(false);
        }

        [Test]
        public async Task PostAuthLogin()
        {
            if (Helper.Secrets == null) return;

            string token = await Authentication.PostAuthLoginGetTokenAsync(Client, Helper.Kind,
                           Helper.Secrets.DtfLogin, Helper.Secrets.DtfPassword).ConfigureAwait(false);
        }
    }
}
