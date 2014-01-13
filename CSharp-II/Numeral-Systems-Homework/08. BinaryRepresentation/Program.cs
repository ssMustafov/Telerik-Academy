// Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryRepresentation
{
    class Program
    {
        static long ConvertDecimalToBinary(int number)
        {
            List<byte> bits = new List<byte>();
            long binary = 0;

            int num = number;
            while (num != 0)
            {
                byte remainder = (byte)(num % 2);
                bits.Add(remainder);

                num /= 2;
            }

            string stringBinary = "";

            if (number == 0)
            {
                stringBinary = "0";
            }

            for (int i = bits.Count - 1; i >= 0; i--)
            {
                stringBinary += Convert.ToString(bits[i]);
            }

            binary = long.Parse(stringBinary);

            return binary;
        }

        static long ShortBinaryRepresentation(short number)
        {
            int[] bits = new int[16];
            int num = number;

            if (number < 0)
            {
                bits[0] = 1;
                num = ~number + 1;
            }

            long numBinary = ConvertDecimalToBinary(num);

            int counter = bits.Length - 1;
            while (numBinary != 0)
            {
                int a = (int)(numBinary % 10);
                bits[counter] = a;
                numBinary /= 10;
                counter--;
            }

            string result = "";

            foreach (var e in bits)
            {
                result += e;
            }

            long finalBits = long.Parse(result);

            return finalBits;
        }

        static void Main(string[] args)
        {
            short shortNumber = short.Parse(Console.ReadLine());
            Console.WriteLine(ShortBinaryRepresentation(shortNumber).ToString().PadLeft(16, '0'));
        }
    }
}
