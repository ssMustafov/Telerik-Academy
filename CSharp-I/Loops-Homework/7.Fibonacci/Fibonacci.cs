using System;
using System.Numerics;

class Fibonacci
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger first = 1;
        BigInteger second = 0;
        BigInteger third = 0;
        BigInteger sum = 0;

        for (int i = 0; i <= n; i++)
        {
            third = first + second;
            first = second;
            second = third;
            Console.WriteLine(third);
            sum += third;
        }
        Console.WriteLine("Sum: {0}", sum);
    }
}