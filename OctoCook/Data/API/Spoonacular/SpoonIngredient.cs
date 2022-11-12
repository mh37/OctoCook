using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OctoCook.Data.API.Spoonacular
{
    internal class SpoonIngredient
    {
        public int id { get; set; }
        public string name { get; set; }
        public float amount { get; set; }
        public string unit { get; set; }
    }
}
