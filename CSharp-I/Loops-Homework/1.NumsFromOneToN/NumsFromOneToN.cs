using System;

class NumsFromOneToN
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int counter = 1;

        while (n > 0)
        {
            Console.Write(counter + " ");
            counter++;
            n--;
        }
    }
}