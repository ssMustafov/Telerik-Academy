// Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. Print the obtained array on the console.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultByIndex
{
    class MultByIndex
    {
        static void Main(string[] args)
        {
            int[] array = new int[20];

            for (int index = 0; index < 20; index++)
            {
                array[index] = index * 5;
            }

            foreach (int elem in array)
            {
                Console.WriteLine(elem);
            }
        }
    }
}
