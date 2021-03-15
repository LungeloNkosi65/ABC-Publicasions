using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ABC_Publicasions.Models
{
    public class GenericMap
    {
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("content")]
        public List<string> content { get; set; }
        [JsonProperty("navigation")]
        public List<Navigation> Navigation { get; set; }
    }
}