using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SieveOfEratosthenes
{
    class SieveOfEratosthenes
    {
        static void Main(string[] args)
        {
            bool[] array = new bool[10000001];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = true;
            }

            int max = (int)Math.Sqrt(array.Length);

            for (int i = 2; i <= max; i++)
            {
                if (array[i])
                {
                    for (int j = i * i; j < array.Length; j+=i)
                    {
                        array[j] = false;
                    }
                }
            }

            for (int i = 2; i < array.Length; i++)
            {
                if (array[i])
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
