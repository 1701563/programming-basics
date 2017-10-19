using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satunnaisluku1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa kokonaisluvut 1-10 ja niiden neliöjuuret.");
            int i = 1;
            do
            {
                Console.WriteLine($"{i}\t\t{Math.Sqrt(i)}");
                i = i + 1;

            } while (i <= 10);
            Console.ReadKey();
        }
    }
}
