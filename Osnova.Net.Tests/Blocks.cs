using System.Net.Http;
using System.Threading.Tasks;
using NUnit.Framework;
using Osnova.Net.Responses;

namespace Osnova.Net.Tests
{
    public class Blocks
    {
        public HttpClient Client { get; } = new HttpClient();

        [SetUp]
        public void Setup() { }

        [Test]
        public void GetUser()
        {
            Assert.DoesNotThrowAsync(async () =>
            {
                WebsiteKind kind = WebsiteKind.Dtf;

                var user = await User.GetUser(Client, kind, 260955);
            });
        }

        [Test]
        public void GetEntry()
        {
            Assert.DoesNotThrowAsync(async () =>
            {
                WebsiteKind kind = WebsiteKind.Dtf;

                var entry = await Entry.GetEntryById(Client, kind, 725050);
            });
        }

        //[Test]
        public async Task Temp()
        {
            WebsiteKind kind = WebsiteKind.Dtf;

            var entry = await Entry.GetEntryById(Client, kind, 725050);
        }
    }
}