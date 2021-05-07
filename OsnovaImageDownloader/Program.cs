using System;
using System.Diagnostics;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Osnova.Net;
using Osnova.Net.Responses;
using Osnova.Net.Responses.Blocks;

namespace OsnovaImageDownloader
{
    internal static class Program
    {
        private static Arguments Args { get; set; } = new Arguments();

        private static WebsiteKind Kind { get; set; } = WebsiteKind.Dtf;

        private static bool IsParsingErrors { get; set; }

        private static async Task Main(string[] args)
        {
            //Parser.Default.ParseArguments<Arguments>(args).WithParsed(ParseArguments).WithNotParsed(_ => IsParsingErrors = true);

            //if (IsParsingErrors) return;

            Args.EntryId = 671347;
            Args.OutPath = "D:/Downloads/test";

            // Stopwatch for diagnostics
            Stopwatch stopwatch = Stopwatch.StartNew();

            var progress = new Progress<double>(Console.WriteLine);
            using HttpClient client = new HttpClient();
            //await core.DownloadAllEntryImages(Args.EntryId, Args.OutPath, progress).ConfigureAwait(false);

            var entryJson = await Entry.GetEntryJsonById(client, Kind, 725050);
            var options = new JsonSerializerOptions
            {
                Converters = { new BlockConverter() },
            };
            var roundTrip = JsonSerializer.Deserialize<OsnovaResponse<Entry>>(entryJson, options);

            //var entry = await Entry.GetEntryById(client, Kind, 725050);

            //foreach (Block block in entry.Blocks)
            //{
            //    block.ParsedData = block.GetBlockData();
            //}

            //List<MediaData> items = entry.Blocks.ToArray()[6].GetItems();

            var user = await User.GetUser(client, Kind, 260955);

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
    }
}
