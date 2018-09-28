using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyedDictionary_Demo 
{
    class Program
    {
        static void Main(string[] args)
        {
            var PrimeMinisters = new PrimeMinistersByYearDictionary()
            {
                new PrimeMinister("James Callaghan", 1974),
                new PrimeMinister("Margret Thatcher", 1979),
                new PrimeMinister("Tony Blair", 1997)
            };




            PrimeMinisters.Add(new PrimeMinister("John Major", 1990));



            var list = (IList<PrimeMinister>) PrimeMinisters;
            Console.WriteLine("First PM is {0}", list[0]);

            Console.WriteLine("TB is {0}", PrimeMinisters[1997]) ;

            foreach (var primeMinister in PrimeMinisters)
            {
                Console.WriteLine(primeMinister);
            }

        }

         
    }
}
