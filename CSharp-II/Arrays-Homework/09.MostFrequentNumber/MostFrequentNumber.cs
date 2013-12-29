using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MostFrequentNumber
{
    class MostFrequentNumber
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

            int max = 1;
            int mostFrequent = 0;

            for (int i = 0; i < n-1; i++)
            {
                int counter = 1;
                for (int j = i+1; j < n; j++)
                {
                    if (array[i] == array[j])
                    {
                        counter++;
                    }
                }

                if (counter > max)
                {
                    max = counter;
                    mostFrequent = array[i];
                }
            }

            Console.Write("Most frequent number is: ");
            Console.WriteLine("{0} ({1} times)", mostFrequent, max);
        }
    }
}
