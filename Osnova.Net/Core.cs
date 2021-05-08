using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Osnova.Net.Responses;
using Osnova.Net.Responses.BlockDatas;
using Osnova.Net.Responses.Blocks;

#pragma warning disable 1591

namespace Osnova.Net
{
    public static class Core
    {
        #region Constants

        public const string BaseDtfUriString = "https://api.dtf.ru";
        public const string BaseTjournalUriString = "https://api.tjournal.ru";
        public const string BaseVcUriString = "https://api.vc.ru";
        public const string BaseLeonardoUriString = "https://leonardo.osnova.io";

        public const double ApiVersion = 1.9;

        #endregion

        public static JsonSerializerOptions Options { get; } = new()
        {
            Converters =
            {
                new BlockConverter(),
                //new ImageBlockDataConverter()
            }
        };

        #region Methods

        public static HttpClient CreateDefaultClient(string authenticationToken = null)
        {
            HttpClient client = new();

            if (!string.IsNullOrWhiteSpace(authenticationToken)) client.DefaultRequestHeaders.Add("X-Device-Token", authenticationToken);

            client.DefaultRequestHeaders.UserAgent.Add(new("osnova-net-app", "1.0.0"));
            client.DefaultRequestHeaders.UserAgent.Add(new("(PC; Windows 10; ru; 1920x1080)"));
            client.DefaultRequestVersion = HttpVersion.Version20;

            return client;
        }

        public static Uri GetBaseUri(WebsiteKind websiteKind, double apiVersion)
        {
            string invariantVersion = apiVersion.ToString(CultureInfo.InvariantCulture);

            var baseString = websiteKind switch
            {
                WebsiteKind.Dtf => BaseDtfUriString,
                WebsiteKind.Tjournal => BaseTjournalUriString,
                WebsiteKind.Vc => BaseVcUriString,
                _ => throw new NotImplementedException()
            };

            return new Uri($"{baseString}/v{invariantVersion}");
        }

        public static async ValueTask DownloadAllEntryImages(HttpClient client, WebsiteKind websiteKind,
                                                             int entryId, string outputPath,
                                                             double apiVersion = ApiVersion,
                                                             IProgress<double> progress = null)
        {
            Directory.CreateDirectory(outputPath);

            var entry = await Entry.GetEntryById(client, websiteKind, entryId, apiVersion).ConfigureAwait(false);

            var mediaItems = new List<MediaItemBlock>();

            foreach (var block in entry.Blocks.Where(block => block.Type == "media"))
            {
                mediaItems.AddRange(((MediaBlockData)block.Data).Items);
            }

            double counter = 0.0;

            foreach (var image in mediaItems)
            {
                var imageData = (ImageBlockData)image.Image.Data;

                var guid = imageData.Uuid.ToString();
                var extension = imageData.Type;
                var itemUri = new Uri($"{BaseLeonardoUriString}/{guid}");

                var bytes = await client.GetByteArrayAsync(itemUri).ConfigureAwait(false);
                await File.WriteAllBytesAsync(Path.Combine(outputPath, $"{guid}.{extension}"), bytes).ConfigureAwait(false);

                // Report progress
                counter++;
                double percentage = counter / mediaItems.Count * 100.0;
                progress?.Report(percentage);
            }
        }

        #endregion
    }
}
