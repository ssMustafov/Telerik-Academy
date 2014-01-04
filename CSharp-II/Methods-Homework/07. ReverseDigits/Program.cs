using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReverseDigits
{
    class Program
    {
        static int ReverseDigitsOfNumber(int number)
        {
            int num = number;
            int reversedNumber = 0;

            while (num != 0)
            {
                int c = num % 10;
                reversedNumber = reversedNumber * 10 + c;
                num /= 10;
            }

            return reversedNumber;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ReverseDigitsOfNumber(2506));
        }
    }
}
