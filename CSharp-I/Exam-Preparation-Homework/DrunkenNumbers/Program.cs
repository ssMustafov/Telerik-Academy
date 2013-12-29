using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DrunkenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int left = 0;
            int right = 0;

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (input < 0)
                {
                    input = -input;
                }

                int number = input;
                int digitCount = 0;
                while (number > 0)
                {
                    int k = number % 10;
                    digitCount++;
                    number /= 10;
                }

                int seperator = digitCount / 2;
                int position = 0;
                while (seperator != position)
                {
                    int k = input % 10;
                    right += k;
                    input /= 10;
                    position++;
                }

                if (digitCount % 2 == 1)
                {
                    int k = input % 10;
                    right += k;
                }

                while (input > 0)
                {
                    int k = input % 10;
                    left += k;
                    input /= 10;
                }
            }

            if (left > right)
            {
                Console.WriteLine("M {0}", left - right);
            }
            else if (left < right)
            {
                Console.WriteLine("V {0}", right - left);
            }
            else
            {
                Console.WriteLine("No {0}", right + left);
            }
        }
    }
}
