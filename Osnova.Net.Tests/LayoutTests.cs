using System.Text.Json;
using System.Threading.Tasks;
using NUnit.Framework;
using Osnova.Net.Entries;

namespace Osnova.Net.Tests
{
    public class LayoutTests
    {
        [SetUp]
        public void Setup() => Helper.InitializeHelper();

        [Test]
        public async Task GetLayout()
        {
           var layout = await EntryLayout.GetLayoutAsync(Helper.Client, Helper.Kind, Core.ApiVersion)
                                 .ConfigureAwait(false);

           if (layout.Undeserialized != null) throw new JsonException("Undeserialized is not empty");

           var json = JsonSerializer.Serialize(layout, Core.Options);
        }

        [Test]
        public async Task GetLayoutHashtag()
        {
            var layout = await EntryLayout.GetLayoutHashtagAsync(Helper.Client, Helper.Kind, "yurucamp")
                                         .ConfigureAwait(false);

            if (layout.Undeserialized != null) throw new JsonException("Undeserialized is not empty");

            var json = JsonSerializer.Serialize(layout, Core.Options);
        }
    }
}
