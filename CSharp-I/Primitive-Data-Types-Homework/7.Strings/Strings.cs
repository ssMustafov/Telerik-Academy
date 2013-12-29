using System;

class Strings
{
    static void Main(string[] args)
    {
        string sayHello = "Hello";
        string sayWorld = "World";
        object HelloWorld = sayHello + " " + sayWorld;
        string sayHelloWorld = (string) HelloWorld;
        Console.WriteLine(sayHelloWorld);
    }
}