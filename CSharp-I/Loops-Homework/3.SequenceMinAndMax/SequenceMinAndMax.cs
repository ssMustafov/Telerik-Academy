using System;

class SequenceMinAndMax
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int min = 0;
        int max = 0;

        for (int i = 0; i < n; i++)
        {
            int input = int.Parse(Console.ReadLine());

            if (input > max)
            {
                max = input;
            }
            else if (input < min)
            {
                min = input;
            }
        }

        Console.WriteLine("Min: {0} Max: {1}", min, max);
    }
}