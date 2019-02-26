using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _2602
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayCards(5);
            //PlayCards(8);
        }

        private static void PlayCards(int maxScore)
        {
            Random engine = new Random();

            int myScore = 0;
            int computerScore = 0;
            int round = 1;

            do
            {
                Console.WriteLine($"Round number {round++} my-score: {myScore} computer-score: {computerScore}");

                // get new card
                int mycard = engine.Next(2, 15);

                // print card
                PrintCard(mycard);

                Thread.Sleep(3000);

                // get new card
                int computercard = engine.Next(2, 15);

                // print card
                PrintCard(computercard);

                Thread.Sleep(500);

                PrintWhoWon(mycard, computercard);

                if (mycard > computercard)
                {
                    myScore++;
                }
                else if (computercard > mycard)
                {
                    computerScore++;
                }
            }
            while (myScore < maxScore && computerScore < maxScore);

            PrintWinner(myScore, computerScore);
        }

        private static void PrintWinner(int myScore, int computerScore)
        {
            if (myScore > computerScore)
            {
                Console.WriteLine("I won!!!!!!!!");
            }
            else
            {
                Console.WriteLine("Computer won ... boooooo .....");
            }
        }

        private static void PrintWhoWon(int mycard, int computercard)
        {
            if (mycard > computercard)
            {
                Console.WriteLine("I won this round!!!!");
            }
            else if (computercard > mycard)
            {
                Console.WriteLine("Computer won ... booooo");
            }
            else
            {
                Console.WriteLine("Tie!");
            }
        }

        private static void PrintCard(int card)
        {
            switch (card)
            {
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    Console.WriteLine(card);
                    break;
                case 11:
                    Console.WriteLine("J");
                    break;
                case 12:
                    Console.WriteLine("Q");
                    break;
                case 13:
                    Console.WriteLine("K");
                    break;
                case 14:
                    Console.WriteLine("A");
                    break;
                default:
                    Console.WriteLine("Bad card!!!!!!!!!!!");
                    break;
            }
        }
    }
}
