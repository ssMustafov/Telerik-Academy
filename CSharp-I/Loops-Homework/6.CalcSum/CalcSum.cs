/*
 Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X^2 + … + N!/X^N 
 */

using System;
using System.Numerics;

class CalcSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        double factoriel = 1;
        double power = 1;
        double sum = 1;

        for (int k = 1; k <= n; k++)
        {
            factoriel *= k;
            power = x * k;
            sum = sum + (factoriel / power);
            Console.Write("{0} / {1}^{0} + ", factoriel, x, k);
        }
        Console.WriteLine("= {0}", sum);
    }
}