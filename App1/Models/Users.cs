using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Models
{
    class Users
    {
        public static Users[] ItemsSource { get; internal set; }
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }
}
