using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaxSum
{
    class MaxSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("[{0}] = ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            int max = 0;
            int position = 0;
            for (int i = 0; i <= n-k; i++)
            {
                for (int j = i; j < i+k; j++)
                {
                    sum += array[j];
                }

                if (sum > max)
                {
                    max = sum;
                    position = i;
                }

                sum = 0;
            }

            for (int i = position; i < position + k; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
        }
    }
}
