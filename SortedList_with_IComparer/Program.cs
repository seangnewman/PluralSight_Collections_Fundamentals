﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList_with_IComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeMinisters = new SortedList<string, PrimeMinister>
            (new UncasedStringComparer())
            {
                {"JC", new PrimeMinister("James Callaghan", 1976)},
                {"MT", new PrimeMinister("Margaret Thatcher", 1979)},
                {"TB", new PrimeMinister("Tony Blair", 1997)}
            };

            primeMinisters.Add("JM", new PrimeMinister("John Major", 1991));

            Console.WriteLine("tony is {0}", primeMinisters["tb"]);

            Console.WriteLine("Now Sorted Dictionary");

            
        }
    }
}
