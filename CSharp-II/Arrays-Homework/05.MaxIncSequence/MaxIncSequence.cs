using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaxIncSequence
{
    class MaxIncSequence
    {
        static void Main(string[] args)
        {
            Console.Write("Enter numbers of elements: ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("[{0}] = ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            int counter = 1;
            int maxCounter = 1;
            int index = 0;
            int startIndex = 0;
            for (int i = 1; i < n; i++)
            {
                if (array[i] > array[i - 1])
                {
                    counter++;
                    if (counter > maxCounter)
                    {
                        maxCounter = counter;
                        startIndex = index;
                    }
                }
                else
                {
                    counter = 1;
                    index = i;
                }
            }

            int endIndex = (startIndex + maxCounter) - 1;
            Console.WriteLine("Maximal sequence of increasing elements:");
            for (int i = startIndex; i <= endIndex; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
