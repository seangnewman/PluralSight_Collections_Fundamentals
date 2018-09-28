using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedSet_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var bigCities= new SortedSet<string>
            (new UncasedStringComparer())
            {
                "Paris", "New York", "Manchester", "Sheffield"
            };

            bigCities.Add("SHEFFIELD");
            bigCities.Add("BEIJING");

            foreach (string city in bigCities)
            {
                Console.WriteLine(city);
            }
        }
    }
}
