// * Modify your last program and try to make it work for any number type, not just integer
// (e.g. decimal, float, byte, etc.). 
// Use generic method (read in Internet about generic methods in C#).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SomeMethodsExtended
{
    class Program
    {
        static T CalcMinimum<T>(params T[] array)
        {
            dynamic min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            return min;
        }

        static T CalcMaximum<T>(params T[] array)
        {
            dynamic max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }

        static T CalcSum<T>(params T[] array)
        {
            dynamic sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }

        static T CalcAverage<T>(params T[] array)
        {
            dynamic sum = 0f;
            int lenght = array.Length;

            sum = CalcSum(array);

            return sum / lenght;
        }

        static T CalcProduct<T>(params T[] array)
        {
            dynamic product = 1;

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
            Console.WriteLine(CalcAverage(5, 2.2, 1, 5));
            Console.WriteLine(CalcProduct(2, 10, 9, 6, 15, 17, 20, 21));
        }
    }
}
