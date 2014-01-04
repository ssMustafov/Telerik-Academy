using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaxElement
{
    class Program
    {
        static int MaxElementInArray(int[] array, int index = 0)
        {
            int max = int.MinValue;

            for (int i = index; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            
            return max;
        }

        static int[] SortArrayInAscOrder(int[] array)
        {
            int[] sortedArray = new int[array.Length];

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            return sortedArray;
        }

        static int[] SortArrayInDescOrder(int[] array)
        {
            int[] sortedArray = new int[array.Length];

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    int max = MaxElementInArray(array, j);
                    if (array[i] < max)
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            return sortedArray;
        }

        static void Main(string[] args)
        {
            int[] array = {6, 33, 120, 0, -7, 54, 18, 23, 3, 29, -17 };

            Console.WriteLine(MaxElementInArray(array, 3));

            SortArrayInAscOrder(array);
            foreach (var e in array)
            {
                Console.Write(e + " ");
            }
            Console.WriteLine();

            SortArrayInDescOrder(array);
            foreach (var e in array)
            {
                Console.Write(e + " ");
            }
            Console.WriteLine();
        }
    }
}
