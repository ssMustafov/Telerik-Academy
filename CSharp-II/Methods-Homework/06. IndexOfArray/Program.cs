// Write a method that returns the index of the first element in array
// that is bigger than its neighbors, or -1, if there’s no such element.
// Use the method from the previous exercise.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BiggerThanNeighbours;

namespace IndexOfArray
{
    class Program
    {
        static int IndexOfBiggestNeighbour(int[] array)
        {
            for (int index = 0; index < array.Length; index++)
            {
                bool result = Neighbours.IsBiggerThanTwoNeighbours(array, index);

                if (result)
                {
                    return index;
                }
            }

            return -1;
        }

        static void Main(string[] args)
        {
            int[] arr = { 5, 2, 4, -1, 99, 0, 17, -10, 3, -1, 100, 0 };

            Console.WriteLine(IndexOfBiggestNeighbour(arr));
        }
    }
}
