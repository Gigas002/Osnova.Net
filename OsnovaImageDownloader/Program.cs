using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using CommandLine;
using Osnova.Net;
using Osnova.Net.BlockDatas;
using Osnova.Net.Blocks;
using Osnova.Net.Entries;
using Osnova.Net.Enums;

namespace OsnovaImageDownloader
{
    internal static class Program
    {
        private static Arguments Args { get; set; } = new Arguments();

        private static WebsiteKind Kind { get; set; } = WebsiteKind.Dtf;

        private static bool IsParsingErrors { get; set; }

        private static async Task Main(string[] args)
        {
            Parser.Default.ParseArguments<Arguments>(args).WithParsed(ParseArguments).WithNotParsed(_ => IsParsingErrors = true);

            if (IsParsingErrors) return;

            // Stopwatch for diagnostics
            Stopwatch stopwatch = Stopwatch.StartNew();

            var progress = new Progress<double>(Console.WriteLine);
            using HttpClient client = Core.CreateDefaultClient();
            await DownloadAllEntryImages(client, Kind, Args.EntryId, Args.OutPath, progress: progress).ConfigureAwait(false);

            Console.WriteLine($"Done in: {stopwatch.ElapsedMilliseconds} ms");
        }

        private static void ParseArguments(Arguments parsedArgs)
        {
            Args = parsedArgs;
            Kind = Enum.Parse<WebsiteKind>(Args.WebsiteKind, true);

            //if (string.IsNullOrWhiteSpace(parsedArgs.OutPath))
            //{
            //    Args.OutPath = Path.Combine(AppContext.BaseDirectory, "downloads");
            //}
        }

        public static async ValueTask DownloadAllEntryImages(HttpClient client, WebsiteKind websiteKind,
                                                             int entryId, string outputPath,
                                                             double apiVersion = Core.ApiVersion,
                                                             IProgress<double> progress = null)
        {
            Directory.CreateDirectory(outputPath);

            var entry = await Entry.GetEntryAsync(client, websiteKind, entryId, apiVersion).ConfigureAwait(false);

            var imageDatas = new List<ImageBlockData>();

            foreach (MediaBlock block in entry.Blocks.Where(block => block is MediaBlock))
            {
                imageDatas.AddRange(block.GetImageDatas());
            }

            double counter = 0.0;

            foreach (var imageData in imageDatas)
            {
                var guid = imageData.Uuid;
                string extension = imageData.Extension.ToString().ToLowerInvariant();
                var itemUri = Core.GetMediaUri(guid);

                var bytes = await client.GetByteArrayAsync(itemUri).ConfigureAwait(false);
                await File.WriteAllBytesAsync(Path.Combine(outputPath, $"{guid}.{extension}"), bytes).ConfigureAwait(false);

                // Report progress
                counter++;
                double percentage = counter / imageDatas.Count * 100.0;
                progress?.Report(percentage);
            }
        }
    }
}
