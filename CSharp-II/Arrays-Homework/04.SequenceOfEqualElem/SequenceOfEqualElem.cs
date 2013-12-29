using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SequenceOfEqualElem
{
    class SequenceOfEqualElem
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write("[{0}] = ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            int temp = 1;
            int max = 1;
            int element = 1;

            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] == array[i+1])
                {
                    temp++;
                }
                else
                {
                    if (max < temp)
                    {
                        max = temp;
                        element = array[i];
                    }
                    temp = 1;
                }
            }

            if (max == 1)
            {
                Console.WriteLine("No equal sequnce!");
                return;
            }

            for (int i = 0; i < max; i++)
            {
                Console.Write("{0} ", element);
            }
            Console.WriteLine();
        }
    }
}
