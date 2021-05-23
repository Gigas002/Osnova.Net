using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Osnova.Net.Tests
{
    public class UploadTests
    {
        [SetUp]
        public void Setup() => Helper.InitializeHelper();

        [Test]
        public async Task PostUploaderUpload()
        {
            // TODO: Add paths to secrets
            if (Helper.Secrets == null) return;

            string filePath1 = "D:/Downloads/test.jpg";
            string filePath2 = "D:/Downloads/test2.jpg";

            List<byte[]> files = new();
            files.Add(await File.ReadAllBytesAsync(filePath1));
            files.Add(await File.ReadAllBytesAsync(filePath2));

            var imageBlocks = await Upload.PostUploaderUploadAsync(Helper.Client, Helper.Kind, files).ConfigureAwait(false);
        }
    }
}
