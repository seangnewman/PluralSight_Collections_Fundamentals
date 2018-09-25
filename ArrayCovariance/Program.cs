using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCovariance
{
    class Program
    {
        static void Main(string[] args)
        {

            object[] objArray = new object[3];

            string[] daysOfWeek =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            object[] objArr2 = daysOfWeek;

            foreach (object obj in objArr2)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
