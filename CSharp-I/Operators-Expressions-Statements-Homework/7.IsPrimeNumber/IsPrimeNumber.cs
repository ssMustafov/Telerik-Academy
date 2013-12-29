using System;

class IsPrimeNumber
{
    static int IsPrimeN(int n)
    {
        if (n == 1)
        {
            return 0;
        }

        if (n == 2)
        {
            return 1;
        }

        int i = 2;
        while (i <= Math.Sqrt(n))
        {
            if (n % i == 0)
            {
                return 0;
            }
            i++;
        }
        

        return 1;
    }
    
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        if ((n > 0) && (n <= 100))
        {
            if (IsPrimeN(n) == 1)
            {
                Console.WriteLine("Number is Prime");
            }
            else
            {
                Console.WriteLine("Number is Not Prime");
            }
        }
        else
        {
            Console.WriteLine("Please enter value less than 100");
        }
    }
}