using System;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using CommandLine;
using Osnova.Net;

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
            using HttpClient client = new HttpClient();
            await Core.DownloadAllEntryImages(client, Kind, Args.EntryId, Args.OutPath, progress: progress).ConfigureAwait(false);

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
