using System;

class NumsNotDivided
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int counter = 1;

        while (n > 0)
        {
            if ((counter % 3 == 0) && (counter % 7 == 0))
            {
                Console.Write(counter + " ");
            }
            counter++;
            n--;
        }
    }
}