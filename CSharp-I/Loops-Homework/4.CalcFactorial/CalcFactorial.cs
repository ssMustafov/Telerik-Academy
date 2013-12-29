using System;
using System.Numerics;

class CalcFactorial
{
    static void Main()
    {
        Console.Write("n! = ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("k! = ");
        int k = int.Parse(Console.ReadLine());

        if (n > 1 && k > 1 && n > k)
        {
            BigInteger kFactorial = 1;
            BigInteger nFactorial = 1;
            BigInteger divided;

            while (k > 0 && n > 0)
            {
                kFactorial *= k;
                nFactorial *= n;
                k--;
                n--;
            }

            divided = nFactorial / kFactorial;
            Console.WriteLine(divided);
        }
        else
        {
            Console.WriteLine("n must be greater than k and more than 0 and positive");
        }
    }
}