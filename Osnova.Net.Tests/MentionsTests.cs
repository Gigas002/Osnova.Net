using System.Text.Json;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Osnova.Net.Tests
{
    public class MentionsTests
    {
        [SetUp]
        public void Setup() => Helper.InitializeHelper();

        [Test]
        public async Task GetSearchForMentions()
        {
            if (Helper.Secrets == null) return;

            var mentionedUsers = await Mentions.GetSearchForMentionsAsync(Helper.Client, Helper.Kind, "yurucamp").ConfigureAwait(false);

            foreach (var value in mentionedUsers)
            {
                if (value.Undeserialized != null) throw new JsonException("Undeserialized is not empty");
            }

            var json = JsonSerializer.Serialize(mentionedUsers, Core.Options);
        }

        [Test]
        public async Task GetEnableMentionNotifications()
        {
            if (Helper.Secrets == null) return;

            var isEnabled = await Mentions.GetEnableMentionNotificationsAsync(Helper.Client, Helper.Kind, 339033).ConfigureAwait(false);
        }

        [Test]
        public async Task GetDisableMentionNotifications()
        {
            if (Helper.Secrets == null) return;

            var isDisabled = await Mentions.GetDisableMentionNotificationsAsync(Helper.Client, Helper.Kind, 339033).ConfigureAwait(false);
        }
    }
}
