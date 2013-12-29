using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SequenceOfMaxSum
{
    class SequenceOfMaxSum
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

            int max = array[0];
            int maxEnd = array[0];
            int longSequence = 1;
            int currentSequence = 1;
            int start = 0;
            int startTemp = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] + maxEnd > array[i])
                {
                    maxEnd = array[i] + maxEnd;
                    currentSequence++;
                }
                else
                {
                    maxEnd = array[i];
                    startTemp = i;
                    currentSequence = 1;
                }

                if (maxEnd > max)
                {
                    max = maxEnd;
                    longSequence = currentSequence;
                    start = startTemp;
                }
            }

            Console.WriteLine(max);

            for (int i = start; i < start + longSequence; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
