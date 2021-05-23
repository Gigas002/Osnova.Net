using System.Text.Json;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Osnova.Net.Tests
{
    public class BlacklistTests
    {
        [SetUp]
        public void Setup() => Helper.InitializeHelper();

        [Test]
        public async Task GetIgnoresHashtags()
        {
            if (Helper.Secrets == null) return;

            var tags = await Blacklist.GetIgnoresHashtagsAsync(Helper.Client, Helper.Kind).ConfigureAwait(false);

            foreach (var tag in tags)
            {
                if (tag.Undeserialized != null) throw new JsonException("Undeserialized is not empty");
            }

            var json = JsonSerializer.Serialize(tags, Core.Options);
        }

        [Test]
        public async Task GetIgnoresSubsites()
        {
            if (Helper.Secrets == null) return;

            var users = await Blacklist.GetIgnoresSubsitesAsync(Helper.Client, Helper.Kind).ConfigureAwait(false);

            foreach (var user in users)
            {
                if (user.Undeserialized != null) throw new JsonException("Undeserialized is not empty");
            }

            var json = JsonSerializer.Serialize(users, Core.Options);
        }
    }
}
