using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintHelloPrint1To5();

            Console.WriteLine();
            int x = 1;

            PrintHelloPrint1To5();

            Console.WriteLine("Enter a number");

            int a = Convert.ToInt32(Console.ReadLine());
            //int c = a * a;
            //Console.WriteLine($"result = {c}");

            PrintNumberPower2(0);
            PrintNumberPower2( a );
            PrintNumberPower2(100);
            PrintNumberPower2(a * 10);

            Average(1, 10);

            Console.WriteLine();
            Console.WriteLine();

            a = Convert.ToInt32(Console.ReadLine());
            PrintNumberPower2(a * 10);
        }


        private static void Average(int number1, int number2)
        {
         
        }


        private static void PrintNumberPower2(int aNumber)
        {
            int c = aNumber * aNumber;
            Console.WriteLine(c);
            aNumber++;
        }


        private static void PrintHelloPrint1To5()
        {
            Console.WriteLine("Hello world!");
            Console.WriteLine(1);
            Console.WriteLine(2);
            Console.WriteLine(3);
            Console.WriteLine(4);
            Console.WriteLine(5);
        }
    }
}
