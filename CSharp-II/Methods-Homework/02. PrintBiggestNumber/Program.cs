// Write a method GetMax() with two parameters that returns the bigger of two integers.
// Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintBiggestNumber
{
    class Program
    {
        public static int GetMax(int number1, int number2)
        {
            int number = number1;
            if (number < number2)
            {
                number = number2;
            }

            return number;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter three numbers:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            Console.Write("The biggest number is: ");
            Console.WriteLine(GetMax(num1, GetMax(num2, num3)));
        }
    }
}
