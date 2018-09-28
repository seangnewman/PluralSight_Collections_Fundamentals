using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet_SetComparisons
{
    class Program
    {
        static void Main(string[] args)
        {
            var ukCities = new HashSet<string>
            {
                "Sheffield", "Ripon", "Turo", "Manchester"
            };

            var bigUKCities = new HashSet<string>
            {
                "Sheffield", "Manchester"
            };

            var bigCitiesArr = new HashSet<string>
            {
                "Paris", "New York", "Manchester", "Sheffield"
            };

            bool ukIsSubset = ukCities.IsSubsetOf(bigCitiesArr);
            Console.WriteLine("UK cities subset of big cities? {0}", ukIsSubset);

            bool bigUkIsSubset = bigUKCities.IsSubsetOf(bigCitiesArr);
            Console.WriteLine("Big UK cities subset of big cities? {0}", bigUkIsSubset);


            ukIsSubset = bigCitiesArr.IsSupersetOf(ukCities);
            Console.WriteLine("UK cities superset of big cities? {0}", ukIsSubset);

            bigUkIsSubset = bigCitiesArr.IsSupersetOf(bigUKCities);
            Console.WriteLine("Big UK cities superset of big cities? {0}", bigUkIsSubset);
        }
    }
}
