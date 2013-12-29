using System;

class CalculateSum
{
    static void Main()
    {
        decimal counter = 2m;
        decimal sum = 1m;
        int sign = 1;

        while (1m / counter > 0.001m)
        {
            sum += (1m / counter) * sign;
            sign *= (-1);
            counter++;
        }
        Console.WriteLine("{0:0.000}", sum);
    }
}