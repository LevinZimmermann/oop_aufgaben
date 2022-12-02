using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenovoApiLibrary
{
    public class Warranty
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("startDate")]
        public DateTime Start { get; set; }

        [JsonProperty("endDate")]
        public DateTime End { get; set; }

        [JsonProperty("type")]
        public string Typ { get; set; }
    }
}
