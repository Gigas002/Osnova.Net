using System.Threading.Tasks;
using NUnit.Framework;
using Osnova.Net.Enums;

namespace Osnova.Net.Tests
{
    public class TimelineTests
    {
        private const TimelineCategory Category = TimelineCategory.MainPage;

        private const TimelineSorting Sorting = TimelineSorting.Recent;

        [SetUp]
        public void Setup() => Constants.CreateClient();

        [Test]
        public async Task GetTimeline() => _ = await Timeline.GetTimelineAsync(Constants.Client, Constants.Kind, Category, Sorting).ConfigureAwait(false);

        [Test]
        public async Task GetTimelineByHashtag() => _ = await Timeline.GetTimelineByHashtagAsync(Constants.Client, Constants.Kind, "yurucamp", Category, Sorting).ConfigureAwait(false);

        [Test]
        public async Task GetTimelineNews() => _ = await Timeline.GetTimelineNewsAsync(Constants.Client, Constants.Kind, Sorting).ConfigureAwait(false);

        [Test]
        public async Task GetFlashHolder() => _ = await Timeline.GetFlashHolderAsync(Constants.Client, Constants.Kind).ConfigureAwait(false);
    }
}
