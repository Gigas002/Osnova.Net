using System.Text.Json;
using System.Threading.Tasks;
using NUnit.Framework;
using Osnova.Net.Comments;

namespace Osnova.Net.Tests
{
    public class CommentTests
    {
        [SetUp]
        public void Setup() => Helper.InitializeHelper();

        [Test]
        public async Task GetEntryComments()
        {
            var comments = await Comment.GetEntryCommentsAsync(Helper.Client, Helper.Kind, 663573);

            foreach (var value in comments)
            {
                if (value.Undeserialized != null) throw new JsonException("Undeserialized is not empty");
            }

            var json = JsonSerializer.Serialize(comments, Core.Options);
        }

        [Test]
        public async Task GetEntryCommentsLevels()
        {
            var levels = await Comment.GetEntryCommentsThreadsAsync(Helper.Client, Helper.Kind, 663573);

            if (levels.Undeserialized != null) throw new JsonException("Undeserialized is not empty");

            var json = JsonSerializer.Serialize(levels, Core.Options);
        }

        [Test]
        public async Task GetEntryCommentsThread()
        {
            var threads = await Comment.GetEntryCommentThreadAsync(Helper.Client, Helper.Kind, Helper.EntryId, 10518559);

            if (threads.Undeserialized != null) throw new JsonException("Undeserialized is not empty");

            var json = JsonSerializer.Serialize(threads, Core.Options);
        }

        [Test]
        public async Task GetCommentLikers()
        {
            var likers = await Comment.GetCommentLikersAsync(Helper.Client, Helper.Kind, 10518559);

            foreach (var value in likers)
            {
                if (value.Value.Undeserialized != null) throw new JsonException("Undeserialized is not empty");
            }

            var json = JsonSerializer.Serialize(likers, Core.Options);
        }

        [Test]
        public async Task GetEntryWidgets()
        {
            var widgets = await Comment.GetPopularAsync(Helper.Client, Helper.Kind, Helper.EntryId);

            var json = JsonSerializer.Serialize(widgets, Core.Options);
        }
    }
}
