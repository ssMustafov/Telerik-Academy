// Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RandomValues
{
    class Program
    {
        static void RandomGenerator(int min, int max)
        {
            Random generator = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(generator.Next(min, max + 1));
            }
        }

        static void Main(string[] args)
        {
            RandomGenerator(100, 200);
        }
    }
}
