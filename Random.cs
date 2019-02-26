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

            int secretNumber = engine.Next(1000) + 1;

            Console.WriteLine(secretNumber);
        }
    }
}
