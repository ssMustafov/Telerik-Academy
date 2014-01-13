// Write a program to convert hexadecimal numbers to their decimal representation.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HexToDecimal
{
    class Program
    {
        static int ConvertHexToDecimal(string hex)
        {
            int decimalNumber = 0;
            int counter = 0;
            int lenght = hex.Length - 1;
            List<int> decimals = new List<int>();

            while (lenght != -1)
            {
                if (hex[lenght] >= 'A' && hex[lenght] <= 'F')
                {
                    switch (hex[lenght])
                    {
                        case 'A': decimals.Add(10); break;
                        case 'B': decimals.Add(11); break;
                        case 'C': decimals.Add(12); break;
                        case 'D': decimals.Add(13); break;
                        case 'E': decimals.Add(14); break;
                        case 'F': decimals.Add(15); break;
                        default: break;
                    }
                }
                else
                {
                    int v = (int)Char.GetNumericValue(hex[lenght]);
                    decimals.Add(v);
                }

                lenght--;
            }

            while (counter != decimals.Count)
            {
                decimalNumber += decimals[counter] * (int)(Math.Pow(16, counter));
                counter++;
            }
            
            return decimalNumber;
        }

        static void Main(string[] args)
        {
            string hex = Console.ReadLine();

            Console.WriteLine(ConvertHexToDecimal(hex));
        }
    }
}
