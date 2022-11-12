using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OctoCook.Data.API.Spoonacular
{
    public class SpoonRecipe
    {
        [JsonProperty("id")]
        public int id { get; set; }
        [JsonProperty("title")]
        public string title { get; set; }
        [JsonProperty("image")]
        public string image { get; set; }
        [JsonProperty("imageType")]
        public string imageType { get; set; }
    }
}
