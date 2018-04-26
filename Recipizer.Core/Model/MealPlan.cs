using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Recipizer.Core.Model
{
    public class MealPlan
    {
        public List<MealDay> Days;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Note { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; }

        public MealPlan()
        {

        }
    }
}