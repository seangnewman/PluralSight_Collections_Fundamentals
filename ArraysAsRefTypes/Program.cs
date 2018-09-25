using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAsRefTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x1 = { 1, 4, 9, 16 };
            var x2 = x1;
            int[] x3 = { 1, 4, 9, 16 };
           

            Console.WriteLine(String.Format("x1==x2 is {0}", x1 == x2));
            Console.WriteLine(String.Format("x1==x3 is {0}", x1 == x3));
        }
    }
}
