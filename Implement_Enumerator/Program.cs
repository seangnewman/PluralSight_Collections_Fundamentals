using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implement_Enumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            AllDaysOfWeek allDays = new AllDaysOfWeek();

            foreach (string day in allDays)
            {
                Console.WriteLine(day);
            }
        }
    }
}
