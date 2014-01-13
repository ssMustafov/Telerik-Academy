// Write a program to convert hexadecimal numbers to binary numbers (directly).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace HexToBinary
{
    class Program
    {
        static BigInteger ConvertHexToBinary(string hex)
        {
            List<string> bits = new List<string>();

            for (int i = 0; i < hex.Length; i++)
            {
                switch (hex[i])
                {
                    case '0': bits.Add("0000"); break;
                    case '1': bits.Add("0001"); break;
                    case '2': bits.Add("0010"); break;
                    case '3': bits.Add("0011"); break;
                    case '4': bits.Add("0100"); break;
                    case '5': bits.Add("0101"); break;
                    case '6': bits.Add("0110"); break;
                    case '7': bits.Add("0111"); break;
                    case '8': bits.Add("1000"); break;
                    case '9': bits.Add("1001"); break;
                    case 'A': bits.Add("1010"); break;
                    case 'B': bits.Add("1011"); break;
                    case 'C': bits.Add("1100"); break;
                    case 'D': bits.Add("1101"); break;
                    case 'E': bits.Add("1110"); break;
                    case 'F': bits.Add("1111"); break;
                    default: break;
                }
            }

            bits[0] = bits[0].TrimStart('0');

            string appended = "";

            foreach (var e in bits)
            {
                appended += e;
            }

            BigInteger binary = BigInteger.Parse(appended);

            return binary;
        }

        static void Main(string[] args)
        {
            string hex = Console.ReadLine();

            Console.WriteLine(ConvertHexToBinary(hex));
        }
    }
}
