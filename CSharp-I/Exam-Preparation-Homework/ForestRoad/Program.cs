using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int height = 2 * n - 1;

        int positionToRight = 0;
        int positionToLeft = 2 * n - 2;
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j == positionToRight)
                {
                    Console.Write(new string('*', 1));
                }
                else if (j == positionToLeft)
                {
                    Console.Write(new string('*', 1));
                }
                else
                {
                    Console.Write(new string('.', 1));
                }
            }
            Console.WriteLine();
            positionToRight++;
            positionToLeft--;
        }
    }
}