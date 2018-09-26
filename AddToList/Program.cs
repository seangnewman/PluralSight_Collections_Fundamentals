using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddToList
{
    class Program
    {
        static void Main(string[] args)
        {

            var presidents = new List<string>(12)
            {
                "Jimmy Carter",
                "Ronald Reagan",
                "George HW Bush",
                "Bill Clinton",
                "George W Bush",
                "Barack Obama"
                
            };

             
            presidents.Add(("Donald Trump"));

            //var copy = presidents.AsReadOnly();
            var copy = new ReadOnlyCollection<string>(presidents);

            //BadCode(copy);

            foreach (string president in presidents)
            {
                Console.WriteLine(president);
            }
        }

        static void BadCode(IList<string> lst)
        {
            lst.RemoveAt(2);
        }
    }
}
