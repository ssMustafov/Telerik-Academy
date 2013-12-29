using System;
using System.Numerics;

class FactorialCalc
{
    static void Main()
    {
        Console.Write("n! = ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("k! = ");
        int k = int.Parse(Console.ReadLine());

        if (k > 0 && n > 0 && k > n)
        {
            BigInteger nFactorial = 1;
            BigInteger kFactorial = 1;
            BigInteger minus = k - n;
            BigInteger m = 1;
            BigInteger formula;

            while (minus > 0)
            {
                m *= minus;
                minus--;
            }

            while (k > 0 && n > 0)
            {
                nFactorial *= n;
                kFactorial *= k;
                n--;
                k--;
            }

            formula = (nFactorial * kFactorial) / m;
            Console.WriteLine(formula);
        }
        else
        {
            Console.WriteLine("k must be greater than n and greater than 1");
        }
    }
}