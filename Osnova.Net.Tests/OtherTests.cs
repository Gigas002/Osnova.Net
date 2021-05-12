using System;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Osnova.Net.Tests
{
    public class OtherTests
    {
        [SetUp]
        public void Setup() => Constants.CreateClient();

        [Test]
        public async Task GetLocate()
        {
            var entryBlock = await Other.GetLocateAsync(Constants.Client, Constants.Kind, new Uri($"https://dtf.ru/{Constants.EntryId}"));
            var userBlock = await Other.GetLocateAsync(Constants.Client, Constants.Kind, new Uri($"https://dtf.ru/u/{Constants.UserId}"));
        }
    }
}
