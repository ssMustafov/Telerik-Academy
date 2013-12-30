// Write a program, that reads from the console an array of N integers and an integer K, 
// sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 

using System;

class Program
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        for (int index = 0; index < n; index++)
        {
            Console.Write("[{0}]: ", index);
            array[index] = int.Parse(Console.ReadLine());
        }

        foreach (var elem in array)
        {
            Console.WriteLine(elem);
        }
        
        Array.Sort(array);

        Console.WriteLine("Sorted:");
        foreach (var e in array)
        {
            Console.Write(e + " ");
        }
        Console.WriteLine();

        int result = Array.BinarySearch(array, k);
        if (array[result] <= k)
	    {
		    Console.WriteLine("The index of value {0} in the sorted array is {1}", k, result);
	    }
    }
}