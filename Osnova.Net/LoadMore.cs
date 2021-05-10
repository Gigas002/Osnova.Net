using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Osnova.Net
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
        /// TODO: probably Uri, not string
        /// </summary>
        [JsonPropertyName("avatars")]
        public IEnumerable<string> Avatars { get; set; }
    }
}