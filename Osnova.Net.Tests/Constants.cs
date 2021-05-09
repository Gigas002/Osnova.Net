using System.IO;
using System.Net.Http;

namespace Osnova.Net.Tests
{
    // TODO: rename this
    // TODO: IDisposable?
    public static class Constants
    {
        public static string SecretsPath { get; } = Path.Combine(new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent.Parent.Parent.Parent.FullName, "secrets.txt");

        private static bool IsClientCreated { get; set; }

        public static HttpClient Client { get; private set; }

        public static void CreateClient()
        {
            if (IsClientCreated) return;

            string token = null;

            // Requires you to add your api token in secrets.txt on repo's root
            if (File.Exists(SecretsPath))
            {
                token = File.ReadAllText(SecretsPath);
            }

            Client = Core.CreateDefaultClient(token);

            IsClientCreated = true;
        }
    }
}
