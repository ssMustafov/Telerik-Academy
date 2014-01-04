// Write a method that asks the user for his name and prints “Hello, <name>”
// (for example, “Hello, Peter!”). Write a program to test this method.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintName
{
    class Program
    {
        public static string PrintHello(string name)
        {
            Console.WriteLine("Hello, {0}", name);
            return name;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            string input = Console.ReadLine();

            PrintHello(input);
        }
    }
}
