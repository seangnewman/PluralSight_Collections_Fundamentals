﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forEachReadOnly
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

            MakeDaysPlural(daysOfWeek);

            foreach (string day in daysOfWeek)
            {
                Console.WriteLine(day);
            } 
        }

        static void MakeDaysPlural(string[] daysOfWeek)
        {
            for (int i = 0; i < daysOfWeek.Length; i++)
            {
                daysOfWeek[i] = daysOfWeek[i] + "s";
            }
        }
    }
}
