using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silmukka1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Syötä luku jonka kertoman haluat laskea. ");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);

            int i = 0;
            int f = 1;

            do
            {
                Console.Write($"{number} = {i+1}");
                i = i + 1;
                f *= i;
            }
            while (i < number);

            Console.WriteLine();
            Console.WriteLine($"Vastaus: {f}");
            Console.ReadKey();
            
        }
    }
}
