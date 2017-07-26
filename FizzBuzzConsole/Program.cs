using FizzBuzzLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fb = new FizzBuzz();

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(fb.CheckNumber(i));
            }

            Console.ReadKey();
        }
    }
}
