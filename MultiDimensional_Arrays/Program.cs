using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimensional_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            float[,] tempsGrid = new float[4,3];

            //for (int x = 0; x < 4; x++)
            //{
            //    for (int y = 0; y < 3; y++)
            //    {
            //        tempsGrid[x, y] = x + 10 * y;
            //    }
            //}

            //foreach (float temp in tempsGrid)
            //{
            //    Console.WriteLine(temp);
            //}

            Console.WriteLine();

            Console.WriteLine("Length is {0}", tempsGrid.Length);
            Console.WriteLine("The Rank or Dimension is {0}", tempsGrid.Rank);

            for (int x = tempsGrid.GetLowerBound(0); x <= tempsGrid.GetUpperBound(0); x++)
            {
                for (int y = tempsGrid.GetLowerBound(1); y <= tempsGrid.GetUpperBound(1); y++)
                {
                    tempsGrid[x, y] = x + 10 * y;
                }

            }


            for (int x = 0; x < tempsGrid.GetLength(0); x++)
            {
                for (int y = 0; y < tempsGrid.GetLength(1); y++)
                {
                    Console.Write("{0}, ",tempsGrid[x,y]);
                }

                Console.WriteLine();
            }

        }
    }
}
