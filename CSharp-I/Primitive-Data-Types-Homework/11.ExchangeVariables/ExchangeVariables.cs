using System;

class ExchangeVariables
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = 10;
        int c = a;
        a = b;
        b = c;
    }
}