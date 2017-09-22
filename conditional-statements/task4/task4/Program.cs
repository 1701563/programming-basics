using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma asettaa annetut luvut suuruusjärjestykseen");
            Console.Write("Syötä luku: ");
            string userInput;
            userInput = Console.ReadLine();
            int number1;
            string userInput;
            userInput = Console.ReadLine();
            int number2;
            string userInput;
            userInput = Console.ReadLine();
            int number3;
            
            int.TryParse(userInput, out evaluatedNumber);
            if (evaluatedNumber % 2 != 0) Console.WriteLine($"Numero {evaluatedNumber} on pariton");
            else if (evaluatedNumber % 2 != 0) Console.WriteLine($"Numero {evaluatedNumber} on pariton");
            Console.ReadKey();

        }
    }
}
