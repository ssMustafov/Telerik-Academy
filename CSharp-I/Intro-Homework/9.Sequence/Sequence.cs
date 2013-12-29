using System;

class Sequence
{
    static void Main()
    {
        for (int i = 1; i <= 10; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }

            if (i % 2 == 1)
            {
                Console.WriteLine(i * (-1));
            }
        }
    }
}