using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Osnova.Net.Responses
{
    public class LoadMore
    {
        /// <summary>
        /// Список id комментариев для подгрузки
        /// </summary>
        [JsonPropertyName("ids")]
        public IEnumerable<long> Ids { get; set; }

        /// <summary>
        /// Количество подгружаемых комментариев
        /// </summary>
        [JsonPropertyName("count")]
        public int Count { get; set; }

        /// <summary>
        /// Список аватарок пользователей в подгружаемых комментариях
        /// </summary>
        [JsonPropertyName("avatars")]
        public IEnumerable<string> Avatars { get; set; }
    }
}