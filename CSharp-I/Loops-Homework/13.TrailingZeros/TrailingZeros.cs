/*
    * Write a program that calculates for given N how many trailing zeros present at the end of the number N!. Examples:
	N = 10  N! = 3628800  2
	N = 20  N! = 2432902008176640000  4
 */

using System;
using System.Numerics;

class TrailingZeros
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger factorial = 1;

        if (n > 0)
        {
            BigInteger count = 0;
            int five = 5;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                count += n / five;
                five *= 5;
            }
            Console.WriteLine("n! = {0}", factorial);
            Console.WriteLine("Zeros: {0}", count);
        }
    }
}