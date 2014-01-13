// Write a program to convert binary numbers to hexadecimal numbers (directly).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace BinaryToHex
{
    class Program
    {
        static string ConvertBinaryToHex(BigInteger binary)
        {
            List<int> bits = new List<int>();
            List<string> hexs = new List<string>();

            while (binary != 0)
            {    
                int a = (int)(binary % 10000);
                bits.Add(a);
                binary /= 10000;
            }

            for (int i = 0; i < bits.Count; i++)
            {
                switch (bits[i])
                {
                    case 0: hexs.Add("0"); break;
                    case 1: hexs.Add("1"); break;
                    case 10: hexs.Add("2"); break;
                    case 11: hexs.Add("3"); break;
                    case 100: hexs.Add("4"); break;
                    case 101: hexs.Add("5"); break;
                    case 110: hexs.Add("6"); break;
                    case 111: hexs.Add("7"); break;
                    case 1000: hexs.Add("8"); break;
                    case 1001: hexs.Add("9"); break;
                    case 1010: hexs.Add("A"); break;
                    case 1011: hexs.Add("B"); break;
                    case 1100: hexs.Add("C"); break;
                    case 1101: hexs.Add("D"); break;
                    case 1110: hexs.Add("E"); break;
                    case 1111: hexs.Add("F"); break;
                    default: break;
                }
            }

            string realHexNumber = "";

            for (int i = hexs.Count - 1; i >=0; i--)
            {
                realHexNumber += hexs[i];
            }

            return realHexNumber;
        }

        static void Main(string[] args)
        {
            BigInteger binary = BigInteger.Parse(Console.ReadLine());
            
            Console.WriteLine(ConvertBinaryToHex(binary));
        }
    }
}
