/*
  Write a program to calculate the Nth Catalan number by given N 
 */

using System;
using System.Numerics;

class CatalanNumber
{
    static void Main()
    {
        string input;
        int n;
        do
        {
            input = Console.ReadLine();
        } while (!int.TryParse(input, out n) || n < 1);

        BigInteger factorielByTwo = 1;
        BigInteger factorielPlusOne = 1;
        BigInteger factoriel = 1;
        BigInteger sum = 0;

        for (int i = 1; i <= n; i++)
        {
            factoriel *= i;
        }

        for (int i = 1; i <= n*2; i++)
        {
            factorielByTwo *= i;
        }

        for (int i = 1; i <= n+1; i++)
        {
            factorielPlusOne *= i;
        }

        sum = factorielByTwo / (factorielPlusOne * factoriel);
        Console.WriteLine(sum);
    }
}