using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OctoCook.Data.API.Spoonacular
{
    internal class SpoonRecipeDetails
    {
        public int id { get; set; }
        public SpoonIngredient[] extendedIngredients { get; set; }
        public string title { get; set; }
        public int readyInMinutes { get; set; }
        public int servings { get; set; }
        public string sourceUrl { get; set; }
        public string image { get; set; }
        public string imageType { get; set; }
        public string summary { get; set; }
        public string instructions { get; set; }
    }
}

