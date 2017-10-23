using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satunnaisluku6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Ohjelma heittää noppaa 1000 kertaa, ja kertoo kuinka montaa numero 6 esiintyi.");
            int counterForNumber6 = 0;
            for (int i = 1; i <= 1000; i++)
            {
                double j = rnd.Next(1,7);
                if (j == 6)
                    counterForNumber6++;
                Console.WriteLine($"{i}. {j}");
            }
            Console.WriteLine($"Numero kuusi esiintyi {counterForNumber6} kertaa");
            Console.ReadKey();
        }
    }
}
