// Write a method that checks if the element at given position in 
// given array of integers is bigger than its two neighbors (when such exist).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BiggerThanNeighbours
{
    public class Neighbours
    {
        public static bool IsBiggerThanTwoNeighbours(int[] array, int position)
        {
            if (position == 0)
            {
                return false;
            }
            else if (position >= array.Length && position >= (array.Length - 1))
            {
                Console.WriteLine("The array have {0} elements. Starting from index 0.", array.Length);
            }
            else if ((array[position] > array[position - 1]) && (array[position] > array[position + 1]))
            {
                return true;
            }

            return false;
        }

        static void Main(string[] args)
        {
            int[] array = {1, 0, 10, -10, 5, 9, 14, 20 };

            Console.WriteLine(IsBiggerThanTwoNeighbours(array, 2));
        }
    }
}
