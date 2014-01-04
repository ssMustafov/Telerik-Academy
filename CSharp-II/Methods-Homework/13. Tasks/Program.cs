// Write a program that can solve these tasks:
// Reverses the digits of a number
// Calculates the average of a sequence of integers
// Solves a linear equation a * x + b = 0
//		Create appropriate methods.
//		Provide a simple text-based menu for the user to choose which task to solve.
// Validate the input data:
//      The decimal number should be non-negative
//      The sequence should not be empty
//      a should not be equal to 0


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tasks
{
    class Program
    {
        static int ReverseNumberDigits(int number)
        {
            if (number < 0)
            {
                Console.WriteLine("The number should not be negative!");
                return -1;
            }

            int num = number;
            int reversed = 0;

            while (num != 0)
            {
                int c = num % 10;
                reversed = reversed * 10 + c;
                num /= 10;
            }

            return reversed;
        }

        static decimal AverageOfSequence(int[] sequence)
        {
            decimal sum = 0m;
            int lenght = sequence.GetLength(0);

            for (int index = 0; index < lenght; index++)
            {
                sum += sequence[index];
            }

            decimal result = (sum / lenght);

            return result;
        }

        static bool IsEmptyArray(int[] array)
        {
            bool isEmpty = true;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[i] != 0)
                {
                    isEmpty = false;
                }
            }

            return isEmpty;
        }

        static double SolveLinearEquation(int a, int b)
        {
            double A = a;
            double B = b * (-1);
            
            return B / A;
        }

        static void Main(string[] args)
        {
            char codeOp = ' ';
            
            do
            {
                // Menu
                Console.WriteLine();
                Console.WriteLine("Please choose task from the menu:");
                Console.WriteLine("\t0: Exit");
                Console.WriteLine("\t1: Reverse the digits of a number");
                Console.WriteLine("\t2: Calculate the average of a sequence of integers");
                Console.WriteLine("\t3: Solve a linear equation (a * x + b = 0)");
                Console.Write("Choose task number: ");
                codeOp = char.Parse(Console.ReadLine());

                // Tasks implementation
                switch (codeOp)
                {
                    case '0': break;

                    case '1':
                        {
                            Console.Write("Enter a number: ");
                            int number = int.Parse(Console.ReadLine());

                            Console.WriteLine("Reversed number is: {0}", ReverseNumberDigits(number));
                        }
                        break;

                    case '2':
                        {
                            Console.Write("Enter sequence length: ");
                            int n = int.Parse(Console.ReadLine());

                            int[] sequence = new int[n];

                            for (int i = 0; i < sequence.GetLength(0); i++)
                            {
                                sequence[i] = int.Parse(Console.ReadLine());
                            }

                            if (IsEmptyArray(sequence))
                            {
                                Console.WriteLine("The sequence is empty or full of zeros!");
                                break;
                            }
                            
                            Console.WriteLine("The average is: {0}", AverageOfSequence(sequence));
                        }
                        break;

                    case '3':
                        {
                            Console.Write("Enter coef. a: ");
                            int a = int.Parse(Console.ReadLine());

                            Console.Write("Enter coef. b: ");
                            int b = int.Parse(Console.ReadLine());

                            if (a == 0)
                            {
                                Console.WriteLine("The coef. a should not be a zero");
                                break;
                            }
                            
                            Console.WriteLine("You entered: {0} * x + {1} = 0", a, b);
                            Console.WriteLine("The decision is: x = {0}", SolveLinearEquation(a, b));
                        }
                        break;

                    default: Console.WriteLine("Wrong code operation!"); break;
                }
            } while (codeOp != '0');
        }
    }
}
