using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet_SetEquals
{
    class Program
    {
        static void Main(string[] args)
        {
            var bigCities = new HashSet<string>
            {
                "New York", "Manchester", "Sheffield", "Paris"
            };

            var citiesInUk = new HashSet<string>
            {
                "Sheffield", "Ripon", "Turo", "Manchester"
            };

            var bigCitiesArr = new string[]
            {
                "Paris", "New York", "Manchester", "Sheffield"
            };

            bool areEqual = bigCities.SetEquals(bigCitiesArr);
            Console.WriteLine("bigCities = bigCitiesArr? {0}", areEqual);

            bool areEqualUk = citiesInUk.SetEquals(bigCitiesArr);
            Console.WriteLine("citiesInUk = bigCitiesArr? {0}", areEqualUk);


        }
    }
}
