using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectXam.Models
{
    public class MenuJson

    {
        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("type")]
        public string type { get; set; }

        [JsonProperty("description")]
        public string description { get; set; }

        [JsonProperty("image")]
        public string image { get; set; }
    
    }
}
