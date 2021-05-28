using System.IO;
using System.Net.Http;
#if LOCALTESTS
using System.Text.Json;
#endif
using Osnova.Net.Enums;

namespace Osnova.Net.Tests
{
    public static class Helper
    {
        private static string SecretsPath { get; } = Path.Combine(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.Parent.Parent.Parent.FullName, "secrets.json");

        public static HttpClient Client { get; private set; }

        public static Secrets Secrets { get; private set; }

        public const WebsiteKind Kind = WebsiteKind.Dtf;

        public const int UserId = 260955;

        public const int EntryId = 725050;

        public static void InitializeHelper()
        {
            if (Client != null) return;

            #if LOCALTESTS
            // Requires you to add your api token in secrets.json on repo's root
            if (File.Exists(SecretsPath))
            {
                Secrets = JsonSerializer.Deserialize<Secrets>(File.ReadAllText(SecretsPath));
            }
            #endif

            Client = Core.CreateDefaultClient(Secrets?.DtfApiToken);
        }
    }
}
