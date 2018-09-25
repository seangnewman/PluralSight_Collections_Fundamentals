using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            //int indexOfTues = Array.IndexOf(daysOfWeek, "Tuesday");

            //int indexOfW = Array.FindIndex(daysOfWeek, (x) => {
            //    return x[0] == 'W';

            //});

            string[] allWith6Chars = Array.FindAll(daysOfWeek, (x) =>
            {
                return x.Length == 6;
            });

            foreach (string item in allWith6Chars)
            {
                Console.WriteLine(item);
            }
        }
    }
}
