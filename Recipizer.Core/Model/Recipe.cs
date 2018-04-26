using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Recipizer.Core.Model
{
    public class Recipe
    {
        public List<Ingredient> ingredients;
        public string title { get; set; }
        public string description { get; set; }
        public string author { get; set; }
        public DateTime dateCreated { get; set; }
        public string note { get; set; }

        public Recipe()
        {

        }
    }
}