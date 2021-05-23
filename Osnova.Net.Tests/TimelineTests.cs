using System.Text.Json;
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
        public void Setup() => Helper.InitializeHelper();

        [Test]
        public async Task GetTimeline()
        {
            var entries = await Timeline.GetTimelineAsync(Helper.Client, Helper.Kind, Category, Sorting).ConfigureAwait(false);

            foreach (var value in entries)
            {
                if (value.Undeserialized != null) throw new JsonException("Undeserialized is not empty");
            }

            var json = JsonSerializer.Serialize(entries, Core.Options);
        }

        [Test]
        public async Task GetTimelineByHashtag()
        {
            var entries = await Timeline.GetTimelineByHashtagAsync(Helper.Client, Helper.Kind, "yurucamp", Category, Sorting)
                              .ConfigureAwait(false);

            foreach (var value in entries)
            {
                if (value.Undeserialized != null) throw new JsonException("Undeserialized is not empty");
            }

            var json = JsonSerializer.Serialize(entries, Core.Options);
        }

        [Test]
        public async Task GetTimelineNews()
        {
            var entries = await Timeline.GetTimelineNewsAsync(Helper.Client, Helper.Kind, Sorting).ConfigureAwait(false);

            foreach (var value in entries)
            {
                if (value.Undeserialized != null) throw new JsonException("Undeserialized is not empty");
            }

            var json = JsonSerializer.Serialize(entries, Core.Options);
        }

        [Test]
        public async Task GetFlashHolder()
        {
            var entries = await Timeline.GetFlashHolderAsync(Helper.Client, Helper.Kind).ConfigureAwait(false);

            foreach (var value in entries)
            {
                if (value.Undeserialized != null) throw new JsonException("Undeserialized is not empty");
            }

            var json = JsonSerializer.Serialize(entries, Core.Options);
        }
    }
}
