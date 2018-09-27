using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Prime_Ministers
{
    class Program
    {
        static void Main(string[] args)
        {
            var primeMinisters = new Dictionary<string, PrimeMinister>
            (new UncasedStringEqualityComparer())
            {
                {"JC", new PrimeMinister("James Callaghan", 1976)},
                {"MT", new PrimeMinister("Margaret Thatcher", 1979)},
                {"TB", new PrimeMinister("Tony Blair", 1997)}
            };

            PrimeMinister pm = primeMinisters["TB"];
            Console.WriteLine("Value is: {0}\r\n", pm.ToString());


            foreach (var primeMinister in primeMinisters)
            {
                Console.WriteLine("{0}, {1}", primeMinister.Key, primeMinister.Value);
            }

            bool found = primeMinisters.TryGetValue("DC", out pm);

            if (found)
            {
                Console.WriteLine("Value is {0}\r\n", pm.ToString());
            }
            else
            {
                Console.WriteLine("Value not found in dictionary");
            }


            primeMinisters["JC"] = new PrimeMinister("Jim Callaghan", 1976);
            primeMinisters["JM"] = new PrimeMinister("John Major", 1990);
            primeMinisters.Add("GB", new PrimeMinister("Gordon Brown", 2007));
            primeMinisters.Remove("JC");
            Console.WriteLine();
            foreach (var primeMinister in primeMinisters)
            {
                Console.WriteLine("{0}, {1}", primeMinister.Key, primeMinister.Value);
            }

            Console.WriteLine();
            Console.WriteLine(primeMinisters["tb"]);


        }
    }
}
