using System;

class CompareFloatNumbers
{
    static void Main(string[] args)
    {
        float a = 5.3f;
        float b = 6.1f;

        float c = 5.00000001f;
        float d = 5.00000003f;

        bool equal = Math.Abs(a - b) < 0.000001;
        bool equalTwo = Math.Abs(c - d) < 0.000001;
        Console.WriteLine(equal);
        Console.WriteLine(equalTwo);
    }
}