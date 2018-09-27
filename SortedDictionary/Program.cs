﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeMinisters = new SortedDictionary<string, PrimeMinister>
            {
                {"JC", new PrimeMinister("James Callaghan", 1976)},
                {"MT", new PrimeMinister("Margaret Thatcher", 1979)},
                {"TB", new PrimeMinister("Tony Blair", 1997)}
            };

            primeMinisters.Add("JM", new PrimeMinister("John Major", 1991));

            foreach (var primeminister in primeMinisters)
            {
                Console.WriteLine(primeminister);
            }

        }
    }
}
