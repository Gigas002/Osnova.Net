using System.Text.Json.Serialization;

namespace Osnova.Net.Tests
{
    public class Secrets
    {
        [JsonPropertyName("dtf_api_token")]
        public string DtfApiToken { get; set; }

        [JsonPropertyName("dtf_login")]
        public string DtfLogin { get; set; }

        [JsonPropertyName("dtf_password")]
        public string DtfPassword { get; set; }

        public string DtfQrToken { get; set; }
    }
}
