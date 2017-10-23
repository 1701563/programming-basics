using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satunnaisluku3ver2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random h = new Random();
            int i, f;
            for (i = 1; i < 5; i++)
            {
                //Rivi 1: 34, 5, 7, 12, 10,  
                Console.Write($"Rivi {i}: ");
                for (f = 0; f < 5; f++)
                {
                    if (f < 4)
                        Console.Write($"{h.Next(1, 50)}, ");
                    else
                        Console.Write($"{h.Next(1, 50)}");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
