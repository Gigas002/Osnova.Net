using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Osnova.Net.Responses
{
    public class Counter
    {
        [JsonPropertyName("count")]
        public long Count { get; set; }
    }
}
