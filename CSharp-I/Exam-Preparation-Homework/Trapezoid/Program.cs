using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int topWidth = n;
        int bottomWith = 2 * n;
        int height = n + 1;

        string firstDots = new string('.', n);
        string firstStars = new string('*', n);
        Console.WriteLine(firstDots + firstStars);

        int position = n;

        for (int i = 1; i < height; i++)
        {
            for (int j = 0; j < n * 2; j++)
            {
                if (i == height - 1)
                {
                    Console.Write("*");
                }
                else if (j == position - 1 || j == n * 2 - 1)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
            position--;
        }
    }
}
