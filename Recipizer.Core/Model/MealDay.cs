using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Recipizer.Core.Model
{
    public class MealDay
    {
        public List<String> meals { get; set; }
        public List<Recipe> recipes { get; set; }
        public String note { get; set; }
        public int dayID { get; set; }
    }
}