using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MergeSort
{
    class MergeSort
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


        }
    }
}
