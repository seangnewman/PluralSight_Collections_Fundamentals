﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_BasicUsage
{
    class Program
    {
        static void Main(string[] args)
        {
            string monday = "Monday";

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

            daysOfWeek[5] = "Party Day";

            foreach (string day in daysOfWeek)
            {
                Console.WriteLine(day);
            }
        }
    }
}
