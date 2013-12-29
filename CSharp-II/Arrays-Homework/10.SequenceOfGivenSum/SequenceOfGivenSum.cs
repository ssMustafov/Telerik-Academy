using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SequenceOfGivenSum
{
    class SequenceOfGivenSum
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

            Console.Write("Enter numbers sum to find: ");
            int s = int.Parse(Console.ReadLine());

            int sum = 0;
            int startIndex = 0;
            int endIndex = 0;
            for (int i = 0; i < n; i++)
            {
                startIndex = i;
                sum = array[i];
                for (int j = i+1; j < n; j++)
                {
                    endIndex = j;
                    sum = sum + array[j];

                    if (sum == s)
                    {
                        for (int k = startIndex; k <= endIndex; k++)
                        {
                            Console.Write("{0} ", array[k]);
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
