using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OctoCook.Data.API.Spoonacular
{
    public class SpoonRecipe
    {
        public int id { get; set; }
        public string title { get; set; }
        public string image { get; set; }
        public string imageType { get; set; }
    }
}
