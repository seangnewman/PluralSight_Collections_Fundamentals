using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet_Comparer
{
    class Program
    {
        static void Main(string[] args)
        {
            var bigCities = new HashSet<string>
            (new UncasedStringEqualityComparer())
            {
                "New York", "Manchester", "Sheffield", "Paris"
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
