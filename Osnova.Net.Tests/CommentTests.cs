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
    }
}
