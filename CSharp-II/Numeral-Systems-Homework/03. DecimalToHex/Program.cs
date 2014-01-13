// Write a program to convert decimal numbers to their hexadecimal representation.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecimalToHex
{
    class Program
    {
        static string ConvertDecimalToHex(int number)
        {
            List<char> hexs = new List<char>();
            string hexNumber = "";

            int num = number;
            while (num != 0)
            {
                byte remainder = (byte)(num % 16);
 
		        switch (remainder)
                {
                    case 0: hexs.Add('0'); break;
                    case 1: hexs.Add('1'); break;
                    case 2: hexs.Add('2'); break;
                    case 3: hexs.Add('3'); break;
                    case 4: hexs.Add('4'); break;
                    case 5: hexs.Add('5'); break;
                    case 6: hexs.Add('6'); break;
                    case 7: hexs.Add('7'); break;
                    case 8: hexs.Add('8'); break;
                    case 9: hexs.Add('9'); break;
                    case 10: hexs.Add('A'); break;
                    case 11: hexs.Add('B'); break;
                    case 12: hexs.Add('C'); break;
                    case 13: hexs.Add('D'); break;
                    case 14: hexs.Add('E'); break;
                    case 15: hexs.Add('F'); break;
                    default: break;
                }
	            
                num /= 16;
            }

            for (int i = hexs.Count - 1; i >= 0; i--)
            {
                hexNumber += Convert.ToString(hexs[i]);
            }

            return hexNumber;
        }

        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine(ConvertDecimalToHex(number));
        }
    }
}
