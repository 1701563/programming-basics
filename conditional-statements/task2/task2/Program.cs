using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conditional_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa onko numero parillinen vai pariton");
            Console.Write("Syötä luku: ");
            string userInput;
            userInput = Console.ReadLine();
            int evaluatedNumber;
            int.TryParse(userInput, out evaluatedNumber);
            if (evaluatedNumber % 2 == 0) Console.WriteLine($"Numero {evaluatedNumber} on parillinen");
            else if (evaluatedNumber % 2 != 0) Console.WriteLine($"Numero {evaluatedNumber} on pariton");
            Console.ReadKey();

        }
    }
}
