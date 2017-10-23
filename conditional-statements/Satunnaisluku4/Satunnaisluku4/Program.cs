using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satunnaisluku4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.Write("Ohjelma simuloi rahan heittoa. Syötä luku: ");

            string userInput = Console.ReadLine();

            int number = int.Parse(userInput);

            int head = 0;

            int tails = 0;

            Console.WriteLine($"Rahaa on heitetty {number} kertaa.");

            for (int i = 0; i < number; i++)

            {

                if (rnd.Next(2) == 0)

                    head++;

                else

                    tails++;

            }

            Console.Write($"Klaavoja tuli {tails} ja kruunia {head}.");

            Console.ReadKey();



        }
    }
}
