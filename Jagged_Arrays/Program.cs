using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            float[][] tempsGrid = new float[4][];

            Console.WriteLine("The Rank is {0}", tempsGrid.Rank);
            Console.WriteLine("The Length is {0}", tempsGrid.Length);

            for (int x = 0; x < 4; x++)
            {   
                tempsGrid[x] = new float[3];

                for (int y = 0; y < 3; y++)
                {
                    tempsGrid[x][ y] = x + 10 * y;
                }

            }


            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    Console.Write("{0}, ", tempsGrid[x][y]);
                }

                Console.WriteLine();
            }

        }
    }
}
