using System;

class Program
{
    static void Main()
    {
        int k = int.Parse(Console.ReadLine());
        //int digitCounter = 0;
        int lastDigit = k % 10;
        int preLastDigit = k % 100;
        int presLastDigit = k % 1000;
        //int c = k;
        //while (c > 0)
        //{
        //    int p = c % 10;
        //    digitCounter++;
        //    c /= 10;
        //}

        if (presLastDigit == 666)
        {
            k += 334;
        }
        else if (preLastDigit == 66)
        {
            k += 34;
        }
        else if (lastDigit == 6)
        {
            k += 4;
        }
        else
        {
            k++;
        }

        Console.WriteLine(k);
    }
}