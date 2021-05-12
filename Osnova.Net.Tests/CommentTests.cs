using System;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Osnova.Net.Tests
{
    public class CommentTests
    {
        [SetUp]
        public void Setup() => Constants.CreateClient();

        [Test]
        public async Task GetEntryComments()
        {
            var comments = await Comment.GetEntryCommentsAsync(Constants.Client, Constants.Kind, Constants.EntryId);
        }

        [Test]
        public async Task GetEntryCommentsLevels()
        {
            var levels = await Comment.GetEntryCommentsLevelsAsync(Constants.Client, Constants.Kind, Constants.EntryId);
        }

        [Test]
        public async Task GetEntryCommentsThread()
        {
            var threads = await Comment.GetEntryCommentsThreadAsync(Constants.Client, Constants.Kind, Constants.EntryId, 10518559);
        }

        [Test]
        public async Task GetCommentLikers()
        {
            var likers = await Comment.GetCommentLikersAsync(Constants.Client, Constants.Kind, 10518559);
        }

        [Test]
        public async Task GetEntryWidgets()
        {
            var widgets = await Comment.GetEntryWidgetsAsync(Constants.Client, Constants.Kind, Constants.EntryId);
        }
    }
}
