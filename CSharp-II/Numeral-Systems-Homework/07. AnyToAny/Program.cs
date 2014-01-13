// Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnyToAny
{
    class Program
    {
        static string NumeralSystemsConverter(int baseToConvertFrom, int baseToConvertTo, string numberToConvert)
        {
            int convertedToDecimal = ConvertToDecimal(baseToConvertFrom, numberToConvert);

            return ConvertFromDecimal(baseToConvertTo, convertedToDecimal);
        }

        static int ConvertToDecimal(int baseToConvertFrom, string numberToConvert)
        {
            int convertedNumber = 0;

            for (int index = 0; index < numberToConvert.Length; index++)
            {
                char currentChar = numberToConvert[index];
                int currentBit = 0;

                switch (currentChar)
                {
                    case '0': currentBit = 0; break;
                    case '1': currentBit = 1; break;
                    case '2': currentBit = 2; break;
                    case '3': currentBit = 3; break;
                    case '4': currentBit = 4; break;
                    case '5': currentBit = 5; break;
                    case '6': currentBit = 6; break;
                    case '7': currentBit = 7; break;
                    case '8': currentBit = 8; break;
                    case '9': currentBit = 9; break;
                    case 'A': currentBit = 10; break;
                    case 'B': currentBit = 11; break;
                    case 'C': currentBit = 12; break;
                    case 'D': currentBit = 13; break;
                    case 'E': currentBit = 14; break;
                    case 'F': currentBit = 15; break;
                    case 'a': currentBit = 10; break;
                    case 'b': currentBit = 11; break;
                    case 'c': currentBit = 12; break;
                    case 'd': currentBit = 13; break;
                    case 'e': currentBit = 14; break;
                    case 'f': currentBit = 15; break;
                    default: break;
                }

                convertedNumber += currentBit * Convert.ToInt32(Math.Pow(baseToConvertFrom, numberToConvert.Length - index - 1));
            }

            return convertedNumber;
        }

        static string ConvertFromDecimal(int baseToConvertTo, int numberToConvert)
        {
            List<string> hexRepresentation = new List<string>();
            int currentNumberToDivide = numberToConvert;

            while (true)
            {
                int modulo = currentNumberToDivide % baseToConvertTo;

                if (modulo > 9)
                {
                    string letterToPut = null;

                    switch (modulo)
                    {
                        case 10: letterToPut = "A"; break;
                        case 11: letterToPut = "B"; break;
                        case 12: letterToPut = "C"; break;
                        case 13: letterToPut = "D"; break;
                        case 14: letterToPut = "E"; break;
                        case 15: letterToPut = "F"; break;
                        default: break;
                    }

                    hexRepresentation.Add(letterToPut);
                }
                else
                {
                    hexRepresentation.Add(modulo.ToString());
                }
                currentNumberToDivide /= baseToConvertTo;

                if (currentNumberToDivide == 0)
                {
                    break;
                }
            }

            hexRepresentation.Reverse();

            return string.Join("", hexRepresentation);
        }

        static void Main()
        {
            Console.WriteLine("You can convert systems with bases more that 1 and less than 17");
            Console.Write("Please enter the base you want to convert FROM : ");
            int baseToConvertFrom = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nPlease enter the base you want to convert TO : ");
            int baseToConvertTo = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nPlease enter the number to convert: ");
            string numberToConvert = Console.ReadLine();

            string convertedNumber = NumeralSystemsConverter(baseToConvertFrom, baseToConvertTo, numberToConvert);

            Console.WriteLine("\nThe number converted a system with base {0} is {1}", baseToConvertTo, convertedNumber);
        }
    }
}
