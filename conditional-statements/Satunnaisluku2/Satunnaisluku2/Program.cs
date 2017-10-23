using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satunnaisluku2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, f;
            for (i = 1; i < 10; i++)
            {
                for (f = 1; f < 10; f++)
                {
                    Console.Write(f * i + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey(true);
        }
    }
}