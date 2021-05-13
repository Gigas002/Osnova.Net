﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Osnova.Net
{
    public class Contacts
    {
        [JsonPropertyName("socials")]
        public IEnumerable<SocialAccount> Socials { get; set; }

        [JsonPropertyName("site")]
        public object Site { get; set; } // TODO: ПРИВЕТ УЕБАН КОТОРЫЙ И СЮДА ПУСТОЙ МАССИВ ЗАПИХНУЛ!

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("contacts")]
        public string UserContacts { get; set; }
    }
}