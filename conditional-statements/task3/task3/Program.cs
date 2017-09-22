using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa onko numero positiivinen ja parillinen, positiivinen ja pariton, negatiivinen ja parillinen, negatiivinen ja pariton vai nolla");
            Console.Write("Syötä luku: ");
            string userInput;
            userInput = Console.ReadLine();
            int evaluatedNumber;
            int.TryParse(userInput, out evaluatedNumber);
            
            if (evaluatedNumber > 0 && evaluatedNumber % 2 == 0) Console.WriteLine($"Numero {evaluatedNumber} on positiivinen ja parillinen");
            if (evaluatedNumber > 0 && evaluatedNumber % 2 != 0) Console.WriteLine($"Numero {evaluatedNumber} on posiitivinen ja pariton");
            if (evaluatedNumber < 0 && evaluatedNumber % 2 == 0) Console.WriteLine($"Numero {evaluatedNumber} on negatiivinen ja parillinen");
            if (evaluatedNumber < 0 && evaluatedNumber % 2 != 0) Console.WriteLine($"Numero {evaluatedNumber} on negatiivinen ja pariton");
            if (evaluatedNumber == 0) Console.WriteLine("Numero on nolla");
            Console.ReadKey();

        }
    }
}
