// Write a method that adds two polynomials. 
// Represent them as arrays of their coefficients 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Polynomials
{
    class Program
    {
        static int[] AddTwoPolynomials(int[] firstPolynomial, int[] secondPolynomial)
        {
            int[] polynomialsSum = new int[3];

            for (int index = 0; index < 3; index++)
            {
                polynomialsSum[index] = firstPolynomial[index] + secondPolynomial[index];
            }

            return polynomialsSum;
        }

        
        static void Main()
        {
            Console.WriteLine("Enter the first polynomial:");
            Console.Write("Enter A coef.: ");
            int firstA = int.Parse(Console.ReadLine());

            Console.Write("Enter B coef.: ");
            int firstB = int.Parse(Console.ReadLine());

            Console.Write("Enter C coef.: ");
            int firstC = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second polynomial:");
            Console.Write("Enter A coef.: ");
            int secondA = int.Parse(Console.ReadLine());

            Console.Write("Enter B coef.: ");
            int secondB = int.Parse(Console.ReadLine());

            Console.Write("Enter C coef.: ");
            int secondC = int.Parse(Console.ReadLine());

            int[] firstPolynomial = { firstA, firstB, firstC };
            int[] secondPolynomial = { secondA, secondB, secondC };

            int[] sumPolynomials = AddTwoPolynomials(firstPolynomial, secondPolynomial);

            Console.WriteLine("First polynom: {0}x^2 + {1}x + {2}", firstA, firstB, firstC);
            Console.WriteLine("Second polynom: {0}x^2 + {1}x + {2}", secondA, secondB, secondC);
            Console.WriteLine("The sum is: {0}x^2 + {1}x + {2}", sumPolynomials[0], sumPolynomials[1], sumPolynomials[2]);
        }
    }
}
