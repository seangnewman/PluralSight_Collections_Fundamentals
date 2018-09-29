using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerate_While_Changing
{
    class Program
    {
        static void Main(string[] args)
        {

            var days = new string[]
            {
                "Monday",
                "Tuesday",
                "Wednesday"
            };

            foreach (string day in days)
            {
                days[1] = "2nd Day";
                Console.WriteLine(day);
            }
        }
    }
}
