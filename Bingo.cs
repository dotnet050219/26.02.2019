using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2602
{
    class Program
    {
        static void Main(string[] args)
        {
            Random engine = new Random();

            int secretNumber = engine.Next(100) + 1;

            //Console.WriteLine(secretNumber);

            int counter = 0;
            int guess;

            do
            {
                Console.WriteLine("Please guess a number (1-100):");

                guess = Convert.ToInt32(Console.ReadLine());

                counter++;

                if (guess < secretNumber)
                {
                    Console.WriteLine("Pleaes guess higher!");
                }
                else if ( guess > secretNumber)
                {
                    Console.WriteLine("Please guess lower!");
                }
            }
            while (guess != secretNumber);

            Console.WriteLine($"Bingo!!! it took you only {counter}");
        }
    }
}
