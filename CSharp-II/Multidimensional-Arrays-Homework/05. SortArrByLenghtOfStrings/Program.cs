// You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).

using System;
using System.Linq;

class Program
{
    public static void SortByLenghtOfElem(string[] arr)
    {
        // Using LINQ to sort the array by the lenght of the elements
        var sortedArray = from word in arr
                          orderby word.Length
                          select word;

        Console.WriteLine("Sorted array:");
        foreach (var elem in sortedArray)
        {
            Console.WriteLine(elem);
        }
    }

    static void Main()
    {
        Console.Write("Enter the lenght of the array: ");
        int n = int.Parse(Console.ReadLine());

        string[] array = new string[n];

        for (int index = 0; index < n; index++)
        {
            Console.Write("[{0}]: ", index);
            array[index] = Console.ReadLine();
        }

        foreach (var elem in array)
        {
            Console.WriteLine(elem);
        }

        SortByLenghtOfElem(array);
    }
}