// Write a program to convert decimal numbers to their binary representation.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecimalToBinary
{
    class Program
    {
        static int ConvertDecimalToBinary(int number)
        {
            List<byte> bits = new List<byte>();
            int binary = 0;

            int num = number;
            while (num != 0)
            {
                byte remainder = (byte)(num % 2);
                bits.Add(remainder);

                num /= 2;
            }

            string stringBinary = "";
            for (int i = bits.Count - 1; i >= 0; i--)
            {
                stringBinary += Convert.ToString(bits[i]);
            }

            binary = int.Parse(stringBinary);
            
            return binary;
        }

        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(ConvertDecimalToBinary(number));
        }
    }
}
