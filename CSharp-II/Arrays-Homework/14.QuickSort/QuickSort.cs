using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickSort
{
    class QuickSort
    {
        public static void SortQucik(int[] array, int n)
        {
            int i = 0;
            int j = n - 1;
            int y = array[j / 2];
            int z;

            do
            {
                while (array[i] < y) i++;
                while (array[j] > y) j--;

                if (i < j)
                {
                    z = array[i];
                    array[i] = array[j];
                    array[j] = z;
                }
                else
                {
                    if (i == j)
                    {
                        i++;
                        j--;
                    }
                    break;
                }
            } while (++i <= --j);
            for (int k = 0; k < n; k++)
            if (j > 0) SortQucik(array, j + 1);
            if (i < n - 1) SortQucik(array, n - i);
        }
        
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

            SortQucik(array, n);

            foreach (int elem in array)
            {
                Console.WriteLine(elem);
            }
        }
    }
}
