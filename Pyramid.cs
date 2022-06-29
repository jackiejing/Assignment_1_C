using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    public static class Pyramid
    {
        public static void PyramidValue()
        {
            int i, j, k;
            Console.WriteLine("Input of number: ");
            //k = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < k; i++)
            {
                for (j = 1; j <= k; j++)
                {
                    Console.WriteLine(" ");
                }
                for (j = 1; j <= 2 * i - 1; j++)
                {
                    Console.WriteLine("*");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
