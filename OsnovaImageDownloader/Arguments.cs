using CommandLine;

namespace OsnovaImageDownloader
{
    public class Arguments
    {
        [Option('e', "entry-id", Required = true, HelpText = "Entry id")]
        public int EntryId { get; set; }

        [Option('o', "output", Required = true, HelpText = "Output directory path")]
        public string OutPath { get; set; }

        [Option('w', "website-kind", Required = false, HelpText = "Website kind (dtf, tjournal, vc)")]
        public string WebsiteKind { get; set; } = "dtf";
    }
}
