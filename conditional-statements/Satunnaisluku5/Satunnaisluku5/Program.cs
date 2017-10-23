using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satunnaisluku5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Ohjelma tulostaa vakioveikkauksen rivin");
            for (int i = 1; i <= 13; i++)
            {
                double j = rnd.NextDouble();
                if (j <= 0.4)
                    Console.WriteLine($"{i}. Kotivoitto");
                else if (j >= 0.8)
                    Console.WriteLine($"{i}. Tasapeli");
                else
                    Console.WriteLine($"{i}. Vierasvoitto");
            }
            Console.ReadKey();

        }
    }
}
