using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            var bigCities = new HashSet<string>
            {
                "New York", "Manchester", "Sheffield", "Paris"
            };

            bool addedSheffield = bigCities.Add("Sheffield");
            bool addedBeijing = bigCities.Add("Beijing");
            Console.WriteLine("Added Sheffield = {0}", addedSheffield);
            Console.WriteLine("Added Beijing = {0}", addedBeijing);

            foreach (string city in bigCities)
            {
                Console.WriteLine(city);
            }
        }
    }
}
