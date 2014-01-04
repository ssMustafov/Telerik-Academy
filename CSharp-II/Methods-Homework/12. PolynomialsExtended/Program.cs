using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PolynomialsExtended
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

        static int[] SubstractTwoPolynomials(int[] firstPolynomial, int[] secondPolynomial)
        {
            int[] polynomials = new int[3];

            for (int index = 0; index < 3; index++)
            {
                polynomials[index] = firstPolynomial[index] - secondPolynomial[index];
            }

            return polynomials;
        }

        static int[] MultiplyTwoPolynomials(int[] firstPolynomial, int[] secondPolynomial)
        {
            int[] polynomials = new int[3];
            int sum = 0;

            for (int index = 0; index < 3; index++)
            {
                for (int i = 0; i < 3; i++)
                {
                    sum += firstPolynomial[i] * secondPolynomial[index];
                }

                polynomials[index] = sum;
                sum = 0;
            }

            return polynomials;
        }

        static void Main(string[] args)
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
            int[] substractedPolynomials = SubstractTwoPolynomials(firstPolynomial, secondPolynomial);
            int[] multipliedPolynomials = MultiplyTwoPolynomials(firstPolynomial, secondPolynomial);

            Console.WriteLine("First polynom: {0}x^2 + {1}x + {2}", firstA, firstB, firstC);
            Console.WriteLine("Second polynom: {0}x^2 + {1}x + {2}", secondA, secondB, secondC);
            Console.WriteLine("The sum is: {0}x^2 + {1}x + {2}", sumPolynomials[0], sumPolynomials[1], sumPolynomials[2]);
            Console.WriteLine("The substraction is: {0}x^2 + {1}x + {2}", substractedPolynomials[0], substractedPolynomials[1], substractedPolynomials[2]);
            Console.WriteLine("The multyplied is: {0}x^2 + {1}x + {2}", multipliedPolynomials[0], multipliedPolynomials[1], multipliedPolynomials[2]);
        }
    }
}
