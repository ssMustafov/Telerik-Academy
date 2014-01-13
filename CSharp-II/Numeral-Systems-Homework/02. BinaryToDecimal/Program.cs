// Write a program to convert binary numbers to their decimal representation.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryToDecimal
{
    class Program
    {
        static int ConvertBinaryToDecimal(int binary)
        {
            int counter = 0;
            int decimalNumber = 0;

            while (binary != 0)
            {
                int c = binary % 10;
                if (c != 0)
                {
                    decimalNumber += c * (int)(Math.Pow(2, counter));
                }
                counter++;
                binary /= 10;
            }

            return decimalNumber;
        }

        static void Main(string[] args)
        {
            int binary = int.Parse(Console.ReadLine());

            Console.WriteLine(ConvertBinaryToDecimal(binary));
        }
    }
}
