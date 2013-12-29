using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinarySearch
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            Console.Write("Enter numbers elements: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            for (int index = 0; index < n; index++)
            {
                Console.Write("[{0}]: ", index);
                array[index] = int.Parse(Console.ReadLine());
            }

            int i, j, k, min;
            for (i = 0; i < n - 1; i++)
            {
                k = i;
                for (j = i + 1; j < n; j++)
                {
                    if (array[j] < array[k])
                    {
                        k = j;
                    }
                }

                if (k > i)
                {
                    min = array[k];
                    array[k] = array[i];
                    array[i] = min;
                }
            }

            Console.Write("Enter number to find: ");
            int number = int.Parse(Console.ReadLine());

            int left = 0;
            int right = n - 1;
            int middle = 0;

            while (right - left > 1)
            {
                middle = (left + right) / 2;
                if (number <= array[middle])
                {
                    right = middle;
                }
                else
                {
                    left = middle;
                }
            }

            Console.WriteLine("The index of {0} is {1}", number, right);
        }
    }
}
