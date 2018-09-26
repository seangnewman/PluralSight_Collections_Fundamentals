using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_Interfaces_Count
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

            ICollection<string> collection = (ICollection<string>) daysOfWeek;

            if(!collection.IsReadOnly)
                collection.Add("Thorsday");
            else
                Console.WriteLine("The collection is read only");

            foreach (string day in daysOfWeek)
            {
                Console.WriteLine(day);            
            }

            Console.WriteLine("Count = {0}", collection.Count);
        }
    }
}
