using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Models
{
    public class Names
    {
        public static Names[] ItemsSource { get; internal set; }

        [JsonProperty("name")]
        public string Name { get; set; }

    }
}
