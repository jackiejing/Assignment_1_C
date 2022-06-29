using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    public static class GussedNumber
    {
        public static void guessValue(string[] args)
        {
            Random random = new Random();
            int rangeofValue = random.Next(1, 3);
            int guessNumber = 0;
            while (guessNumber != rangeofValue)
            {
                guessNumber = int.Parse(Console.ReadLine());
                if (guessNumber > rangeofValue)
                {
                    Console.WriteLine("Too high.");
                }
                else if (guessNumber < rangeofValue)
                {
                    Console.WriteLine("Too low");
                }
            }
            Console.WriteLine("Correct Answer");
            Console.ReadLine();
        }
    }
}
