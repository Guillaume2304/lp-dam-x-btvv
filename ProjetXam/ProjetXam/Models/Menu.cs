using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetXam.Models
{
    public class Menu
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }
    }
}
