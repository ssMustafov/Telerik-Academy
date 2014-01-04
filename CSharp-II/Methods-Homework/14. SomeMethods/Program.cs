// Write methods to calculate minimum, maximum, average, sum and
// product of given set of integer numbers. Use variable number of arguments.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SomeMethods
{
    class Program
    {
        static int CalcMinimum(params int[] array)
        {
            int min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            return min;
        }

        static int CalcMaximum(params int[] array)
        {
            int max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }

        static int CalcSum(params int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }

        static float CalcAverage(params int[] array)
        {
            float sum = 0f;
            int lenght = array.Length;

            sum = CalcSum(array);

            return sum / lenght;
        }

        static long CalcProduct(params int[] array)
        {
            long product = 1;

            for (int i = 0; i < array.Length; i++)
            {
                product *= array[i];
            }

            return product;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(CalcMinimum(2, 3, -10, -1, 0, -10));
            Console.WriteLine(CalcMaximum(2, 3, -10, -1, 0, -10));
            Console.WriteLine(CalcSum(5, 2, 1, 5));
            Console.WriteLine(CalcAverage(5, 2, 1, 5));
            Console.WriteLine(CalcProduct(2, 10, 9, 6, 15, 17, 20, 21));
        }
    }
}
