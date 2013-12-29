using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            char[] A = { 'a', 'z', 'c', 'd' };
            char[] B = { 'e', 'f', 'g', 'h' };

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] < B[i])
                {
                    Console.Write("{0} ", A[i]);
                }
                else
                {
                    Console.Write("{0} ", B[i]);
                }
            }
            Console.WriteLine();
        }
    }
}
