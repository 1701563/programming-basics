using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silmukka5ver2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee annetuun lukuun asti parittomien ja parillisten lukujen summan ");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);

            int i = 0;
            int evenSum = 0, oddSum = 0;
            if (number > 0)
                do
                {
                    if (i % 2 == 0)
                        evenSum += i;
                    else
                        oddSum += i;
                    i = i + 1;
                }
                while (i <= number);

            else
                do
                {
                    if (i % 2 == 0)
                        evenSum += i;
                    else
                        oddSum += i;
                    i = i + (-1);
                } while (i >= number);

            Console.WriteLine($"Parittomien summa= {oddSum} ja parillisten summa= {evenSum}");
            Console.ReadKey();

        }
    }
}
