using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satunnaisluku3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, arvottu;
            Random satluku = new Random();
            for (i = 1; i < 21; i++)
            {
                arvottu = satluku.Next(1, 50);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}