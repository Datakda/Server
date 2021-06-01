using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Models
{
    public class RandomDouble
    {
        public double result { get; set; }


        public RandomDouble(MinMax minMax) 
        {
            Random random = new Random();
            result = random.NextDouble() * (minMax.Max - minMax.Min) + minMax.Min;
        }

    }
}
